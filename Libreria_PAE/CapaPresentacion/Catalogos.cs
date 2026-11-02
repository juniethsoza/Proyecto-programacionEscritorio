using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaNegocio;
using Entidades;

namespace Libreria_PAE
{
    public partial class frmCatalogos : Form
    {

        private int idClienteSeleccionado = 0;

        private readonly ClienteNegocio negocio = new ClienteNegocio();

        private int idCategoriaSeleccionado = 0;

        private readonly CategoriaNegocio negocioCategoria = new CategoriaNegocio();

        private int idSubcategoriaSeleccionado = 0;

        private readonly SubCategoriaNegocio negocioSubcategoria = new SubCategoriaNegocio();

        private int idProveedorSeleccionado = 0;
        private readonly ProveedorNegocio negocioProveedor = new ProveedorNegocio();

        private int idProductoSeleccionado = 0;
        private readonly ProductoNegocio negocioProducto = new ProductoNegocio();

        private int stockExistenteProducto = 0;

        public frmCatalogos()
        {
            InitializeComponent();
        }

        private void frmCatalogos_Load(object sender, EventArgs e)
        {

            //Clientes
            if (cmbOrdenar != null && cmbOrdenar.Items.Count == 0)
            {
                cmbOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbOrdenar.Items.Add("A-Z");
                cmbOrdenar.Items.Add("Z-A");
                cmbOrdenar.SelectedIndex = 0;
            }

            if (cmbNombre != null && cmbNombre.Items.Count == 0)
            {
                cmbNombre.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbNombre.Items.Add("Nombre");
                cmbNombre.Items.Add("Apellido");
                cmbNombre.SelectedIndex = 0;
            }

            //Categorías
            if (cmbOrdCat != null && cmbOrdCat.Items.Count == 0)
            {
                cmbOrdCat.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbOrdCat.Items.Add("A-Z");
                cmbOrdCat.Items.Add("Z-A");
                cmbOrdCat.SelectedIndex = 0;
            }

            if (cmbNomCt != null && cmbNomCt.Items.Count == 0)
            {
                cmbNomCt.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbNomCt.Items.Add("Nombre");
                cmbNomCt.Items.Add("Descripción");
                cmbNomCt.SelectedIndex = 0;
            }

            //Subcategorías
            if (cmbSubcat != null && cmbSubcat.Items.Count == 0)
            {
                cmbSubcat.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbSubcat.Items.Add("A-Z");
                cmbSubcat.Items.Add("Z-A");
                cmbSubcat.SelectedIndex = 0;
            }

            if (cmbNomSub != null && cmbNomSub.Items.Count == 0)
            {
                cmbNomSub.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbNomSub.Items.Add("Nombre");
                cmbNomSub.Items.Add("Descripción");
                cmbNomSub.Items.Add("Categoria");
                cmbNomSub.SelectedIndex = 0;
            }

            //Proveedores
            if (cmbProveedor != null && cmbProveedor.Items.Count == 0)
            {
                cmbProveedor.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbProveedor.Items.Add("A-Z");
                cmbProveedor.Items.Add("Z-A");
                cmbProveedor.SelectedIndex = 0;
            }

            if (cmbNomProv != null && cmbNomProv.Items.Count == 0)
            {
                cmbNomProv.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbNomProv.Items.Add("Nombre");
                cmbNomProv.Items.Add("Teléfono");
                cmbNomProv.SelectedIndex = 0;
            }

            //Productos
            if (cmbProducto != null && cmbProducto.Items.Count == 0)
            {
                cmbProducto.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbProducto.Items.Add("A-Z");
                cmbProducto.Items.Add("Z-A");
                cmbProducto.SelectedIndex = 0;
            }

            if (cmbNomP != null && cmbNomP.Items.Count == 0)
            {
                cmbNomP.DropDownStyle = ComboBoxStyle.DropDownList;
                cmbNomP.Items.Add("Código");
                cmbNomP.Items.Add("Nombre");
                cmbNomP.Items.Add("Categoría");
                cmbNomP.Items.Add("Subcategoría");
                cmbNomP.Items.Add("Stock actual");
                cmbNomP.Items.Add("Stock mínimo");
                cmbNomP.SelectedIndex = 1;
            }

            if (dgvCliente != null)
            {
                dgvCliente.ColumnHeadersVisible = true;
                dgvCliente.RowHeadersVisible = true;
                dgvCliente.RowHeadersWidth = 45;
            }

            if (dgvCategoria != null)
            {
                dgvCategoria.ColumnHeadersVisible = true;
                dgvCategoria.RowHeadersVisible = true;
                dgvCategoria.RowHeadersWidth = 45;
            }

            if (dgvSubcategoria != null)
            {
                dgvSubcategoria.ColumnHeadersVisible = true;
                dgvSubcategoria.RowHeadersVisible = true;
                dgvSubcategoria.RowHeadersWidth = 45;
            }

            if (dgvProveedor != null)
            {
                dgvProveedor.ColumnHeadersVisible = true;
                dgvProveedor.RowHeadersVisible = true;
                dgvProveedor.RowHeadersWidth = 45;
            }

            if (dgvProducto != null)
            {
                dgvProducto.ColumnHeadersVisible = true;
                dgvProducto.RowHeadersVisible = true;
                dgvProducto.RowHeadersWidth = 45;
            }

            //Reglas iniciales para la UI de Productos
            if (txtStockActualP != null)
            {
                txtStockActualP.ReadOnly = true;
                txtStockActualP.Text = "0";
            }

            if (cmbCategoriaP != null)
            {
                cmbCategoriaP.SelectedIndexChanged -= cmbCategoriaP_SelectedIndexChanged;
                cmbCategoriaP.SelectedIndexChanged += cmbCategoriaP_SelectedIndexChanged;
            }

            CargarComboCategoriasEnSubcat();
            CargarCombosProducto();

            CargarClientes();
            CargarCategorias();
            CargarSubcategorias();
            CargarProveedores();
            CargarProductos();
        }

    //Modulo de clientes

