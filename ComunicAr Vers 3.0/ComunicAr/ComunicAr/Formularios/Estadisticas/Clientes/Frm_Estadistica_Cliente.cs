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
using ComunicAr.Negocio_Estadisticas;

namespace ComunicAr.Formularios.Estadisticas.Clientes
{
    public partial class Frm_Estadistica_Cliente : Form
    {
        Estadistica_cliente BU_cliente = new Estadistica_cliente();
        bool flag = true;
        public Frm_Estadistica_Cliente()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Cliente_Load(object sender, EventArgs e)
        {

            this.rv_estadistica_cliente_baja.RefreshReport();
            this.rv_Clien_Serv.RefreshReport();
            txt_ingresar_año.Enabled = false;
            txt_vigencia.Enabled = false;
            txt_fecha_alta.Enabled = false;
        }

        private void btn_estadistica_cliente_baja_calcular_Click(object sender, EventArgs e)
        {
            ReportDataSource dato = new ReportDataSource("DataSet1", BU_cliente.SearchClientes_baja(txt_estadistica_cliente_baja_año.Text));
            rv_estadistica_cliente_baja.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Clientes.Clientes dado de baja.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            parametros[0] = new ReportParameter("Rp01", "Año: " + txt_estadistica_cliente_baja_año.Text);
            rv_estadistica_cliente_baja.LocalReport.SetParameters(parametros);
            rv_estadistica_cliente_baja.LocalReport.DataSources.Clear();
            rv_estadistica_cliente_baja.LocalReport.DataSources.Add(dato);
            rv_estadistica_cliente_baja.RefreshReport();
        }
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///////////////////////////////////CLIENTES POR SERVICIO USADO////////////////////////////////////////////////
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void btn_calcular_C_Click(object sender, EventArgs e)
        {
            CalcularRporte();
        }
        public void CalcularRporte()
        {
            if (string.IsNullOrEmpty(txt_year_C.Text) ^ txt_year_C.Text == "AAAA")
            {
                MessageBox.Show("Porfavor selelccione un año a buscar.");
                flag = false;
            }
            else
            {
                DataTable tabla = new DataTable();
                int year = int.Parse(txt_year_C.Text.ToString());
                Packs_Vendidos prepago = new Packs_Vendidos();
                tabla = prepago.PacksDatosXAño(year);
                ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                rv_Clien_Serv.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Clientes.ClienteXServContratados.rdlc";
                rv_Clien_Serv.LocalReport.DataSources.Clear();
                rv_Clien_Serv.LocalReport.DataSources.Add(PaqueteDatos);
                rv_Clien_Serv.RefreshReport();
            }
        }
        private void txt_year_C_Click(object sender, EventArgs e)
        {
            txt_year_C.Clear();
        }
        /////////////////////////////////// CLIENTES POR PROVINCIA ////////////////////////////////////////////////
        private void ArmarReporte(DataTable tabla)
        {
            ReportDataSource dato = new ReportDataSource("DataSet1", tabla);
            rv_cliente_provincia.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Clientes.Clientes_por_provincia.rdlc";
            rv_cliente_provincia.LocalReport.DataSources.Clear();
            rv_cliente_provincia.LocalReport.DataSources.Add(dato);
            rv_cliente_provincia.RefreshReport();
        }
        private void rb_fecha_alta_CheckedChanged(object sender, EventArgs e)
        {
            txt_fecha_alta.Enabled = true;
        }

        private void rb_todas_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_fecha_alta.Enabled = false;
            txt_fecha_alta.Clear();

        }

        private void btn_cliente_provincia_Click_1(object sender, EventArgs e)
        {
            if (rb_todas.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = BU_cliente.Todas_provincias();
                ArmarReporte(tabla);
            }
            if (rb_fecha_alta.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = BU_cliente.fecha_alta(txt_fecha_alta.Text.ToString());
                ArmarReporte(tabla);
            }
        }
        ///////////////////////////////// CLIENTE POR SERVICIO /////////////////////////////////////////////
        private void rb_C_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_ingresar_año.Enabled = true;
            txt_vigencia.Enabled = false;
            txt_vigencia.Clear();
        }

        private void rb_between_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_ingresar_año.Enabled = false;
            txt_vigencia.Enabled = true;
            txt_ingresar_año.Clear();
        }

        private void rb_todos_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_ingresar_año.Enabled = false;
            txt_vigencia.Enabled = false;
            txt_ingresar_año.Clear();
            txt_vigencia.Clear();
        }
        private void ArmarReporteDatos(DataTable tabla)
        {
            ReportDataSource dato = new ReportDataSource("DataSet1", tabla);
            rv_cliente_servicio.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Clientes.Clientes_por_servicio.rdlc";
            rv_cliente_servicio.LocalReport.DataSources.Clear();
            rv_cliente_servicio.LocalReport.DataSources.Add(dato);
            rv_cliente_servicio.RefreshReport();
        }
        private void btn_cliente_servicio_Click_1(object sender, EventArgs e)
        {
            if (rb_C.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = BU_cliente.Servicio_en_un_año(Convert.ToInt32(txt_ingresar_año.Text));
                ArmarReporteDatos(tabla);
            }
            if (rb_between.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = BU_cliente.Servicio_en_alta_año(txt_vigencia.Text.ToString());
                ArmarReporteDatos(tabla);
            }
            if (rb_todos.Checked)
            {
                DataTable tabla = new DataTable();
                tabla = BU_cliente.Todos_clientes();
                ArmarReporteDatos(tabla);
            }
        }
    }
}
