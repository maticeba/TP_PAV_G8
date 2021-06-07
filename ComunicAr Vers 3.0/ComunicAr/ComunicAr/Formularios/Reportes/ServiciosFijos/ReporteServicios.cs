using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Negocio;
using ComunicAr.Negocio_Listados;
using Microsoft.Reporting.WinForms;

namespace ComunicAr.Formularios.Reportes.ServiciosFijos
{
    public partial class ReporteServicios : Form
    {
        public ReporteServicios()
        {
            InitializeComponent();
        }

        private void ReporteServicios_Load(object sender, EventArgs e)
        {

            this.rv_Fijos.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txt_cliente.Text == "")
            {
                MessageBox.Show("Ingrese un número de cliente emisor");
                cmb_numeros.CargarCombo();
            }
            else
            {
                Llamadas llamadas = new Llamadas();
                DataTable existEmisor = new DataTable();
                existEmisor = llamadas.Search_cliente(txt_cliente.Text);
                if (existEmisor.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado el cliente buscado");
                }
                else
                {
                    string nombre = existEmisor.Rows[0]["nombre_razonSocial"].ToString();
                    MessageBox.Show("El cliente emisor es " + nombre);
                    cmb_numeros.CargarComboXcliente(txt_cliente.Text, nombre);
                    cmb_numeros.SelectedIndex = -1;
                }
                btn_calc.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            txt_cliente.Enabled = true;
            btn_buscar.Visible = true;
            btn_calc.Enabled = false;
            cmb_numeros.Enabled = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_cliente.Enabled = true;
            btn_buscar.Visible = true;
            cmb_numeros.Enabled = true;
            btn_calc.Enabled = false;

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txt_cliente.Enabled = false;
            btn_buscar.Visible = false;
            cmb_numeros.Enabled = false;
            txt_cliente.Clear();
            cmb_numeros.SelectedIndex = -1;
            btn_calc.Enabled = true;


        }

        private void cmb_numeros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_numeros.SelectedIndex == -1)
            {
                btn_calc.Enabled = false;
            }
            else
            {
                btn_calc.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            DataTable tabla2 = new DataTable();
            tabla2.Columns.Add("nombre_razonSocial", typeof(string));
            tabla2.Columns.Add("numero", typeof(string));
            tabla2.Columns.Add("descripcion", typeof(string));
            tabla2.Columns.Add("costo_mensual", typeof(string));
            Reporte_ServiciosFijos rp_sf = new Reporte_ServiciosFijos();

            if (rb_todos.Checked == true)
            {
                DataTable tabla = new DataTable();
                tabla = rp_sf.ReporteTodos();
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    string numero = tabla.Rows[i]["cod_nacional"].ToString() + tabla.Rows[i]["cod_area"].ToString() + tabla.Rows[i]["nro_telefono"].ToString();
                    
                    DataRow row = tabla2.NewRow();
                    /*row["numero"] = numero;
                    row["nombre_razonSocial"] = tabla.Rows[i]["nombre_razonSocial"].ToString();
                    row["descripcion"] = tabla.Rows[i]["descripcion"].ToString();
                    row["costo_mensual"] = tabla.Rows[i]["costo_mensual"].ToString();*/
                    tabla2.Rows.Add(tabla.Rows[i]["nombre_razonSocial"].ToString(), numero, tabla.Rows[i]["descripcion"].ToString(), tabla.Rows[i]["costo_mensual"].ToString());
                    string prueba = numero + tabla.Rows[i]["nombre_razonSocial"].ToString() + tabla.Rows[i]["descripcion"].ToString() + tabla.Rows[i]["costo_mensual"].ToString();
                    //MessageBox.Show(prueba);
                }
                Reporte_fijos(tabla2);
            }
            if (rb_cliente.Checked == true)
            {
                if (txt_cliente.Text == "")
                {
                    MessageBox.Show("Introduzca un numero de cliente");
                }
                else
                {
                    DataTable tabla = new DataTable();
                    tabla = rp_sf.ReporteCliente(txt_cliente.Text);
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        string numero = tabla.Rows[i]["cod_nacional"].ToString() + tabla.Rows[i]["cod_area"].ToString() + tabla.Rows[i]["nro_telefono"].ToString();

                        DataRow row = tabla2.NewRow();
                        /*row["numero"] = numero;
                        row["nombre_razonSocial"] = tabla.Rows[i]["nombre_razonSocial"].ToString();
                        row["descripcion"] = tabla.Rows[i]["descripcion"].ToString();
                        row["costo_mensual"] = tabla.Rows[i]["costo_mensual"].ToString();*/
                        tabla2.Rows.Add(tabla.Rows[i]["nombre_razonSocial"].ToString(), numero, tabla.Rows[i]["descripcion"].ToString(), tabla.Rows[i]["costo_mensual"].ToString());
                        string prueba = numero + tabla.Rows[i]["nombre_razonSocial"].ToString() + tabla.Rows[i]["descripcion"].ToString() + tabla.Rows[i]["costo_mensual"].ToString();
                        //MessageBox.Show(prueba);
                    }
                    Reporte_fijos(tabla2);

                }
                
            }
            if (rb_num.Checked == true)
            {
                if (cmb_numeros.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione un numero ");
                }
                else
                {
                    DataTable tabla = new DataTable();
                    tabla = rp_sf.ReportNum(txt_cliente.Text, cmb_numeros.SelectedValue.ToString());
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        string numero = tabla.Rows[i]["cod_nacional"].ToString() + tabla.Rows[i]["cod_area"].ToString() + tabla.Rows[i]["nro_telefono"].ToString();

                        DataRow row = tabla2.NewRow();
                        /*row["numero"] = numero;
                        row["nombre_razonSocial"] = tabla.Rows[i]["nombre_razonSocial"].ToString();
                        row["descripcion"] = tabla.Rows[i]["descripcion"].ToString();
                        row["costo_mensual"] = tabla.Rows[i]["costo_mensual"].ToString();*/
                        tabla2.Rows.Add(tabla.Rows[i]["nombre_razonSocial"].ToString(), numero, tabla.Rows[i]["descripcion"].ToString(), tabla.Rows[i]["costo_mensual"].ToString());
                        string prueba = numero + tabla.Rows[i]["nombre_razonSocial"].ToString() + tabla.Rows[i]["descripcion"].ToString() + tabla.Rows[i]["costo_mensual"].ToString();
                        //MessageBox.Show(prueba);
                    }

                    Reporte_fijos(tabla2);
                }

            }
        }
        private void Reporte_fijos(DataTable tabla)
        {
            //ReportDataSource repoteDatos = new ReportDataSource("DataSet1", tabla);
            ReportDataSource repoteDatos = new ReportDataSource("DataSet1", tabla);
            rv_Fijos.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.ServiciosFijos.Reporte_ServiciosFijos.rdlc";
            rv_Fijos.LocalReport.DataSources.Clear();
            rv_Fijos.LocalReport.DataSources.Add(repoteDatos);
            rv_Fijos.RefreshReport();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
