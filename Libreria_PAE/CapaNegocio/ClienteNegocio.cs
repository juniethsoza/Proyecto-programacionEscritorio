using CapaDato;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CapaNegocio
{
    public class ClienteNegocio
    {
        private readonly ClienteDatos datos = new ClienteDatos();

        public bool Insertar(Cliente cliente)
        {
            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new Exception("El nombre del cliente es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
                throw new Exception("El apellido del cliente es obligatorio.");
            try
            {
                return datos.Insertar(cliente);
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("El número de teléfono ingresado ya está registrado con otro cliente.");
                }
                throw;
            }

           
        }

        public bool Actualizar(Cliente cliente)
        {
            if (cliente.IdCliente <= 0)
                throw new Exception("Debe seleccionar un cliente válido para actualizar.");

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
                throw new Exception("El nombre del cliente es obligatorio.");

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
                throw new Exception("El apellido del cliente es obligatorio.");

            try
            {
                return datos.Actualizar(cliente);
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    throw new Exception("El número de teléfono ingresado ya está registrado con otro cliente.");
                }
                throw;
            }
        }

        public bool Eliminar(int idCliente)
        {
            if (idCliente <= 0)
                throw new Exception("Debe seleccionar un cliente válido para dar de baja.");

            return datos.Eliminar(idCliente);
        }

        public List<Cliente> ConsultarTodos()
        {
            return datos.ConsultarTodos()
                .OrderBy(c => c.IdCliente) 
                .ToList(); ;
        }

        public List<Cliente> Filtrar(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return datos.ConsultarTodos();

            return datos.Filtrar(filtro);
        }
    }
}