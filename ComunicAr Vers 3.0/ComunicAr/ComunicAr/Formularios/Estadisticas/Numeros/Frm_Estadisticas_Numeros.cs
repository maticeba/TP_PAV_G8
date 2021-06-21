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

namespace ComunicAr.Formularios.Estadisticas.Numeros
{
    public partial class Frm_Estadisticas_Numeros : Form
    {
        private bool flag { get; set; }
        private string año { get; set; }
        private string mes { get; set; }
        Estadistica_Nros BU_nros = new Estadistica_Nros();
        public Frm_Estadisticas_Numeros()
        {
            InitializeComponent();
        }

        private void Frm_Estadisticas_Numeros_Load(object sender, EventArgs e)
        {

            this.rv_estadistica_nros_baja.RefreshReport();
        }

        private void rdBtn_estadistica_nro_bajas_año_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn_estadistica_nro_bajas_año.Checked == true)
            {
                txt_estad_nro_baja_mes.Enabled = false;
                flag = true;
            }
        }

        private void rdBtn_estadistica_nro_bajas_mes_CheckedChanged(object sender, EventArgs e)
        {
            if (rdBtn_estadistica_nro_bajas_mes.Checked == true)
            {
                txt_estad_nro_baja_mes.Enabled = true;
                flag = false;
            }
        }

        private void btn_estad_nro_baja_cargar_Click(object sender, EventArgs e)
        {
            DateTime actual = new DateTime();
            if (txt_estad_nro_baja_año.Text == "")
            {
                año = actual.Year.ToString();
            }
            else
            {
                año = txt_estad_nro_baja_año.Text;
            }
            if (txt_estad_nro_baja_mes.Text == "")
            {
                mes = actual.Month.ToString();
            }
            else
            {
                mes = txt_estad_nro_baja_mes.Text;
            }
            ReportDataSource dato = new ReportDataSource("DS_nros_baja", BU_nros.SearchNro_baja(año, mes, flag));

            rv_estadistica_nros_baja.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Estadisticas.Numeros.Estadistica_Numeros_bajas.rdlc";
            ReportParameter[] parametros = new ReportParameter[1];
            if (flag == true)
            {
                parametros[0] = new ReportParameter("Rp01", "Año: " + año);
            }
            else
            {
                string nombre_mes = BU_nros.mes(mes);
                parametros[0] = new ReportParameter("Rp01", "Año: " + año + " - Mes: " + nombre_mes);
            }
            rv_estadistica_nros_baja.LocalReport.SetParameters(parametros);
            rv_estadistica_nros_baja.LocalReport.DataSources.Clear();
            rv_estadistica_nros_baja.LocalReport.DataSources.Add(dato);
            rv_estadistica_nros_baja.RefreshReport();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            rdBtn_estadistica_nro_bajas_año.Checked = true;
        }
    }
}
