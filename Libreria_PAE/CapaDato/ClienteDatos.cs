using Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
namespace CapaDato
{
    public class ClienteDatos
    {
        private readonly string Cadena;

        public ClienteDatos()
        {
            Cadena = ConfigurationManager.ConnectionStrings["ConexionBD"].ConnectionString;
        }

        private SqlConnection CrearConexion()
        {
            return new SqlConnection(Cadena);
        }

        public bool Insertar(Cliente cliente)
        {
            using (SqlConnection conexion = CrearConexion())
            using (SqlCommand comando = new SqlCommand("sp_Cliente_Insertar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = cliente.Nombre;
                comando.Parameters.Add("@Apellido", SqlDbType.NVarChar, 100).Value = cliente.Apellido;
                comando.Parameters.Add("@Telefono", SqlDbType.NVarChar, 20).Value =
                    string.IsNullOrWhiteSpace(cliente.Telefono) ? (object)DBNull.Value : cliente.Telefono;

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        public List<Cliente> ConsultarTodos()
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = CrearConexion())
            using (SqlCommand comando = new SqlCommand("sp_Cliente_Listar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                conexion.Open();
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            IdCliente = Convert.ToInt32(lector["IdCliente"]),
                            Nombre = lector["Nombre"].ToString(),
                            Apellido = lector["Apellido"].ToString(),
                            Telefono = lector["Telefono"] != DBNull.Value ? lector["Telefono"].ToString() : string.Empty,
                            CreatedAt = Convert.ToDateTime(lector["CreatedAt"]),
                            Estado = Convert.ToBoolean(lector["Estado"])
                        };
                        lista.Add(cliente);
                    }
                }
            }
            return lista;
        }

        public bool Actualizar(Cliente cliente)
        {
            using (SqlConnection conexion = CrearConexion())
            using (SqlCommand comando = new SqlCommand("sp_Cliente_Actualizar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = cliente.IdCliente;
                comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 100).Value = cliente.Nombre;
                comando.Parameters.Add("@Apellido", SqlDbType.NVarChar, 100).Value = cliente.Apellido;
                comando.Parameters.Add("@Telefono", SqlDbType.NVarChar, 20).Value =
                    string.IsNullOrWhiteSpace(cliente.Telefono) ? (object)DBNull.Value : cliente.Telefono;

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        public bool Eliminar(int idCliente)
        {
            using (SqlConnection conexion = CrearConexion())
            using (SqlCommand comando = new SqlCommand("sp_Cliente_Eliminar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@IdCliente", SqlDbType.Int).Value = idCliente;

                conexion.Open();
                int filasAfectadas = comando.ExecuteNonQuery();
                return filasAfectadas > 0;
            }
        }

        public List<Cliente> Filtrar(string filtro)
        {
            List<Cliente> lista = new List<Cliente>();

            using (SqlConnection conexion = CrearConexion())
            using (SqlCommand comando = new SqlCommand("sp_Cliente_Buscar", conexion))
            {
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.Add("@Filtro", SqlDbType.NVarChar, 100).Value = filtro;

                conexion.Open();
                using (SqlDataReader lector = comando.ExecuteReader())
                {
                    while (lector.Read())
                    {
                        Cliente cliente = new Cliente
                        {
                            IdCliente = Convert.ToInt32(lector["IdCliente"]),
                            Nombre = lector["Nombre"].ToString(),
                            Apellido = lector["Apellido"].ToString(),
                            Telefono = lector["Telefono"] != DBNull.Value ? lector["Telefono"].ToString() : string.Empty,
                            CreatedAt = Convert.ToDateTime(lector["CreatedAt"]),
                            Estado = Convert.ToBoolean(lector["Estado"])
                        };
                        lista.Add(cliente);
                    }
                }
            }
            return lista;
        }
    }
}