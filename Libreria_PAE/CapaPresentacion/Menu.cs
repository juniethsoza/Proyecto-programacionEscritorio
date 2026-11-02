using System;
using System.Drawing;
using System.Windows.Forms;
using CapaNegocio;
using CapaPresentacion;

namespace Libreria_PAE
{
    public partial class frmSIVIG : Form
    {
        private bool cerrandoSesion = false;
        private ToolStripMenuItem tsmiCerrarSesion;

        public frmSIVIG()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

            this.Load += FrmSIVIG_Load;
            this.FormClosing += FrmSIVIG_FormClosing;

            this.tsmiSeguridad.Click += TsmiSeguridad_Click;
        }

        private void FrmSIVIG_Load(object sender, EventArgs e)
        {
            // 1. Mostrar el usuario y su rol en la barra de título superior
            if (SesionActual.EstaLogueado())
            {
                this.Text = $"Inicio - SIGIV | Usuario: {SesionActual.NombreCompleto} ({SesionActual.Rol})";
            }

            // 2. Aplicar Roles y Permisos directamente a los controles del Menu.Designer.cs
            this.tsmiSeguridad.Enabled = SesionActual.TienePermiso("Usuarios_Gestionar");
            this.tsmiReportess.Enabled = SesionActual.TienePermiso("Reportes_Ver");

            // 3. Crear y añadir el botón "Cerrar sesión" a la derecha de mnsMenu
            if (tsmiCerrarSesion == null)
            {
                tsmiCerrarSesion = new ToolStripMenuItem
                {
                    Name = "tsmiCerrarSesion",
                    Text = "Cerrar sesión",
                    Image = global::CapaPresentacion.Properties.Resources.salir,
                    Alignment = ToolStripItemAlignment.Right,
                    Font = new Font("Microsoft PhagsPa", 10F, FontStyle.Bold)
                };
                tsmiCerrarSesion.Click += TsmiCerrarSesion_Click;
                this.mnsMenu.Items.Add(tsmiCerrarSesion);
            }
        }

        private void TsmiSeguridad_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new FrmSeguridad());
        }

        private void AbrirFormularioHijo(Form formularioHijo)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.GetType() == formularioHijo.GetType())
                {
                    frm.Activate();
                    formularioHijo.Dispose();
                    return;
                }
            }

            formularioHijo.MdiParent = this;
            formularioHijo.Show();
        }

        private void TsmiCerrarSesion_Click(object sender, EventArgs e)
        {
            using (FrmCerrarSesion modal = new FrmCerrarSesion())
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    cerrandoSesion = true;
                    SesionActual.CerrarSesion();

                    FrmLogin login = new FrmLogin();
                    login.Show();
                    this.Close();
                }
            }
        }

        private void FrmSIVIG_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!cerrandoSesion && e.CloseReason == CloseReason.UserClosing)
            {
                Application.Exit();
            }
        }
    }
}