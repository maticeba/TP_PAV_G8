using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Negocio_Estadisticas;
using Microsoft.Reporting.WinForms;
using ComunicAr.Negocio;


namespace ComunicAr.Formularios.Estadisticas.Llamadas
{
    public partial class Frm_Llamadas_Estadisticas : Form
    {
        
        public Frm_Llamadas_Estadisticas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //LLAMADAS POR TIPO DE COMUNICACION
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Tipo_Llamada tipo = new Tipo_Llamada();
        private void Frm_Llamadas_Estadisticas_Load(object sender, EventArgs e)
        {

            this.rv_tipoLlamadas.RefreshReport();
            this.rv_llamadas.RefreshReport();
        }

        private void rb_mes_CheckedChanged(object sender, EventArgs e)
        {
            txt_año.Enabled = true;
            txt_mes.Enabled = true;
            btn_calcular.Enabled = true;
            txt_mesDesde.Enabled = false;
            txt_añoDesde.Enabled = false;
            txt_mesHasta.Enabled = false;
            txt_añoHasta.Enabled = false;

        }

        private void rb_rango_CheckedChanged(object sender, EventArgs e)
        {
            txt_año.Enabled = false;
            txt_mes.Enabled = false;
            btn_calcular.Enabled = true;
            txt_mesDesde.Enabled = true;
            txt_añoDesde.Enabled = true;
            txt_mesHasta.Enabled = true;
            txt_añoHasta.Enabled = true;
        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {
            txt_año.Enabled = false;
            txt_mes.Enabled = false;
            btn_calcular.Enabled = true;
            txt_mesDesde.Enabled = false;
            txt_añoDesde.Enabled = false;
            txt_mesHasta.Enabled = false;
            txt_añoHasta.Enabled = false;
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (rb_todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = tipo.Llamadas_tipo_Completas();
                ReportDataSource dato = new ReportDataSource("DataSet1", tabla);
                rv_tipoLlamadas.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Llamadas.Reporte_TipoComunicacion.rdlc";
                rv_tipoLlamadas.LocalReport.DataSources.Clear();
                rv_tipoLlamadas.LocalReport.DataSources.Add(dato);
                rv_tipoLlamadas.RefreshReport();
            }
            else if (rb_mes.Checked == true)
            {
                if (txt_mes.Text == "" || txt_año.Text=="")
                {
                    MessageBox.Show("Ingrese todos los datos solicitados");
                }
                else
                {
                    DataTable tabla = new DataTable();
                    tabla = tipo.Llamadas_tipo_mes(txt_mes.Text, txt_año.Text);
                    ReportDataSource dato = new ReportDataSource("DataSet1", tabla);
                    rv_tipoLlamadas.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Llamadas.Reporte_TipoComunicacion.rdlc";
                    rv_tipoLlamadas.LocalReport.DataSources.Clear();
                    rv_tipoLlamadas.LocalReport.DataSources.Add(dato);
                    rv_tipoLlamadas.RefreshReport();
                }

            }
            else if (rb_rango.Checked == true)
            {
                if (txt_mesDesde.Text == "" || txt_añoDesde.Text == "" || txt_mesHasta.Text == "" || txt_añoHasta.Text=="")
                {
                    MessageBox.Show("Ingrese todos los datos pedidos");
                }
                else
                {
                    DataTable tabla = new DataTable();
                    tabla = tipo.Llamadas_tipo_rango(txt_mesDesde.Text, txt_añoDesde.Text, txt_mesHasta.Text, txt_añoHasta.Text);
                    ReportDataSource dato = new ReportDataSource("DataSet1", tabla);
                    rv_tipoLlamadas.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Llamadas.Reporte_TipoComunicacion.rdlc";
                    rv_tipoLlamadas.LocalReport.DataSources.Clear();
                    rv_tipoLlamadas.LocalReport.DataSources.Add(dato);
                    rv_tipoLlamadas.RefreshReport(); 
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///TERMINA LLAMADAS POR TIPO DE COMUNICACION
        ///EMPIEZA LLAMADAS POR MES
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void rb_sin_CheckedChanged(object sender, EventArgs e)
        {
            txt_cliente2.Enabled = false;
            txt_año2.Enabled = true;
            btn_buscar.Visible = false;
            Calcular2.Enabled = true;

        }

        private void rb_cliente_CheckedChanged(object sender, EventArgs e)
        {
            txt_cliente2.Enabled = true;
            txt_año2.Enabled = true;
            btn_buscar.Visible = true;
            Calcular2.Enabled = false;
        }



        private void btn_buscar_Click(object sender, EventArgs e)
        {
            if (txt_cliente2.Text == "")
            {
                MessageBox.Show("Ingrese un número de cliente emisor");

            }
            else
            {
                Negocio.Llamadas llamadas = new Negocio.Llamadas();
                DataTable existEmisor = new DataTable();
                existEmisor = llamadas.Search_cliente(txt_cliente2.Text);
                if (existEmisor.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado el cliente buscado");
                }
                else
                {
                    string nombre = existEmisor.Rows[0]["nombre_razonSocial"].ToString();
                    MessageBox.Show("El cliente emisor es " + nombre);
                    Calcular2.Enabled = true;
                }
                
            }
        }

        private void Calcular2_Click(object sender, EventArgs e)
        {
            CantidadLlamadas cant_llam = new CantidadLlamadas(); 
            if (rb_sin.Checked == true)
            {
                if (txt_año2.Text != "")
                {
                    DataTable tabla = new DataTable();
                    tabla = cant_llam.Llamadas_sinFiltro(txt_año2.Text);
                    ReportDataSource dato = new ReportDataSource("DataSet1", tabla);
                    rv_llamadas.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Llamadas.ReporteLlamadas.rdlc";
                    rv_llamadas.LocalReport.DataSources.Clear();
                    rv_llamadas.LocalReport.DataSources.Add(dato);
                    rv_llamadas.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Ingrese el año");
                }
            }
            else if (rb_cliente.Checked == true)
            {
                if (txt_año2.Text != "")
                {
                    DataTable tabla = new DataTable();
                    tabla = cant_llam.Llamadas_Cliente(txt_año2.Text, txt_cliente2.Text);
                    ReportDataSource dato = new ReportDataSource("DataSet1", tabla);
                    rv_llamadas.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Llamadas.ReporteLlamadas.rdlc";
                    rv_llamadas.LocalReport.DataSources.Clear();
                    rv_llamadas.LocalReport.DataSources.Add(dato);
                    rv_llamadas.RefreshReport();
                }
                else
                {
                    MessageBox.Show("Ingrese el año");
                }

            }
        }
    }
}
