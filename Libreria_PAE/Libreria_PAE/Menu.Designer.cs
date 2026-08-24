namespace Libreria_PAE
{
    partial class frmSIVIG
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSIVIG));
            this.mnsMenu = new System.Windows.Forms.MenuStrip();
            this.tsmiSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCatalogos = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOperaciones = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReportess = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAyuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnsMenu
            // 
            this.mnsMenu.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsMenu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mnsMenu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mnsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSeguridad,
            this.tsmiCatalogos,
            this.tsmiOperaciones,
            this.tsmiReportess,
            this.tsmiAyuda});
            this.mnsMenu.Location = new System.Drawing.Point(0, 0);
            this.mnsMenu.Name = "mnsMenu";
            this.mnsMenu.Padding = new System.Windows.Forms.Padding(12, 3, 0, 3);
            this.mnsMenu.Size = new System.Drawing.Size(728, 34);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tsmiSeguridad
            // 
            this.tsmiSeguridad.Image = global::Libreria_PAE.Properties.Resources.icons8_ajustes_de_usuario_100;
            this.tsmiSeguridad.Name = "tsmiSeguridad";
            this.tsmiSeguridad.Size = new System.Drawing.Size(143, 28);
            this.tsmiSeguridad.Text = "Seguridad";
            // 
            // tsmiCatalogos
            // 
            this.tsmiCatalogos.Image = global::Libreria_PAE.Properties.Resources.icons8_vista_general_3_100;
            this.tsmiCatalogos.Name = "tsmiCatalogos";
            this.tsmiCatalogos.Size = new System.Drawing.Size(137, 28);
            this.tsmiCatalogos.Text = "Catálogos";
            // 
            // tsmiOperaciones
            // 
            this.tsmiOperaciones.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiOperaciones.Image = global::Libreria_PAE.Properties.Resources.icons8_grupos_de_usuarios_100;
            this.tsmiOperaciones.Name = "tsmiOperaciones";
            this.tsmiOperaciones.Size = new System.Drawing.Size(165, 28);
            this.tsmiOperaciones.Text = "Operaciones";
            // 
            // tsmiReportess
            // 
            this.tsmiReportess.Image = global::Libreria_PAE.Properties.Resources.icons8_ventas_totales_100;
            this.tsmiReportess.Name = "tsmiReportess";
            this.tsmiReportess.Size = new System.Drawing.Size(133, 28);
            this.tsmiReportess.Text = "Reportes";
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.Image = global::Libreria_PAE.Properties.Resources.icons8_ayuda_100;
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(108, 28);
            this.tsmiAyuda.Text = "Ayuda";
            // 
            // frmSIVIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(728, 513);
            this.Controls.Add(this.mnsMenu);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSIVIG";
            this.Text = "SIVIG";
            this.mnsMenu.ResumeLayout(false);
            this.mnsMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiSeguridad;
        private System.Windows.Forms.ToolStripMenuItem tsmiCatalogos;
        private System.Windows.Forms.ToolStripMenuItem tsmiOperaciones;
        private System.Windows.Forms.ToolStripMenuItem tsmiReportess;
        private System.Windows.Forms.ToolStripMenuItem tsmiAyuda;
    }
}