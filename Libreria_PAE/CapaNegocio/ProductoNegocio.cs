using System;
using System.Collections.Generic;
using CapaDatos;
using ProductoEntidad = Entidades.Producto;

namespace CapaNegocio
{
    public class ProductoNegocio
    {
        private readonly ProductoDatos datos = new ProductoDatos();

        public List<ProductoEntidad> Listar(string filtro, string ordenarPor, bool descendente)
        {
            string[] campos = { "Codigo", "Nombre", "Categoria", "Subcategoria",
                "PrecioCompra", "PrecioVenta", "StockActual", "StockMinimo", "CreatedAt" };
            if (Array.IndexOf(campos, ordenarPor) < 0)
                throw new ArgumentException("Seleccione un campo válido para ordenar.");
            string criterio = string.IsNullOrWhiteSpace(filtro) ? null : filtro.Trim();
            if (criterio != null && criterio.Length > 4000)
                throw new ArgumentException("La búsqueda admite hasta 4000 caracteres.");
            return datos.Listar(criterio, ordenarPor, descendente);
        }

        public ProductoEntidad Buscar(int id)
        {
            ValidarId(id);
            return datos.Buscar(id);
        }

        public int Insertar(ProductoEntidad producto)
        {
            Validar(producto);
            if (producto.StockActual != 0)
                throw new ArgumentException("El producto se registra con stock cero. Registre las entradas mediante compras o ajustes.");
            return datos.Insertar(producto);
        }

        public void Actualizar(ProductoEntidad producto)
        {
            Validar(producto);
            ValidarId(producto.IdProducto);
            // El procedimiento conserva StockActual, Estado y CreatedAt.
            datos.Actualizar(producto);
        }

        public void Eliminar(int id)
        {
            ValidarId(id);
            datos.Eliminar(id);
        }

        private static void ValidarId(int id)
        {
            if (id <= 0) throw new ArgumentException("Seleccione un producto válido.");
        }

        private static void Validar(ProductoEntidad producto)
        {
            if (producto == null) throw new ArgumentNullException(nameof(producto));
            if (producto.CategoriaID <= 0)
                throw new ArgumentException("Seleccione una categoría.");
            if (producto.SubCategoriaID <= 0)
                throw new ArgumentException("Seleccione una subcategoría.");
            if (string.IsNullOrWhiteSpace(producto.Codigo))
                throw new ArgumentException("El código del producto es obligatorio.");
            if (string.IsNullOrWhiteSpace(producto.Nombre))
                throw new ArgumentException("El nombre del producto es obligatorio.");

            producto.Codigo = producto.Codigo.Trim();
            producto.Nombre = producto.Nombre.Trim();
            producto.Descripcion = string.IsNullOrWhiteSpace(producto.Descripcion)
                ? null : producto.Descripcion.Trim();
            if (producto.Codigo.Length > 50)
                throw new ArgumentException("El código admite hasta 50 caracteres.");
            if (producto.Nombre.Length > 100)
                throw new ArgumentException("El nombre admite hasta 100 caracteres.");
            if (producto.Descripcion != null && producto.Descripcion.Length > 255)
                throw new ArgumentException("La descripción admite hasta 255 caracteres.");
            ValidarPrecio(producto.PrecioCompra, "compra");
            ValidarPrecio(producto.PrecioVenta, "venta");
            if (producto.StockMinimo < 0)
                throw new ArgumentException("El stock mínimo no puede ser negativo.");
        }

        private static void ValidarPrecio(decimal precio, string tipo)
        {
            if (precio < 0 || precio > 99999999.99m || decimal.Round(precio, 2) != precio)
                throw new ArgumentException("El precio de " + tipo +
                    " debe estar entre 0 y 99999999.99 y tener hasta dos decimales.");
        }
    }
}

