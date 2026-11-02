using System;
using System.Collections.Generic;
using System.Linq;
using ProductoEntidad = Entidades.Producto;

namespace CapaDatos
{
    public class ProductoDatos
    {
        public List<ProductoEntidad> Listar(string filtro, string ordenarPor, bool descendente)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Producto_Listar(filtro, ordenarPor, descendente))
            {
                return resultado.Select(p => new ProductoEntidad
                {
                    IdProducto = p.IdProducto,
                    CategoriaID = p.CategoriaID,
                    SubCategoriaID = p.SubCategoriaID,
                    Codigo = p.Codigo,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,
                    PrecioCompra = p.PrecioCompra,
                    PrecioVenta = p.PrecioVenta,
                    StockActual = p.StockActual,
                    StockMinimo = p.StockMinimo,
                    CreatedAt = p.CreatedAt,
                    Estado = p.Estado,
                    NombreCategoria = p.NombreCategoria,
                    NombreSubcategoria = p.NombreSubcategoria,
                    EstadoStock = p.EstadoStock
                }).ToList();
            }
        }

        public ProductoEntidad Buscar(int id)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Producto_Buscar(id))
            {
                var p = resultado.FirstOrDefault();
                return p == null ? null : new ProductoEntidad
                {
                    IdProducto = p.IdProducto,
                    CategoriaID = p.CategoriaID,
                    SubCategoriaID = p.SubCategoriaID,
                    Codigo = p.Codigo,
                    Nombre = p.Nombre,
                    Descripcion = p.Descripcion,
                    PrecioCompra = p.PrecioCompra,
                    PrecioVenta = p.PrecioVenta,
                    StockActual = p.StockActual,
                    StockMinimo = p.StockMinimo,
                    CreatedAt = p.CreatedAt,
                    Estado = p.Estado,
                    NombreCategoria = p.NombreCategoria,
                    NombreSubcategoria = p.NombreSubcategoria,
                    EstadoStock = p.EstadoStock
                };
            }
        }

        public int Insertar(ProductoEntidad producto)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Producto_Insertar(producto.CategoriaID, producto.SubCategoriaID, producto.Codigo, producto.Nombre,
                producto.Descripcion, producto.PrecioCompra, producto.PrecioVenta, producto.StockMinimo))
            {
                int id = resultado.SingleOrDefault() ?? 0;
                if (id <= 0) throw new InvalidOperationException("No se recibió el identificador del producto.");
                return id;
            }
        }

        public void Actualizar(ProductoEntidad producto)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Producto_Actualizar(producto.IdProducto, producto.CategoriaID, producto.SubCategoriaID, producto.Codigo, producto.Nombre,
                producto.Descripcion, producto.PrecioCompra, producto.PrecioVenta, producto.StockMinimo))
            {
                if (resultado.SingleOrDefault() != true)
                    throw new InvalidOperationException("No se confirmó la actualización del producto.");
            }
        }

        public void Eliminar(int id)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Producto_Eliminar(id))
            {
                if (resultado.SingleOrDefault() != true)
                    throw new InvalidOperationException("No se confirmó la eliminación del producto.");
            }
        }
    }
}

