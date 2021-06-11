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


namespace ComunicAr.Formularios.Estadisticas.Llamadas
{
    public partial class Frm_Llamadas_Estadisticas : Form
    {
        Tipo_Llamada tipo = new Tipo_Llamada();
        public Frm_Llamadas_Estadisticas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //LLAMADAS POR TIPO DE COMUNICACION
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Frm_Llamadas_Estadisticas_Load(object sender, EventArgs e)
        {

            this.rv_tipoLlamadas.RefreshReport();
            this.reportViewer2.RefreshReport();
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
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
