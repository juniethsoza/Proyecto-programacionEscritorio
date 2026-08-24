namespace Libreria_PAE
{
    partial class frmAyuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAyuda));
            this.grpManualUso = new System.Windows.Forms.GroupBox();
            this.lblManualUso = new System.Windows.Forms.Label();
            this.btnAcceder = new System.Windows.Forms.Button();
            this.grpSoporteTecnico = new System.Windows.Forms.GroupBox();
            this.lblSoporteTecnico = new System.Windows.Forms.Label();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.grpManualUso.SuspendLayout();
            this.grpSoporteTecnico.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpManualUso
            // 
            this.grpManualUso.Controls.Add(this.lblManualUso);
            this.grpManualUso.Controls.Add(this.btnAcceder);
            this.grpManualUso.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpManualUso.Location = new System.Drawing.Point(35, 28);
            this.grpManualUso.Name = "grpManualUso";
            this.grpManualUso.Size = new System.Drawing.Size(722, 189);
            this.grpManualUso.TabIndex = 0;
            this.grpManualUso.TabStop = false;
            this.grpManualUso.Text = "Manual de uso";
            this.grpManualUso.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblManualUso
            // 
            this.lblManualUso.AutoSize = true;
            this.lblManualUso.Location = new System.Drawing.Point(36, 83);
            this.lblManualUso.Name = "lblManualUso";
            this.lblManualUso.Size = new System.Drawing.Size(666, 20);
            this.lblManualUso.TabIndex = 1;
            this.lblManualUso.Text = "Consulta la documentacion del sistema para conocer el uso correcto de cada modulo" +
    "";
            this.lblManualUso.Click += new System.EventHandler(this.lblManualUso_Click);
            // 
            // btnAcceder
            // 
            this.btnAcceder.BackColor = System.Drawing.Color.Purple;
            this.btnAcceder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAcceder.Location = new System.Drawing.Point(613, 139);
            this.btnAcceder.Name = "btnAcceder";
            this.btnAcceder.Size = new System.Drawing.Size(103, 45);
            this.btnAcceder.TabIndex = 2;
            this.btnAcceder.Text = "Acceder";
            this.btnAcceder.UseVisualStyleBackColor = false;
            // 
            // grpSoporteTecnico
            // 
            this.grpSoporteTecnico.Controls.Add(this.btnCerrar);
            this.grpSoporteTecnico.Controls.Add(this.lblSoporteTecnico);
            this.grpSoporteTecnico.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpSoporteTecnico.Location = new System.Drawing.Point(35, 248);
            this.grpSoporteTecnico.Name = "grpSoporteTecnico";
            this.grpSoporteTecnico.Size = new System.Drawing.Size(722, 190);
            this.grpSoporteTecnico.TabIndex = 3;
            this.grpSoporteTecnico.TabStop = false;
            this.grpSoporteTecnico.Text = "Soporte tecnico";
            // 
            // lblSoporteTecnico
            // 
            this.lblSoporteTecnico.AutoSize = true;
            this.lblSoporteTecnico.Location = new System.Drawing.Point(6, 51);
            this.lblSoporteTecnico.Name = "lblSoporteTecnico";
            this.lblSoporteTecnico.Size = new System.Drawing.Size(568, 100);
            this.lblSoporteTecnico.TabIndex = 4;
            this.lblSoporteTecnico.Text = "Si presenta problemas con el sistema contacte con el equipo de soporte.\r\n\r\nCorreo" +
    ": soportetecnico@gmail.com\r\n\r\nTelefono: 8888-8888";
            this.lblSoporteTecnico.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.Purple;
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCerrar.Location = new System.Drawing.Point(613, 139);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(103, 45);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // frmAyuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.grpSoporteTecnico);
            this.Controls.Add(this.grpManualUso);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAyuda";
            this.Text = "Ayuda";
            this.grpManualUso.ResumeLayout(false);
            this.grpManualUso.PerformLayout();
            this.grpSoporteTecnico.ResumeLayout(false);
            this.grpSoporteTecnico.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpManualUso;
        private System.Windows.Forms.Label lblManualUso;
        private System.Windows.Forms.Button btnAcceder;
        private System.Windows.Forms.GroupBox grpSoporteTecnico;
        private System.Windows.Forms.Label lblSoporteTecnico;
        private System.Windows.Forms.Button btnCerrar;
    }
}