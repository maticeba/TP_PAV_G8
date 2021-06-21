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
            
            cmb_tipoDisp.CargarCombo();
            cmb_tipoDisp.SelectedIndex = -1;
            cmb_Marca.Marca();
            cmb_Marca.SelectedIndex = -1;
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
                if (txtMes.TextLength == 0 || txtYear.TextLength == 0)
                {
                    MessageBox.Show("Rellene los campos Correctamente");
                }
                else
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
                if (cmb_CodNacional.SelectedIndex == -1)
                {
                    MessageBox.Show("Rellene los campos Correctamente");
                }
                else
                {
                    tabla = dispv.DispxServicioCodN(Convert.ToInt32(cmb_CodNacional.Text));
                    ReportDataSource paqueteDatos = new ReportDataSource("DataSet1", tabla);
                    reportViewer2.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Dispositivos.ReporteDispxServ.rdlc";
                    reportViewer2.LocalReport.DataSources.Clear();
                    reportViewer2.LocalReport.DataSources.Add(paqueteDatos);
                    reportViewer2.RefreshReport();
                }
            }
            if (radioButton3.Checked)
            {

                tabla = dispv.DispxServicio();
                ReportDataSource paqueteDatos = new ReportDataSource("DataSet1", tabla);
                reportViewer2.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Dispositivos.ReporteDispxServ.rdlc";
                reportViewer2.LocalReport.DataSources.Clear();
                reportViewer2.LocalReport.DataSources.Add(paqueteDatos);
                reportViewer2.RefreshReport();
            }
            if (radioButton5.Checked)
            {
                if (txt_cliente.Text.Length == 0)
                {
                    MessageBox.Show("Rellene los campos Correctamente");
                }
                else
                {
                    tabla = dispv.DispxServicioCliente(Convert.ToInt32(txt_cliente.Text));
                    ReportDataSource paqueteDatos = new ReportDataSource("DataSet1", tabla);
                    reportViewer2.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Dispositivos.ReporteDispxServ.rdlc";
                    reportViewer2.LocalReport.DataSources.Clear();
                    reportViewer2.LocalReport.DataSources.Add(paqueteDatos);
                    reportViewer2.RefreshReport();
                }
            }
            if (radioButton6.Checked)
            {
                if (cmb_tipoDisp.SelectedIndex == -1)
                {
                    MessageBox.Show("Rellene los campos Correctamente");
                }
                else
                {
                    tabla = dispv.DispxServicioTipo(cmb_tipoDisp.SelectedIndex + 1);
                    ReportDataSource paqueteDatos = new ReportDataSource("DataSet1", tabla);
                    reportViewer2.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Dispositivos.ReporteDispxServ.rdlc";
                    reportViewer2.LocalReport.DataSources.Clear();
                    reportViewer2.LocalReport.DataSources.Add(paqueteDatos);
                    reportViewer2.RefreshReport();
                }
            }

            if (radioButton7.Checked)
            {
                if (cmb_Marca.SelectedIndex == -1)
                {
                    MessageBox.Show("Rellene los campos Correctamente");
                }
                else
                {
                    tabla = dispv.DispxServicioMarca(cmb_Marca.Text);
                    ReportDataSource paqueteDatos = new ReportDataSource("DataSet1", tabla);
                    reportViewer2.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Dispositivos.ReporteDispxServ.rdlc";
                    reportViewer2.LocalReport.DataSources.Clear();
                    reportViewer2.LocalReport.DataSources.Add(paqueteDatos);
                    reportViewer2.RefreshReport();
                }
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
            txtMes.Clear();
            txtYear.Clear();


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txtMes.Enabled = false;
            txtYear.Enabled = false;
            txtMes.Clear();
            txtYear.Clear();

            txtMes.Text = "MM";
            txtYear.Text = "YYYY";
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

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            cmb_CodNacional.Enabled = true;
            txt_cliente.Enabled = false;
            cmb_Marca.Enabled = false;
            cmb_tipoDisp.Enabled = false;

            txt_cliente.Clear();
            cmb_Marca.SelectedIndex = -1;
            cmb_tipoDisp.SelectedIndex = -1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            cmb_CodNacional.Enabled = false;
            txt_cliente.Enabled = true;
            cmb_Marca.Enabled = false;
            cmb_tipoDisp.Enabled = false;

            cmb_CodNacional.SelectedIndex = -1;
            cmb_Marca.SelectedIndex = -1;
            cmb_tipoDisp.SelectedIndex = -1;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            cmb_CodNacional.Enabled = false;
            txt_cliente.Enabled = false;
            cmb_Marca.Enabled = false;
            cmb_tipoDisp.Enabled = true;

            cmb_CodNacional.SelectedIndex = -1;
            cmb_Marca.SelectedIndex = -1;
            txt_cliente.Clear();
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            cmb_CodNacional.Enabled = false;
            txt_cliente.Enabled = false;
            cmb_Marca.Enabled = true;
            cmb_tipoDisp.Enabled = false;

            cmb_CodNacional.SelectedIndex = -1;
            cmb_tipoDisp.SelectedIndex = -1;
            txt_cliente.Clear();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            cmb_CodNacional.Enabled = false;
            txt_cliente.Enabled = false;
            cmb_Marca.Enabled = false;
            cmb_tipoDisp.Enabled = false;

            cmb_Marca.SelectedIndex = -1;
            cmb_CodNacional.SelectedIndex = -1;
            cmb_tipoDisp.SelectedIndex = -1;
            txt_cliente.Clear();
        }
    }
}
