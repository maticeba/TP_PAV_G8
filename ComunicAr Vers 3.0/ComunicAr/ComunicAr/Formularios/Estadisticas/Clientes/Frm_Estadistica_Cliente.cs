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
        public Frm_Estadistica_Cliente()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Cliente_Load(object sender, EventArgs e)
        {

            this.rv_estadistica_cliente_baja.RefreshReport();
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
    }
}
