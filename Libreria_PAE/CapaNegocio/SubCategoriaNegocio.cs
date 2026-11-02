using CapaDatos;
using System;
using System.Collections.Generic;
using SubCategoriaEntidad = Entidades.SubCategoria;

namespace CapaNegocio
{
    public class SubCategoriaNegocio
    {
        private readonly SubCategoriaDatos datos = new SubCategoriaDatos();

        public List<SubCategoriaEntidad> Listar(string filtro, string ordenarPor, bool descendente)
        {
            if (ordenarPor != "Nombre" && ordenarPor != "Descripcion" && ordenarPor != "CreatedAt" && ordenarPor != "Categoria")
                throw new ArgumentException("Seleccione un campo válido para ordenar.");
            string criterio = string.IsNullOrWhiteSpace(filtro) ? null : filtro.Trim();
            if (criterio != null && criterio.Length > 4000)
                throw new ArgumentException("La búsqueda no puede superar los 4000 caracteres.");
            return datos.Listar(criterio, ordenarPor, descendente);
        }

        public SubCategoriaEntidad Buscar(int id)
        {
            ValidarId(id);
            return datos.Buscar(id);
        }

        public int Insertar(SubCategoriaEntidad categoria)
        {
            Validar(categoria);
            return datos.Insertar(categoria);
        }

        public void Actualizar(SubCategoriaEntidad categoria)
        {
            Validar(categoria);
            ValidarId(categoria.IdSubcategoria);
            datos.Actualizar(categoria);
        }

        public void Eliminar(int id)
        {
            ValidarId(id);
            datos.Eliminar(id);
        }

        private static void ValidarId(int id)
        {
            if (id <= 0) throw new ArgumentException("Seleccione una categoría de la lista.");
        }

        private static void Validar(SubCategoriaEntidad categoria)
        {
            if (categoria == null) throw new ArgumentNullException(nameof(categoria));
            if (categoria.CategoriaID <= 0) throw new ArgumentException("Seleccione una categoría.");
            if (string.IsNullOrWhiteSpace(categoria.Nombre))
                throw new ArgumentException("El nombre de la categoría es obligatorio.");
            categoria.Nombre = categoria.Nombre.Trim();
            categoria.Descripcion = string.IsNullOrWhiteSpace(categoria.Descripcion)
                ? null : categoria.Descripcion.Trim();
            if (categoria.Nombre.Length > 100)
                throw new ArgumentException("El nombre admite hasta 100 caracteres.");
            if (categoria.Descripcion != null && categoria.Descripcion.Length > 255)
                throw new ArgumentException("La descripción admite hasta 255 caracteres.");
        }
    }
}