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
using ComunicAr.Negocio;

namespace ComunicAr.Formularios.ABM_Llamadas
{
    public partial class Frm_Baja_Llamadas : Form
    {
        public string id_llamada { get; set; }
        public Frm_Baja_Llamadas()
        {
            InitializeComponent();
        }

        private void btn_cliente_baja_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cliente_baja_aceptar_Click(object sender, EventArgs e)
        {
            Llamadas llamada = new Llamadas();
            llamada.Pp_id_llamada = id_llamada;
            if(MessageBox.Show ("¿Esta seguro de borra?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                llamada.EraseLlamada();
                MessageBox.Show("La llamada se ha borrado exitosamente");
                this.Close();
            }
        }

        private void Frm_Baja_Llamadas_Load(object sender, EventArgs e)
        {
            Llamadas llamada = new Llamadas();
            llamada.Pp_id_llamada = id_llamada;
            MostrarDatos(llamada.LlamadasPresent());
        }

        private void MostrarDatos(DataTable tabla)
        {
            // Emisor
            txtBox_llamadas_baja_idEmisor.Text = tabla.Rows[0]["id_emisor"].ToString();

            cmb_llamada_baja_tel_emisor.CargarComboXcliente(txtBox_llamadas_baja_idEmisor.Text, "");
            cmb_llamada_baja_tel_emisor.SelectedIndex = -1;

            string cod_nac_emisor = tabla.Rows[0]["nac_emisor"].ToString();
            string cod_area_emisor = tabla.Rows[0]["area_emisor"].ToString();
            string nro_emisor = tabla.Rows[0]["tel_emisor"].ToString();
            string emisor = "+" + cod_nac_emisor + " " + cod_area_emisor + " " + nro_emisor;

            cmb_llamada_baja_tel_emisor.SelectedText = emisor;
            
            // Receptor
            txtBox_llamadas_baja_idReceptor.Text = tabla.Rows[0]["id_receptor"].ToString();

            cmb_llamada_baja_tel_receptor.CargarComboXcliente(txtBox_llamadas_baja_idReceptor.Text, "");
            cmb_llamada_baja_tel_receptor.SelectedIndex = -1;

            string cod_nac_receptor = tabla.Rows[0]["nac_recept"].ToString();
            string cod_area_receptor = tabla.Rows[0]["area_recept"].ToString();
            string nro_receptor = tabla.Rows[0]["tel_recept"].ToString();
            string receptor = "+" + cod_nac_receptor + " " + cod_area_receptor + " " + nro_receptor;

            cmb_llamada_baja_tel_receptor.SelectedText = receptor;

            // Fecha y hora Inicio

            cmb_llamada_baja_inicio_hs.CargarComboXhora();
            cmb_llamada_baja_inicio_mins.CargarComboXminXseg();
            cmb_llamada_baja_inicio_seg.CargarComboXminXseg();

            string dia_inicio = tabla.Rows[0]["dia_inicio"].ToString();
            string mes_inicio = tabla.Rows[0]["mes_inicio"].ToString();
            string año_inicio = tabla.Rows[0]["año_inicio"].ToString();
            string hora_inicio = tabla.Rows[0]["hora_inicio"].ToString();
            string min_inicio = tabla.Rows[0]["min_inicio"].ToString();
            string seg_inicio = tabla.Rows[0]["seg_inicio"].ToString();
            string fecha_inicio = dia_inicio + "/" + mes_inicio + "/" + año_inicio;

            txtbox_llamada_baja_fecha_inicio.Text = fecha_inicio;

            cmb_llamada_baja_inicio_hs.SelectedIndex = int.Parse(hora_inicio);
            cmb_llamada_baja_inicio_mins.SelectedIndex = int.Parse(min_inicio);
            cmb_llamada_baja_inicio_seg.SelectedIndex = int.Parse(seg_inicio);

            // Fecha y hora fin

            cmb_llamada_baja_fin_hs.CargarComboXhora();
            cmb_llamada_baja_fin_mins.CargarComboXminXseg();
            cmb_llamada_baja_fin_segs.CargarComboXminXseg();

            string dia_fin = tabla.Rows[0]["dia_fin"].ToString();
            string mes_fin = tabla.Rows[0]["mes_fin"].ToString();
            string año_fin = tabla.Rows[0]["año_fin"].ToString();
            string hora_fin = tabla.Rows[0]["hora_fin"].ToString();
            string min_fin = tabla.Rows[0]["min_fin"].ToString();
            string seg_fin = tabla.Rows[0]["seg_fin"].ToString();
            string fecha_fin = dia_fin + "/" + mes_fin + "/" + año_fin;

            txt_llamada_baja_fecha_fin.Text = fecha_fin;

            cmb_llamada_baja_fin_hs.SelectedIndex = int.Parse(hora_fin);
            cmb_llamada_baja_fin_mins.SelectedIndex = int.Parse(min_fin);
            cmb_llamada_baja_fin_segs.SelectedIndex = int.Parse(seg_fin);
        }
    }
}
