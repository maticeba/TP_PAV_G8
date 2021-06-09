using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Clases;
using Microsoft.Reporting.WinForms;
using ComunicAr.Negocio_Reportes;

namespace ComunicAr.Formularios.Reportes.Numeros
{
    public partial class Reporte_para_Numeros : Form
    {

        public Reporte_para_Numeros()
        {
            InitializeComponent();
        }

        private void Reporte_para_Numeros_Load(object sender, EventArgs e)
        {
            cmb_nac.CargarCombo();
            cmb_nac.SelectedIndex = -1;



            this.rv_numeros.RefreshReport();
        }

        private void btn_reporte_cliente_cargar_Click(object sender, EventArgs e)
        {

        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cmb_nac_SelectedIndexChanged(object sender, EventArgs e)
        {
           if (cmb_nac.SelectedIndex == -1)
            {
                cmb_area.SelectedIndex = -1;
            }
            else
            {
                string referencia = cmb_nac.SelectedValue.ToString();
                cmb_area.Cargar_con_Ref(referencia);
                cmb_area.SelectedIndex = -1;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cmb_nac.Enabled = true;
            cmb_area.Enabled = false;
            cmb_area.SelectedIndex = -1;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            cmb_nac.Enabled = true;
           cmb_area.Enabled = true;
            cmb_nac.SelectedIndex = -1;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            cmb_nac.Enabled = false;
            cmb_area.Enabled = false;
            cmb_area.SelectedIndex = -1;
            cmb_nac.SelectedIndex = -1;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox011_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();
            ReporteNumero ng_rn = new ReporteNumero();
            if (rb_todos.Checked == true)
            {
                
                tabla = ng_rn.ReporteTodos();
                Reporte_Numero(tabla);
            }
            if (rb_nac.Checked == true)
            {
                if (cmb_nac.SelectedIndex != -1)
                {
                    string cod_nac = cmb_nac.SelectedValue.ToString();
                    tabla = ng_rn.ReporteNacional(cod_nac);
                    Reporte_Numero(tabla);
                }
                else
                {
                    MessageBox.Show("Elija un codigo nacional");
                }

            }
            if (rb_area.Checked == true)
            {
                if (cmb_area.SelectedIndex != -1)
                {
                    string cod_nac = cmb_nac.SelectedValue.ToString();
                    string cod_area = cmb_area.SelectedValue.ToString();
                    tabla = ng_rn.ReporteArea(cod_nac, cod_area);
                    Reporte_Numero(tabla);
                }
                else
                {
                    MessageBox.Show("Elija un codigo de area");
                }
            }
        }
        private void Reporte_Numero(DataTable tabla)
        {
            ReportDataSource repoteDatos = new ReportDataSource("DataSet1",tabla);
            rv_numeros.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Numeros.ReportNumeros.rdlc";
            rv_numeros.LocalReport.DataSources.Clear();
            rv_numeros.LocalReport.DataSources.Add(repoteDatos);
            rv_numeros.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
