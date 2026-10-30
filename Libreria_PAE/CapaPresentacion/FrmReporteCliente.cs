using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Entidades;
using Microsoft.Reporting.WinForms;

namespace Libreria_PAE
{
    public partial class FrmReporteCliente : Form
    {
        private readonly List<Cliente> clientes;

        public FrmReporteCliente(List<Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }

        private void FrmReporteCliente_Load(object sender, EventArgs e)
        {
            try
            {
                string rutaReporte = Path.Combine(Application.StartupPath, "Reports", "rpClientes.rdlc");

                if (!File.Exists(rutaReporte))
                {
                    MessageBox.Show("No se encontró el reporte en: " + rutaReporte, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                reportViewer1.Reset();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                reportViewer1.LocalReport.ReportPath = rutaReporte;
                reportViewer1.LocalReport.DataSources.Clear();

                ReportDataSource origen = new ReportDataSource("dsCliente", clientes);
                reportViewer1.LocalReport.DataSources.Add(origen);

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "No fue posible cargar el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}