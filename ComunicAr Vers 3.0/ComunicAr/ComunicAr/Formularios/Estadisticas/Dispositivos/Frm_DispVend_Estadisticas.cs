using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Negocio_Estadisticas;
using Microsoft.Reporting.WinForms;

namespace ComunicAr.Formularios.Estadisticas.Dispositivos

{
    public partial class Frm_DispVend_Estadisticas : Form
    {
        int mes;
        int year;
        public Frm_DispVend_Estadisticas()
        {
            InitializeComponent();
        }

        private void Frm_DispVend_Estadisticas_Load(object sender, EventArgs e)
        {
            cmb_CodNacional.Codigo_Nacional();
            cmb_CodNacional.SelectedIndex = -1;
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void Calcular_DispVendidos()
        {
            DataTable tabla = new DataTable();
            DispVendidos dispv = new DispVendidos();
            if (radioButton2.Checked)
            {
                mes = Convert.ToInt32(txtMes.Text);
                year = Convert.ToInt32(txtYear.Text);

                tabla = dispv.DispVendxMes(mes, year);
                ReportDataSource paqueteDatos = new ReportDataSource("DataSet_Disp", tabla);
                reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Dispositivos.ReportDispVend.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(paqueteDatos);
                reportViewer1.RefreshReport();
            }
            if (radioButton1.Checked)
            {
                mes = DateTime.Now.Month;
                year = DateTime.Now.Year;

                tabla = dispv.DispVendxMes(mes, year);
                ReportDataSource paqueteDatos = new ReportDataSource("DataSet_Disp", tabla);
                reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Dispositivos.ReportDispVend.rdlc";
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(paqueteDatos);
                reportViewer1.RefreshReport();
            }
        }
        private void Calcular_DispxServ()
        {
            DataTable tabla = new DataTable();
            DispVendidos dispv = new DispVendidos();


            if (radioButton4.Checked)
            {
                tabla = dispv.DispxServicioCodN(Convert.ToInt32(cmb_CodNacional.Text));
                ReportDataSource paqueteDatos = new ReportDataSource("DataSet1", tabla);
                reportViewer2.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Dispositivos.ReporteDispxServ.rdlc";
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(paqueteDatos);
                reportViewer2.RefreshReport();
            }
            if (radioButton4.Checked)
            {
                tabla = dispv.DispxServicio();
                ReportDataSource paqueteDatos = new ReportDataSource("DataSet1", tabla);
                reportViewer2.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Dispositivos.ReporteDispxServ.rdlc";
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(paqueteDatos);
                reportViewer2.RefreshReport();
            }
            
            
        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular_DispVendidos();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txtMes.Enabled = true;
            txtYear.Enabled = true;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtMes.Enabled = false;
            txtYear.Enabled = false;
            txtMes.Clear();
            txtYear.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Calcular_DispxServ();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void DispositivosPorServicios_Click(object sender, EventArgs e)
        {

        }
    }
}
