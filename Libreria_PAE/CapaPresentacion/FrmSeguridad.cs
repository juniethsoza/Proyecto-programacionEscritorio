using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class FrmSeguridad : Form
    {
        private int idUsuarioSeleccionado = 0;
        private List<sp_Usuario_Listar_Result> listaActual = new List<sp_Usuario_Listar_Result>();

        // Controles Izquierda
        private TextBox txtBuscar;
        private ComboBox cboFiltroRol;
        private DataGridView dgvUsuarios;
        private Label lblFechaRegistro;
        private Button btnNuevo;
        private Button btnDesactivar;
        private Button btnCerrar;

        // Controles Derecha
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtUsuario;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtContrasena;
        private CheckBox chkMostrarPass;
        private ComboBox cboRol;
        private CheckBox chkActivo;
        private Button btnGuardar;

        // Paleta de colores viva y exacta a la maqueta
        private readonly Color ColorFondoLila = Color.FromArgb(215, 202, 245);  // #D7CAF5
        private readonly Color ColorRosaVivo = Color.FromArgb(245, 185, 225);   // #F5B9E1
        private readonly Color ColorBordeRosa = Color.FromArgb(220, 145, 195);

        // Importaciones para permitir arrastrar la ventana sin bordes
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public FrmSeguridad()
        {
            InitializeComponent();
            this.Controls.Clear();
            ConstruirInterfaz();
            this.Load += FrmSeguridad_Load;
        }

        private void ConstruirInterfaz()
        {
            this.Text = "Gestión de usuarios";
            this.Size = new Size(885, 480); // Largo ajustado para ver todos los márgenes sin barras
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = ColorFondoLila;
            this.FormBorderStyle = FormBorderStyle.None; // Sin barra nativa de Windows

            // ================= BARRA SUPERIOR PERSONALIZADA =================
            Panel pnlTopBar = new Panel
            {
                Size = new Size(885, 36),
                Location = new Point(0, 0),
                BackColor = ColorRosaVivo
            };
            // Permitir arrastrar la ventana desde la barra superior
            pnlTopBar.MouseDown += (s, e) => {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                }
            };
            this.Controls.Add(pnlTopBar);

            Label lblTituloBarra = new Label
            {
                Text = "Gestión de usuarios",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                Location = new Point(15, 8),
                AutoSize = true,
                BackColor = Color.Transparent
            };
            lblTituloBarra.MouseDown += (s, e) => {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(this.Handle, 0x112, 0xf012, 0);
                }
            };
            pnlTopBar.Controls.Add(lblTituloBarra);

            // Botón de cierre único (×) en la barra superior
            Button btnCerrarWin = new Button
            {
                Text = "×",
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                Size = new Size(40, 36),
                Location = new Point(845, 0),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = Color.Black,
                Cursor = Cursors.Hand
            };
            btnCerrarWin.FlatAppearance.BorderSize = 0;
            btnCerrarWin.Click += (s, e) => this.Close();
            pnlTopBar.Controls.Add(btnCerrarWin);

            // Título principal "Usuarios"
            Label lblUsuariosGrande = new Label
            {
                Text = "Usuarios",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                Location = new Point(18, 42),
                AutoSize = true
            };
            this.Controls.Add(lblUsuariosGrande);

            Label lblSubtitulo = new Label
            {
                Text = "Registro y administración del personal",
                Font = new Font("Segoe UI", 8.5f),
                Location = new Point(20, 68),
                AutoSize = true
            };
            this.Controls.Add(lblSubtitulo);

            // ================= PANEL IZQUIERDO =================
            Panel pnlIzquierdo = new Panel
            {
                Location = new Point(18, 92),
                Size = new Size(505, 365),
                BackColor = Color.White
            };
            this.Controls.Add(pnlIzquierdo);

            Label lblPersonal = new Label
            {
                Text = "Personal registrado",
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                Location = new Point(12, 10),
                AutoSize = true
            };
            pnlIzquierdo.Controls.Add(lblPersonal);

            Label lblLupa = new Label
            {
                Text = "🔍",
                Font = new Font("Segoe UI", 9f),
                Location = new Point(12, 34),
                AutoSize = true
            };
            pnlIzquierdo.Controls.Add(lblLupa);

            txtBuscar = new TextBox
            {
                Font = new Font("Segoe UI", 9f),
                Location = new Point(34, 32),
                Size = new Size(260, 23)
            };
            txtBuscar.TextChanged += (s, e) => CargarTablaUsuarios();
            pnlIzquierdo.Controls.Add(txtBuscar);

            cboFiltroRol = new ComboBox
            {
                Font = new Font("Segoe UI", 9f),
                Location = new Point(302, 32),
                Size = new Size(190, 23),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            cboFiltroRol.SelectedIndexChanged += (s, e) => CargarTablaUsuarios();
            pnlIzquierdo.Controls.Add(cboFiltroRol);

            dgvUsuarios = new DataGridView
            {
                Location = new Point(12, 62),
                Size = new Size(480, 205),
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                ReadOnly = true,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                RowHeadersVisible = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                EnableHeadersVisualStyles = false
            };
            dgvUsuarios.ColumnHeadersDefaultCellStyle.BackColor = ColorFondoLila;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dgvUsuarios.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 8.5f, FontStyle.Bold);
            dgvUsuarios.ColumnHeadersHeight = 26;
            dgvUsuarios.DefaultCellStyle.SelectionBackColor = ColorRosaVivo;
            dgvUsuarios.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvUsuarios.RowTemplate.Height = 23;
            dgvUsuarios.CellClick += DgvUsuarios_CellClick;
            pnlIzquierdo.Controls.Add(dgvUsuarios);

            lblFechaRegistro = new Label
            {
                Text = "Fecha de registro: --/--/----",
                Font = new Font("Segoe UI", 7.5f),
                Location = new Point(12, 275),
                AutoSize = true
            };
            pnlIzquierdo.Controls.Add(lblFechaRegistro);

            btnNuevo = new Button
            {
                Text = "Nuevo usuario",
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                BackColor = ColorRosaVivo,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(12, 305),
                Size = new Size(150, 36),
                Cursor = Cursors.Hand
            };
            btnNuevo.FlatAppearance.BorderColor = ColorBordeRosa;
            btnNuevo.Click += (s, e) => LimpiarFormulario();
            pnlIzquierdo.Controls.Add(btnNuevo);

            btnDesactivar = new Button
            {
                Text = "Desactivar",
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                BackColor = Color.White,
                ForeColor = Color.FromArgb(210, 45, 45),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(174, 305),
                Size = new Size(150, 36),
                Cursor = Cursors.Hand
            };
            btnDesactivar.FlatAppearance.BorderColor = Color.FromArgb(210, 45, 45);
            btnDesactivar.Click += BtnDesactivar_Click;
            pnlIzquierdo.Controls.Add(btnDesactivar);

            btnCerrar = new Button
            {
                Text = "Cerrar",
                Font = new Font("Segoe UI", 8.5f, FontStyle.Bold),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(336, 305),
                Size = new Size(156, 36),
                Cursor = Cursors.Hand
            };
            btnCerrar.FlatAppearance.BorderColor = Color.Silver;
            btnCerrar.Click += (s, e) => this.Close();
            pnlIzquierdo.Controls.Add(btnCerrar);

            // ================= PANEL DERECHO =================
            Panel pnlDerecho = new Panel
            {
                Location = new Point(535, 92),
                Size = new Size(324, 365),
                BackColor = Color.White
            };
            this.Controls.Add(pnlDerecho);

            Label lblRegTitulo = new Label
            {
                Text = "Registro de usuario",
                Font = new Font("Segoe UI", 10f, FontStyle.Bold),
                Location = new Point(12, 10),
                AutoSize = true
            };
            pnlDerecho.Controls.Add(lblRegTitulo);

            pnlDerecho.Controls.Add(CrearLabel("Nombre:", 12, 36));
            txtNombre = CrearTextBox(12, 52, 142);
            pnlDerecho.Controls.Add(txtNombre);

            pnlDerecho.Controls.Add(CrearLabel("Apellido:", 162, 36));
            txtApellido = CrearTextBox(162, 52, 150);
            pnlDerecho.Controls.Add(txtApellido);

            pnlDerecho.Controls.Add(CrearLabel("Usuario:", 12, 88));
            txtUsuario = CrearTextBox(12, 104, 142);
            pnlDerecho.Controls.Add(txtUsuario);

            pnlDerecho.Controls.Add(CrearLabel("Teléfono:", 162, 88));
            txtTelefono = CrearTextBox(162, 104, 150);
            pnlDerecho.Controls.Add(txtTelefono);

            pnlDerecho.Controls.Add(CrearLabel("Correo electrónico:", 12, 140));
            txtEmail = CrearTextBox(12, 156, 300);
            pnlDerecho.Controls.Add(txtEmail);

            pnlDerecho.Controls.Add(CrearLabel("Contraseña:", 12, 194));
            txtContrasena = CrearTextBox(82, 190, 148);
            txtContrasena.UseSystemPasswordChar = true;
            pnlDerecho.Controls.Add(txtContrasena);

            chkMostrarPass = new CheckBox
            {
                Text = "Mostrar",
                Font = new Font("Segoe UI", 7.5f),
                Location = new Point(236, 192),
                AutoSize = true
            };
            chkMostrarPass.CheckedChanged += (s, e) => { txtContrasena.UseSystemPasswordChar = !chkMostrarPass.Checked; };
            pnlDerecho.Controls.Add(chkMostrarPass);

            pnlDerecho.Controls.Add(CrearLabel("Rol:", 12, 238));
            cboRol = new ComboBox
            {
                Font = new Font("Segoe UI", 8.5f),
                Location = new Point(82, 234),
                Size = new Size(148, 23),
                DropDownStyle = ComboBoxStyle.DropDownList
            };
            pnlDerecho.Controls.Add(cboRol);

            chkActivo = new CheckBox
            {
                Text = "Activo",
                Font = new Font("Segoe UI", 8f),
                Location = new Point(236, 236),
                Checked = true,
                AutoSize = true
            };
            pnlDerecho.Controls.Add(chkActivo);

            btnGuardar = new Button
            {
                Text = "Guardar usuario",
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                BackColor = ColorRosaVivo,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(12, 305),
                Size = new Size(300, 36),
                Cursor = Cursors.Hand
            };
            btnGuardar.FlatAppearance.BorderColor = ColorBordeRosa;
            btnGuardar.Click += BtnGuardar_Click;
            pnlDerecho.Controls.Add(btnGuardar);
        }

        private Label CrearLabel(string texto, int x, int y)
        {
            return new Label
            {
                Text = texto,
                Font = new Font("Segoe UI", 8.5f, FontStyle.Regular),
                Location = new Point(x, y),
                AutoSize = true
            };
        }

        private TextBox CrearTextBox(int x, int y, int ancho)
        {
            return new TextBox
            {
                Font = new Font("Segoe UI", 8.5f),
                Location = new Point(x, y),
                Size = new Size(ancho, 23)
            };
        }

        private void FrmSeguridad_Load(object sender, EventArgs e)
        {
            CargarCombosRoles();
            CargarTablaUsuarios();
            LimpiarFormulario();
        }

        private void CargarCombosRoles()
        {
            try
            {
                var roles = CN_Usuario.ListarRoles()
                    .GroupBy(r => r.IdRol)
                    .Select(g => g.First())
                    .ToList();

                var listaFiltro = new List<sp_Rol_Listar_Result>
                {
                    new sp_Rol_Listar_Result { IdRol = 0, Nombre = "Todos los roles" }
                };
                listaFiltro.AddRange(roles);

                cboFiltroRol.DataSource = listaFiltro;
                cboFiltroRol.DisplayMember = "Nombre";
                cboFiltroRol.ValueMember = "IdRol";

                cboRol.DataSource = roles.ToList();
                cboRol.DisplayMember = "Nombre";
                cboRol.ValueMember = "IdRol";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar roles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarTablaUsuarios()
        {
            try
            {
                int? rolFiltro = null;
                if (cboFiltroRol.SelectedValue != null && int.TryParse(cboFiltroRol.SelectedValue.ToString(), out int idR) && idR > 0)
                {
                    rolFiltro = idR;
                }

                listaActual = CN_Usuario.ListarUsuarios(txtBuscar.Text, rolFiltro);

                var vistaTabla = listaActual.Select(u => new
                {
                    u.IdUsuario,
                    Nombre = u.Nombre,
                    Apellido = u.Apellido,
                    Usuario = u.Username,
                    Rol = u.Rol,
                    Estado = (u.Estado == true) ? "Activo" : "Inactivo"
                }).ToList();

                dgvUsuarios.DataSource = vistaTabla;

                if (dgvUsuarios.Columns["IdUsuario"] != null)
                {
                    dgvUsuarios.Columns["IdUsuario"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= listaActual.Count) return;

            var usuario = listaActual[e.RowIndex];
            idUsuarioSeleccionado = usuario.IdUsuario;

            txtNombre.Text = usuario.Nombre;
            txtApellido.Text = usuario.Apellido;
            txtUsuario.Text = usuario.Username;
            txtTelefono.Text = usuario.Telefono;
            txtEmail.Text = usuario.Email;
            txtContrasena.Text = usuario.Clave;
            cboRol.SelectedValue = usuario.RolID;
            chkActivo.Checked = usuario.Estado ?? false;

            string fechaStr = usuario.FechaRegistro.HasValue
                ? usuario.FechaRegistro.Value.ToString("dd/MM/yyyy")
                : "--/--/----";
            lblFechaRegistro.Text = $"Fecha de registro: {fechaStr}";

            btnDesactivar.Text = (usuario.Estado == true) ? "Desactivar" : "Activar";
        }

        private void LimpiarFormulario()
        {
            idUsuarioSeleccionado = 0;
            txtNombre.Clear();
            txtApellido.Clear();
            txtUsuario.Clear();
            txtTelefono.Clear();
            txtEmail.Clear();
            txtContrasena.Clear();
            if (cboRol.Items.Count > 0) cboRol.SelectedIndex = 0;
            chkActivo.Checked = true;
            lblFechaRegistro.Text = $"Fecha de registro: {DateTime.Now:dd/MM/yyyy}";
            btnDesactivar.Text = "Desactivar";
            dgvUsuarios.ClearSelection();
            txtNombre.Focus();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                int rolId = cboRol.SelectedValue != null ? Convert.ToInt32(cboRol.SelectedValue) : 0;

                CN_Usuario.GuardarUsuario(
                    idUsuarioSeleccionado,
                    rolId,
                    txtNombre.Text,
                    txtApellido.Text,
                    txtUsuario.Text,
                    txtContrasena.Text,
                    txtEmail.Text,
                    txtTelefono.Text,
                    chkActivo.Checked
                );

                MessageBox.Show("Usuario guardado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTablaUsuarios();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                string mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show(mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BtnDesactivar_Click(object sender, EventArgs e)
        {
            if (idUsuarioSeleccionado <= 0)
            {
                MessageBox.Show("Selecciona un usuario de la tabla primero.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                bool nuevoEstado = CN_Usuario.CambiarEstado(idUsuarioSeleccionado);
                string accion = nuevoEstado ? "activado" : "desactivado";
                MessageBox.Show($"El usuario ha sido {accion}.", "Estado actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarTablaUsuarios();
                LimpiarFormulario();
            }
            catch (Exception ex)
            {
                string mensaje = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show(mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}   