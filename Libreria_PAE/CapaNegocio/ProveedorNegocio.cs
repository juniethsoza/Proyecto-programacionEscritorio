using System;
using System.Collections.Generic;
using CapaDatos;
using ProveedorEntidad = Entidades.Proveedor;

namespace CapaNegocio
{
    public class ProveedorNegocio
    {
        private readonly ProveedorDatos datos = new ProveedorDatos();

        public List<ProveedorEntidad> Listar(string filtro, string ordenarPor, bool descendente)
        {
            if (ordenarPor != "Nombre" && ordenarPor != "Telefono" &&
                ordenarPor != "CreatedAt" && ordenarPor != "Estado")
                throw new ArgumentException("Seleccione un campo válido para ordenar.");

            string criterio = string.IsNullOrWhiteSpace(filtro) ? null : filtro.Trim();
            if (criterio != null && criterio.Length > 4000)
                throw new ArgumentException("La búsqueda no puede superar los 4000 caracteres.");
            return datos.Listar(criterio, ordenarPor, descendente);
        }

        public ProveedorEntidad Buscar(int id)
        {
            ValidarId(id);
            return datos.Buscar(id);
        }

        public int Insertar(ProveedorEntidad proveedor)
        {
            Validar(proveedor);
            return datos.Insertar(proveedor);
        }

        public void Actualizar(ProveedorEntidad proveedor)
        {
            Validar(proveedor);
            ValidarId(proveedor.IdProveedor);
            datos.Actualizar(proveedor);
        }

        public void Eliminar(int id)
        {
            ValidarId(id);
            datos.Eliminar(id);
        }

        private static void ValidarId(int id)
        {
            if (id <= 0)
                throw new ArgumentException("Seleccione un proveedor válido.");
        }

        private static void Validar(ProveedorEntidad proveedor)
        {
            if (proveedor == null)
                throw new ArgumentNullException(nameof(proveedor));
            if (string.IsNullOrWhiteSpace(proveedor.Nombre))
                throw new ArgumentException("El nombre del proveedor es obligatorio.");
            if (string.IsNullOrWhiteSpace(proveedor.Telefono))
                throw new ArgumentException("El teléfono del proveedor es obligatorio.");

            proveedor.Nombre = proveedor.Nombre.Trim();
            proveedor.Telefono = proveedor.Telefono.Trim();
            if (proveedor.Nombre.Length > 100)
                throw new ArgumentException("El nombre admite hasta 100 caracteres.");
            if (proveedor.Telefono.Length > 20)
                throw new ArgumentException("El teléfono admite hasta 20 caracteres.");
        }
    }
}

