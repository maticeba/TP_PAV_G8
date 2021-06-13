using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Negocio;
using ComunicAr.Negocio_Transacciones;
using Microsoft.Reporting.WinForms;

namespace ComunicAr.Formularios
{
    public partial class Frm_Reporte_Facturas : Form
    {
        public Frm_Reporte_Facturas()
        {
            InitializeComponent();
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_numeros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Datos_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rb_limite_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_Costo_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void btn_calcular_prepago_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calcular_Fact_Click(object sender, EventArgs e)
        {
            calcular_Factura_Monto();

        }
        private void rb03_Fact_CheckedChanged(object sender, EventArgs e)
        {
            txt_Fact_Desde.Enabled = false;
            txt_Fact_Hasta.Enabled = false;

        }
        private void rb02_Fact_CheckedChanged(object sender, EventArgs e)
        {
            txt_Fact_Desde.Enabled = true;
            txt_Fact_Hasta.Enabled = true;

        }
        private void calcular_Factura_Monto()
        {
            bool flag = true;
            DataTable tabla = new DataTable();
            Emitir_Factura monto = new Emitir_Factura();

            if (rb03_Fact.Checked == true)
            {
                tabla = monto.MontoFactura();
                ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                rv01_Fact.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Facturas.Reporte_Fact_Monto.rdlc";
                rv01_Fact.LocalReport.DataSources.Clear();
                rv01_Fact.LocalReport.DataSources.Add(PaqueteDatos);
                rv01_Fact.RefreshReport();
            }

            if (rb02_Fact.Checked == true)
            {
                flag = true;
                if (string.IsNullOrEmpty(txt_Fact_Desde.Text) && string.IsNullOrEmpty(txt_Fact_Hasta.Text))
                {
                    MessageBox.Show("Debe completar la informacion");
                    flag = false;
                }
                else
                {
                    if (string.IsNullOrEmpty(txt_Fact_Desde.Text))
                    {
                        int hasta = int.Parse(txt_Fact_Hasta.Text);
                        tabla = monto.MontoFacturaMM(hasta, ">");
                        ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                        rv01_Fact.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Facturas.Reporte_Fact_Monto.rdlc";
                        rv01_Fact.LocalReport.DataSources.Clear();
                        rv01_Fact.LocalReport.DataSources.Add(PaqueteDatos);
                        rv01_Fact.RefreshReport();
                        flag = false;
                    }
                    if (string.IsNullOrEmpty(txt_Fact_Hasta.Text))
                    {
                        int desde = int.Parse(txt_Fact_Desde.Text);
                        tabla = monto.MontoFacturaMM(desde, "<");
                        ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                        rv01_Fact.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Facturas.Reporte_Fact_Monto.rdlc";
                        rv01_Fact.LocalReport.DataSources.Clear();
                        rv01_Fact.LocalReport.DataSources.Add(PaqueteDatos);
                        rv01_Fact.RefreshReport();
                        flag = false;
                    }
                }
                
                if (flag == true)
                {
                    int desde = int.Parse(txt_Fact_Desde.Text);
                    int hasta = int.Parse(txt_Fact_Hasta.Text);
                    tabla = monto.MontoFacturaentre(desde,hasta);
                    ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                    rv01_Fact.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Facturas.Reporte_Fact_Monto.rdlc";
                    rv01_Fact.LocalReport.DataSources.Clear();
                    rv01_Fact.LocalReport.DataSources.Add(PaqueteDatos);
                    rv01_Fact.RefreshReport();
                }

            }

        }
    }
}
