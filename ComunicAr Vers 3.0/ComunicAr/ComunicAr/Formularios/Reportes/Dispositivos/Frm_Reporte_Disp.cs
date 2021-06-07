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
using ComunicAr.Clases;

namespace ComunicAr.Formularios.Reportes.Dispositivos
{
    public partial class Frm_Reporte_Disp : Form
    {
        Dispositivos1 disp = new Dispositivos1();
        Dispositivos2 disp2 = new Dispositivos2();
        Acceso_BD BD = new Acceso_BD();
        string Mes;
        int precioMax;

        public Frm_Reporte_Disp()
        {
            InitializeComponent();
        }

        private void Frm_Reporte_Disp_Load(object sender, EventArgs e)
        {
            comboBox011.CargarCombo();
            comboBox011.SelectedIndex = -1;
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular_datos_dispositivos();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Calcular_datos_dispositivosNuevos();
        }
        private void Calcular_datos_dispositivos()
        {
            DataTable tabla = new DataTable();
            if (rB1.Checked)
            {
                if (textBox01.TextLength == 0)
                {
                    tabla = disp.ReporteDispositivos_Todos(Convert.ToString(DateTime.Now));
                    MessageBox.Show("Se uso como parametro la fecha actual para la busqueda");
                }
                else
                {
                    tabla = disp.ReporteDispositivos_Todos(textBox01.Text.ToString());     
                }
                ArmarReporteDispositivosNuevos(tabla);
            }
            if (rB2.Checked)
            {
                tabla = disp.ReporteDispositivos_Marca(comboBox011.SelectedText.ToString());
                ArmarReporteDispositivosNuevos(tabla);
            }

            if (rB2.Checked == false && rB1.Checked == false)
            {
                tabla = disp.ReporteDispositivos_Todos(Convert.ToString(DateTime.Now));
                ArmarReporteDispositivosNuevos(tabla);
                MessageBox.Show("Se uso como parametro la fecha actual para la busqueda");
            }

        }
        private void Calcular_datos_dispositivosNuevos()
        {
            DataTable tabla = new DataTable();
            tabla = disp2.ReporteDispositivosVendidos_Todos();
            if (rB3.Checked)
            {
                if (textBox03.TextLength > 0)
                {
                    ArmarReporteDispositivosNuevos1(disp2.ReporteDispositivosVendidos_PrecioEsp(textBox03.Text.ToString()));
                }
                else
                {
                    MessageBox.Show("No se esta cargando el precio");
                }
            }
            if (rB4.Checked)
            {
                if(textBox04.TextLength == 0)
                {
                    textBox04.SelectedText = "0";
                }
                if(textBox05.TextLength == 0)
                {
                    string sql = "SELECT DISTINCT precio FROM Dispositivos ORDER BY precio DESC";
                    DataTable tabla1 = new DataTable();
                    tabla1 = BD.EjecutarSelect(sql);
                    precioMax = Convert.ToInt32(tabla1.Rows[0]["precio"]);
                    textBox05.SelectedText = precioMax.ToString();
                }
                
                ArmarReporteDispositivosNuevos1(disp2.ReporteDispositivosVendidos_PrecioRango(Convert.ToInt32(textBox04.Text), Convert.ToInt32(textBox05.Text)));
            }

            if (rB5.Checked)
            {
                if (textBox06.TextLength > 0 && textBox07.TextLength > 0)
                {
                    ArmarReporteDispositivosNuevos1(disp2.ReporteDispositivosVendidos_MesEsp(textBox06.Text.ToString(), textBox07.Text.ToString()));
                }
                if (textBox06.TextLength == 0 && textBox07.TextLength == 0)
                {
                    DateTime fechaActual = DateTime.Today;
                    MessageBox.Show("Se uso como parametro la fecha actual para la busqueda");
                    if ((fechaActual.Month) < 10)
                    {
                        Mes = "0" + fechaActual.Month.ToString();
                    }

                    else
                    {
                        Mes = fechaActual.Month.ToString();
                    }

                   
                    ArmarReporteDispositivosNuevos1(disp2.ReporteDispositivosVendidos_MesEsp(Mes, fechaActual.Year.ToString()));
                }

                if (textBox06.TextLength == 0 && textBox07.TextLength > 0)
                {
                    MessageBox.Show("Falta insertar el mes que se desea");
                }

                if (textBox06.TextLength > 0 && textBox07.TextLength == 0)
                {
                    MessageBox.Show("Falta insertar el año que se desea");
                }



            }



        }

        private void ArmarReporteDispositivosNuevos1(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            reportViewer2.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Dispositivos.Reporte_DispVend.rdlc";
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer2.RefreshReport();
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
            comboBox011.Enabled = false;
            comboBox011.SelectedIndex = -1;
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox011.Enabled = true;
            textBox01.Enabled = false;
            textBox01.Clear();
        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }

        private void rB3_CheckedChanged(object sender, EventArgs e)
        {
            textBox03.Enabled = true;
            textBox04.Enabled = false;
            textBox05.Enabled = false;
            textBox06.Enabled = false;
            textBox07.Enabled = false;
            textBox04.Clear();
            textBox05.Clear();
            textBox06.Clear();
            textBox07.Clear();
        }
        private void rB4_CheckedChanged(object sender, EventArgs e)
        {
            textBox03.Enabled = false;
            textBox04.Enabled = true;
            textBox05.Enabled = true;
            textBox06.Enabled = false;
            textBox07.Enabled = false;
            textBox03.Clear();        
            textBox06.Clear();
            textBox07.Clear();

        } 
        private void rB5_CheckedChanged(object sender, EventArgs e)
        {
            textBox03.Enabled = false;
            textBox04.Enabled = false;
            textBox05.Enabled = false;
            textBox06.Enabled = true;
            textBox07.Enabled = true;
            textBox04.Clear();
            textBox05.Clear();
            textBox03.Clear();

        }
        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
          
            
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
          
        }

        private void tabPage1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
