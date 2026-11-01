using System;
using System.Collections.Generic;
using System.Linq;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        public static sp_ValidarLogin_Result IniciarSesion(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                throw new ArgumentException("Debe ingresar el usuario y la contraseña.");

            using (var db = new BDSIGIVEntities())
            {
                var resultado = db.sp_ValidarLogin(username.Trim(), password.Trim()).FirstOrDefault();

                if (resultado != null && resultado.IdUsuario > 0)
                {
                    SesionActual.IdUsuario = resultado.IdUsuario;
                    SesionActual.RolID = resultado.RolID;
                    SesionActual.Rol = resultado.Rol;
                    SesionActual.NombreCompleto = resultado.NombreCompleto;
                    SesionActual.Permisos = ObtenerPermisos(resultado.RolID);
                }

                return resultado;
            }
        }

        public static List<string> ObtenerPermisos(int rolId)
        {
            using (var db = new BDSIGIVEntities())
            {
                return db.sp_Permiso_ListarPorRol(rolId).ToList();
            }
        }

        public static List<sp_Usuario_Listar_Result> ListarUsuarios(string filtro = null, int? rolId = null)
        {
            using (var db = new BDSIGIVEntities())
            {
                int? rolParam = (rolId.HasValue && rolId.Value > 0) ? rolId : null;
                string filtroParam = string.IsNullOrWhiteSpace(filtro) ? null : filtro.Trim();

                return db.sp_Usuario_Listar(filtroParam, rolParam).ToList();
            }
        }

        public static List<sp_Rol_Listar_Result> ListarRoles()
        {
            using (var db = new BDSIGIVEntities())
            {
                return db.sp_Rol_Listar().ToList();
            }
        }

        public static void GuardarUsuario(int idUsuario, int rolId, string nombre, string apellido,
                                          string username, string clave, string email, string telefono, bool estado)
        {
            if (rolId <= 0)
                throw new ArgumentException("Debe seleccionar un rol válido.");
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido))
                throw new ArgumentException("El nombre y el apellido son obligatorios.");
            if (string.IsNullOrWhiteSpace(username))
                throw new ArgumentException("El nombre de usuario es obligatorio.");
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@") || !email.Contains("."))
                throw new ArgumentException("Debe ingresar un correo electrónico válido.");
            if (string.IsNullOrWhiteSpace(telefono))
                throw new ArgumentException("El número de teléfono es obligatorio.");
            if (idUsuario == 0 && string.IsNullOrWhiteSpace(clave))
                throw new ArgumentException("Debe asignar una contraseña para el nuevo usuario.");

            using (var db = new BDSIGIVEntities())
            {
                if (idUsuario == 0)
                {
                    db.sp_Usuario_Insertar(
                        rolId,
                        nombre.Trim(),
                        apellido.Trim(),
                        username.Trim(),
                        clave.Trim(),
                        email.Trim(),
                        telefono.Trim(),
                        estado
                    );
                }
                else
                {
                    string claveParam = string.IsNullOrWhiteSpace(clave) ? null : clave.Trim();

                    db.sp_Usuario_Actualizar(
                        idUsuario,
                        rolId,
                        nombre.Trim(),
                        apellido.Trim(),
                        username.Trim(),
                        claveParam,
                        email.Trim(),
                        telefono.Trim(),
                        estado
                    );
                }
            }
        }

        public static bool CambiarEstado(int idUsuario)
        {
            if (idUsuario <= 0)
                throw new ArgumentException("Seleccione un usuario válido de la tabla.");

            if (idUsuario == SesionActual.IdUsuario)
                throw new InvalidOperationException("No puedes desactivar tu propio usuario con la sesión activa.");

            using (var db = new BDSIGIVEntities())
            {
                var nuevoEstado = db.sp_Usuario_CambiarEstado(idUsuario).FirstOrDefault();
                return Convert.ToBoolean(nuevoEstado);
            }
        }
    }
}