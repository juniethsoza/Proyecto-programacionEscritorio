using System;

namespace Entidades
{
    public class Proveedor
    {
        public int IdProveedor { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public DateTime? CreatedAt { get; set; }
        public bool? Estado { get; set; }
    }
}

