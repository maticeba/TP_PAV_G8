using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Reporting.WinForms;
using System.Windows.Forms;
using ComunicAr.Negocio_Listados;

namespace ComunicAr.Formularios.Reportes.Clientes_Prepago
{
    public partial class Frm_Rep_Clientes_Prepago : Form
    {
        Reporte_Clientes_Prepago clientes = new Reporte_Clientes_Prepago();
        public Frm_Rep_Clientes_Prepago()
        {
            InitializeComponent();
        }

        private void Frm_Rep_Clientes_Prepago_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void rB2_CheckedChanged(object sender, EventArgs e)
        {
            textBox011.Enabled = false;
            textBox011.Clear();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calcular_datos();
        }
        private void Calcular_datos()
        {
            DataTable tabla = new DataTable();
            if (rB1.Checked == true)
            {
                tabla = clientes.ReporteDatos_cantidadMayor(textBox011.Text.ToString());
                ArmarReporteDatos(tabla);
            }
            if (rB2.Checked == true)
            {
                tabla = clientes.ReporteDatos_todos();
                ArmarReporteDatos(tabla);
            }
            if (rB1.Checked == false && rB2.Checked == false) 
            {
                MessageBox.Show("Weleccione una opcion para filtrar");
            }

        }
        private void ArmarReporteDatos(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DS_Rep_Clientes_Prepago", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Clientes_Prepago.Report1.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }
    }
}
