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
            txt_desde.Enabled = false;
            txt_hasta.Enabled = false;
            txt_desde.Clear();
            txt_hasta.Clear();

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            txt_cliente.Enabled = true;
            btn_buscar.Visible = true;
            txt_desde.Enabled = true;
            txt_hasta.Enabled = true;
            txt_cliente.Enabled = false;
            btn_calc.Enabled = true;
            txt_cliente.Clear();
            btn_buscar.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            txt_cliente.Enabled = false;
            btn_buscar.Visible = false;
            txt_cliente.Clear();
            btn_calc.Enabled = true;
            txt_desde.Enabled = false;
            txt_hasta.Enabled = false;
            txt_cliente.Clear();
            txt_desde.Clear();
            txt_hasta.Clear();
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
                    tabla2.Rows.Add(tabla.Rows[i]["nombre_razonSocial"].ToString(), numero, tabla.Rows[i]["descripcion"].ToString(), tabla.Rows[i]["costo_mensual"].ToString());
                    string prueba = numero + tabla.Rows[i]["nombre_razonSocial"].ToString() + tabla.Rows[i]["descripcion"].ToString() + tabla.Rows[i]["costo_mensual"].ToString();
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
                        tabla2.Rows.Add(tabla.Rows[i]["nombre_razonSocial"].ToString(), numero, tabla.Rows[i]["descripcion"].ToString(), tabla.Rows[i]["costo_mensual"].ToString());
                        string prueba = numero + tabla.Rows[i]["nombre_razonSocial"].ToString() + tabla.Rows[i]["descripcion"].ToString() + tabla.Rows[i]["costo_mensual"].ToString();
                    }
                    Reporte_fijos(tabla2);

                }

            }
            if (rb_num.Checked == true)
            {
                if (txt_desde.Text == "" && txt_hasta.Text == "")
                {
                    MessageBox.Show("Introduzca un rango de precios");
                }
                else if (txt_desde.Text == "" && txt_hasta.Text != "")
                {
                    DataTable tabla = new DataTable();
                    tabla = rp_sf.ReportHasta(txt_hasta.Text);
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        string numero = tabla.Rows[i]["cod_nacional"].ToString() + tabla.Rows[i]["cod_area"].ToString() + tabla.Rows[i]["nro_telefono"].ToString();
                        DataRow row = tabla2.NewRow();
                        tabla2.Rows.Add(tabla.Rows[i]["nombre_razonSocial"].ToString(), numero, tabla.Rows[i]["descripcion"].ToString(), tabla.Rows[i]["costo_mensual"].ToString());
                        string prueba = numero + tabla.Rows[i]["nombre_razonSocial"].ToString() + tabla.Rows[i]["descripcion"].ToString() + tabla.Rows[i]["costo_mensual"].ToString();
                    }
                    Reporte_fijos(tabla2);
                }
                else if (txt_desde.Text != "" && txt_hasta.Text == "")
                {
                    DataTable tabla = new DataTable();
                    tabla = rp_sf.ReprotDesde(txt_desde.Text);
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        string numero = tabla.Rows[i]["cod_nacional"].ToString() + tabla.Rows[i]["cod_area"].ToString() + tabla.Rows[i]["nro_telefono"].ToString();

                        DataRow row = tabla2.NewRow();
                        tabla2.Rows.Add(tabla.Rows[i]["nombre_razonSocial"].ToString(), numero, tabla.Rows[i]["descripcion"].ToString(), tabla.Rows[i]["costo_mensual"].ToString());
                        string prueba = numero + tabla.Rows[i]["nombre_razonSocial"].ToString() + tabla.Rows[i]["descripcion"].ToString() + tabla.Rows[i]["costo_mensual"].ToString();
                    }
                    Reporte_fijos(tabla2);
                }
                else
                {
                    DataTable tabla = new DataTable();
                    tabla = rp_sf.ReportNum(txt_desde.Text, txt_hasta.Text);
                    for (int i = 0; i < tabla.Rows.Count; i++)
                    {
                        string numero = tabla.Rows[i]["cod_nacional"].ToString() + tabla.Rows[i]["cod_area"].ToString() + tabla.Rows[i]["nro_telefono"].ToString();
                        DataRow row = tabla2.NewRow();
                        tabla2.Rows.Add(tabla.Rows[i]["nombre_razonSocial"].ToString(), numero, tabla.Rows[i]["descripcion"].ToString(), tabla.Rows[i]["costo_mensual"].ToString());
                        string prueba = numero + tabla.Rows[i]["nombre_razonSocial"].ToString() + tabla.Rows[i]["descripcion"].ToString() + tabla.Rows[i]["costo_mensual"].ToString();

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
        /// <summary>
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        // REPORTE DE SERVICIOS DATOS

        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        Reporte_Datos datos = new Reporte_Datos();
        private void Calcular_datos()
        {
            DataTable tabla = new DataTable();
            if (rb_Costo.Checked == true)
            {
                tabla = datos.ReporteDatos_limitecosto(txt_costo_desde.Text.ToString(), txt_costo_hasta.Text.ToString());
                ArmarReporteDatos(tabla);
            }
            if (rb_limite.Checked == true)
            {
                tabla = datos.ReporteDatos_limitedatos(txt_limite.Text.ToString());
                ArmarReporteDatos(tabla);
            }
            if (rb_todos1.Checked == true)
            {
                tabla = datos.ReporteDatos_todos();
                ArmarReporteDatos(tabla);
            }
            if (rb_Costo.Checked == false && rb_limite.Checked == false && rb_todos1.Checked == false)
            {
                MessageBox.Show("Elija un parametro para la busqueda");
            }
        }
        private void ArmarReporteDatos(DataTable tabla)
        {
            ReportDataSource PaqueteDatos = new ReportDataSource("DS_Rep_Datos", tabla);
            reportViewer1.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.ServiciosFijos.Reporte_Datos.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(PaqueteDatos);
            reportViewer1.RefreshReport();
        }
        private void rb_Costo_CheckedChanged(object sender, EventArgs e)
        {
            txt_costo_desde.Enabled = true;
            txt_costo_hasta.Enabled = true;
            txt_limite.Enabled = false;
            txt_costo_desde.Clear();
            txt_limite.Clear();
        }

        private void rb_limite_CheckedChanged(object sender, EventArgs e)
        {
            txt_costo_desde.Enabled = false;
            txt_costo_hasta.Enabled = false;
            txt_limite.Enabled = true;
            txt_limite.Clear();
            txt_costo_desde.Clear();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            txt_costo_desde.Enabled = false;
            txt_costo_hasta.Enabled = false;
            txt_limite.Enabled = false;
            txt_limite.Clear();
            txt_costo_desde.Clear();
        }

        private void btn_Calcular_Datos_Click(object sender, EventArgs e)
        {
            Calcular_datos();
        }
        //TERMINA DATOS
        private void btn_Calcular_Fijos_Click(object sender, EventArgs e)
        {

            caluclar_Datos_fijos();

        }
        private void caluclar_Datos_fijos()
        {
            bool flag = true;
            DataTable tabla = new DataTable();
            ServicioFijo fijo = new ServicioFijo();

            if (rb03_Fijos.Checked == true)
            {
                tabla = fijo.ServicioFijoCompleto();
                ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                rv01_Fijos.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Servicios.Reporte_Servicios_Fijos.rdlc";
                rv01_Fijos.LocalReport.DataSources.Clear();
                rv01_Fijos.LocalReport.DataSources.Add(PaqueteDatos);
                rv01_Fijos.RefreshReport();
            }
           
            if (rb02_Fijos.Checked == true)
            {
                flag = true;
                if (string.IsNullOrEmpty(txt_SF_Desde.Text) && string.IsNullOrEmpty(txt_SF_Hasta.Text))
                {
                    MessageBox.Show("Debe completar la informacion");
                    flag = false;

                }
                else
                {
                    if (string.IsNullOrEmpty(txt_SF_Desde.Text))
                    {
                        int hasta = int.Parse(txt_SF_Hasta.Text);
                        tabla = fijo.ServicioFijoMayorMenor(hasta, "<");
                        ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                        rv01_Fijos.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Servicios.Reporte_Servicios_Fijos.rdlc";
                        rv01_Fijos.LocalReport.DataSources.Clear();
                        rv01_Fijos.LocalReport.DataSources.Add(PaqueteDatos);
                        rv01_Fijos.RefreshReport();
                        flag = false;
                    }
                    if (string.IsNullOrEmpty(txt_SF_Hasta.Text))
                    {
                        int desde = int.Parse(txt_SF_Desde.Text);
                        tabla = fijo.ServicioFijoMayorMenor(desde, ">");
                        ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                        rv01_Fijos.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Servicios.Reporte_Servicios_Fijos.rdlc";
                        rv01_Fijos.LocalReport.DataSources.Clear();
                        rv01_Fijos.LocalReport.DataSources.Add(PaqueteDatos);
                        rv01_Fijos.RefreshReport();
                        flag = false;

                    }
                }

                if (flag == true)
                {
                    int desde = int.Parse(txt_SF_Desde.Text);
                    int hasta = int.Parse(txt_SF_Hasta.Text);
                    tabla = fijo.ServicioFijoMM(desde,hasta);
                    ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                    rv01_Fijos.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.Servicios.Reporte_Servicios_Fijos.rdlc";
                    rv01_Fijos.LocalReport.DataSources.Clear();
                    rv01_Fijos.LocalReport.DataSources.Add(PaqueteDatos);
                    rv01_Fijos.RefreshReport();
                }

            }

        }
        private void rb03_Fijos_CheckedChanged(object sender, EventArgs e)
        {
            txt_SF_Desde.Enabled = false;
            txt_SF_Hasta.Enabled = false;

        }
        private void rb02_Fijos_CheckedChanged(object sender, EventArgs e)
        {
            txt_SF_Desde.Enabled = true;
            txt_SF_Hasta.Enabled = true;

        }

        private void btn_calcular_prepago_Click(object sender, EventArgs e)
        {
            Calcular_Datos_Prepagos();
        }
        private void Calcular_Datos_Prepagos()
        {
            bool flag = true;
            if (rb02_Prepagos_Tipo.Checked == true)
            {
                DataTable tabla = new DataTable();
                Servicios_Prepagos prepago = new Servicios_Prepagos();
                if (rb03_Prepagos.Checked == true)
                {
                    tabla = prepago.ServiciosCompletos();
                    ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                    rv02.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.ServiciosFijos.Reporte_Servicios_Prepagos.rdlc";
                    rv02.LocalReport.DataSources.Clear();
                    rv02.LocalReport.DataSources.Add(PaqueteDatos);
                    rv02.RefreshReport();
                }


                flag = true;
                if (string.IsNullOrEmpty(txt_SP_desde.Text) && string.IsNullOrEmpty(txt_SP_hasta.Text))
                {
                    MessageBox.Show("Debe completar la informacion");
                    flag = false;
                }
                else
                {
                    if (string.IsNullOrEmpty(txt_SP_desde.Text))
                    {
                        int hasta = int.Parse(txt_SP_hasta.Text);
                        tabla = prepago.ServiciosPrepagosMayorMenorDuracion(hasta, "<");
                        ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                        rv02.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.ServiciosFijos.Reporte_Servicios_Prepagos.rdlc";
                        rv02.LocalReport.DataSources.Clear();
                        rv02.LocalReport.DataSources.Add(PaqueteDatos);
                        rv02.RefreshReport();
                        flag = false;
                    }

                    if (string.IsNullOrEmpty(txt_SP_hasta.Text))
                    {
                        int desde = int.Parse(txt_SP_desde.Text);
                        tabla = prepago.ServiciosPrepagosMayorMenorDuracion(desde, ">");
                        ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                        rv02.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.ServiciosFijos.Reporte_Servicios_Prepagos.rdlc";
                        rv02.LocalReport.DataSources.Clear();
                        rv02.LocalReport.DataSources.Add(PaqueteDatos);
                        rv02.RefreshReport();
                        flag = false;

                    }

                    if (flag == true)
                    {
                        int desde = int.Parse(txt_SP_desde.Text);
                        int hasta = int.Parse(txt_SP_hasta.Text);
                        tabla = prepago.ServicioPrepagoMMDuracion(desde, hasta);
                        ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                        rv02.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.ServiciosFijos.Reporte_Servicios_Prepagos.rdlc";
                        rv02.LocalReport.DataSources.Clear();
                        rv02.LocalReport.DataSources.Add(PaqueteDatos);
                        rv02.RefreshReport();
                    }
                }
            }
            if (rb01_Prepagos_Tipo.Checked == true)
            {
                DataTable tabla = new DataTable();
                Servicios_Prepagos prepago = new Servicios_Prepagos();
                if (rb03_Prepagos.Checked == true)
                {
                    tabla = prepago.ServiciosCompletos();
                    ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                    rv02.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.ServiciosFijos.Reporte_Servicios_Prepagos.rdlc";
                    rv02.LocalReport.DataSources.Clear();
                    rv02.LocalReport.DataSources.Add(PaqueteDatos);
                    rv02.RefreshReport();
                }
                if (rb02_Prepagos.Checked == true)
                {
                    flag = true;
                    if (string.IsNullOrEmpty(txt_SP_desde.Text) && string.IsNullOrEmpty(txt_SP_hasta.Text))
                    {
                        MessageBox.Show("Debe completar la informacion");
                        flag = false;
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(txt_SP_desde.Text))
                        {
                            int hasta = int.Parse(txt_SP_hasta.Text);
                            tabla = prepago.ServiciosPrepagosMayorMenor(hasta, "<");
                            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                            rv02.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.ServiciosFijos.Reporte_Servicios_Prepagos.rdlc";
                            rv02.LocalReport.DataSources.Clear();
                            rv02.LocalReport.DataSources.Add(PaqueteDatos);
                            rv02.RefreshReport();
                            flag = false;
                        }
                        if (string.IsNullOrEmpty(txt_SP_hasta.Text))
                        {
                            int desde = int.Parse(txt_SP_desde.Text);
                            tabla = prepago.ServiciosPrepagosMayorMenor(desde, ">");
                            ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                            rv02.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.ServiciosFijos.Reporte_Servicios_Prepagos.rdlc";
                            rv02.LocalReport.DataSources.Clear();
                            rv02.LocalReport.DataSources.Add(PaqueteDatos);
                            rv02.RefreshReport();
                            flag = false;

                        }
                    }
                    if (flag == true)
                    {
                        int desde = int.Parse(txt_SP_desde.Text);
                        int hasta = int.Parse(txt_SP_hasta.Text);
                        tabla = prepago.ServiciosPrepagosMMCosto(desde,hasta);
                        ReportDataSource PaqueteDatos = new ReportDataSource("DataSet1", tabla);
                        rv02.LocalReport.ReportEmbeddedResource = "ComunicAr.Formularios.Reportes.ServiciosFijos.Reporte_Servicios_Prepagos.rdlc";
                        rv02.LocalReport.DataSources.Clear();
                        rv02.LocalReport.DataSources.Add(PaqueteDatos);
                        rv02.RefreshReport();
                    }

                }
            }


        }
        private void rb03_Prepago_CheckedChanged(object sender, EventArgs e)
        {
            txt_SP_desde.Enabled = false;
            txt_SP_hasta.Enabled = false;

        }
        private void rb02_Prepago_CheckedChanged(object sender, EventArgs e)
        {
            txt_SP_desde.Enabled = true;
            txt_SP_hasta.Enabled = true;

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
