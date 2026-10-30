using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Entidades;
using CapaNegocio;
using System.Linq;

namespace Libreria_PAE
{
    public partial class frmCatalogos : Form
    {
        private int idClienteSeleccionado = 0;
        private readonly ClienteNegocio negocio = new ClienteNegocio();

        public frmCatalogos()
        {
            InitializeComponent();
            dgvCliente.RowPostPaint += dgvCliente_RowPostPaint;

            if (tbcCatalogo.TabPages.Contains(tbpCategoria)) tbcCatalogo.TabPages.Remove(tbpCategoria);
            if (tbcCatalogo.TabPages.Contains(tbpProducto)) tbcCatalogo.TabPages.Remove(tbpProducto);
            if (tbcCatalogo.TabPages.Contains(tbpProveedor)) tbcCatalogo.TabPages.Remove(tbpProveedor);

            if (tbcCatalogo.TabPages.Contains(tbpCliente))
            {
                tbcCatalogo.SelectedTab = tbpCliente;
            }
        }

        private void frmCatalogos_Load(object sender, EventArgs e)
        {
            if (cmbOrdenar.Items.Count == 0)
            {
                cmbOrdenar.Items.Add("A-Z");
                cmbOrdenar.Items.Add("Z-A");
                cmbOrdenar.SelectedIndex = 0; 
            }

            rbNombre.Checked = true; 
            CargarClientes();
            CargarClientes();
        }

        private void CargarClientes()
        {
            try
            {
                string filtro = txtFiltrar != null ? txtFiltrar.Text.Trim() : "";
                List<Cliente> lista = negocio.Filtrar(filtro);

                Cliente consumidorGeneral = lista.FirstOrDefault(c => c.Nombre == "Consumidor" && c.Apellido == "General");

                if (consumidorGeneral != null)
                {
                    lista.Remove(consumidorGeneral);
                }

                if (rbApellido != null && rbApellido.Checked)
                {
                    if (cmbOrdenar != null && cmbOrdenar.Text == "Z-A")
                        lista = lista.OrderByDescending(c => c.Apellido).ToList();
                    else
                        lista = lista.OrderBy(c => c.Apellido).ToList();
                }
                else 
                {
                    if (cmbOrdenar != null && cmbOrdenar.Text == "Z-A")
                        lista = lista.OrderByDescending(c => c.Nombre).ToList();
                    else
                        lista = lista.OrderBy(c => c.Nombre).ToList();
                }

                if (consumidorGeneral != null)
                {
                    lista.Insert(0, consumidorGeneral);
                }

                dgvCliente.DataSource = null;
                dgvCliente.DataSource = lista;

                if (dgvCliente.Columns.Count > 0)
                {
                    if (dgvCliente.Columns["IdCliente"] != null)
                        dgvCliente.Columns["IdCliente"].Visible = false;

                    if (dgvCliente.Columns["Estado"] != null)
                        dgvCliente.Columns["Estado"].Visible = false;

                    if (dgvCliente.Columns["Nombre"] != null)
                        dgvCliente.Columns["Nombre"].HeaderText = "Nombre";

                    if (dgvCliente.Columns["Apellido"] != null)
                        dgvCliente.Columns["Apellido"].HeaderText = "Apellido";

                    if (dgvCliente.Columns["Telefono"] != null)
                        dgvCliente.Columns["Telefono"].HeaderText = "Teléfono";

                    if (dgvCliente.Columns["CreatedAt"] != null)
                        dgvCliente.Columns["CreatedAt"].HeaderText = "Fecha Registro";

                    dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar clientes: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Cliente ObtenerCliente()
        {
            return new Cliente
            {
                IdCliente = idClienteSeleccionado,
                Nombre = txtNombre.Text.Trim(),
                Apellido = txtApellido.Text.Trim(),
                Telefono = txtTelefono.Text.Trim()
            };
        }

        private void MostrarCliente(Cliente cliente)
        {
            if (cliente == null) return;

            idClienteSeleccionado = cliente.IdCliente;
            txtNombre.Text = cliente.Nombre;
            txtApellido.Text = cliente.Apellido;
            txtTelefono.Text = cliente.Telefono ?? string.Empty;

            if (label23 != null)
                label23.Text = cliente.CreatedAt.ToString("dd/MM/yyyy");

            if (label24 != null)
                label24.Text = cliente.Estado ? "Activo" : "Baja";

            bool esConsumidorGeneral = (cliente.Nombre == "Consumidor" && cliente.Apellido == "General");

            txtNombre.ReadOnly = esConsumidorGeneral;
            txtApellido.ReadOnly = esConsumidorGeneral;
            txtTelefono.ReadOnly = esConsumidorGeneral;

        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            if (label23 != null) label23.Text = "---";
            if (label24 != null) label24.Text = "---";
            idClienteSeleccionado = 0;
            txtNombre.Focus();
        }

        private void EjecutarGuardarOAgregar()
        {
            try
            {
                Cliente cliente = ObtenerCliente();

                if (idClienteSeleccionado == 0)
                {
                    negocio.Insertar(cliente);
                    MessageBox.Show("El cliente fue registrado correctamente.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocio.Actualizar(cliente);
                    MessageBox.Show("Los datos del cliente fueron actualizados correctamente.", "Actualización completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarClientes();
                LimpiarControles();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EjecutarDarDeBaja()
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente de la lista para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea dar de baja a este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes) return;

                bool eliminado = negocio.Eliminar(idClienteSeleccionado);
                if (eliminado)
                {
                    MessageBox.Show("Cliente dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    CargarClientes();
                    LimpiarControles();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            EjecutarGuardarOAgregar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            EjecutarGuardarOAgregar();
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EjecutarDarDeBaja();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Cliente cliente = dgvCliente.Rows[e.RowIndex].DataBoundItem as Cliente;
            if (cliente != null)
            {
                MostrarCliente(cliente);
            }
        }

        private void dgvCliente_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string numeroFila = (e.RowIndex + 1).ToString();

            StringFormat formato = new StringFormat()
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Rectangle limitesEncabezado = new Rectangle(
                e.RowBounds.Left,
                e.RowBounds.Top,
                dgvCliente.RowHeadersWidth,
                e.RowBounds.Height
            );

            using (SolidBrush pincel = new SolidBrush(dgvCliente.RowHeadersDefaultCellStyle.ForeColor))
            {
                e.Graphics.DrawString(
                    numeroFila,
                    dgvCliente.RowHeadersDefaultCellStyle.Font ?? this.Font,
                    pincel,
                    limitesEncabezado,
                    formato
                );
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (idClienteSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un cliente de la tabla para editar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtNombre.Focus();
                MessageBox.Show("Modifique los campos necesarios y presione Guardar.", "Modo Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> listaClientes = new List<Cliente>();

                if (idClienteSeleccionado > 0)
                {
                    Cliente clienteUnico = negocio.Buscar(idClienteSeleccionado);
                    if (clienteUnico != null)
                    {
                        
                        listaClientes.Add(clienteUnico);
                    }
                }
                else
                {
                    listaClientes = negocio.Consultar();
                }

                if (listaClientes == null || listaClientes.Count == 0)
                {
                    MessageBox.Show("No existen datos para mostrar en el reporte.",
                        "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (FrmReporteCliente formulario = new FrmReporteCliente(listaClientes))
                {
                    formulario.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible generar el reporte",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void rdNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNombre.Checked) CargarClientes();
        }

        private void rdApellido_CheckedChanged(object sender, EventArgs e)
        {
            if (rbApellido.Checked) CargarClientes();
        }
    }
}