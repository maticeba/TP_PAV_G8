using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Negocio_Listados;
using ComunicAr.Formularios.Reportes.DispVendidos;
using Microsoft.Reporting.WinForms;

namespace ComunicAr
{
    public partial class Frm_Reporte_Disp_Vendidos : Form
    {
        Dispositivos disp = new Dispositivos();
        public Frm_Reporte_Disp_Vendidos()
        {
            InitializeComponent();
        }

       
        private void Frm_Reporte_Disp_Vendidos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular_datos_dispositivosNuevos();
        }
        
        private void Calcular_datos_dispositivosNuevos()
        {
            DataTable tabla = new DataTable();
            tabla = disp.ReporteDispositivosVendidos_Todos();
            if (rB1.Checked)
            {
                
                ArmarReporteDispositivosNuevos(disp.ReporteDispositivosVendidos_PrecioEsp(textBox1.Text.ToString()));

            }
            if (rB2.Checked)
            {
                ArmarReporteDispositivosNuevos(disp.ReporteDispositivosVendidos_PrecioRango(textBox2.Text.ToString(), textBox4.Text.ToString()));
            }

            if (rB3.Checked)
            {
                ArmarReporteDispositivosNuevos(disp.ReporteDispositivosVendidos_MesEsp(textBox3.Text.ToString(), textBox5.Text.ToString()));
            }
           

        
        }
        
        private void ArmarReporteDispositivosNuevos (DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.DispVendidos.Reporte_DispVend.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rB1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            textBox5.Clear();
        }
        private void rB2_CheckedChanged_1(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = true;
            textBox3.Enabled = false;
            textBox4.Enabled = true;
            textBox5.Enabled = false;
            textBox1.Clear();
            textBox3.Clear();
            textBox5.Clear();

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = true;
            textBox4.Enabled = false;
            textBox5.Enabled = true;
            textBox1.Clear();
            textBox2.Clear();
            textBox4.Clear();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
