namespace Libreria_PAE
{
    partial class Reportes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reportes));
            this.tcConsultarstk = new System.Windows.Forms.TabControl();
            this.TCconsultarStock = new System.Windows.Forms.TabPage();
            this.btnCerrarCS = new System.Windows.Forms.Button();
            this.dgvInfoCs = new System.Windows.Forms.DataGridView();
            this.CLMcódigoCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMproductoCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMcategoríaCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMprecioCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMstockCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMmínimoCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMestadoCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbBuscarProucto = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.CBAlerta = new System.Windows.Forms.CheckBox();
            this.CMBcatgoría = new System.Windows.Forms.ComboBox();
            this.tbNombreCod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBreportesVentas = new System.Windows.Forms.TabPage();
            this.dgvReporteVenta = new System.Windows.Forms.DataGridView();
            this.CLMnumFacturaRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMFechaRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLMTotalVentaRV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTotalVendidoRV = new System.Windows.Forms.TextBox();
            this.btnCerrarRV = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CLcódigoCs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tcConsultarstk.SuspendLayout();
            this.TCconsultarStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCs)).BeginInit();
            this.gbBuscarProucto.SuspendLayout();
            this.TBreportesVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // tcConsultarstk
            // 
            this.tcConsultarstk.Controls.Add(this.TCconsultarStock);
            this.tcConsultarstk.Controls.Add(this.TBreportesVentas);
            this.tcConsultarstk.Location = new System.Drawing.Point(3, 1);
            this.tcConsultarstk.Name = "tcConsultarstk";
            this.tcConsultarstk.SelectedIndex = 0;
            this.tcConsultarstk.Size = new System.Drawing.Size(996, 549);
            this.tcConsultarstk.TabIndex = 0;
            // 
            // TCconsultarStock
            // 
            this.TCconsultarStock.BackColor = System.Drawing.Color.Thistle;
            this.TCconsultarStock.Controls.Add(this.btnCerrarCS);
            this.TCconsultarStock.Controls.Add(this.dgvInfoCs);
            this.TCconsultarStock.Controls.Add(this.gbBuscarProucto);
            this.TCconsultarStock.Location = new System.Drawing.Point(4, 29);
            this.TCconsultarStock.Name = "TCconsultarStock";
            this.TCconsultarStock.Padding = new System.Windows.Forms.Padding(3);
            this.TCconsultarStock.Size = new System.Drawing.Size(988, 516);
            this.TCconsultarStock.TabIndex = 0;
            this.TCconsultarStock.Text = "Consultar stock";
            // 
            // btnCerrarCS
            // 
            this.btnCerrarCS.BackColor = System.Drawing.Color.Purple;
            this.btnCerrarCS.ForeColor = System.Drawing.Color.White;
            this.btnCerrarCS.Location = new System.Drawing.Point(824, 427);
            this.btnCerrarCS.Name = "btnCerrarCS";
            this.btnCerrarCS.Size = new System.Drawing.Size(118, 46);
            this.btnCerrarCS.TabIndex = 2;
            this.btnCerrarCS.Text = "Cerrar";
            this.btnCerrarCS.UseVisualStyleBackColor = false;
            // 
            // dgvInfoCs
            // 
            this.dgvInfoCs.AllowUserToAddRows = false;
            this.dgvInfoCs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInfoCs.BackgroundColor = System.Drawing.Color.White;
            this.dgvInfoCs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfoCs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfoCs.ColumnHeadersHeight = 30;
            this.dgvInfoCs.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLMcódigoCs,
            this.CLMproductoCs,
            this.CLMcategoríaCs,
            this.CLMprecioCs,
            this.CLMstockCs,
            this.CLMmínimoCs,
            this.CLMestadoCs});
            this.dgvInfoCs.EnableHeadersVisualStyles = false;
            this.dgvInfoCs.Location = new System.Drawing.Point(33, 246);
            this.dgvInfoCs.Name = "dgvInfoCs";
            this.dgvInfoCs.RowHeadersVisible = false;
            this.dgvInfoCs.RowHeadersWidth = 51;
            this.dgvInfoCs.RowTemplate.Height = 24;
            this.dgvInfoCs.Size = new System.Drawing.Size(922, 175);
            this.dgvInfoCs.TabIndex = 1;
            // 
            // CLMcódigoCs
            // 
            this.CLMcódigoCs.HeaderText = "Código";
            this.CLMcódigoCs.MinimumWidth = 6;
            this.CLMcódigoCs.Name = "CLMcódigoCs";
            // 
            // CLMproductoCs
            // 
            this.CLMproductoCs.HeaderText = "Producto";
            this.CLMproductoCs.MinimumWidth = 6;
            this.CLMproductoCs.Name = "CLMproductoCs";
            // 
            // CLMcategoríaCs
            // 
            this.CLMcategoríaCs.HeaderText = "Categoría";
            this.CLMcategoríaCs.MinimumWidth = 6;
            this.CLMcategoríaCs.Name = "CLMcategoríaCs";
            // 
            // CLMprecioCs
            // 
            this.CLMprecioCs.HeaderText = "Precio";
            this.CLMprecioCs.MinimumWidth = 6;
            this.CLMprecioCs.Name = "CLMprecioCs";
            // 
            // CLMstockCs
            // 
            this.CLMstockCs.HeaderText = "Stock";
            this.CLMstockCs.MinimumWidth = 6;
            this.CLMstockCs.Name = "CLMstockCs";
            // 
            // CLMmínimoCs
            // 
            this.CLMmínimoCs.HeaderText = "Mínimo";
            this.CLMmínimoCs.MinimumWidth = 6;
            this.CLMmínimoCs.Name = "CLMmínimoCs";
            // 
            // CLMestadoCs
            // 
            this.CLMestadoCs.HeaderText = "Estado";
            this.CLMestadoCs.MinimumWidth = 6;
            this.CLMestadoCs.Name = "CLMestadoCs";
            // 
            // gbBuscarProucto
            // 
            this.gbBuscarProucto.Controls.Add(this.btnBuscar);
            this.gbBuscarProucto.Controls.Add(this.CBAlerta);
            this.gbBuscarProucto.Controls.Add(this.CMBcatgoría);
            this.gbBuscarProucto.Controls.Add(this.tbNombreCod);
            this.gbBuscarProucto.Controls.Add(this.label2);
            this.gbBuscarProucto.Controls.Add(this.label1);
            this.gbBuscarProucto.Location = new System.Drawing.Point(72, 36);
            this.gbBuscarProucto.Name = "gbBuscarProucto";
            this.gbBuscarProucto.Size = new System.Drawing.Size(845, 153);
            this.gbBuscarProucto.TabIndex = 0;
            this.gbBuscarProucto.TabStop = false;
            this.gbBuscarProucto.Text = "Buscar Producto";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Purple;
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(689, 90);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(124, 57);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            // 
            // CBAlerta
            // 
            this.CBAlerta.AutoSize = true;
            this.CBAlerta.Location = new System.Drawing.Point(58, 104);
            this.CBAlerta.Name = "CBAlerta";
            this.CBAlerta.Size = new System.Drawing.Size(123, 24);
            this.CBAlerta.TabIndex = 4;
            this.CBAlerta.Text = "Solo alertas";
            this.CBAlerta.UseVisualStyleBackColor = true;
            // 
            // CMBcatgoría
            // 
            this.CMBcatgoría.FormattingEnabled = true;
            this.CMBcatgoría.Location = new System.Drawing.Point(595, 46);
            this.CMBcatgoría.Name = "CMBcatgoría";
            this.CMBcatgoría.Size = new System.Drawing.Size(179, 28);
            this.CMBcatgoría.TabIndex = 3;
            // 
            // tbNombreCod
            // 
            this.tbNombreCod.Location = new System.Drawing.Point(203, 46);
            this.tbNombreCod.Name = "tbNombreCod";
            this.tbNombreCod.Size = new System.Drawing.Size(176, 27);
            this.tbNombreCod.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(497, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Categorías";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre o código";
            // 
            // TBreportesVentas
            // 
            this.TBreportesVentas.BackColor = System.Drawing.Color.Thistle;
            this.TBreportesVentas.Controls.Add(this.dgvReporteVenta);
            this.TBreportesVentas.Controls.Add(this.tbTotalVendidoRV);
            this.TBreportesVentas.Controls.Add(this.btnCerrarRV);
            this.TBreportesVentas.Controls.Add(this.btnConsultar);
            this.TBreportesVentas.Controls.Add(this.comboBox3);
            this.TBreportesVentas.Controls.Add(this.comboBox1);
            this.TBreportesVentas.Controls.Add(this.label5);
            this.TBreportesVentas.Controls.Add(this.label4);
            this.TBreportesVentas.Controls.Add(this.label3);
            this.TBreportesVentas.Location = new System.Drawing.Point(4, 29);
            this.TBreportesVentas.Name = "TBreportesVentas";
            this.TBreportesVentas.Padding = new System.Windows.Forms.Padding(3);
            this.TBreportesVentas.Size = new System.Drawing.Size(988, 516);
            this.TBreportesVentas.TabIndex = 1;
            this.TBreportesVentas.Text = "Reportes de Ventas";
            // 
            // dgvReporteVenta
            // 
            this.dgvReporteVenta.AllowUserToAddRows = false;
            this.dgvReporteVenta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReporteVenta.BackgroundColor = System.Drawing.Color.White;
            this.dgvReporteVenta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporteVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReporteVenta.ColumnHeadersHeight = 30;
            this.dgvReporteVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CLMnumFacturaRV,
            this.CLMFechaRV,
            this.CLMTotalVentaRV});
            this.dgvReporteVenta.EnableHeadersVisualStyles = false;
            this.dgvReporteVenta.Location = new System.Drawing.Point(78, 173);
            this.dgvReporteVenta.Name = "dgvReporteVenta";
            this.dgvReporteVenta.RowHeadersVisible = false;
            this.dgvReporteVenta.RowHeadersWidth = 51;
            this.dgvReporteVenta.RowTemplate.Height = 24;
            this.dgvReporteVenta.Size = new System.Drawing.Size(736, 188);
            this.dgvReporteVenta.TabIndex = 9;
            // 
            // CLMnumFacturaRV
            // 
            this.CLMnumFacturaRV.HeaderText = "№ Factura";
            this.CLMnumFacturaRV.MinimumWidth = 6;
            this.CLMnumFacturaRV.Name = "CLMnumFacturaRV";
            // 
            // CLMFechaRV
            // 
            this.CLMFechaRV.HeaderText = "Fecha";
            this.CLMFechaRV.MinimumWidth = 6;
            this.CLMFechaRV.Name = "CLMFechaRV";
            // 
            // CLMTotalVentaRV
            // 
            this.CLMTotalVentaRV.HeaderText = "Total Venta";
            this.CLMTotalVentaRV.MinimumWidth = 6;
            this.CLMTotalVentaRV.Name = "CLMTotalVentaRV";
            // 
            // tbTotalVendidoRV
            // 
            this.tbTotalVendidoRV.Location = new System.Drawing.Point(663, 394);
            this.tbTotalVendidoRV.Name = "tbTotalVendidoRV";
            this.tbTotalVendidoRV.Size = new System.Drawing.Size(151, 27);
            this.tbTotalVendidoRV.TabIndex = 8;
            // 
            // btnCerrarRV
            // 
            this.btnCerrarRV.BackColor = System.Drawing.Color.Purple;
            this.btnCerrarRV.ForeColor = System.Drawing.Color.White;
            this.btnCerrarRV.Location = new System.Drawing.Point(87, 384);
            this.btnCerrarRV.Name = "btnCerrarRV";
            this.btnCerrarRV.Size = new System.Drawing.Size(122, 47);
            this.btnCerrarRV.TabIndex = 7;
            this.btnCerrarRV.Text = "Cerrar";
            this.btnCerrarRV.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.Purple;
            this.btnConsultar.ForeColor = System.Drawing.Color.White;
            this.btnConsultar.Location = new System.Drawing.Point(668, 72);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(134, 54);
            this.btnConsultar.TabIndex = 6;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(462, 86);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(175, 28);
            this.comboBox3.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(158, 86);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(185, 28);
            this.comboBox1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(536, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total vendido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(398, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Desde:";
            // 
            // CLcódigoCs
            // 
            this.CLcódigoCs.HeaderText = "Código";
            this.CLcódigoCs.MinimumWidth = 6;
            this.CLcódigoCs.Name = "CLcódigoCs";
            this.CLcódigoCs.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Column7";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.Width = 125;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(978, 528);
            this.Controls.Add(this.tcConsultarstk);
            this.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Reportes";
            this.Text = "Reportes";
            this.tcConsultarstk.ResumeLayout(false);
            this.TCconsultarStock.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoCs)).EndInit();
            this.gbBuscarProucto.ResumeLayout(false);
            this.gbBuscarProucto.PerformLayout();
            this.TBreportesVentas.ResumeLayout(false);
            this.TBreportesVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporteVenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcConsultarstk;
        private System.Windows.Forms.TabPage TCconsultarStock;
        private System.Windows.Forms.TabPage TBreportesVentas;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.GroupBox gbBuscarProucto;
        private System.Windows.Forms.TextBox tbNombreCod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.CheckBox CBAlerta;
        private System.Windows.Forms.ComboBox CMBcatgoría;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLcódigoCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridView dgvInfoCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMcódigoCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMproductoCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMcategoríaCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMprecioCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMstockCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMmínimoCs;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMestadoCs;
        private System.Windows.Forms.Button btnCerrarCS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox tbTotalVendidoRV;
        private System.Windows.Forms.Button btnCerrarRV;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvReporteVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMnumFacturaRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMFechaRV;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLMTotalVentaRV;
    }
}