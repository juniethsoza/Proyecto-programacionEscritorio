using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos;
using SubCategoriaEntidad = Entidades.SubCategoria;

namespace CapaDatos
{
    public class SubCategoriaDatos
    {
        public List<SubCategoriaEntidad> Listar(string filtro, string ordenarPor, bool descendente)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_SubCategoria_Listar(filtro, ordenarPor, descendente))
            {
                return resultado.Select(c => new SubCategoriaEntidad
                {
                    IdSubcategoria = c.IdSubcategoria,
                    CategoriaID = c.CategoriaID,
                    NombreCategoria = c.NombreCategoria,
                    Nombre = c.Nombre,
                    Descripcion = c.Descripcion,
                    CreatedAt = c.CreatedAt
                }).ToList();
            }
        }

        public SubCategoriaEntidad Buscar(int id)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_SubCategoria_Buscar(id))
            {
                var c = resultado.FirstOrDefault();
                return c == null ? null : new SubCategoriaEntidad
                {
                    IdSubcategoria = c.IdSubcategoria,
                    CategoriaID = c.CategoriaID,
                    NombreCategoria = c.NombreCategoria,
                    Nombre = c.Nombre,
                    Descripcion = c.Descripcion,
                    CreatedAt = c.CreatedAt
                };
            }
        }

        public int Insertar(SubCategoriaEntidad categoria)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_SubCategoria_Insertar(categoria.CategoriaID, categoria.Nombre, categoria.Descripcion))
            {
                int id = resultado.SingleOrDefault() ?? 0;
                if (id <= 0) throw new InvalidOperationException("El procedimiento no devolvió el identificador de la categoría.");
                return id;
            }
        }

        public void Actualizar(SubCategoriaEntidad categoria)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_SubCategoria_Actualizar(categoria.IdSubcategoria, categoria.CategoriaID, categoria.Nombre, categoria.Descripcion))
            {
                if (resultado.SingleOrDefault() != true)
                    throw new InvalidOperationException("No se confirmó la actualización de la categoría.");
            }
        }

        public void Eliminar(int id)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_SubCategoria_Eliminar(id))
            {
                if (resultado.SingleOrDefault() != true)
                    throw new InvalidOperationException("No se confirmó la eliminación de la categoría.");
            }
        }
    }
}
