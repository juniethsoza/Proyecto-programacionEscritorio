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
    public partial class frmCambioContraseña : Form
    {

        public frmCambioContraseña()
        {
            InitializeComponent();

            txtNuevaContraseña.UseSystemPasswordChar = true;
            txtConfirmarContraseña.UseSystemPasswordChar = true;
        }


        private void btnCambiar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCorreoTelefono.Text))
            {
                MessageBox.Show(
                    "Ingrese un correo electrónico o número de teléfono.",
                    "Advertencia"
                );

                txtCorreoTelefono.Focus();
                return;
            }
            if (txtCodigo.Text != frmLogin.codigoRecuperacion)
            {
                MessageBox.Show(
                    "El código de recuperación es incorrecto.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                txtCodigo.Clear();
                txtCodigo.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtNuevaContraseña.Text))
            {
                MessageBox.Show(
                    "Ingrese una nueva contraseña.",
                    "Advertencia"
                );

                txtNuevaContraseña.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtConfirmarContraseña.Text))
            {
                MessageBox.Show(
                    "Confirme su nueva contraseña.",
                    "Advertencia"
                );

                txtConfirmarContraseña.Focus();
                return;
            }
            if (txtNuevaContraseña.Text != txtConfirmarContraseña.Text)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden.",
                    "Error"
                );

                txtConfirmarContraseña.Clear();
                txtConfirmarContraseña.Focus();
                return;
            }
            frmLogin.contraseña = txtNuevaContraseña.Text;

            MessageBox.Show(
                "La contraseña se cambió correctamente.",
                "Éxito"
            );
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }



}
    

