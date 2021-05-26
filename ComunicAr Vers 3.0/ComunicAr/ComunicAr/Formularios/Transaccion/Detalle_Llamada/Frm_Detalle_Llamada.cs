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
using ComunicAr.Negocio;



namespace ComunicAr.Formularios.Transaccion.Detalle_Llamada
{
    public partial class Frm_Detalle_Llamada : Form
    {
        public string Pp_NroFac { get; set; }
        public string Pp_NroCliente { get; set; }
        public string Pp_idLlamada { get; set; }
        public bool flag { get; set; }
        public Frm_Detalle_Llamada()
        {
            InitializeComponent();
        }

        private void Frm_Detalle_Llamada_Load(object sender, EventArgs e)
        {
            flag = false;
            
            DataTable tabla = new DataTable();
            Detalle_Llamadas Detalle = new Detalle_Llamadas();
            tabla = Detalle.CargarCliente(Pp_NroFac);
            Txt_ID_DLlamadas.Text = tabla.Rows[0]["nro_cliente"].ToString();
            Txt_Nombre_DLlamadas.Text = tabla.Rows[0]["nombre_razonSocial"].ToString();
            Txt_NroFac_DLlamadas.Text = tabla.Rows[0]["nro_factura"].ToString();
            
            DataTable tabla2 = new DataTable();
            Detalle_Llamadas Detalle2 = new Detalle_Llamadas();
            tabla2 = Detalle2.RecoleccionDatos(Pp_NroCliente);
            
            dataGridView1.Rows.Clear();
            CargarDatos(tabla2);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarDatos(DataTable tabla)
        {
            float subtotal = 0;

            dataGridView1.Rows.Clear();
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
            flag = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Pp_idLlamada = dataGridView1.CurrentRow.Cells["Column1"].Value.ToString();
            flag = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Seleccione una llamada para modificar");
            }
            else
            {
                Formularios.ABM_Llamadas.Frm_Modificar_Llamadas Mod_lla = new Formularios.ABM_Llamadas.Frm_Modificar_Llamadas();
                Mod_lla.id_llamada = Pp_idLlamada;
                Mod_lla.Deshabilidator = true;
                //Mod_lla.txtBox_llamadas_mod_idEmisor.Enable = false;
                Mod_lla.ShowDialog();

                dataGridView1.Rows.Clear();
                DataTable tabla2 = new DataTable();
                Detalle_Llamadas Detalle2 = new Detalle_Llamadas();
                tabla2 = Detalle2.RecoleccionDatos(Pp_NroCliente);
                CargarDatos(tabla2);
                flag = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == false)
            {
                MessageBox.Show("Seleccione una llamada para eliminar");
            }
            else
            {
                Formularios.ABM_Llamadas.Frm_Baja_Llamadas baja_lla = new Formularios.ABM_Llamadas.Frm_Baja_Llamadas();
                baja_lla.id_llamada = Pp_idLlamada;
                baja_lla.ShowDialog();

                dataGridView1.Rows.Clear();
                DataTable tabla2 = new DataTable();
                Detalle_Llamadas Detalle2 = new Detalle_Llamadas();
                tabla2 = Detalle2.RecoleccionDatos(Pp_NroCliente);
                CargarDatos(tabla2);
                flag = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Detalle_Llamadas Detalle = new Detalle_Llamadas();
            if (MessageBox.Show("¿Desea cargar el detalle de llamada?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    Detalle.Pp_NroFac = Pp_NroFac;
                    Detalle.Pp_IdLlamada = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    Detalle.Pp_Subtotal = txt_subtotal.Text.ToString();
                    Detalle.insertarDetalleLlamada();
                }
                MessageBox.Show("Detalle cargado exitosamente");
            }
        }
    }
}

