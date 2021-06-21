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

namespace ComunicAr.Formularios.Estadisticas.Servicios
{
    public partial class Frm_Servicios_Estadisiticas : Form
    {
        bool flag = true;
        public Frm_Servicios_Estadisiticas()
        {
            InitializeComponent();
        }

        private void Frm_Servicios_Estadisiticas_Load(object sender, EventArgs e)
        {
            this.rv01_Servicios.RefreshReport();
            this.rv02_Serv.RefreshReport();
            chequeable();
        }
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////PACKS VENDIDOS POR MES SEGUN AÑO////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        private void btn_calcular_serv_Click_1(object sender, EventArgs e)
        {

            CalcularRporte();
        }
        public void CalcularRporte()
        {
            if(string.IsNullOrEmpty(txt_year_S.Text) ^ txt_year_S.Text == "AAAA")
            {
                MessageBox.Show("Porfavor selelccione un año a buscar.");
                flag = false;
            }
            else
            {
                DataTable tabla = new DataTable();
                int year = int.Parse(txt_year_S.Text.ToString());
                Packs_Vendidos prepago = new Packs_Vendidos();
                tabla = prepago.PacksDatosXAño(year);
                ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                rv01_Servicios.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Servicios.Reporte_Packs.rdlc";
                rv01_Servicios.LocalReport.DataSources.Clear();
                rv01_Servicios.LocalReport.DataSources.Add(PaqueteDatos);
                rv01_Servicios.RefreshReport();
            }
        }
        private void txt_year_S_Click(object sender, EventArgs e)
        {
            txt_year_S.Clear();

        }
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////PACKS VENDIDOS POR MES /////////////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void txt_Desde_Mes_Click(object sender, EventArgs e)
        {
            txt_desde_mes.Clear();
        }

        private void txt_Hasta_Mes_Click(object sender, EventArgs e)
        {
            txt_hasta_mes.Clear();
        }

        private void txt_hasta_year_Click(object sender, EventArgs e)
        {
            txt_hasta_year.Clear();
        }

        private void txt_desde_year_Click(object sender, EventArgs e)
        {
            txt_desde_year.Clear();

        }

        private void txt_mes_Click(object sender, EventArgs e)
        {
            txt_mes.Clear();
        }

        private void txt_year_Click(object sender, EventArgs e)
        {
            txt_year.Clear();

        }

        private void btn_Calcular_S_Click(object sender, EventArgs e)
        {
            Calcular_Rep_Servicios();
        }

        private void rb_intervalo_CheckedChanged(object sender, EventArgs e)
        {
            txt_hasta_year.Enabled = true;
            txt_hasta_mes.Enabled = true;
            txt_desde_mes.Enabled = true;
            txt_desde_year.Enabled = true;
            txt_year.Enabled = false;
            txt_mes.Enabled = false;

        }
        private void chequeable()
        {
            if(rb_intervalo.Checked == false & rb_mes.Checked == false)
            {
                txt_hasta_year.Enabled = false;
                txt_hasta_mes.Enabled = false;
                txt_desde_mes.Enabled = false;
                txt_desde_year.Enabled = false;
                txt_year.Enabled = false;
                txt_mes.Enabled = false;
            }
        }
        private void rb_mes_CheckedChanged(object sender, EventArgs e)
        {
            txt_hasta_year.Enabled = false;
            txt_hasta_mes.Enabled = false;
            txt_desde_mes.Enabled = false;
            txt_desde_year.Enabled = false;
            txt_year.Enabled = true;
            txt_mes.Enabled = true;
        }
        private void Calcular_Rep_Servicios()
        {
            if(rb_intervalo.Checked== true)
            {
                flag = true;
                if (string.IsNullOrEmpty(txt_desde_mes.Text) | string.IsNullOrEmpty(txt_desde_year.Text)|string.IsNullOrEmpty(txt_hasta_mes.Text)|string.IsNullOrEmpty(txt_hasta_year.Text))
                {

                    MessageBox.Show("Porfavor complete los datos a buscar.");
                    flag = false;
                }
                if(txt_desde_mes.Text == "MM" | txt_hasta_mes.Text == "MM" | txt_hasta_year.Text == "AAAA" | txt_desde_year.Text == "AAAA")
                {
                    MessageBox.Show("Porfavor complete los datos a buscar.");
                    flag = false;
                }
                if(flag == true)
                {
                    int D_Mes = int.Parse(txt_desde_mes.Text.ToString());
                    int D_Year = int.Parse(txt_desde_year.Text.ToString());
                    int H_Mes = int.Parse(txt_hasta_mes.Text.ToString());
                    int H_year = int.Parse(txt_hasta_year.Text.ToString());

                    DataTable tabla = new DataTable();
                    Packs_Vendidos servicios = new Packs_Vendidos();
                    tabla = servicios.ServiciosXIntervalo(D_Mes, D_Year, H_Mes, H_year);
                    ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                    rv02_Serv.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Servicios.ReporteServiciosXmes.rdlc";
                    rv02_Serv.LocalReport.DataSources.Clear();
                    rv02_Serv.LocalReport.DataSources.Add(PaqueteDatos);
                    rv02_Serv.RefreshReport();
                    
                        
                    
                }

            }
            if(rb_mes.Checked == true)
            {
                flag = true;
                if (string.IsNullOrEmpty(txt_mes.Text) | string.IsNullOrEmpty(txt_year.Text))
                {
                    MessageBox.Show("Porfavor complete los datos a buscar.");
                    flag = false;
                }
                if (txt_year.Text == "AAAA" | txt_mes.Text == "MM")
                {
                    MessageBox.Show("Porfavor complete los datos a buscar.");
                    flag = false;
                }
                else
                {
                    int mes = int.Parse(txt_mes.Text.ToString());
                    int year = int.Parse(txt_year.Text.ToString());
                    DataTable tabla = new DataTable();
                    Packs_Vendidos servicios = new Packs_Vendidos();
                    tabla = servicios.ServiciosXmes(mes, year);
                    ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                    rv02_Serv.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Servicios.ReporteServiciosXmes.rdlc";
                    rv02_Serv.LocalReport.DataSources.Clear();
                    rv02_Serv.LocalReport.DataSources.Add(PaqueteDatos);
                    rv02_Serv.RefreshReport();
                    
                        
                    
                }
            }
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void rv01_Servicios_Load(object sender, EventArgs e)
        {

        }
    }
}
