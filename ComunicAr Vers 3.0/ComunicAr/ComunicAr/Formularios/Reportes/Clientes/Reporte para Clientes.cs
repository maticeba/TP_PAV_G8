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

namespace ComunicAr.Formularios.Reportes.Clientes
{
    public partial class Reporte_para_Clientes : Form
    {
        DataTable table = new DataTable();
        public Reporte_para_Clientes()
        {
            InitializeComponent();
        }

        private void Reporte_para_Clientes_Load(object sender, EventArgs e)
        {

            this.rv_cliente_clientes.RefreshReport();
        }

        private void btn_reporte_cliente_cargar_Click(object sender, EventArgs e)
        {
            CargarTablaCliente();
            ArmarReporteClientes();
        }
        private void CargarTablaCliente()
        {
            if (rb_cliente_clientes_01.Checked == true)
            {
                ReporteCliente Rep_Cliente = new ReporteCliente();
                table = Rep_Cliente.SearchClientes_comienzo(txt_reporte_cliente_letras.Text);

            }
            if (rb_cliente_clientes_02.Checked == true)
            {
                ReporteCliente Rep_Cliente = new ReporteCliente();
                table = Rep_Cliente.SearchClientes_wherever(txt_reporte_cliente_letras.Text);

            }
            if (rb_cliente_clientes_03.Checked == true)
            {
                ReporteCliente Rep_Cliente = new ReporteCliente();
                table = Rep_Cliente.SearchClientes_todos();
            }
        }
        private void ArmarReporteClientes()
        {
            ReportDataSource Datos = new ReportDataSource("DS_Rep_Clientes", table);
            rv_cliente_clientes.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Clientes.ReportCliente.rdlc";
            rv_cliente_clientes.LocalReport.DataSources.Clear();
            rv_cliente_clientes.LocalReport.DataSources.Add(Datos);
            rv_cliente_clientes.RefreshReport();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
