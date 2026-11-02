using System;

namespace Entidades
{
    public class SubCategoria
    {
        public int IdSubcategoria { get; set; }
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string NombreCategoria { get; set; }
    }
}
