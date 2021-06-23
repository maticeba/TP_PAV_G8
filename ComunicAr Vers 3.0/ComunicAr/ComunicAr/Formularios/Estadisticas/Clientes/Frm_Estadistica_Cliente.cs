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
    }
}
