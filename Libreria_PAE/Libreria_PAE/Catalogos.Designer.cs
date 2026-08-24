namespace Libreria_PAE
{
    partial class frmCatalogos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCatalogos));
            this.tbcCatalogo = new System.Windows.Forms.TabControl();
            this.tbpCategoria = new System.Windows.Forms.TabPage();
            this.tbpProducto = new System.Windows.Forms.TabPage();
            this.tbpProveedor = new System.Windows.Forms.TabPage();
            this.tbpCliente = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombreCategoria = new System.Windows.Forms.TextBox();
            this.txtDescripcionCt = new System.Windows.Forms.TextBox();
            this.btnGuardarCt = new System.Windows.Forms.Button();
            this.btnEliminarCt = new System.Windows.Forms.Button();
            this.btnCerrarCt = new System.Windows.Forms.Button();
            this.dgvCategoria = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombreCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCodigoPr = new System.Windows.Forms.TextBox();
            this.txtNombrePr = new System.Windows.Forms.TextBox();
            this.txtStockAPr = new System.Windows.Forms.TextBox();
            this.txtPrecioCompraPr = new System.Windows.Forms.TextBox();
            this.txtPrecioVentaPr = new System.Windows.Forms.TextBox();
            this.txtStockMPr = new System.Windows.Forms.TextBox();
            this.cmbCategoriaPR = new System.Windows.Forms.ComboBox();
            this.btnGuardarPr = new System.Windows.Forms.Button();
            this.btnEliminarPr = new System.Windows.Forms.Button();
            this.btnCerrarPr = new System.Windows.Forms.Button();
            this.dvgProducto = new System.Windows.Forms.DataGridView();
            this.clCodigoPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clNombrePr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCategoriaPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStockPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrecioVentaPr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbcCatalogo.SuspendLayout();
            this.tbpCategoria.SuspendLayout();
            this.tbpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCatalogo
            // 
            this.tbcCatalogo.Controls.Add(this.tbpCategoria);
            this.tbcCatalogo.Controls.Add(this.tbpProducto);
            this.tbcCatalogo.Controls.Add(this.tbpProveedor);
            this.tbcCatalogo.Controls.Add(this.tbpCliente);
            this.tbcCatalogo.Location = new System.Drawing.Point(2, 6);
            this.tbcCatalogo.Name = "tbcCatalogo";
            this.tbcCatalogo.SelectedIndex = 0;
            this.tbcCatalogo.Size = new System.Drawing.Size(945, 634);
            this.tbcCatalogo.TabIndex = 0;
            // 
            // tbpCategoria
            // 
            this.tbpCategoria.BackColor = System.Drawing.Color.Thistle;
            this.tbpCategoria.Controls.Add(this.dgvCategoria);
            this.tbpCategoria.Controls.Add(this.btnCerrarCt);
            this.tbpCategoria.Controls.Add(this.btnEliminarCt);
            this.tbpCategoria.Controls.Add(this.btnGuardarCt);
            this.tbpCategoria.Controls.Add(this.txtDescripcionCt);
            this.tbpCategoria.Controls.Add(this.txtNombreCategoria);
            this.tbpCategoria.Controls.Add(this.label2);
            this.tbpCategoria.Controls.Add(this.label1);
            this.tbpCategoria.Location = new System.Drawing.Point(4, 32);
            this.tbpCategoria.Name = "tbpCategoria";
            this.tbpCategoria.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCategoria.Size = new System.Drawing.Size(937, 598);
            this.tbpCategoria.TabIndex = 0;
            this.tbpCategoria.Text = "Categoría";
            this.tbpCategoria.Click += new System.EventHandler(this.tbpCategoria_Click);
            // 
            // tbpProducto
            // 
            this.tbpProducto.BackColor = System.Drawing.Color.Thistle;
            this.tbpProducto.Controls.Add(this.dvgProducto);
            this.tbpProducto.Controls.Add(this.btnCerrarPr);
            this.tbpProducto.Controls.Add(this.btnEliminarPr);
            this.tbpProducto.Controls.Add(this.btnGuardarPr);
            this.tbpProducto.Controls.Add(this.cmbCategoriaPR);
            this.tbpProducto.Controls.Add(this.txtStockMPr);
            this.tbpProducto.Controls.Add(this.txtPrecioVentaPr);
            this.tbpProducto.Controls.Add(this.txtPrecioCompraPr);
            this.tbpProducto.Controls.Add(this.txtStockAPr);
            this.tbpProducto.Controls.Add(this.txtNombrePr);
            this.tbpProducto.Controls.Add(this.txtCodigoPr);
            this.tbpProducto.Controls.Add(this.label9);
            this.tbpProducto.Controls.Add(this.label8);
            this.tbpProducto.Controls.Add(this.label7);
            this.tbpProducto.Controls.Add(this.label6);
            this.tbpProducto.Controls.Add(this.label5);
            this.tbpProducto.Controls.Add(this.label4);
            this.tbpProducto.Controls.Add(this.label3);
            this.tbpProducto.Location = new System.Drawing.Point(4, 32);
            this.tbpProducto.Name = "tbpProducto";
            this.tbpProducto.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProducto.Size = new System.Drawing.Size(937, 598);
            this.tbpProducto.TabIndex = 1;
            this.tbpProducto.Text = "Producto";
            // 
            // tbpProveedor
            // 
            this.tbpProveedor.BackColor = System.Drawing.Color.Thistle;
            this.tbpProveedor.Location = new System.Drawing.Point(4, 32);
            this.tbpProveedor.Name = "tbpProveedor";
            this.tbpProveedor.Padding = new System.Windows.Forms.Padding(3);
            this.tbpProveedor.Size = new System.Drawing.Size(937, 598);
            this.tbpProveedor.TabIndex = 2;
            this.tbpProveedor.Text = "Proveedor";
            // 
            // tbpCliente
            // 
            this.tbpCliente.BackColor = System.Drawing.Color.Thistle;
            this.tbpCliente.Location = new System.Drawing.Point(4, 32);
            this.tbpCliente.Name = "tbpCliente";
            this.tbpCliente.Padding = new System.Windows.Forms.Padding(3);
            this.tbpCliente.Size = new System.Drawing.Size(937, 598);
            this.tbpCliente.TabIndex = 3;
            this.tbpCliente.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Categoría";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descripción";
            // 
            // txtNombreCategoria
            // 
            this.txtNombreCategoria.Location = new System.Drawing.Point(305, 83);
            this.txtNombreCategoria.Name = "txtNombreCategoria";
            this.txtNombreCategoria.Size = new System.Drawing.Size(463, 31);
            this.txtNombreCategoria.TabIndex = 2;
            // 
            // txtDescripcionCt
            // 
            this.txtDescripcionCt.Location = new System.Drawing.Point(305, 146);
            this.txtDescripcionCt.Name = "txtDescripcionCt";
            this.txtDescripcionCt.Size = new System.Drawing.Size(463, 31);
            this.txtDescripcionCt.TabIndex = 3;
            // 
            // btnGuardarCt
            // 
            this.btnGuardarCt.BackColor = System.Drawing.Color.Purple;
            this.btnGuardarCt.ForeColor = System.Drawing.Color.White;
            this.btnGuardarCt.Location = new System.Drawing.Point(407, 222);
            this.btnGuardarCt.Name = "btnGuardarCt";
            this.btnGuardarCt.Size = new System.Drawing.Size(157, 46);
            this.btnGuardarCt.TabIndex = 4;
            this.btnGuardarCt.Text = "Guardar";
            this.btnGuardarCt.UseVisualStyleBackColor = false;
            // 
            // btnEliminarCt
            // 
            this.btnEliminarCt.BackColor = System.Drawing.Color.Purple;
            this.btnEliminarCt.ForeColor = System.Drawing.Color.White;
            this.btnEliminarCt.Location = new System.Drawing.Point(570, 222);
            this.btnEliminarCt.Name = "btnEliminarCt";
            this.btnEliminarCt.Size = new System.Drawing.Size(157, 46);
            this.btnEliminarCt.TabIndex = 5;
            this.btnEliminarCt.Text = "Eliminar";
            this.btnEliminarCt.UseVisualStyleBackColor = false;
            // 
            // btnCerrarCt
            // 
            this.btnCerrarCt.BackColor = System.Drawing.Color.Purple;
            this.btnCerrarCt.ForeColor = System.Drawing.Color.White;
            this.btnCerrarCt.Location = new System.Drawing.Point(735, 222);
            this.btnCerrarCt.Name = "btnCerrarCt";
            this.btnCerrarCt.Size = new System.Drawing.Size(157, 46);
            this.btnCerrarCt.TabIndex = 6;
            this.btnCerrarCt.Text = "Cerrar";
            this.btnCerrarCt.UseVisualStyleBackColor = false;
            // 
            // dgvCategoria
            // 
            this.dgvCategoria.AllowUserToAddRows = false;
            this.dgvCategoria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCategoria.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategoria.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCategoria.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoria.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategoria.ColumnHeadersHeight = 30;
            this.dgvCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCategoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clId,
            this.clNombreCategoria,
            this.clDescripcion});
            this.dgvCategoria.EnableHeadersVisualStyles = false;
            this.dgvCategoria.Location = new System.Drawing.Point(22, 292);
            this.dgvCategoria.Name = "dgvCategoria";
            this.dgvCategoria.RowHeadersVisible = false;
            this.dgvCategoria.RowHeadersWidth = 62;
            this.dgvCategoria.RowTemplate.Height = 28;
            this.dgvCategoria.Size = new System.Drawing.Size(870, 266);
            this.dgvCategoria.TabIndex = 7;
            // 
            // clId
            // 
            this.clId.HeaderText = "id";
            this.clId.MinimumWidth = 8;
            this.clId.Name = "clId";
            // 
            // clNombreCategoria
            // 
            this.clNombreCategoria.HeaderText = "Nombre Categoria";
            this.clNombreCategoria.MinimumWidth = 8;
            this.clNombreCategoria.Name = "clNombreCategoria";
            // 
            // clDescripcion
            // 
            this.clDescripcion.HeaderText = "Descripción";
            this.clDescripcion.MinimumWidth = 8;
            this.clDescripcion.Name = "clDescripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Código";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 23);
            this.label5.TabIndex = 2;
            this.label5.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 23);
            this.label6.TabIndex = 3;
            this.label6.Text = "Stock actual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(169, 23);
            this.label7.TabIndex = 4;
            this.label7.Text = "Precio de compra";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(463, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(150, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Precio de venta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 23);
            this.label9.TabIndex = 6;
            this.label9.Text = "Stock mínimo ";
            // 
            // txtCodigoPr
            // 
            this.txtCodigoPr.Location = new System.Drawing.Point(148, 35);
            this.txtCodigoPr.Name = "txtCodigoPr";
            this.txtCodigoPr.Size = new System.Drawing.Size(290, 31);
            this.txtCodigoPr.TabIndex = 7;
            // 
            // txtNombrePr
            // 
            this.txtNombrePr.Location = new System.Drawing.Point(148, 93);
            this.txtNombrePr.Name = "txtNombrePr";
            this.txtNombrePr.Size = new System.Drawing.Size(290, 31);
            this.txtNombrePr.TabIndex = 8;
            // 
            // txtStockAPr
            // 
            this.txtStockAPr.Location = new System.Drawing.Point(148, 198);
            this.txtStockAPr.Name = "txtStockAPr";
            this.txtStockAPr.Size = new System.Drawing.Size(290, 31);
            this.txtStockAPr.TabIndex = 9;
            // 
            // txtPrecioCompraPr
            // 
            this.txtPrecioCompraPr.Location = new System.Drawing.Point(619, 32);
            this.txtPrecioCompraPr.Name = "txtPrecioCompraPr";
            this.txtPrecioCompraPr.Size = new System.Drawing.Size(290, 31);
            this.txtPrecioCompraPr.TabIndex = 10;
            // 
            // txtPrecioVentaPr
            // 
            this.txtPrecioVentaPr.Location = new System.Drawing.Point(619, 93);
            this.txtPrecioVentaPr.Name = "txtPrecioVentaPr";
            this.txtPrecioVentaPr.Size = new System.Drawing.Size(290, 31);
            this.txtPrecioVentaPr.TabIndex = 11;
            // 
            // txtStockMPr
            // 
            this.txtStockMPr.Location = new System.Drawing.Point(619, 147);
            this.txtStockMPr.Name = "txtStockMPr";
            this.txtStockMPr.Size = new System.Drawing.Size(290, 31);
            this.txtStockMPr.TabIndex = 12;
            // 
            // cmbCategoriaPR
            // 
            this.cmbCategoriaPR.FormattingEnabled = true;
            this.cmbCategoriaPR.Location = new System.Drawing.Point(148, 147);
            this.cmbCategoriaPR.Name = "cmbCategoriaPR";
            this.cmbCategoriaPR.Size = new System.Drawing.Size(290, 31);
            this.cmbCategoriaPR.TabIndex = 13;
            // 
            // btnGuardarPr
            // 
            this.btnGuardarPr.BackColor = System.Drawing.Color.Purple;
            this.btnGuardarPr.ForeColor = System.Drawing.Color.White;
            this.btnGuardarPr.Location = new System.Drawing.Point(372, 276);
            this.btnGuardarPr.Name = "btnGuardarPr";
            this.btnGuardarPr.Size = new System.Drawing.Size(175, 48);
            this.btnGuardarPr.TabIndex = 14;
            this.btnGuardarPr.Text = "Guardar";
            this.btnGuardarPr.UseVisualStyleBackColor = false;
            // 
            // btnEliminarPr
            // 
            this.btnEliminarPr.BackColor = System.Drawing.Color.Purple;
            this.btnEliminarPr.ForeColor = System.Drawing.Color.White;
            this.btnEliminarPr.Location = new System.Drawing.Point(553, 276);
            this.btnEliminarPr.Name = "btnEliminarPr";
            this.btnEliminarPr.Size = new System.Drawing.Size(175, 48);
            this.btnEliminarPr.TabIndex = 15;
            this.btnEliminarPr.Text = "Eliminar";
            this.btnEliminarPr.UseVisualStyleBackColor = false;
            // 
            // btnCerrarPr
            // 
            this.btnCerrarPr.BackColor = System.Drawing.Color.Purple;
            this.btnCerrarPr.ForeColor = System.Drawing.Color.White;
            this.btnCerrarPr.Location = new System.Drawing.Point(734, 276);
            this.btnCerrarPr.Name = "btnCerrarPr";
            this.btnCerrarPr.Size = new System.Drawing.Size(175, 48);
            this.btnCerrarPr.TabIndex = 16;
            this.btnCerrarPr.Text = "Cerrar";
            this.btnCerrarPr.UseVisualStyleBackColor = false;
            // 
            // dvgProducto
            // 
            this.dvgProducto.AllowUserToAddRows = false;
            this.dvgProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgProducto.BackgroundColor = System.Drawing.Color.White;
            this.dvgProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dvgProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dvgProducto.ColumnHeadersHeight = 30;
            this.dvgProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dvgProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clCodigoPr,
            this.clNombrePr,
            this.clCategoriaPr,
            this.clStockPr,
            this.clPrecioVentaPr});
            this.dvgProducto.EnableHeadersVisualStyles = false;
            this.dvgProducto.Location = new System.Drawing.Point(13, 332);
            this.dvgProducto.Name = "dvgProducto";
            this.dvgProducto.RowHeadersVisible = false;
            this.dvgProducto.RowHeadersWidth = 62;
            this.dvgProducto.RowTemplate.Height = 28;
            this.dvgProducto.Size = new System.Drawing.Size(898, 226);
            this.dvgProducto.TabIndex = 17;
            // 
            // clCodigoPr
            // 
            this.clCodigoPr.HeaderText = "Código";
            this.clCodigoPr.MinimumWidth = 8;
            this.clCodigoPr.Name = "clCodigoPr";
            // 
            // clNombrePr
            // 
            this.clNombrePr.HeaderText = "Nombre";
            this.clNombrePr.MinimumWidth = 8;
            this.clNombrePr.Name = "clNombrePr";
            // 
            // clCategoriaPr
            // 
            this.clCategoriaPr.HeaderText = "Categoría";
            this.clCategoriaPr.MinimumWidth = 8;
            this.clCategoriaPr.Name = "clCategoriaPr";
            // 
            // clStockPr
            // 
            this.clStockPr.HeaderText = "Stock";
            this.clStockPr.MinimumWidth = 8;
            this.clStockPr.Name = "clStockPr";
            // 
            // clPrecioVentaPr
            // 
            this.clPrecioVentaPr.HeaderText = "Precio de venta";
            this.clPrecioVentaPr.MinimumWidth = 8;
            this.clPrecioVentaPr.Name = "clPrecioVentaPr";
            // 
            // frmCatalogos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(927, 608);
            this.Controls.Add(this.tbcCatalogo);
            this.Font = new System.Drawing.Font("Cambria", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmCatalogos";
            this.Text = "Catalogos";
            this.tbcCatalogo.ResumeLayout(false);
            this.tbpCategoria.ResumeLayout(false);
            this.tbpCategoria.PerformLayout();
            this.tbpProducto.ResumeLayout(false);
            this.tbpProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgProducto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCatalogo;
        private System.Windows.Forms.TabPage tbpCategoria;
        private System.Windows.Forms.TabPage tbpProducto;
        private System.Windows.Forms.TabPage tbpProveedor;
        private System.Windows.Forms.TabPage tbpCliente;
        private System.Windows.Forms.TextBox txtDescripcionCt;
        private System.Windows.Forms.TextBox txtNombreCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCategoria;
        private System.Windows.Forms.Button btnCerrarCt;
        private System.Windows.Forms.Button btnEliminarCt;
        private System.Windows.Forms.Button btnGuardarCt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombreCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDescripcion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCerrarPr;
        private System.Windows.Forms.Button btnEliminarPr;
        private System.Windows.Forms.Button btnGuardarPr;
        private System.Windows.Forms.ComboBox cmbCategoriaPR;
        private System.Windows.Forms.TextBox txtStockMPr;
        private System.Windows.Forms.TextBox txtPrecioVentaPr;
        private System.Windows.Forms.TextBox txtPrecioCompraPr;
        private System.Windows.Forms.TextBox txtStockAPr;
        private System.Windows.Forms.TextBox txtNombrePr;
        private System.Windows.Forms.TextBox txtCodigoPr;
        private System.Windows.Forms.DataGridView dvgProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCodigoPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNombrePr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clCategoriaPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStockPr;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrecioVentaPr;
    }
}