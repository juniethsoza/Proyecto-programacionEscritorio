using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos;
using CategoriaEntidad = Entidades.Categoria;

namespace CapaDatos
{
    public class CategoriaDatos
    {
        public List<CategoriaEntidad> Listar(string filtro, string ordenarPor, bool descendente)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Categoria_Listar(filtro, ordenarPor, descendente))
            {
                return resultado.Select(c => new CategoriaEntidad
                {
                    IdCategoria = c.IdCategoria,
                    Nombre = c.Nombre,
                    Descripcion = c.Descripcion,
                    CreatedAt = c.CreatedAt
                }).ToList();
            }
        }

        public CategoriaEntidad Buscar(int id)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Categoria_Buscar(id))
            {
                var c = resultado.FirstOrDefault();
                return c == null ? null : new CategoriaEntidad
                {
                    IdCategoria = c.IdCategoria,
                    Nombre = c.Nombre,
                    Descripcion = c.Descripcion,
                    CreatedAt = c.CreatedAt
                };
            }
        }

        public int Insertar(CategoriaEntidad categoria)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Categoria_Insertar(categoria.Nombre, categoria.Descripcion))
            {
                int id = resultado.SingleOrDefault() ?? 0;
                if (id <= 0) throw new InvalidOperationException("El procedimiento no devolvió el identificador de la categoría.");
                return id;
            }
        }

        public void Actualizar(CategoriaEntidad categoria)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Categoria_Actualizar(categoria.IdCategoria, categoria.Nombre, categoria.Descripcion))
            {
                if (resultado.SingleOrDefault() != true)
                    throw new InvalidOperationException("No se confirmó la actualización de la categoría.");
            }
        }

        public void Eliminar(int id)
        {
            using (var contexto = new BDSIGIVEntities())
            using (var resultado = contexto.sp_Categoria_Eliminar(id))
            {
                if (resultado.SingleOrDefault() != true)
                    throw new InvalidOperationException("No se confirmó la eliminación de la categoría.");
            }
        }
    }
}
