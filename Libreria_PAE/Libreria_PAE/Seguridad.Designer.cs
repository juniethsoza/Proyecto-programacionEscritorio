namespace Libreria_PAE
{
    partial class Seguridad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Seguridad));
            this.tbcOpciones = new System.Windows.Forms.TabControl();
            this.tbpUsuarios = new System.Windows.Forms.TabPage();
            this.tbpCerraSesion = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuarioGU = new System.Windows.Forms.TextBox();
            this.txtNombreGU = new System.Windows.Forms.TextBox();
            this.txtApellidoGU = new System.Windows.Forms.TextBox();
            this.txtContraseñaGU = new System.Windows.Forms.TextBox();
            this.cmbRolGU = new System.Windows.Forms.ComboBox();
            this.btnGuardarGU = new System.Windows.Forms.Button();
            this.btnEliminarGU = new System.Windows.Forms.Button();
            this.btnCerrarGU = new System.Windows.Forms.Button();
            this.dgvGUsuarios = new System.Windows.Forms.DataGridView();
            this.Usuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.pcbAlerta = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUsuarioCS = new System.Windows.Forms.TextBox();
            this.txtContraseñaCS = new System.Windows.Forms.TextBox();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnCancelarCS = new System.Windows.Forms.Button();
            this.tbcOpciones.SuspendLayout();
            this.tbpUsuarios.SuspendLayout();
            this.tbpCerraSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlerta)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcOpciones
            // 
            this.tbcOpciones.Controls.Add(this.tbpUsuarios);
            this.tbcOpciones.Controls.Add(this.tbpCerraSesion);
            this.tbcOpciones.Location = new System.Drawing.Point(0, 0);
            this.tbcOpciones.Name = "tbcOpciones";
            this.tbcOpciones.SelectedIndex = 0;
            this.tbcOpciones.Size = new System.Drawing.Size(984, 652);
            this.tbcOpciones.TabIndex = 0;
            // 
            // tbpUsuarios
            // 
            this.tbpUsuarios.BackColor = System.Drawing.Color.Thistle;
            this.tbpUsuarios.Controls.Add(this.dgvGUsuarios);
            this.tbpUsuarios.Controls.Add(this.btnCerrarGU);
            this.tbpUsuarios.Controls.Add(this.btnEliminarGU);
            this.tbpUsuarios.Controls.Add(this.btnGuardarGU);
            this.tbpUsuarios.Controls.Add(this.cmbRolGU);
            this.tbpUsuarios.Controls.Add(this.txtContraseñaGU);
            this.tbpUsuarios.Controls.Add(this.txtApellidoGU);
            this.tbpUsuarios.Controls.Add(this.txtNombreGU);
            this.tbpUsuarios.Controls.Add(this.txtUsuarioGU);
            this.tbpUsuarios.Controls.Add(this.label5);
            this.tbpUsuarios.Controls.Add(this.label4);
            this.tbpUsuarios.Controls.Add(this.label3);
            this.tbpUsuarios.Controls.Add(this.label2);
            this.tbpUsuarios.Controls.Add(this.label1);
            this.tbpUsuarios.Location = new System.Drawing.Point(4, 32);
            this.tbpUsuarios.Name = "tbpUsuarios";
            this.tbpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUsuarios.Size = new System.Drawing.Size(976, 616);
            this.tbpUsuarios.TabIndex = 0;
            this.tbpUsuarios.Text = "Gestionar Usuarios";
            // 
            // tbpCerraSesion
            // 
            this.tbpCerraSesion.BackColor = System.Drawing.Color.Thistle;
            this.tbpCerraSesion.Controls.Add(this.btnCancelarCS);
            this.tbpCerraSesion.Controls.Add(this.btnCerrarSesion);
            this.tbpCerraSesion.Controls.Add(this.txtContraseñaCS);
            this.tbpCerraSesion.Controls.Add(this.txtUsuarioCS);
            this.tbpCerraSesion.Controls.Add(this.label9);
            this.tbpCerraSesion.Controls.Add(this.label8);
            this.tbpCerraSesion.Controls.Add(this.label7);
            this.tbpCerraSesion.Controls.Add(this.pcbAlerta);
            this.tbpCerraSesion.Controls.Add(this.label6);
            this.tbpCerraSesion.Location = new System.Drawing.Point(4, 32);
            this.tbpCerraSesion.Name = "tbpCerraSesion";
            this.tbpCerraSesion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCerraSesion.Size = new System.Drawing.Size(976, 616);
            this.tbpCerraSesion.TabIndex = 1;
            this.tbpCerraSesion.Text = "Cerrar Sesión";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(582, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol";
            // 
            // txtUsuarioGU
            // 
            this.txtUsuarioGU.Location = new System.Drawing.Point(155, 40);
            this.txtUsuarioGU.Name = "txtUsuarioGU";
            this.txtUsuarioGU.Size = new System.Drawing.Size(348, 31);
            this.txtUsuarioGU.TabIndex = 5;
            // 
            // txtNombreGU
            // 
            this.txtNombreGU.Location = new System.Drawing.Point(155, 99);
            this.txtNombreGU.Name = "txtNombreGU";
            this.txtNombreGU.Size = new System.Drawing.Size(348, 31);
            this.txtNombreGU.TabIndex = 6;
            // 
            // txtApellidoGU
            // 
            this.txtApellidoGU.Location = new System.Drawing.Point(155, 164);
            this.txtApellidoGU.Name = "txtApellidoGU";
            this.txtApellidoGU.Size = new System.Drawing.Size(348, 31);
            this.txtApellidoGU.TabIndex = 7;
            // 
            // txtContraseñaGU
            // 
            this.txtContraseñaGU.Location = new System.Drawing.Point(642, 40);
            this.txtContraseñaGU.Name = "txtContraseñaGU";
            this.txtContraseñaGU.Size = new System.Drawing.Size(276, 31);
            this.txtContraseñaGU.TabIndex = 8;
            // 
            // cmbRolGU
            // 
            this.cmbRolGU.FormattingEnabled = true;
            this.cmbRolGU.Location = new System.Drawing.Point(642, 104);
            this.cmbRolGU.Name = "cmbRolGU";
            this.cmbRolGU.Size = new System.Drawing.Size(276, 31);
            this.cmbRolGU.TabIndex = 9;
            // 
            // btnGuardarGU
            // 
            this.btnGuardarGU.BackColor = System.Drawing.Color.Purple;
            this.btnGuardarGU.ForeColor = System.Drawing.Color.White;
            this.btnGuardarGU.Location = new System.Drawing.Point(378, 263);
            this.btnGuardarGU.Name = "btnGuardarGU";
            this.btnGuardarGU.Size = new System.Drawing.Size(174, 49);
            this.btnGuardarGU.TabIndex = 10;
            this.btnGuardarGU.Text = "Guardar";
            this.btnGuardarGU.UseVisualStyleBackColor = false;
            // 
            // btnEliminarGU
            // 
            this.btnEliminarGU.BackColor = System.Drawing.Color.Purple;
            this.btnEliminarGU.ForeColor = System.Drawing.Color.White;
            this.btnEliminarGU.Location = new System.Drawing.Point(568, 263);
            this.btnEliminarGU.Name = "btnEliminarGU";
            this.btnEliminarGU.Size = new System.Drawing.Size(174, 49);
            this.btnEliminarGU.TabIndex = 11;
            this.btnEliminarGU.Text = "Eliminar";
            this.btnEliminarGU.UseVisualStyleBackColor = false;
            // 
            // btnCerrarGU
            // 
            this.btnCerrarGU.BackColor = System.Drawing.Color.Purple;
            this.btnCerrarGU.ForeColor = System.Drawing.Color.White;
            this.btnCerrarGU.Location = new System.Drawing.Point(759, 263);
            this.btnCerrarGU.Name = "btnCerrarGU";
            this.btnCerrarGU.Size = new System.Drawing.Size(174, 49);
            this.btnCerrarGU.TabIndex = 12;
            this.btnCerrarGU.Text = "Cerrar";
            this.btnCerrarGU.UseVisualStyleBackColor = false;
            // 
            // dgvGUsuarios
            // 
            this.dgvGUsuarios.AllowUserToAddRows = false;
            this.dgvGUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGUsuarios.BackgroundColor = System.Drawing.Color.White;
            this.dgvGUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvGUsuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvGUsuarios.ColumnHeadersHeight = 30;
            this.dgvGUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Usuarios,
            this.Nombre,
            this.Column1});
            this.dgvGUsuarios.EnableHeadersVisualStyles = false;
            this.dgvGUsuarios.Location = new System.Drawing.Point(53, 372);
            this.dgvGUsuarios.Name = "dgvGUsuarios";
            this.dgvGUsuarios.RowHeadersVisible = false;
            this.dgvGUsuarios.RowHeadersWidth = 62;
            this.dgvGUsuarios.RowTemplate.Height = 28;
            this.dgvGUsuarios.Size = new System.Drawing.Size(865, 228);
            this.dgvGUsuarios.TabIndex = 13;
            this.dgvGUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGUsuarios_CellContentClick);
            // 
            // Usuarios
            // 
            this.Usuarios.HeaderText = "Usuario";
            this.Usuarios.MinimumWidth = 8;
            this.Usuarios.Name = "Usuarios";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Completo";
            this.Nombre.MinimumWidth = 8;
            this.Nombre.Name = "Nombre";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Rol";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(293, 26);
            this.label6.TabIndex = 0;
            this.label6.Text = "Finalizar sesión del usuario";
            // 
            // pcbAlerta
            // 
            this.pcbAlerta.Image = global::Libreria_PAE.Properties.Resources.icons8_alerta_64;
            this.pcbAlerta.Location = new System.Drawing.Point(294, 150);
            this.pcbAlerta.Name = "pcbAlerta";
            this.pcbAlerta.Size = new System.Drawing.Size(44, 32);
            this.pcbAlerta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbAlerta.TabIndex = 1;
            this.pcbAlerta.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 23);
            this.label7.TabIndex = 2;
            this.label7.Text = "Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 23);
            this.label8.TabIndex = 3;
            this.label8.Text = "Contraseña";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(383, 23);
            this.label9.TabIndex = 4;
            this.label9.Text = "¿Está seguro que desea salir del sistema?";
            // 
            // txtUsuarioCS
            // 
            this.txtUsuarioCS.Location = new System.Drawing.Point(260, 239);
            this.txtUsuarioCS.Name = "txtUsuarioCS";
            this.txtUsuarioCS.Size = new System.Drawing.Size(464, 31);
            this.txtUsuarioCS.TabIndex = 5;
            // 
            // txtContraseñaCS
            // 
            this.txtContraseñaCS.Location = new System.Drawing.Point(260, 320);
            this.txtContraseñaCS.Name = "txtContraseñaCS";
            this.txtContraseñaCS.Size = new System.Drawing.Size(464, 31);
            this.txtContraseñaCS.TabIndex = 6;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.Purple;
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(260, 478);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(180, 49);
            this.btnCerrarSesion.TabIndex = 7;
            this.btnCerrarSesion.Text = "Cerrar Sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            // 
            // btnCancelarCS
            // 
            this.btnCancelarCS.BackColor = System.Drawing.Color.Purple;
            this.btnCancelarCS.ForeColor = System.Drawing.Color.White;
            this.btnCancelarCS.Location = new System.Drawing.Point(544, 478);
            this.btnCancelarCS.Name = "btnCancelarCS";
            this.btnCancelarCS.Size = new System.Drawing.Size(180, 49);
            this.btnCancelarCS.TabIndex = 8;
            this.btnCancelarCS.Text = "Cancelar";
            this.btnCancelarCS.UseVisualStyleBackColor = false;
            // 
            // Seguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(949, 656);
            this.Controls.Add(this.tbcOpciones);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Seguridad";
            this.Text = "Seguridad";
            this.tbcOpciones.ResumeLayout(false);
            this.tbpUsuarios.ResumeLayout(false);
            this.tbpUsuarios.PerformLayout();
            this.tbpCerraSesion.ResumeLayout(false);
            this.tbpCerraSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAlerta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcOpciones;
        private System.Windows.Forms.TabPage tbpUsuarios;
        private System.Windows.Forms.TabPage tbpCerraSesion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCerrarGU;
        private System.Windows.Forms.Button btnEliminarGU;
        private System.Windows.Forms.Button btnGuardarGU;
        private System.Windows.Forms.ComboBox cmbRolGU;
        private System.Windows.Forms.TextBox txtContraseñaGU;
        private System.Windows.Forms.TextBox txtApellidoGU;
        private System.Windows.Forms.TextBox txtNombreGU;
        private System.Windows.Forms.TextBox txtUsuarioGU;
        private System.Windows.Forms.DataGridView dgvGUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pcbAlerta;
        private System.Windows.Forms.Button btnCancelarCS;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.TextBox txtContraseñaCS;
        private System.Windows.Forms.TextBox txtUsuarioCS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
    }
}