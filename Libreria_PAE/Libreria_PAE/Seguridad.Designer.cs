namespace Libreria_PAE
{
    partial class frmSeguridad
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSeguridad));
            this.tbcOpciones = new System.Windows.Forms.TabControl();
            this.tbpUsuarios = new System.Windows.Forms.TabPage();
            this.txtTelefonoGU = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCorreoGU = new System.Windows.Forms.TextBox();
            this.dgvGUsuarios = new System.Windows.Forms.DataGridView();
            this.colUsuarios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreGU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidoGU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMcorreoGU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMtelefonoGU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCerrarGU = new System.Windows.Forms.Button();
            this.btnEliminarGU = new System.Windows.Forms.Button();
            this.btnGuardarGU = new System.Windows.Forms.Button();
            this.cmbRolGU = new System.Windows.Forms.ComboBox();
            this.txtContraseñaGU = new System.Windows.Forms.TextBox();
            this.txtApellidoGU = new System.Windows.Forms.TextBox();
            this.txtNombreGU = new System.Windows.Forms.TextBox();
            this.txtIdUsuarioGU = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpCerraSesion = new System.Windows.Forms.TabPage();
            this.btnCancelarCS = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.txtContraseñaCS = new System.Windows.Forms.TextBox();
            this.txtUsuarioCS = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pcbAlerta = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbcOpciones.SuspendLayout();
            this.tbpUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGUsuarios)).BeginInit();
            this.tbpCerraSesion.SuspendLayout();
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
            this.tbpUsuarios.Controls.Add(this.txtTelefonoGU);
            this.tbpUsuarios.Controls.Add(this.label12);
            this.tbpUsuarios.Controls.Add(this.label10);
            this.tbpUsuarios.Controls.Add(this.txtCorreoGU);
            this.tbpUsuarios.Controls.Add(this.dgvGUsuarios);
            this.tbpUsuarios.Controls.Add(this.btnCerrarGU);
            this.tbpUsuarios.Controls.Add(this.btnEliminarGU);
            this.tbpUsuarios.Controls.Add(this.btnGuardarGU);
            this.tbpUsuarios.Controls.Add(this.cmbRolGU);
            this.tbpUsuarios.Controls.Add(this.txtContraseñaGU);
            this.tbpUsuarios.Controls.Add(this.txtApellidoGU);
            this.tbpUsuarios.Controls.Add(this.txtNombreGU);
            this.tbpUsuarios.Controls.Add(this.txtIdUsuarioGU);
            this.tbpUsuarios.Controls.Add(this.label5);
            this.tbpUsuarios.Controls.Add(this.label4);
            this.tbpUsuarios.Controls.Add(this.label3);
            this.tbpUsuarios.Controls.Add(this.label2);
            this.tbpUsuarios.Controls.Add(this.label1);
            this.tbpUsuarios.Location = new System.Drawing.Point(4, 29);
            this.tbpUsuarios.Name = "tbpUsuarios";
            this.tbpUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUsuarios.Size = new System.Drawing.Size(976, 619);
            this.tbpUsuarios.TabIndex = 0;
            this.tbpUsuarios.Text = "Gestionar Usuarios";
            // 
            // txtTelefonoGU
            // 
            this.txtTelefonoGU.Location = new System.Drawing.Point(653, 33);
            this.txtTelefonoGU.Name = "txtTelefonoGU";
            this.txtTelefonoGU.Size = new System.Drawing.Size(223, 27);
            this.txtTelefonoGU.TabIndex = 18;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(564, 40);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Telefono";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 221);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(156, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Correo electronico";
            // 
            // txtCorreoGU
            // 
            this.txtCorreoGU.Location = new System.Drawing.Point(211, 221);
            this.txtCorreoGU.Name = "txtCorreoGU";
            this.txtCorreoGU.Size = new System.Drawing.Size(292, 27);
            this.txtCorreoGU.TabIndex = 14;
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
            this.colUsuarios,
            this.colNombreGU,
            this.colApellidoGU,
            this.CLMcorreoGU,
            this.CLMtelefonoGU,
            this.colRol});
            this.dgvGUsuarios.EnableHeadersVisualStyles = false;
            this.dgvGUsuarios.Location = new System.Drawing.Point(53, 337);
            this.dgvGUsuarios.Name = "dgvGUsuarios";
            this.dgvGUsuarios.RowHeadersVisible = false;
            this.dgvGUsuarios.RowHeadersWidth = 62;
            this.dgvGUsuarios.RowTemplate.Height = 28;
            this.dgvGUsuarios.Size = new System.Drawing.Size(865, 228);
            this.dgvGUsuarios.TabIndex = 13;
            this.dgvGUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGUsuarios_CellContentClick);
            // 
            // colUsuarios
            // 
            this.colUsuarios.HeaderText = "IdUsuario";
            this.colUsuarios.MinimumWidth = 8;
            this.colUsuarios.Name = "colUsuarios";
            // 
            // colNombreGU
            // 
            this.colNombreGU.HeaderText = "Nombre ";
            this.colNombreGU.MinimumWidth = 8;
            this.colNombreGU.Name = "colNombreGU";
            // 
            // colApellidoGU
            // 
            this.colApellidoGU.HeaderText = "Apellido";
            this.colApellidoGU.MinimumWidth = 6;
            this.colApellidoGU.Name = "colApellidoGU";
            // 
            // CLMcorreoGU
            // 
            this.CLMcorreoGU.HeaderText = "Correo electronico";
            this.CLMcorreoGU.MinimumWidth = 6;
            this.CLMcorreoGU.Name = "CLMcorreoGU";
            // 
            // CLMtelefonoGU
            // 
            this.CLMtelefonoGU.HeaderText = "Telefono";
            this.CLMtelefonoGU.MinimumWidth = 6;
            this.CLMtelefonoGU.Name = "CLMtelefonoGU";
            // 
            // colRol
            // 
            this.colRol.HeaderText = "Rol";
            this.colRol.MinimumWidth = 8;
            this.colRol.Name = "colRol";
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
            // cmbRolGU
            // 
            this.cmbRolGU.FormattingEnabled = true;
            this.cmbRolGU.Location = new System.Drawing.Point(653, 163);
            this.cmbRolGU.Name = "cmbRolGU";
            this.cmbRolGU.Size = new System.Drawing.Size(223, 28);
            this.cmbRolGU.TabIndex = 9;
            // 
            // txtContraseñaGU
            // 
            this.txtContraseñaGU.Location = new System.Drawing.Point(653, 104);
            this.txtContraseñaGU.Name = "txtContraseñaGU";
            this.txtContraseñaGU.Size = new System.Drawing.Size(223, 27);
            this.txtContraseñaGU.TabIndex = 8;
            // 
            // txtApellidoGU
            // 
            this.txtApellidoGU.Location = new System.Drawing.Point(155, 164);
            this.txtApellidoGU.Name = "txtApellidoGU";
            this.txtApellidoGU.Size = new System.Drawing.Size(348, 27);
            this.txtApellidoGU.TabIndex = 7;
            // 
            // txtNombreGU
            // 
            this.txtNombreGU.Location = new System.Drawing.Point(155, 99);
            this.txtNombreGU.Name = "txtNombreGU";
            this.txtNombreGU.Size = new System.Drawing.Size(348, 27);
            this.txtNombreGU.TabIndex = 6;
            // 
            // txtIdUsuarioGU
            // 
            this.txtIdUsuarioGU.Location = new System.Drawing.Point(155, 40);
            this.txtIdUsuarioGU.Name = "txtIdUsuarioGU";
            this.txtIdUsuarioGU.Size = new System.Drawing.Size(348, 27);
            this.txtIdUsuarioGU.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(591, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rol";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Contraseña";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "IdUsuario";
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
            this.tbpCerraSesion.Controls.Add(this.label6);
            this.tbpCerraSesion.Controls.Add(this.pcbAlerta);
            this.tbpCerraSesion.Location = new System.Drawing.Point(4, 29);
            this.tbpCerraSesion.Name = "tbpCerraSesion";
            this.tbpCerraSesion.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCerraSesion.Size = new System.Drawing.Size(976, 619);
            this.tbpCerraSesion.TabIndex = 1;
            this.tbpCerraSesion.Text = "Cerrar Sesión";
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
            // txtContraseñaCS
            // 
            this.txtContraseñaCS.Location = new System.Drawing.Point(260, 320);
            this.txtContraseñaCS.Name = "txtContraseñaCS";
            this.txtContraseñaCS.Size = new System.Drawing.Size(464, 27);
            this.txtContraseñaCS.TabIndex = 6;
            // 
            // txtUsuarioCS
            // 
            this.txtUsuarioCS.Location = new System.Drawing.Point(260, 239);
            this.txtUsuarioCS.Name = "txtUsuarioCS";
            this.txtUsuarioCS.Size = new System.Drawing.Size(464, 27);
            this.txtUsuarioCS.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(306, 415);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(329, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "¿Está seguro que desea salir del sistema?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(137, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Contraseña";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 242);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Usuario";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(344, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(249, 22);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmSeguridad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(949, 656);
            this.Controls.Add(this.tbcOpciones);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSeguridad";
            this.Text = "Seguridad";
            this.tbcOpciones.ResumeLayout(false);
            this.tbpUsuarios.ResumeLayout(false);
            this.tbpUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGUsuarios)).EndInit();
            this.tbpCerraSesion.ResumeLayout(false);
            this.tbpCerraSesion.PerformLayout();
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
        private System.Windows.Forms.TextBox txtIdUsuarioGU;
        private System.Windows.Forms.DataGridView dgvGUsuarios;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pcbAlerta;
        private System.Windows.Forms.Button btnCancelarCS;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.TextBox txtContraseñaCS;
        private System.Windows.Forms.TextBox txtUsuarioCS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCorreoGU;
        private System.Windows.Forms.TextBox txtTelefonoGU;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreGU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidoGU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMcorreoGU;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMtelefonoGU;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRol;
    }
}