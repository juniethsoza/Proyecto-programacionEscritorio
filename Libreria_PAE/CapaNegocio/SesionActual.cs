using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio
{
    public static class SesionActual
    {
        public static int IdUsuario { get; set; }
        public static int RolID { get; set; }
        public static string Rol { get; set; }
        public static string NombreCompleto { get; set; }
        public static List<string> Permisos { get; set; } = new List<string>();

        public static bool EstaLogueado()
        {
            return IdUsuario > 0;
        }

        public static bool TienePermiso(string nombrePermiso)
        {
            if (!string.IsNullOrEmpty(Rol) && Rol.Equals("Administrador", StringComparison.OrdinalIgnoreCase))
            {
                return true;
            }

            if (Permisos == null || Permisos.Count == 0)
            {
                return false;
            }

            return Permisos.Any(p => p.Equals(nombrePermiso, StringComparison.OrdinalIgnoreCase));
        }

       
        public static void CerrarSesion()
        {
            IdUsuario = 0;
            RolID = 0;
            Rol = string.Empty;
            NombreCompleto = string.Empty;
            Permisos.Clear();
        }
    }
}