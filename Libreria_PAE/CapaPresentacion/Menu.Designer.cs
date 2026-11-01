namespace Libreria_PAE
{
    partial class frmSIVIG
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

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
            this.mnsMenu.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.mnsMenu.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.mnsMenu.Size = new System.Drawing.Size(849, 38);
            this.mnsMenu.TabIndex = 0;
            this.mnsMenu.Text = "menuStrip1";
            // 
            // tsmiSeguridad
            // 
            this.tsmiSeguridad.Image = global::CapaPresentacion.Properties.Resources.Seguridad;
            this.tsmiSeguridad.Name = "tsmiSeguridad";
            this.tsmiSeguridad.Size = new System.Drawing.Size(147, 30);
            this.tsmiSeguridad.Text = "Seguridad";
            // 
            // tsmiCatalogos
            // 
            this.tsmiCatalogos.Name = "tsmiCatalogos";
            this.tsmiCatalogos.Size = new System.Drawing.Size(121, 30);
            this.tsmiCatalogos.Text = "Catálogos";
            // 
            // tsmiOperaciones
            // 
            this.tsmiOperaciones.Font = new System.Drawing.Font("Microsoft PhagsPa", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmiOperaciones.Image = global::CapaPresentacion.Properties.Resources.Operaciones;
            this.tsmiOperaciones.Name = "tsmiOperaciones";
            this.tsmiOperaciones.Size = new System.Drawing.Size(169, 30);
            this.tsmiOperaciones.Text = "Operaciones";
            // 
            // tsmiReportess
            // 
            this.tsmiReportess.Image = global::CapaPresentacion.Properties.Resources.Reportes;
            this.tsmiReportess.Name = "tsmiReportess";
            this.tsmiReportess.Size = new System.Drawing.Size(136, 30);
            this.tsmiReportess.Text = "Reportes";
            // 
            // tsmiAyuda
            // 
            this.tsmiAyuda.Image = global::CapaPresentacion.Properties.Resources.Ayuda;
            this.tsmiAyuda.Name = "tsmiAyuda";
            this.tsmiAyuda.Size = new System.Drawing.Size(112, 30);
            this.tsmiAyuda.Text = "Ayuda";
            // 
            // frmSIVIG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(849, 714);
            this.Controls.Add(this.mnsMenu);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmSIVIG";
            this.Text = "Inicio";
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