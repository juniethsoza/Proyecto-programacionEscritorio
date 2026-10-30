using CapaDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using ClienteEntidad = Entidades.Cliente;

namespace CapaDato
{
    public class ClienteDatos
    {
        public List<ClienteEntidad> ConsultarTodos()
        {
            using (BDSIGIVEntities contexto = new BDSIGIVEntities())
            {
                List<CapaDatos.Cliente> clientesBD = contexto.Cliente.ToList();
                return ConvertirLista(clientesBD);
            }
        }

        public ClienteEntidad Buscar(int idCliente)
        {
            using (BDSIGIVEntities contexto = new BDSIGIVEntities())
            {
                CapaDatos.Cliente clienteBD = contexto.Cliente.FirstOrDefault(
                    registro => registro.IdCliente == idCliente);

                return ConvertirEntidad(clienteBD);
            }
        }

        public List<ClienteEntidad> Filtrar(string texto)
        {
            if (string.IsNullOrWhiteSpace(texto))
            {
                return ConsultarTodos();
            }

            using (BDSIGIVEntities contexto = new BDSIGIVEntities())
            {
                string criterio = texto.Trim().ToLower();

                List<CapaDatos.Cliente> clientesBD = contexto.Cliente
                    .Where(cliente =>
                        cliente.Nombre.ToLower().Contains(criterio) ||
                        cliente.Apellido.ToLower().Contains(criterio) ||
                        (cliente.Telefono != null && cliente.Telefono.Contains(criterio)))
                    .ToList();

                return ConvertirLista(clientesBD);
            }
        }

        public bool Insertar(ClienteEntidad cliente)
        {
            using (BDSIGIVEntities contexto = new BDSIGIVEntities())
            {
                CapaDatos.Cliente nuevoCliente = new CapaDatos.Cliente
                {
                    Nombre = cliente.Nombre,
                    Apellido = cliente.Apellido,
                    Telefono = string.IsNullOrWhiteSpace(cliente.Telefono) ? null : cliente.Telefono,
                    CreatedAt = DateTime.Now,
                    Estado = true
                };

                contexto.Cliente.Add(nuevoCliente);
                return contexto.SaveChanges() > 0;
            }
        }

        public bool Actualizar(ClienteEntidad cliente)
        {
            using (BDSIGIVEntities contexto = new BDSIGIVEntities())
            {
                CapaDatos.Cliente clienteEncontrado = contexto.Cliente.FirstOrDefault(
                    registro => registro.IdCliente == cliente.IdCliente);

                if (clienteEncontrado == null)
                {
                    return false;
                }

                clienteEncontrado.Nombre = cliente.Nombre;
                clienteEncontrado.Apellido = cliente.Apellido;
                clienteEncontrado.Telefono = string.IsNullOrWhiteSpace(cliente.Telefono) ? null : cliente.Telefono;

                contexto.SaveChanges();
                return true;
            }
        }

        public bool Eliminar(int idCliente)
        {
            using (BDSIGIVEntities contexto = new BDSIGIVEntities())
            {
                CapaDatos.Cliente clienteEncontrado = contexto.Cliente.FirstOrDefault(
                    registro => registro.IdCliente == idCliente);

                if (clienteEncontrado == null)
                {
                    return false;
                }

                clienteEncontrado.Estado = false; 
                contexto.SaveChanges();
                return true;
            }
        }

        private static ClienteEntidad ConvertirEntidad(CapaDatos.Cliente clienteBD)
        {
            if (clienteBD == null)
            {
                return null;
            }

            return new ClienteEntidad
            {
                IdCliente = clienteBD.IdCliente,
                Nombre = clienteBD.Nombre,
                Apellido = clienteBD.Apellido,
                Telefono = clienteBD.Telefono ?? string.Empty,
                CreatedAt = clienteBD.CreatedAt ?? DateTime.Now,
                Estado = clienteBD.Estado ?? true
            };
        }

        private static List<ClienteEntidad> ConvertirLista(IEnumerable<CapaDatos.Cliente> listaBD)
        {
            return listaBD
                .Select(cliente => ConvertirEntidad(cliente))
                .ToList();
        }
    }
}