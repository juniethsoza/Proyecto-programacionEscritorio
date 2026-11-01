using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmCerrarSesion : Form
    {
        private readonly Color ColorRosa = Color.FromArgb(243, 200, 232);    // #F3C8E8
        private readonly Color ColorPurpura = Color.FromArgb(211, 200, 243); // #D3C8F3

        public FrmCerrarSesion()
        {
            InitializeComponent();
            ConstruirInterfaz();
        }

        private void ConstruirInterfaz()
        {
            this.Text = "Cerrar sesión";
            this.Size = new Size(480, 340);
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.BackColor = ColorPurpura;

            Panel card = new Panel
            {
                Size = new Size(390, 230),
                Location = new Point(38, 35),
                BackColor = Color.White
            };
            this.Controls.Add(card);

            Label lblIcono = new Label
            {
                Text = "↪",
                Font = new Font("Segoe UI Symbol", 32, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(390, 55),
                Location = new Point(0, 15),
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(lblIcono);

            Label lblPregunta = new Label
            {
                Text = "¿Deseas cerrar sesión?",
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                AutoSize = false,
                Size = new Size(390, 30),
                Location = new Point(0, 75),
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(lblPregunta);

            Label lblDetalle = new Label
            {
                Text = "Volverás a la pantalla de inicio de sesión.",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Regular),
                ForeColor = Color.FromArgb(65, 65, 65),
                AutoSize = false,
                Size = new Size(390, 24),
                Location = new Point(0, 108),
                TextAlign = ContentAlignment.MiddleCenter
            };
            card.Controls.Add(lblDetalle);

            Button btnCancelar = new Button
            {
                Text = "Cancelar",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                BackColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(35, 155),
                Size = new Size(145, 40),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.Cancel
            };
            btnCancelar.FlatAppearance.BorderColor = Color.Silver;
            card.Controls.Add(btnCancelar);

            Button btnConfirmar = new Button
            {
                Text = "Cerrar sesión",
                Font = new Font("Segoe UI", 9.5f, FontStyle.Bold),
                BackColor = ColorRosa,
                FlatStyle = FlatStyle.Flat,
                Location = new Point(205, 155),
                Size = new Size(150, 40),
                Cursor = Cursors.Hand,
                DialogResult = DialogResult.OK
            };
            btnConfirmar.FlatAppearance.BorderColor = Color.FromArgb(200, 150, 190);
            card.Controls.Add(btnConfirmar);

            this.CancelButton = btnCancelar;
            this.AcceptButton = btnConfirmar;
        }
    }
}