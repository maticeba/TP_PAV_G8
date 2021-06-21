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
        ReporteLlamada Rep_Llamada = new ReporteLlamada();
      
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Reporte_Llamadas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            
            this.reportViewer2.RefreshReport();
        }
       // calcular datos de llamda
        private void calcular_Llamadas()
        {
            DataTable tabla = new DataTable();
            if(rdbtn_Cliente.Checked==true)
            {
                ArmarReporteLlamadasxFecha(Rep_Llamada.ReporteLlamadaCliente(textBox011.Text));
            }
            if (rdbtn_Todos.Checked == true)
            {
                tabla = Rep_Llamada.Reportellamadas_todos();
                ArmarReporteLlamadasxFecha(tabla);
            }
            if (rdbtn_PorFecha.Checked==true)
            {
                ArmarReporteLlamadasxFecha(Rep_Llamada.ReporteLlamadaFecha(textBox012.Text,textBox013.Text));
            }


        }

        public void ArmarReporteLlamadasxFecha(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Llamada.ReporteLlamadaxfecha.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();

        }

        private void btn_Calcular_Click(object sender, EventArgs e)
        {
            
            calcular_Llamadas();
        }

        private void rdbtn_Todos_CheckedChanged(object sender, EventArgs e)
        {
            textBox011.Enabled = false;
            textBox012.Enabled = false;
            textBox013.Enabled = false;
            btn_buscar.Enabled = false;
            btn_Calcular.Enabled = true;
            textBox011.Clear();
            textBox012.Clear();
            textBox013.Clear();
            
        }

        private void rdbtn_PorFecha_CheckedChanged(object sender, EventArgs e)
        {
            btn_buscar.Enabled = false;
            textBox011.Enabled = false;
            textBox012.Enabled = true;
            textBox013.Enabled = true;
            btn_Calcular.Enabled = true;
            textBox011.Clear();
            textBox012.Clear();
            textBox013.Clear();

        }

        private void rdbtn_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            btn_buscar.Enabled = true;
            textBox011.Enabled = true;
            textBox012.Enabled = false;
            textBox013.Enabled = false;
            btn_Calcular.Enabled = true;
            textBox011.Clear();
            textBox012.Clear();
            textBox013.Clear();

        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (textBox011.Text == "")
            {
                MessageBox.Show("Ingrese un numero de cliente emisor");

            }
            else
            {
                ReporteLlamada rep_llamada = new ReporteLlamada();
                DataTable existeEmisor = new DataTable();
                existeEmisor = rep_llamada.Buscar_cliente(textBox011.Text);
                if (existeEmisor.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado el cliente buscado");
                }
                else
                {
                    string nombre = existeEmisor.Rows[0]["nombre_razonSocial"].ToString();
                    MessageBox.Show("El cliente emisor es " + nombre);

                }
                btn_Calcular.Enabled = true;
            }
        }
    }
}