        private void CargarClientes()
        {
            try
            {
                string filtro = txtFiltrar != null ? txtFiltrar.Text.Trim() : "";
                List<Cliente> lista = negocio.Filtrar(filtro);

                if (lista == null) lista = new List<Cliente>();

                Cliente consumidorGeneral = lista.FirstOrDefault(c => c.Nombre == "Consumidor" && c.Apellido == "General");

                if (consumidorGeneral != null)
                {
                    lista.Remove(consumidorGeneral);
                }

                bool ordenarPorApellido = (cmbNombre != null && cmbNombre.SelectedItem?.ToString() == "Apellido");
                bool esDescendente = (cmbOrdenar != null && cmbOrdenar.SelectedItem?.ToString() == "Z-A");

                if (ordenarPorApellido)
                {
                    lista = esDescendente
                        ? lista.OrderByDescending(c => c.Apellido ?? string.Empty).ToList()
                        : lista.OrderBy(c => c.Apellido ?? string.Empty).ToList();
                }
                else
                {
                    lista = esDescendente
                        ? lista.OrderByDescending(c => c.Nombre ?? string.Empty).ToList()
                        : lista.OrderBy(c => c.Nombre ?? string.Empty).ToList();
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

                    if (dgvCliente.Columns["CreatedAt"] != null)
                        dgvCliente.Columns["CreatedAt"].Visible = false;

                    if (dgvCliente.Columns["Nombre"] != null)
                        dgvCliente.Columns["Nombre"].HeaderText = "Nombre";

                    if (dgvCliente.Columns["Apellido"] != null)
                        dgvCliente.Columns["Apellido"].HeaderText = "Apellido";

                    if (dgvCliente.Columns["Telefono"] != null)
                        dgvCliente.Columns["Telefono"].HeaderText = "Teléfono";

                    dgvCliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    dgvCliente.EnableHeadersVisualStyles = false;
                    Color colorLila = Color.FromArgb(225, 213, 248);
                    Color colorTexto = Color.FromArgb(30, 30, 30);

                    dgvCliente.ColumnHeadersDefaultCellStyle.BackColor = colorLila;
                    dgvCliente.ColumnHeadersDefaultCellStyle.ForeColor = colorTexto;

                    foreach (DataGridViewColumn col in dgvCliente.Columns)
                    {
                        col.HeaderCell.Style.BackColor = colorLila;
                        col.HeaderCell.Style.ForeColor = colorTexto;
                    }

                    dgvCliente.TopLeftHeaderCell.Style.BackColor = colorLila;
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

            btnEliminar.Enabled = !esConsumidorGeneral;

            if (btnAgregar != null)
            {
                btnAgregar.Text = "Modificar";
                btnAgregar.Enabled = !esConsumidorGeneral;
            }
        }

        private void LimpiarControles()
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtTelefono.Clear();
            txtNombre.ReadOnly = false;
            txtApellido.ReadOnly = false;
            txtTelefono.ReadOnly = false;

            btnEliminar.Enabled = true;

            if (btnAgregar != null)
            {
                btnAgregar.Text = "Agregar";
                btnAgregar.Enabled = true;
            }

            if (label23 != null) label23.Text = "---";
            if (label24 != null) label24.Text = "---";
            idClienteSeleccionado = 0;
            txtNombre.Focus();
        }

        private void EjecutarGuardarOAgregar()
        {
            try
            {
                if (txtNombre.Text.Trim().Equals("Consumidor", StringComparison.OrdinalIgnoreCase) &&
                    txtApellido.Text.Trim().Equals("General", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("El cliente 'Consumidor General' es un registro base del sistema y no puede ser modificado ni sobreescrito.",
                                    "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

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

            if (txtNombre.Text.Trim().Equals("Consumidor", StringComparison.OrdinalIgnoreCase) &&
                txtApellido.Text.Trim().Equals("General", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("El cliente 'Consumidor General' es un registro del sistema y no puede ser dado de baja.",
                                "Acción no permitida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void btnAgregar_Click(object sender, EventArgs e) => EjecutarGuardarOAgregar();
        private void btnEliminar_Click(object sender, EventArgs e) => EjecutarDarDeBaja();
        private void btnNuevo_Click(object sender, EventArgs e) => LimpiarControles();
        private void btnCerrar_Click_1(object sender, EventArgs e) => Close();

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFiltrar.Text)) CargarClientes();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvCliente.Rows[e.RowIndex].DataBoundItem is Cliente cliente) MostrarCliente(cliente);
        }

        private void dgvCliente_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string numeroFila = (e.RowIndex + 1).ToString();
            using (StringFormat formato = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                Rectangle limitesEncabezado = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvCliente.RowHeadersWidth, e.RowBounds.Height);
                using (SolidBrush pincel = new SolidBrush(dgvCliente.RowHeadersDefaultCellStyle.ForeColor))
                {
                    e.Graphics.DrawString(numeroFila, dgvCliente.RowHeadersDefaultCellStyle.Font ?? this.Font, pincel, limitesEncabezado, formato);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                List<Cliente> listaClientes = new List<Cliente>();

                if (idClienteSeleccionado > 0)
                {
                    Cliente clienteUnico = negocio.Buscar(idClienteSeleccionado);
                    if (clienteUnico != null) listaClientes.Add(clienteUnico);
                }
                else
                {
                    listaClientes = negocio.Consultar();
                }

                if (listaClientes == null || listaClientes.Count == 0)
                {
                    MessageBox.Show("No existen datos para mostrar en el reporte.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                using (FrmReporteCliente formulario = new FrmReporteCliente(listaClientes))
                {
                    formulario.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible generar el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cmbOrdenar_SelectedIndexChanged(object sender, EventArgs e) => CargarClientes();
        private void cmbNombre_SelectedIndexChanged_1(object sender, EventArgs e) => CargarClientes();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFiltrar.Text))
            {
                MessageBox.Show("Por favor, ingrese un término en el buscador para realizar la consulta.", "Búsqueda vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtFiltrar.Focus();
                return;
            }
            CargarClientes();
        }

//Modulo de categorias

        private void CargarCategorias()
        {
            try
            {
                string filtro = txtBuscarCt != null ? txtBuscarCt.Text.Trim() : null;
                string seleccionCampo = (cmbNomCt != null && cmbNomCt.SelectedItem != null)
                    ? cmbNomCt.SelectedItem.ToString()
                    : "Nombre";

                string ordenarPor = (seleccionCampo == "Descripción" || seleccionCampo == "Descripcion")
                    ? "Descripcion"
                    : "Nombre";

                bool esDescendente = (cmbOrdCat != null && cmbOrdCat.SelectedItem?.ToString() == "Z-A");

                List<Categoria> lista = negocioCategoria.Listar(filtro, ordenarPor, esDescendente);

                if (lista == null) lista = new List<Categoria>();

                dgvCategoria.DataSource = null;
                dgvCategoria.DataSource = lista;

                if (dgvCategoria.Columns.Count > 0)
                {
                    if (dgvCategoria.Columns["IdCategoria"] != null) dgvCategoria.Columns["IdCategoria"].Visible = false;
                    if (dgvCategoria.Columns["Estado"] != null) dgvCategoria.Columns["Estado"].Visible = false;
                    if (dgvCategoria.Columns["CreatedAt"] != null) dgvCategoria.Columns["CreatedAt"].Visible = false;
                    if (dgvCategoria.Columns["Nombre"] != null) dgvCategoria.Columns["Nombre"].HeaderText = "Nombre";
                    if (dgvCategoria.Columns["Descripcion"] != null) dgvCategoria.Columns["Descripcion"].HeaderText = "Descripción";

                    dgvCategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvCategoria.EnableHeadersVisualStyles = false;

                    Color colorLila = Color.FromArgb(225, 213, 248);
                    Color colorTexto = Color.FromArgb(30, 30, 30);

                    dgvCategoria.ColumnHeadersDefaultCellStyle.BackColor = colorLila;
                    dgvCategoria.ColumnHeadersDefaultCellStyle.ForeColor = colorTexto;

                    foreach (DataGridViewColumn col in dgvCategoria.Columns)
                    {
                        col.HeaderCell.Style.BackColor = colorLila;
                        col.HeaderCell.Style.ForeColor = colorTexto;
                    }

                    dgvCategoria.TopLeftHeaderCell.Style.BackColor = colorLila;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Categoria ObtenerCategoria()
        {
            return new Categoria
            {
                IdCategoria = idCategoriaSeleccionado,
                Nombre = txtNombreCategoria.Text.Trim(),
                Descripcion = txtDescripcionCt.Text.Trim()
            };
        }

        private void MostrarCategoria(Categoria categoria)
        {
            if (categoria == null) return;

            idCategoriaSeleccionado = categoria.IdCategoria;
            txtNombreCategoria.Text = categoria.Nombre;
            txtDescripcionCt.Text = categoria.Descripcion ?? string.Empty;

            if (lbFecha != null)
                lbFecha.Text = categoria.CreatedAt?.ToString("dd/MM/yyyy") ?? string.Empty;

            if (btnAgregarCt != null)
            {
                btnAgregarCt.Text = "Modificar";
            }
        }

        private void LimpiarControlesCategoria()
        {
            txtNombreCategoria.Clear();
            txtDescripcionCt.Clear();
            if (lbFecha != null) lbFecha.Text = "---";
            idCategoriaSeleccionado = 0;

            if (btnAgregarCt != null)
            {
                btnAgregarCt.Text = "Agregar";
            }

            txtNombreCategoria.Focus();
        }

        private void EjecutarGuardarOAgregarCategoria()
        {
            try
            {
                Categoria categoria = ObtenerCategoria();

                if (idCategoriaSeleccionado == 0)
                {
                    negocioCategoria.Insertar(categoria);
                    MessageBox.Show("La categoría fue registrada correctamente.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocioCategoria.Actualizar(categoria);
                    MessageBox.Show("Los datos de la categoría fueron actualizados correctamente.", "Actualización completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarCategorias();
                CargarComboCategoriasEnSubcat();
                CargarCombosProducto();
                LimpiarControlesCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EjecutarDarDeBajaCategoria()
        {
            if (idCategoriaSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una categoría de la lista para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea dar de baja a esta categoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes) return;

                negocioCategoria.Eliminar(idCategoriaSeleccionado);
                MessageBox.Show("Categoría dada de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarCategorias();
                CargarComboCategoriasEnSubcat();
                CargarCombosProducto();
                LimpiarControlesCategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarCt_Click(object sender, EventArgs e) => EjecutarGuardarOAgregarCategoria();
        private void btnEliminarCt_Click(object sender, EventArgs e) => EjecutarDarDeBajaCategoria();
        private void btnCerrarCt_Click(object sender, EventArgs e) => Close();
        private void cmbOrdCat_SelectedIndexChanged(object sender, EventArgs e) => CargarCategorias();
        private void cmbNomCt_SelectedIndexChanged(object sender, EventArgs e) => CargarCategorias();
        private void btnNuevoCt_Click(object sender, EventArgs e) => LimpiarControlesCategoria();

        private void btnImprimirCt_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El reporte de categorías estará disponible próximamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnbuscarCat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarCt.Text))
            {
                MessageBox.Show("Por favor, ingrese un término en el buscador para realizar la consulta.", "Búsqueda vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscarCt.Focus();
                return;
            }
            CargarCategorias();
        }

        private void txtBuscarCt_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarCt.Text)) CargarCategorias();
        }

        private void dgvCategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvCategoria.Rows[e.RowIndex].DataBoundItem is Categoria categoria) MostrarCategoria(categoria);
        }

        private void dgvCategoria_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string numeroFila = (e.RowIndex + 1).ToString();
            using (StringFormat formato = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                Rectangle areaEncabezado = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvCategoria.RowHeadersWidth, e.RowBounds.Height);
                Color colorTexto = dgvCategoria.Rows[e.RowIndex].Selected ? Color.Black : dgvCategoria.RowHeadersDefaultCellStyle.ForeColor;
                using (Brush pincel = new SolidBrush(colorTexto))
                {
                    e.Graphics.DrawString(numeroFila, dgvCategoria.Font, pincel, areaEncabezado, formato);
                }
            }
        }

        //Modulo de subcategoria

        private void CargarComboCategoriasEnSubcat()
        {
            try
            {
                if (cmbCategoria == null) return;

                List<Categoria> categorias = negocioCategoria.Listar(null, "Nombre", false);
                cmbCategoria.DataSource = null;
                cmbCategoria.DataSource = categorias;
                cmbCategoria.DisplayMember = "Nombre";
                cmbCategoria.ValueMember = "IdCategoria";
                cmbCategoria.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías en subcategorías: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CargarSubcategorias()
        {
            try
            {
                if (dgvSubcategoria == null) return;

                string filtro = txtBuscarSub != null ? txtBuscarSub.Text.Trim() : null;
                string seleccionCampo = (cmbNomSub != null && cmbNomSub.SelectedItem != null)
                    ? cmbNomSub.SelectedItem.ToString()
                    : "Nombre";

                string ordenarPor = "Nombre";
                if (seleccionCampo.IndexOf("Descripci", StringComparison.OrdinalIgnoreCase) >= 0)
                    ordenarPor = "Descripcion";
                else if (seleccionCampo.IndexOf("Categor", StringComparison.OrdinalIgnoreCase) >= 0)
                    ordenarPor = "Categoria";
                else if (seleccionCampo.Equals("CreatedAt", StringComparison.OrdinalIgnoreCase))
                    ordenarPor = "CreatedAt";

                bool esDescendente = (cmbSubcat != null && cmbSubcat.SelectedItem?.ToString() == "Z-A");

                List<SubCategoria> lista = negocioSubcategoria.Listar(filtro, ordenarPor, esDescendente);

                if (lista == null) lista = new List<SubCategoria>();

                dgvSubcategoria.DataSource = null;
                dgvSubcategoria.DataSource = lista;

                if (dgvSubcategoria.Columns.Count > 0)
                {
                    if (dgvSubcategoria.Columns["IdSubcategoria"] != null) dgvSubcategoria.Columns["IdSubcategoria"].Visible = false;
                    if (dgvSubcategoria.Columns["CategoriaID"] != null) dgvSubcategoria.Columns["CategoriaID"].Visible = false;
                    if (dgvSubcategoria.Columns["CreatedAt"] != null) dgvSubcategoria.Columns["CreatedAt"].Visible = false;

                    if (dgvSubcategoria.Columns["NombreCategoria"] != null)
                    {
                        dgvSubcategoria.Columns["NombreCategoria"].HeaderText = "Categoría";
                        dgvSubcategoria.Columns["NombreCategoria"].DisplayIndex = 0;
                    }
                    if (dgvSubcategoria.Columns["Nombre"] != null)
                    {
                        dgvSubcategoria.Columns["Nombre"].HeaderText = "Subcategoría";
                        dgvSubcategoria.Columns["Nombre"].DisplayIndex = 1;
                    }
                    if (dgvSubcategoria.Columns["Descripcion"] != null)
                    {
                        dgvSubcategoria.Columns["Descripcion"].HeaderText = "Descripción";
                        dgvSubcategoria.Columns["Descripcion"].DisplayIndex = 2;
                    }

                    dgvSubcategoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvSubcategoria.EnableHeadersVisualStyles = false;
                    Color colorLila = Color.FromArgb(225, 213, 248);
                    Color colorTexto = Color.FromArgb(30, 30, 30);

                    dgvSubcategoria.ColumnHeadersDefaultCellStyle.BackColor = colorLila;
                    dgvSubcategoria.ColumnHeadersDefaultCellStyle.ForeColor = colorTexto;

                    foreach (DataGridViewColumn col in dgvSubcategoria.Columns)
                    {
                        col.HeaderCell.Style.BackColor = colorLila;
                        col.HeaderCell.Style.ForeColor = colorTexto;
                    }

                    dgvSubcategoria.TopLeftHeaderCell.Style.BackColor = colorLila;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar subcategorías: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private SubCategoria ObtenerSubcategoria()
        {
            int catId = 0;
            if (cmbCategoria?.SelectedValue != null)
            {
                int.TryParse(cmbCategoria.SelectedValue.ToString(), out catId);
            }
            else if (cmbCategoria?.SelectedItem is Categoria cat)
            {
                catId = cat.IdCategoria;
            }

            return new SubCategoria
            {
                IdSubcategoria = idSubcategoriaSeleccionado,
                CategoriaID = catId,
                Nombre = txtNombresub != null ? txtNombresub.Text.Trim() : string.Empty,
                Descripcion = txtDescripcionsub != null ? txtDescripcionsub.Text.Trim() : string.Empty
            };
        }

        private void MostrarSubcategoria(SubCategoria subcat)
        {
            if (subcat == null) return;

            idSubcategoriaSeleccionado = subcat.IdSubcategoria;
            if (cmbCategoria != null) cmbCategoria.SelectedValue = subcat.CategoriaID;
            if (txtNombresub != null) txtNombresub.Text = subcat.Nombre;
            if (txtDescripcionsub != null) txtDescripcionsub.Text = subcat.Descripcion ?? string.Empty;

            if (pnlFechasub != null) pnlFechasub.Visible = true;
            if (lbFechasub != null)
            {
                lbFechasub.Text = subcat.CreatedAt?.ToString("dd/MM/yyyy") ?? "---";
            }

            if (btnAgregarsub != null)
            {
                btnAgregarsub.Text = "Modificar";
            }
        }

        private void LimpiarControlesSubcategoria()
        {
            if (cmbCategoria != null) cmbCategoria.SelectedIndex = -1;
            if (txtNombresub != null) txtNombresub.Clear();
            if (txtDescripcionsub != null) txtDescripcionsub.Clear();
            if (pnlFechasub != null) pnlFechasub.Visible = false;
            if (lbFechasub != null) lbFechasub.Text = "---";

            idSubcategoriaSeleccionado = 0;

            if (btnAgregarsub != null)
            {
                btnAgregarsub.Text = "Agregar";
            }

            if (dgvSubcategoria != null) dgvSubcategoria.ClearSelection();
            if (cmbCategoria != null) cmbCategoria.Focus();
        }

        private void EjecutarGuardarOAgregarSubcategoria()
        {
            try
            {
                if (cmbCategoria == null || cmbCategoria.SelectedIndex == -1 || cmbCategoria.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione una categoría principal.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    if (cmbCategoria != null) cmbCategoria.Focus();
                    return;
                }

                SubCategoria subcat = ObtenerSubcategoria();

                if (idSubcategoriaSeleccionado == 0)
                {
                    negocioSubcategoria.Insertar(subcat);
                    MessageBox.Show("La subcategoría fue registrada correctamente.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocioSubcategoria.Actualizar(subcat);
                    MessageBox.Show("Los datos de la subcategoría fueron actualizados correctamente.", "Actualización completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarSubcategorias();
                LimpiarControlesSubcategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EjecutarDarDeBajaSubcategoria()
        {
            if (idSubcategoriaSeleccionado == 0)
            {
                MessageBox.Show("Seleccione una subcategoría de la lista para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea dar de baja a esta subcategoría?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes) return;

                negocioSubcategoria.Eliminar(idSubcategoriaSeleccionado);
                MessageBox.Show("Subcategoría dada de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarSubcategorias();
                LimpiarControlesSubcategoria();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarsub_Click(object sender, EventArgs e) => EjecutarGuardarOAgregarSubcategoria();
        private void btnEliminarsub_Click(object sender, EventArgs e) => EjecutarDarDeBajaSubcategoria();
        private void btnNuevosub_Click(object sender, EventArgs e) => LimpiarControlesSubcategoria();
        private void btnCerrarsub_Click(object sender, EventArgs e) => Close();

        private void btnImprimirsub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El reporte de subcategorías estará disponible próximamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarsub_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarSub.Text))
            {
                MessageBox.Show("Por favor, ingrese un término en el buscador para realizar la consulta.", "Búsqueda vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscarSub.Focus();
                return;
            }
            CargarSubcategorias();
        }

        private void txtBuscarSub_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarSub.Text)) CargarSubcategorias();
        }

        private void cmbSubcat_SelectedIndexChanged(object sender, EventArgs e) => CargarSubcategorias();
        private void cmbNomSub_SelectedIndexChanged(object sender, EventArgs e) => CargarSubcategorias();

        private void dgvSubcategoria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvSubcategoria.Rows[e.RowIndex].DataBoundItem is SubCategoria subcat) MostrarSubcategoria(subcat);
        }

        private void dgvSubcategoria_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string numeroFila = (e.RowIndex + 1).ToString();
            using (StringFormat formato = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                Rectangle areaEncabezado = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvSubcategoria.RowHeadersWidth, e.RowBounds.Height);
                Color colorTexto = dgvSubcategoria.Rows[e.RowIndex].Selected ? Color.Black : dgvSubcategoria.RowHeadersDefaultCellStyle.ForeColor;
                using (Brush pincel = new SolidBrush(colorTexto))
                {
                    e.Graphics.DrawString(numeroFila, dgvSubcategoria.Font, pincel, areaEncabezado, formato);
                }
            }
        }

        //Modulo de proveedores

        private void CargarProveedores()
        {
            try
            {
                if (dgvProveedor == null) return;

                string filtro = txtBucarPrv != null ? txtBucarPrv.Text.Trim() : null;
                string seleccionCampo = (cmbNomProv != null && cmbNomProv.SelectedItem != null)
                    ? cmbNomProv.SelectedItem.ToString()
                    : "Nombre";

                string ordenarPor = "Nombre";
                if (seleccionCampo.IndexOf("Tel", StringComparison.OrdinalIgnoreCase) >= 0)
                    ordenarPor = "Telefono";

                bool esDescendente = (cmbProveedor != null && cmbProveedor.SelectedItem?.ToString() == "Z-A");

                List<Proveedor> lista = negocioProveedor.Listar(filtro, ordenarPor, esDescendente);

                if (lista == null) lista = new List<Proveedor>();

                dgvProveedor.DataSource = null;
                dgvProveedor.DataSource = lista;

                if (dgvProveedor.Columns.Count > 0)
                {
                    if (dgvProveedor.Columns["IdProveedor"] != null) dgvProveedor.Columns["IdProveedor"].Visible = false;
                    if (dgvProveedor.Columns["CreatedAt"] != null) dgvProveedor.Columns["CreatedAt"].Visible = false;
                    if (dgvProveedor.Columns["Estado"] != null) dgvProveedor.Columns["Estado"].Visible = false;

                    if (dgvProveedor.Columns["Nombre"] != null)
                    {
                        dgvProveedor.Columns["Nombre"].HeaderText = "Nombre";
                        dgvProveedor.Columns["Nombre"].DisplayIndex = 0;
                    }
                    if (dgvProveedor.Columns["Telefono"] != null)
                    {
                        dgvProveedor.Columns["Telefono"].HeaderText = "Teléfono";
                        dgvProveedor.Columns["Telefono"].DisplayIndex = 1;
                    }

                    dgvProveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvProveedor.EnableHeadersVisualStyles = false;

                    Color colorLila = Color.FromArgb(225, 213, 248);
                    Color colorTexto = Color.FromArgb(30, 30, 30);

                    dgvProveedor.ColumnHeadersDefaultCellStyle.BackColor = colorLila;
                    dgvProveedor.ColumnHeadersDefaultCellStyle.ForeColor = colorTexto;

                    foreach (DataGridViewColumn col in dgvProveedor.Columns)
                    {
                        col.HeaderCell.Style.BackColor = colorLila;
                        col.HeaderCell.Style.ForeColor = colorTexto;
                    }

                    dgvProveedor.TopLeftHeaderCell.Style.BackColor = colorLila;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar proveedores: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Proveedor ObtenerProveedor()
        {
            return new Proveedor
            {
                IdProveedor = idProveedorSeleccionado,
                Nombre = txtNombrePrv != null ? txtNombrePrv.Text.Trim() : string.Empty,
                Telefono = txtTelefonoPrv != null ? txtTelefonoPrv.Text.Trim() : string.Empty
            };
        }

        private void MostrarProveedor(Proveedor proveedor)
        {
            if (proveedor == null) return;

            idProveedorSeleccionado = proveedor.IdProveedor;
            if (txtNombrePrv != null) txtNombrePrv.Text = proveedor.Nombre;
            if (txtTelefonoPrv != null) txtTelefonoPrv.Text = proveedor.Telefono ?? string.Empty;

            if (pnlFechaPrv != null) pnlFechaPrv.Visible = true;
            if (lbFechaProv != null)
            {
                lbFechaProv.Text = proveedor.CreatedAt?.ToString("dd/MM/yyyy") ?? "---";
            }

            if (pnlEstadoProv != null) pnlEstadoProv.Visible = true;
            if (lbEstadoPrv != null)
            {
                lbEstadoPrv.Text = (proveedor.Estado.HasValue && proveedor.Estado.Value) ? "Activo" : "Baja";
            }

            if (btnAgregarProv != null)
            {
                btnAgregarProv.Text = "Modificar";
            }
        }

        private void LimpiarControlesProveedor()
        {
            if (txtNombrePrv != null) txtNombrePrv.Clear();
            if (txtTelefonoPrv != null) txtTelefonoPrv.Clear();

            if (pnlFechaPrv != null) pnlFechaPrv.Visible = false;
            if (lbFechaProv != null) lbFechaProv.Text = "---";

            if (pnlEstadoProv != null) pnlEstadoProv.Visible = false;
            if (lbEstadoPrv != null) lbEstadoPrv.Text = "---";

            idProveedorSeleccionado = 0;

            if (btnAgregarProv != null)
            {
                btnAgregarProv.Text = "Agregar";
            }

            if (dgvProveedor != null) dgvProveedor.ClearSelection();
            if (txtNombrePrv != null) txtNombrePrv.Focus();
        }

        private void EjecutarGuardarOAgregarProveedor()
        {
            try
            {
                Proveedor proveedor = ObtenerProveedor();

                if (idProveedorSeleccionado == 0)
                {
                    negocioProveedor.Insertar(proveedor);
                    MessageBox.Show("El proveedor fue registrado correctamente.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocioProveedor.Actualizar(proveedor);
                    MessageBox.Show("Los datos del proveedor fueron actualizados correctamente.", "Actualización completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarProveedores();
                LimpiarControlesProveedor();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EjecutarDarDeBajaProveedor()
        {
            if (idProveedorSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un proveedor de la lista para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea dar de baja a este proveedor?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes) return;

                negocioProveedor.Eliminar(idProveedorSeleccionado);
                MessageBox.Show("Proveedor dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProveedores();
                LimpiarControlesProveedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarProv_Click_1(object sender, EventArgs e) => EjecutarGuardarOAgregarProveedor();
        private void btnEliminarPrv_Click_1(object sender, EventArgs e) => EjecutarDarDeBajaProveedor();
        private void btnNuevoPrv_Click_1(object sender, EventArgs e) => LimpiarControlesProveedor();
        private void btnCerrarPrv_Click_1(object sender, EventArgs e) => Close();
        private void btnImprimirPrv_Click(object sender, EventArgs e) => MessageBox.Show("El reporte de proveedores estará disponible próximamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private void btnbuscarPrv_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBucarPrv.Text))
            {
                MessageBox.Show("Por favor, ingrese un término en el buscador para realizar la consulta.", "Búsqueda vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBucarPrv.Focus();
                return;
            }
            CargarProveedores();
        }

        private void txtBucarPrv_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBucarPrv.Text)) CargarProveedores();
        }

        private void cmbProveedor_SelectedIndexChanged_1(object sender, EventArgs e) => CargarProveedores();
        private void cmbNomProv_SelectedIndexChanged_1(object sender, EventArgs e) => CargarProveedores();

        private void dgvProveedor_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProveedor.Rows[e.RowIndex].DataBoundItem is Proveedor proveedor) MostrarProveedor(proveedor);
        }

        private void dgvProveedor_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string numeroFila = (e.RowIndex + 1).ToString();
            using (StringFormat formato = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                Rectangle areaEncabezado = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvProveedor.RowHeadersWidth, e.RowBounds.Height);
                Color colorTexto = dgvProveedor.Rows[e.RowIndex].Selected ? Color.Black : dgvProveedor.RowHeadersDefaultCellStyle.ForeColor;
                using (Brush pincel = new SolidBrush(colorTexto))
                {
                    e.Graphics.DrawString(numeroFila, dgvProveedor.Font, pincel, areaEncabezado, formato);
                }
            }
        }

        //Modulo de productos

        private void CargarCombosProducto()
        {
            try
            {
                if (cmbCategoriaP != null)
                {
                    var categorias = negocioCategoria.Listar(null, "Nombre", false);
                    cmbCategoriaP.DataSource = null;
                    cmbCategoriaP.DataSource = categorias;
                    cmbCategoriaP.DisplayMember = "Nombre";
                    cmbCategoriaP.ValueMember = "IdCategoria";
                    cmbCategoriaP.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar categorías en productos: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void cmbCategoriaP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSubcategoriaP == null) return;

                if (cmbCategoriaP.SelectedValue != null && int.TryParse(cmbCategoriaP.SelectedValue.ToString(), out int idCat))
                {
                    var subcategorias = negocioSubcategoria.Listar(null, "Nombre", false)
                                        .Where(s => s.CategoriaID == idCat).ToList();

                    cmbSubcategoriaP.DataSource = null;
                    cmbSubcategoriaP.DataSource = subcategorias;
                    cmbSubcategoriaP.DisplayMember = "Nombre";
                    cmbSubcategoriaP.ValueMember = "IdSubcategoria";
                    cmbSubcategoriaP.SelectedIndex = -1;
                }
                else
                {
                    cmbSubcategoriaP.DataSource = null;
                }
            }
            catch
            {

            }
        }

        private void CargarProductos()
        {
            try
            {
                if (dgvProducto == null) return;

                string filtro = txtBuscarP != null ? txtBuscarP.Text.Trim() : null;
                string seleccionCampo = (cmbNomP != null && cmbNomP.SelectedItem != null)
                    ? cmbNomP.SelectedItem.ToString()
                    : "Nombre";

                string ordenarPor = "Nombre";
                if (seleccionCampo == "Código") ordenarPor = "Codigo";
                else if (seleccionCampo == "Categoría") ordenarPor = "Categoria";
                else if (seleccionCampo == "Subcategoría") ordenarPor = "Subcategoria";
                else if (seleccionCampo == "Stock actual") ordenarPor = "StockActual";
                else if (seleccionCampo == "Stock mínimo") ordenarPor = "StockMinimo";

                bool esDescendente = (cmbProducto != null && cmbProducto.SelectedItem?.ToString() == "Z-A");

                List<Producto> lista = negocioProducto.Listar(filtro, ordenarPor, esDescendente);

                if (lista == null) lista = new List<Producto>();

                dgvProducto.DataSource = null;
                dgvProducto.DataSource = lista;

                if (dgvProducto.Columns.Count > 0)
                {
                    string[] columnasOcultas = { "IdProducto", "CategoriaID", "SubCategoriaID", "CreatedAt", "Estado", "Descripcion" };
                    foreach (string col in columnasOcultas)
                    {
                        if (dgvProducto.Columns[col] != null) dgvProducto.Columns[col].Visible = false;
                    }

                    if (dgvProducto.Columns["Codigo"] != null) { dgvProducto.Columns["Codigo"].HeaderText = "Código"; dgvProducto.Columns["Codigo"].DisplayIndex = 0; }
                    if (dgvProducto.Columns["Nombre"] != null) { dgvProducto.Columns["Nombre"].HeaderText = "Nombre"; dgvProducto.Columns["Nombre"].DisplayIndex = 1; }
                    if (dgvProducto.Columns["NombreCategoria"] != null) { dgvProducto.Columns["NombreCategoria"].HeaderText = "Categoría"; dgvProducto.Columns["NombreCategoria"].DisplayIndex = 2; }
                    if (dgvProducto.Columns["NombreSubcategoria"] != null) { dgvProducto.Columns["NombreSubcategoria"].HeaderText = "Subcategoría"; dgvProducto.Columns["NombreSubcategoria"].DisplayIndex = 3; }

                    if (dgvProducto.Columns["PrecioCompra"] != null)
                    {
                        dgvProducto.Columns["PrecioCompra"].HeaderText = "P. Compra";
                        dgvProducto.Columns["PrecioCompra"].DefaultCellStyle.Format = "N2";
                    }
                    if (dgvProducto.Columns["PrecioVenta"] != null)
                    {
                        dgvProducto.Columns["PrecioVenta"].HeaderText = "P. Venta";
                        dgvProducto.Columns["PrecioVenta"].DefaultCellStyle.Format = "N2";
                    }

                    if (dgvProducto.Columns["StockActual"] != null) { dgvProducto.Columns["StockActual"].HeaderText = "Stock"; }
                    if (dgvProducto.Columns["StockMinimo"] != null) { dgvProducto.Columns["StockMinimo"].HeaderText = "Mínimo"; }
                    if (dgvProducto.Columns["EstadoStock"] != null) { dgvProducto.Columns["EstadoStock"].HeaderText = "Alerta Stock"; }

                    dgvProducto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvProducto.EnableHeadersVisualStyles = false;

                    Color colorLila = Color.FromArgb(225, 213, 248);
                    Color colorTexto = Color.FromArgb(30, 30, 30);

                    dgvProducto.ColumnHeadersDefaultCellStyle.BackColor = colorLila;
                    dgvProducto.ColumnHeadersDefaultCellStyle.ForeColor = colorTexto;

                    foreach (DataGridViewColumn col in dgvProducto.Columns)
                    {
                        col.HeaderCell.Style.BackColor = colorLila;
                        col.HeaderCell.Style.ForeColor = colorTexto;
                    }

                    dgvProducto.TopLeftHeaderCell.Style.BackColor = colorLila;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Producto ObtenerProducto()
        {
            int catId = 0, subcatId = 0;

            if (cmbCategoriaP?.SelectedValue != null) int.TryParse(cmbCategoriaP.SelectedValue.ToString(), out catId);

            if (cmbSubcategoriaP?.SelectedValue != null)
            {
                int.TryParse(cmbSubcategoriaP.SelectedValue.ToString(), out subcatId);
            }
            else if (cmbSubcategoriaP?.SelectedItem is SubCategoria sub)
            {
                subcatId = sub.IdSubcategoria;
            }

            int stock = 0;
            if (txtStockActualP != null && !string.IsNullOrWhiteSpace(txtStockActualP.Text)) int.TryParse(txtStockActualP.Text, out stock);

            string codigoIngresado = txtCodigoP != null ? txtCodigoP.Text.Trim() : string.Empty;
            if (string.IsNullOrWhiteSpace(codigoIngresado))
            {
                codigoIngresado = "PROD-" + DateTime.Now.ToString("yyMMddHHmmss");
            }

            return new Producto
            {
                IdProducto = idProductoSeleccionado,
                CategoriaID = catId,
                SubCategoriaID = subcatId,
                Codigo = codigoIngresado,
                Nombre = txtNombreP != null ? txtNombreP.Text.Trim() : string.Empty,
                Descripcion = txtDescripcionP != null ? txtDescripcionP.Text.Trim() : string.Empty,
                PrecioCompra = nudPrecioCompra != null ? nudPrecioCompra.Value : 0,
                PrecioVenta = nupPrecioVenta != null ? nupPrecioVenta.Value : 0,
                StockActual = stock, 
                StockMinimo = nudStockMinimo != null ? (int)nudStockMinimo.Value : 0
            };
        }

        private void MostrarProducto(Producto p)
        {
            if (p == null) return;

            idProductoSeleccionado = p.IdProducto;
            stockExistenteProducto = p.StockActual;

            if (txtCodigoP != null) txtCodigoP.Text = p.Codigo;
            if (txtNombreP != null) txtNombreP.Text = p.Nombre;
            if (txtDescripcionP != null) txtDescripcionP.Text = p.Descripcion ?? string.Empty;

            if (cmbCategoriaP != null) cmbCategoriaP.SelectedValue = p.CategoriaID;

            cmbCategoriaP_SelectedIndexChanged(null, null);
            if (cmbSubcategoriaP != null) cmbSubcategoriaP.SelectedValue = p.SubCategoriaID;

            if (nudPrecioCompra != null) nudPrecioCompra.Value = p.PrecioCompra;
            if (nupPrecioVenta != null) nupPrecioVenta.Value = p.PrecioVenta;

            if (txtStockActualP != null) txtStockActualP.Text = p.StockActual.ToString();
            if (nudStockMinimo != null) nudStockMinimo.Value = p.StockMinimo;

            if (pnlDescripcionP != null) pnlDescripcionP.Visible = true;
            if (lbDescripcionP != null) lbDescripcionP.Text = !string.IsNullOrWhiteSpace(p.Descripcion) ? p.Descripcion : "---";

            if (pnlFechaP != null) pnlFechaP.Visible = true;
            if (lbFechaP != null) lbFechaP.Text = p.CreatedAt?.ToString("dd/MM/yyyy") ?? "---";

            if (pnlEstadoP != null) pnlEstadoP.Visible = true;
            if (lbEstadoP != null)
            {
                lbEstadoP.Text = p.StockActual > 0 ? "Existente" : "Agotado";
                lbEstadoP.ForeColor = p.StockActual > 0 ? Color.Black : Color.Red;
            }

            if (btnAgregarP != null) btnAgregarP.Text = "Modificar";
            if (btnEliminarP != null) btnEliminarP.Enabled = true;
        }

        private void LimpiarControlesProducto()
        {
            idProductoSeleccionado = 0;
            stockExistenteProducto = 0;

            if (txtCodigoP != null) txtCodigoP.Clear();
            if (txtNombreP != null) txtNombreP.Clear();
            if (txtDescripcionP != null) txtDescripcionP.Clear();
            if (cmbCategoriaP != null) cmbCategoriaP.SelectedIndex = -1;
            if (cmbSubcategoriaP != null) cmbSubcategoriaP.DataSource = null;

            if (nudPrecioCompra != null) nudPrecioCompra.Value = 0;
            if (nupPrecioVenta != null) nupPrecioVenta.Value = 0;
            if (txtStockActualP != null) txtStockActualP.Text = "0"; 
            if (nudStockMinimo != null) nudStockMinimo.Value = 0;

            if (pnlDescripcionP != null) pnlDescripcionP.Visible = false;
            if (lbDescripcionP != null) lbDescripcionP.Text = "---";
            if (pnlFechaP != null) pnlFechaP.Visible = false;
            if (lbFechaP != null) lbFechaP.Text = "---";
            if (pnlEstadoP != null) pnlEstadoP.Visible = false;
            if (lbEstadoP != null)
            {
                lbEstadoP.Text = "---";
                lbEstadoP.ForeColor = Color.Black;
            }

            if (btnAgregarP != null) btnAgregarP.Text = "Agregar";
            if (btnEliminarP != null) btnEliminarP.Enabled = false;

            if (dgvProducto != null) dgvProducto.ClearSelection();
            if (txtCodigoP != null) txtCodigoP.Focus();
        }

        private void EjecutarGuardarOAgregarProducto()
        {
            try
            {
                Producto p = ObtenerProducto();

                if (idProductoSeleccionado == 0)
                {
                    negocioProducto.Insertar(p);
                    MessageBox.Show("El producto fue registrado correctamente.", "Registro completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    negocioProducto.Actualizar(p);
                    MessageBox.Show("Los datos del producto fueron actualizados correctamente.", "Actualización completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                CargarProductos();
                LimpiarControlesProducto();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EjecutarDarDeBajaProducto()
        {
            if (idProductoSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un producto de la lista para dar de baja.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DialogResult respuesta = MessageBox.Show("¿Desea dar de baja a este producto?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta != DialogResult.Yes) return;

                negocioProducto.Eliminar(idProductoSeleccionado);
                MessageBox.Show("Producto dado de baja correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProductos();
                LimpiarControlesProducto();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregarP_Click_1(object sender, EventArgs e) => EjecutarGuardarOAgregarProducto();
        private void btnEliminarP_Click_1(object sender, EventArgs e) => EjecutarDarDeBajaProducto();
        private void btnNuevoP_Click_1(object sender, EventArgs e) => LimpiarControlesProducto();
        private void btnCerrarP_Click(object sender, EventArgs e) => Close();

        private void btnImprimirP_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("El reporte de productos estará disponible próximamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBuscarP_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarP.Text))
            {
                MessageBox.Show("Ingrese un término en el buscador para realizar la consulta.", "Búsqueda vacía", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtBuscarP.Focus();
                return;
            }
            CargarProductos();
        }

        private void txtBuscarP_TextChanged_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscarP.Text)) CargarProductos();
        }

        private void cmbProducto_SelectedIndexChanged_1(object sender, EventArgs e) => CargarProductos();
        private void cmbNomP_SelectedIndexChanged_1(object sender, EventArgs e) => CargarProductos();

        private void dgvProducto_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dgvProducto.Rows[e.RowIndex].DataBoundItem is Producto p) MostrarProducto(p);
        }

        private void dgvProducto_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            string numeroFila = (e.RowIndex + 1).ToString();
            using (StringFormat formato = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center })
            {
                Rectangle areaEncabezado = new Rectangle(e.RowBounds.Left, e.RowBounds.Top, dgvProducto.RowHeadersWidth, e.RowBounds.Height);
                Color colorTexto = dgvProducto.Rows[e.RowIndex].Selected ? Color.Black : dgvProducto.RowHeadersDefaultCellStyle.ForeColor;
                using (Brush pincel = new SolidBrush(colorTexto))
                {
                    e.Graphics.DrawString(numeroFila, dgvProducto.Font, pincel, areaEncabezado, formato);
                }
            }
        }
    }
}