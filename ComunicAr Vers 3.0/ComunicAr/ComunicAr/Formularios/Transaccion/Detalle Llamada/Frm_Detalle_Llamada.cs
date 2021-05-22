using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ComunicAr.Negocio_Transacciones;
using ComunicAr.Formularios;



namespace ComunicAr.Transaccion.Emision_de_Factura
{
    public partial class Frm_Detalle_Llamada : Form
    {
        public string Pp_NroFac;
        public string Pp_NroCliente;
        public Frm_Detalle_Llamada()
        {
            InitializeComponent();
        }

        private void Frm_Detalle_Llamada_Load(object sender, EventArgs e)
        {
            Pp_NroFac = "1";
            Pp_NroCliente = "1";
            DataTable tabla = new DataTable();
            Detalle_Llamadas Detalle = new Detalle_Llamadas();
            tabla = Detalle.CargarCliente(Pp_NroFac);
            Txt_ID_DLlamadas.Text = tabla.Rows[0]["nro_cliente"].ToString();
            Txt_Nombre_DLlamadas.Text = tabla.Rows[0]["nombre_razonSocial"].ToString();
            Txt_NroFac_DLlamadas.Text = tabla.Rows[0]["nro_factura"].ToString();
            DataTable tabla2 = new DataTable();
            Detalle_Llamadas Detalle2 = new Detalle_Llamadas();
            tabla2 = Detalle2.RecoleccionDatos(Pp_NroCliente);
            CargarDatos(tabla2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos(DataTable tabla)
        {
            float subtotal = 0;
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                
                
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = tabla.Rows[i]["id_llamada"].ToString();
                string cod_nac_emisor = tabla.Rows[i]["cod_nacional"].ToString();
                string cod_area_emisor = tabla.Rows[i]["cod_area"].ToString();
                string nro_emisor = tabla.Rows[i]["nro_telefono"].ToString();
                string emisor = "+" + cod_nac_emisor + " " + cod_area_emisor + " " + nro_emisor;
                dataGridView1.Rows[i].Cells[1].Value = emisor;
                string cod_nac_receptor = tabla.Rows[i]["Rcod_nac"].ToString();
                string cod_area_receptor = tabla.Rows[i]["Rcod_area"].ToString();
                string nro_receptor = tabla.Rows[i]["Rnro"].ToString();
                string receptor = "+" + cod_nac_receptor + " " + cod_area_receptor + " " + nro_receptor;
                dataGridView1.Rows[i].Cells[2].Value = receptor; 
                dataGridView1.Rows[i].Cells[3].Value = tabla.Rows[i]["fecha_hora_inicio"].ToString();
                dataGridView1.Rows[i].Cells[4].Value = tabla.Rows[i]["duracion"].ToString();
                float precio = float.Parse(tabla.Rows[i]["costo"].ToString()) * float.Parse(tabla.Rows[i]["duracion"].ToString());
                dataGridView1.Rows[i].Cells[5].Value = precio.ToString();
                subtotal += precio;
                txt_subtotal.Text = subtotal.ToString();

            }
            txt_subtotal.Text = subtotal.ToString();
        }
    }
}
