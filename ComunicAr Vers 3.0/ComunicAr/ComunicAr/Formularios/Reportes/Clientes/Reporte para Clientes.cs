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
        ReporteCliente Rep_Cliente = new ReporteCliente();
        public Reporte_para_Clientes()
        {
            InitializeComponent();
        }

        private void Reporte_para_Clientes_Load(object sender, EventArgs e)
        {
            this.rv_cliente_clientes.RefreshReport();
            this.rv_cliente_clientesXtipoDispositivo.RefreshReport();
            cmb_report_clienteXdispo_tipoDispo.CargarCombo();
            //cmb_report_clienteXdispo_tipoDispo.SelectedIndex = -1;
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
                table = Rep_Cliente.SearchClientes_comienzo(txt_reporte_cliente_letras.Text);
            }
            if (rb_cliente_clientes_02.Checked == true)
            {
                table = Rep_Cliente.SearchClientes_wherever(txt_reporte_cliente_letras.Text);
            }
            if (rb_cliente_clientes_03.Checked == true)
            {
                table = Rep_Cliente.SearchClientes_todos();
            }
        }
        private void ArmarReporteClientes()
        {
            ReportDataSource Datos = new ReportDataSource("DS_List_clienteXmodelo", table);
            rv_cliente_clientes.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Clientes.ReportCliente.rdlc";
            rv_cliente_clientes.LocalReport.DataSources.Clear();
            rv_cliente_clientes.LocalReport.DataSources.Add(Datos);
            rv_cliente_clientes.RefreshReport();
        }
        private void cmb_report_clienteXdispo_tipoDispo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_report_clienteXdispo_marcaDispo.CargarComboDisp(int.Parse(cmb_report_clienteXdispo_tipoDispo.SelectedValue.ToString()));
        }

        private void cmb_report_clienteXdispo_marcaDispo_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_report_clienteXdispo_modeloDispo.CargarComboDispMej(int.Parse(cmb_report_clienteXdispo_tipoDispo.SelectedValue.ToString()), 
                                                                              cmb_report_clienteXdispo_marcaDispo.SelectedValue.ToString());
        }

        private void btn_reporte_clienteXmodelo_cargar_Click(object sender, EventArgs e)
        {
            CargarTablaClienteXmodelo();
            ArmarReporteClientesXmodelo();
        }
        private void CargarTablaClienteXmodelo()
        {
            string tipo = cmb_report_clienteXdispo_modeloDispo.SelectedValue.ToString();
            table = Rep_Cliente.SearchClientesXmodeloDispositivo(tipo);
            MessageBox.Show("Filas de tabla = " + table.Rows.Count.ToString());
        }
        private void ArmarReporteClientesXmodelo()
        {
            ReportDataSource clienteXmodelo = new ReportDataSource("DS_List_clienteXmodelo", table);
            rv_cliente_clientesXtipoDispositivo.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Clientes.ReportClientexModDispo.rdlc";
            rv_cliente_clientesXtipoDispositivo.LocalReport.DataSources.Clear();
            rv_cliente_clientesXtipoDispositivo.LocalReport.DataSources.Add(clienteXmodelo);
            rv_cliente_clientesXtipoDispositivo.RefreshReport();
        }
    }
}
