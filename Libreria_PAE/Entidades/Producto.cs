using System;

namespace Entidades
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public int CategoriaID { get; set; }
        public int SubCategoriaID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCompra { get; set; }
        public decimal PrecioVenta { get; set; }
        public int StockActual { get; set; }
        public int StockMinimo { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Estado { get; set; }
        public string NombreCategoria { get; set; }
        public string NombreSubcategoria { get; set; }
        public string EstadoStock { get; set; }
    }
}

