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

namespace ComunicAr.Formularios.Reportes.Servicios
{
    public partial class Frm_Rep_Servicios : Form
    {
        Reporte_Datos datos = new Reporte_Datos();
        public Frm_Rep_Servicios()
        {
            InitializeComponent();
        }
        private void Calcular_datos()
        {
            DataTable tabla = new DataTable();
            if (rb_Costo.Checked == true)
            {
                tabla = datos.ReporteDatos_limitecosto(txt_costo.Text.ToString());
                ArmarReporteDatos(tabla);
            }
            if (rb_limite.Checked == true)
            {
                tabla = datos.ReporteDatos_limitedatos(txt_limite.Text.ToString());
                ArmarReporteDatos(tabla);
            }
            if (rb_todos.Checked == true)
            {
                tabla = datos.ReporteDatos_todos();
                ArmarReporteDatos(tabla);
            }
            if (rb_Costo.Checked == false && rb_limite.Checked == false && rb_todos.Checked == false)
            {
                MessageBox.Show("Elija un parametro para la busqueda");
            }
        }
        private void ArmarReporteDatos(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DS_Rep_Datos", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Servicios.Reporte_Datos.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }
        private void Frm_Rep_Servicios_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void rb_Costo_CheckedChanged(object sender, EventArgs e)
        {
            txt_costo.Enabled = true;
            txt_limite.Enabled = false;
            txt_costo.Clear();
            txt_limite.Clear();
        }

        private void rb_limite_CheckedChanged(object sender, EventArgs e)
        {
            txt_costo.Enabled = false;
            txt_limite.Enabled = true;
            txt_limite.Clear();
            txt_costo.Clear();
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            txt_costo.Enabled = false;
            txt_limite.Enabled = false;
            txt_limite.Clear();
            txt_costo.Clear();
        }

        private void btn_Calcular_Datos_Click(object sender, EventArgs e)
        {
            Calcular_datos();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
