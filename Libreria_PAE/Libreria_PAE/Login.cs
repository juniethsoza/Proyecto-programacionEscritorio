using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Libreria_PAE
{
    public partial class frmLogin : Form
    {
        // Datos del sistema
        public static string contraseña = "123";
        public static string codigoRecuperacion = "2026";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" &&
                txtContraseña.Text == contraseña)
            {
                MessageBox.Show(
                    "Inicio de sesión exitoso",
                    "Acceso"
                );
            }
            else
            {
                MessageBox.Show(
                    "Usuario o contraseña inválidos",
                    "Error"
                );

                txtUsuario.Clear();
                txtContraseña.Clear();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmCambioContraseña recuperar = new frmCambioContraseña();

            recuperar.ShowDialog();
        }
    }
}

