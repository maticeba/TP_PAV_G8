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

namespace ComunicAr.Formularios.Reportes.Datos
{
    public partial class Frm_Rep_Datos : Form
    {
        Reporte_Datos datos = new Reporte_Datos();
        public Frm_Rep_Datos()
        {
            InitializeComponent();
        }

        private void Frm_Rep_Datos_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
        private void Calcular_datos()
        {
            DataTable tabla = new DataTable();
            if (rb_Costo.Checked == true)
            {
                tabla = datos.ReporteDatos_limitecosto(textBox011.Text.ToString());
                ArmarReporteDatos(tabla);
            }
            if (rb_limite.Checked == true)
            {
                tabla = datos.ReporteDatos_limitedatos(textBox012.Text.ToString());
                ArmarReporteDatos(tabla);
            }
            if (rb_todos2.Checked == true)
            {
                tabla = datos.ReporteDatos_todos();
                ArmarReporteDatos(tabla);
            }
            if (rb_Costo.Checked == false && rb_limite.Checked == false && rb_todos2.Checked == false)
            {
                MessageBox.Show("Elija un parametro para la busqueda");
            }
        }
        private void ArmarReporteDatos(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DS_Rep_Datos", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Datos.Reporte_Datos.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void rb_limite_CheckedChanged(object sender, EventArgs e)
        {
            textBox011.Enabled = false;
            textBox012.Enabled = true;
            textBox012.Clear();
            textBox011.Clear();
        }

        private void rb_Costo_CheckedChanged(object sender, EventArgs e)
        {
            textBox011.Enabled = true;
            textBox012.Enabled = false;
            textBox011.Clear();
            textBox012.Clear();
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            textBox011.Enabled = false;
            textBox012.Enabled = false;
            textBox011.Clear();
            textBox012.Clear();

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Calcular_datos();
        }
    }
}
