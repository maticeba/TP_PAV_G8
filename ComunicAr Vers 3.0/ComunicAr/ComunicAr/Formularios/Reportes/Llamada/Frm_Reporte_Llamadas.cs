using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Negocio_Reportes;
using Microsoft.Reporting.WinForms;
using ComunicAr.Negocio_Listados;

namespace ComunicAr.Formularios.Reportes.Llamada
{
    public partial class Frm_Reporte_Llamadas : Form
    {
        DataTable table = new DataTable();
        ReporteCliente Rep_Cliente = new ReporteCliente();
        public Frm_Reporte_Llamadas()
        {
            InitializeComponent();
        }
        private void CargarTablaClienteXtiempo()
        {
            if (rBD1.Checked)
            {

                int tiempo = Convert.ToInt32(txt_duracion.Text.ToString());
                table = Rep_Cliente.SearchClienteXtiempo(tiempo);
                ArmarReporteClientesXtiempo(table);
            }
            if (rBD2.Checked)
            {

                table = Rep_Cliente.SearchClienteTodosxDuracion();
                ArmarReporteClientesXtiempo(table);
            }
        }

        private void ArmarReporteClientesXtiempo(DataTable table)
        {
            ReportDataSource parametro = new ReportDataSource("DataSet3", table);
            reportViewer2.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Llamada.ReportClientexLlamada.rdlc";
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(parametro);
            reportViewer2.RefreshReport();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CargarTablaClienteXtiempo();
        }
        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            CargarTablaClienteXtiempo();
        }

        private void rBD1_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_duracion.Enabled = true;
       
        }

        private void rBD2_CheckedChanged(object sender, EventArgs e)
        {
            txt_duracion.Enabled = false;
            txt_duracion.Clear();
        }
    }
}
