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

namespace ComunicAr.Formularios.Reportes.Clientes
{
    public partial class Reporte_para_Clientes : Form
    {
        DataTable table = new DataTable();
        ReporteCliente Rep_Cliente = new ReporteCliente();
        Reporte_Clientes_Prepago Rep_cliente_prepago = new Reporte_Clientes_Prepago();
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
            //this.reportViewer2.RefreshReport();
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
            ReportDataSource Datos = new ReportDataSource("DS_Rep_Clientes", table);
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
        
        // PESTANA CLIENTES PREPAGO
        private void btn_calcular_prepago_Click(object sender, EventArgs e)
        {
            Calcular_datos();
        }
        private void Calcular_datos()
        {
            DataTable tabla = new DataTable();
            if (rb_cantidad.Checked == true)
            {
                tabla = Rep_cliente_prepago.ReporteDatos_cantidadMayor(txt_cantidad.Text.ToString());
                ArmarReporte_Cliente_Prepago(tabla);
            }
            if (rb_todos.Checked == true)
            {
                tabla = Rep_cliente_prepago.ReporteDatos_todos();
                ArmarReporte_Cliente_Prepago(tabla);
            }
            if (rb_cantidad.Checked == false && rb_todos.Checked == false)
            {
                MessageBox.Show("Seleccione una opcion para filtrar");
            }
        }
        private void ArmarReporte_Cliente_Prepago(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DS_Rep_Clientes_Prepago", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Clientes.Rep_Clientes_Prepago.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }
        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            txt_cantidad.Enabled = false;
            txt_cantidad.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
