using System;
using System.Collections.Generic;
using CapaDato;
using ClienteEntidad = Entidades.Cliente;

namespace CapaNegocio
{
    public class ClienteNegocio
    {
        private readonly ClienteDatos clienteDatos;

        public ClienteNegocio()
        {
            clienteDatos = new ClienteDatos();
        }

        public List<ClienteEntidad> Consultar()
        {
            return clienteDatos.ConsultarTodos();
        }

        public ClienteEntidad Buscar(int idCliente)
        {
            ValidarIdCliente(idCliente);
            return clienteDatos.Buscar(idCliente);
        }

        public List<ClienteEntidad> Filtrar(string texto)
        {
            return clienteDatos.Filtrar(texto);
        }

        public bool Insertar(ClienteEntidad cliente)
        {
            ValidarCliente(cliente);
            return clienteDatos.Insertar(cliente);
        }

        public bool Actualizar(ClienteEntidad cliente)
        {
            if (cliente == null || cliente.IdCliente <= 0)
            {
                throw new ArgumentException("Debe seleccionar un cliente válido para actualizar.");
            }

            ValidarCliente(cliente);
            return clienteDatos.Actualizar(cliente);
        }

        public bool Eliminar(int idCliente)
        {
            ValidarIdCliente(idCliente);
            return clienteDatos.Eliminar(idCliente);
        }

        private void ValidarCliente(ClienteEntidad cliente)
        {
            if (cliente == null)
            {
                throw new ArgumentNullException(nameof(cliente), "Los datos del cliente son obligatorios.");
            }

            if (string.IsNullOrWhiteSpace(cliente.Nombre))
            {
                throw new ArgumentException("El nombre del cliente es obligatorio.");
            }

            if (string.IsNullOrWhiteSpace(cliente.Apellido))
            {
                throw new ArgumentException("El apellido del cliente es obligatorio.");
            }

            cliente.Nombre = cliente.Nombre.Trim();
            cliente.Apellido = cliente.Apellido.Trim();
            cliente.Telefono = string.IsNullOrWhiteSpace(cliente.Telefono) ? null : cliente.Telefono.Trim();
        }

        private void ValidarIdCliente(int idCliente)
        {
            if (idCliente <= 0)
            {
                throw new ArgumentException("El identificador del cliente no es válido.");
            }
        }
    }
}