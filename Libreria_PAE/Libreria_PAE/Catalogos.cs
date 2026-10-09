using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;  
using CapaNegocio; 

namespace Libreria_PAE 
{
    public partial class frmCatalogos : Form
    {
        private int idClienteSeleccionado = 0;


        private readonly ClienteNegocio negocio = new ClienteNegocio();

        public frmCatalogos()
        {
            InitializeComponent();
            tbcCatalogo.TabPages.Remove(tbpCategoria);
            tbcCatalogo.TabPages.Remove(tbpProducto);
            tbcCatalogo.TabPages.Remove(tbpProveedor);

            tbcCatalogo.SelectedTab = tbpCliente;
        }

        void Limpiar()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            label23.Text = "---";
            label24.Text = "---";
            idClienteSeleccionado = 0;
            txtNombre.Focus();
        }

        void Imprimir()
        {
            try
            {
                dgvCliente.DataSource = null;
                dgvCliente.DataSource = negocio.ConsultarTodos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cargar los clientes: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCatalogos_Load(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente
            {
                IdCliente = idClienteSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Telefono = string.IsNullOrWhiteSpace(txtTelefono.Text) ? null : txtTelefono.Text.Trim()
            };

            try
            {
                if (idClienteSeleccionado == 0)
                {
                    bool resultado = negocio.Insertar(cliente);
                    if (resultado)
                    {
                        MessageBox.Show("El cliente se registró correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Imprimir();
                        Limpiar();
                    }
                }
                else
                {
                    bool resultado = negocio.Actualizar(cliente);
                    if (resultado)
                    {
                        MessageBox.Show("Cliente actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Imprimir();
                        Limpiar();
                    }
                }
            }
            catch (Microsoft.Data.SqlClient.SqlException ex)
            {
                // Muestra el número exacto del error y el mensaje que envía SQL Server
                MessageBox.Show($"Error de SQL ({ex.Number}): {ex.Message}", "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCliente.CurrentRow != null)
            {
                DataGridViewRow fila = dgvCliente.Rows[e.RowIndex];

                idClienteSeleccionado = Convert.ToInt32(fila.Cells["IdCliente"].Value);
                txtNombre.Text = fila.Cells["Nombre"].Value.ToString();
                txtApellido.Text = fila.Cells["Apellido"].Value.ToString();
                txtTelefono.Text = fila.Cells["Telefono"].Value.ToString();

                label23.Text = Convert.ToDateTime(fila.Cells["CreatedAt"].Value).ToString("dd/MM/yyyy");
                bool estado = Convert.ToBoolean(fila.Cells["Estado"].Value);
                label24.Text = estado ? "Activo" : "Baja";
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente de la lista para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult respuesta = MessageBox.Show("¿Desea dar de baja a este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    bool resultado = negocio.Eliminar(idClienteSeleccionado);
                    if (resultado)
                    {
                        MessageBox.Show("Cliente dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Imprimir();
                        Limpiar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dgvCliente.DataSource = null;
                dgvCliente.DataSource = negocio.Filtrar(txtFiltrar.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

    }
}