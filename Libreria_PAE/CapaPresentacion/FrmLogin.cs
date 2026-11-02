using CapaNegocio;
using Libreria_PAE;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmLogin : Form
    {
        private TextBox txtUsuario;
        private TextBox txtContrasena;
        private CheckBox chkMostrar;
        private Button btnIniciar;
        private Button btnSalir;

        private readonly Color ColorLila = Color.FromArgb(233, 200, 243);    // #E9C8F3
        private readonly Color ColorRosa = Color.FromArgb(243, 200, 232);    // #F3C8E8
        private readonly Color ColorPurpura = Color.FromArgb(211, 200, 243); // #D3C8F3

        public FrmLogin()
        {
            InitializeComponent();
            ConstruirInterfaz();
        }

        private void ConstruirInterfaz()
        {
            this.Text = "Inicio de sesión";
            this.Size = new Size(520, 440);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.BackColor = ColorPurpura;

            Panel card = new Panel
            {
                Size = new Size(360, 330),
                Location = new Point(72, 35),
                BackColor = Color.White
            };
            this.Controls.Add(card);

            Label lblIcono = new Label
            {
                Text = "👤",
                Font = new Font("Segoe UI Emoji", 28, FontStyle.Regular),
                AutoSize = false,
                Size = new Size(360, 55),
                Location = new Point(0, 12),
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(lblIcono);

            Label lblTitulo = new Label
            {
                Text = "Bienvenido a SIGIV",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(360, 28),
                Location = new Point(0, 68),
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(lblTitulo);

            Label lblSubtitulo = new Label
            {
                Text = "Ingresa tus credenciales",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Regular),
                ForeColor = Color.FromArgb(60, 60, 60),
                AutoSize = false,
                Size = new Size(360, 22),
                Location = new Point(0, 95),
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(lblSubtitulo);

            Label lblUsu = new Label
            {
                Text = "Usuario:",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(25, 138),
                AutoSize = true
            };
            card.Controls.Add(lblUsu);

            txtUsuario = new TextBox
            {
                Font = new Font("Segoe UI", 10),
                Location = new Point(108, 134),
                Size = new Size(220, 26)
            };
            card.Controls.Add(txtUsuario);

            Label lblPass = new Label
            {
                Text = "Contraseña:",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                Location = new Point(25, 182),
                AutoSize = true
            };
            card.Controls.Add(lblPass);

            txtContrasena = new TextBox
            {
                Font = new Font("Segoe UI", 10),
                Location = new Point(108, 178),
                Size = new Size(220, 26),
                UseSystemPasswordChar = true
            };
            card.Controls.Add(txtContrasena);

            chkMostrar = new CheckBox
            {
                Text = "Mostrar contraseña",
                Font = new Font("Segoe UI", 8.5f),
                Location = new Point(108, 212),
                AutoSize = true
            };
            chkMostrar.CheckedChanged += (s, e) =>
            {
                txtContrasena.UseSystemPasswordChar = !chkMostrar.Checked;
            };
            card.Controls.Add(chkMostrar);

            btnIniciar = new Button
            {
                Text = "Iniciar sesión",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                BackColor = ColorRosa,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(25, 255),
                Size = new Size(190, 38),
                Cursor = Cursors.Hand
            };
            btnIniciar.FlatAppearance.BorderColor = Color.FromArgb(200, 150, 190);
            btnIniciar.Click += BtnIniciar_Click;
            card.Controls.Add(btnIniciar);

            btnSalir = new Button
            {
                Text = "Salir",
                Font = new Font("Segoe UI", 9f, FontStyle.Bold),
                BackColor = Color.FromArgb(248, 232, 244),
                FlatStyle = FlatStyle.Flat,
                Location = new Point(228, 255),
                Size = new Size(100, 38),
                Cursor = Cursors.Hand
            };
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(200, 150, 190);
            btnSalir.Click += (s, e) => Application.Exit();
            card.Controls.Add(btnSalir);

            this.AcceptButton = btnIniciar;
        }

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                var resultado = CN_Usuario.IniciarSesion(txtUsuario.Text, txtContrasena.Text);

                if (resultado != null && resultado.IdUsuario > 0)
                {
                    frmSIVIG menuPrincipal = new frmSIVIG();
                    menuPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos, o la cuenta está inactiva.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Validación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}