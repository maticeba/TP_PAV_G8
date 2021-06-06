using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using ComunicAr.Negocio_Listados;

namespace ComunicAr.Formularios.Reportes.Dispositivos
{
    public partial class Frm_Reporte_Disp : Form
    {
        Dispositivos1 disp = new Dispositivos1();

        public Frm_Reporte_Disp()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Disp_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular_datos_dispositivos();
        }
        private void Calcular_datos_dispositivos()
        {
            DataTable tabla = new DataTable();
            if (rB1.Checked)
            {
                tabla = disp.ReporteDispositivos_Todos(textBox01.Text.ToString());
                ArmarReporteDispositivosNuevos(tabla);
            }
            if (rB2.Checked)
            {
                tabla = disp.ReporteDispositivos_Marca(textBox02.Text.ToString());
                ArmarReporteDispositivosNuevos(tabla);
            }

            if (rB2.Checked == false && rB1.Checked == false)
            {
                MessageBox.Show("Elija algun parametro para la busqueda");
            }

        }
        private void ArmarReporteDispositivosNuevos(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet2", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Dispositivos.Reporte_Disp.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }

        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            textBox01.Enabled = true;
            textBox02.Enabled = false;
            textBox02.Clear();
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            textBox02.Enabled = true;
            textBox01.Enabled = false;
            textBox01.Clear();
        }
    }
}
