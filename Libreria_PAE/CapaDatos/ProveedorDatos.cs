using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos;
using ProveedorEntidad = Entidades.Proveedor;

namespace CapaDatos
{
    public class ProveedorDatos
    {
        public List<ProveedorEntidad> Listar(string filtro, string ordenarPor, bool descendente)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Proveedor_Listar(filtro, ordenarPor, descendente))
            {
                return resultado.Select(c => new ProveedorEntidad
                {
                    IdProveedor = c.IdProveedor,
                    Nombre = c.Nombre,
                    Telefono = c.Telefono,
                    CreatedAt = c.CreatedAt,
                    Estado = c.Estado
                }).ToList();
            }
        }

        public ProveedorEntidad Buscar(int id)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Proveedor_Buscar(id))
            {
                var c = resultado.FirstOrDefault();
                return c == null ? null : new ProveedorEntidad
                {
                    IdProveedor = c.IdProveedor,
                    Nombre = c.Nombre,
                    Telefono = c.Telefono,
                    CreatedAt = c.CreatedAt,
                    Estado = c.Estado
                };
            }
        }

        public int Insertar(ProveedorEntidad proveedor)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Proveedor_Insertar(proveedor.Nombre, proveedor.Telefono))
            {
                int id = resultado.SingleOrDefault() ?? 0;
                if (id <= 0) throw new InvalidOperationException("El procedimiento no devolvió el identificador de el proveedor.");
                return id;
            }
        }

        public void Actualizar(ProveedorEntidad proveedor)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Proveedor_Actualizar(proveedor.IdProveedor, proveedor.Nombre, proveedor.Telefono))
            {
                if (resultado.SingleOrDefault() != true)
                    throw new InvalidOperationException("No se confirmó la actualización de el proveedor.");
            }
        }

        public void Eliminar(int id)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Proveedor_Eliminar(id))
            {
                if (resultado.SingleOrDefault() != true)
                    throw new InvalidOperationException("No se confirmó la eliminación de el proveedor.");
            }
        }
    }
}
