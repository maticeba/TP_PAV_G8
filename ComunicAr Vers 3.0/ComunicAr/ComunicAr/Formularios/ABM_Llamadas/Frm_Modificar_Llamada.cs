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
    public partial class Frm_Modificar_Llamadas : Form
    {
        public string id_llamada { get; set; }
        public Frm_Modificar_Llamadas()
        {
            InitializeComponent();
        }

        private void btn_cliente_mod_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cliente_mod_aceptar_Click(object sender, EventArgs e)
        {
            
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Llamadas llamada = new Llamadas();

                llamada.Pp_id_emisor = cmb_llamada_mod_tel_emisor.SelectedValue.ToString();
                llamada.Pp_id_receptor = cmb_llamada_mod_tel_receptor.SelectedValue.ToString();
                string fecha_inicio = txtbox_llamada_mod_fecha_inicio.Text;
                string hora_inicio = cmb_llamada_mod_inicio_hs.SelectedValue.ToString();
                string mins_inicio = cmb_llamada_mod_inicio_mins.SelectedValue.ToString();
                string segs_inicio = cmb_llamada_mod_inicio_seg.SelectedValue.ToString();
                llamada.Pp_fecha_hora_inicio = fecha_inicio + " " + hora_inicio + ":" + mins_inicio + ":" + segs_inicio;
                string fecha_fin = txt_llamada_mod_fecha_fin.Text;
                string hora_fin = cmb_llamada_mod_fin_hs.SelectedValue.ToString();
                string mins_fin = cmb_llamada_mod_fin_mins.SelectedValue.ToString();
                string segs_fin = cmb_llamada_mod_fin_segs.SelectedValue.ToString();
                llamada.Pp_fecha_hora_fin = fecha_fin + " " + hora_fin + ":" + mins_fin + ":" + segs_fin;

                string tipo_com = llamada.GetTypeCom(cmb_llamada_mod_tel_emisor.SelectedValue.ToString(),
                                       cmb_llamada_mod_tel_receptor.SelectedValue.ToString());
                llamada.Pp_tipo_comunicación = tipo_com;

                string tipo_banda = llamada.GetTypeBanda(int.Parse(hora_inicio), int.Parse(mins_inicio),
                                                         int.Parse(hora_fin), int.Parse(mins_fin));

                llamada.Pp_banda_horaria = tipo_banda;

                llamada.Pp_id_llamada = id_llamada;

                llamada.UpdateLlamada();
            }
            else
            {
                return;
            }
        }

        private void btn_llamada_mod_buscar_receptor_Click(object sender, EventArgs e)
        {
            if (txtBox_llamadas_mod_idReceptor.Text == "")
            {
                MessageBox.Show("Ingrese un número de cliente receptor");
            }
            else
            {
                Llamadas llamadas = new Llamadas();
                DataTable existReceptor = new DataTable();
                existReceptor = llamadas.Search_cliente(txtBox_llamadas_mod_idReceptor.Text);
                if (existReceptor.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado el cliente buscado");
                }
                else
                {
                    string nombre = existReceptor.Rows[0]["nombre_razonSocial"].ToString();
                    MessageBox.Show("El cliente receptor es " + nombre);
                    cmb_llamada_mod_tel_receptor.CargarComboXcliente(txtBox_llamadas_mod_idReceptor.Text, nombre);
                }
            }
        }

        private void Frm_Modificar_Llamadas_Load(object sender, EventArgs e)
        {
            Llamadas llamada = new Llamadas();
            llamada.Pp_id_llamada = id_llamada;
            MostrarDatos(llamada.LlamadasPresent());
        }

        private void MostrarDatos(DataTable tabla)
        {
            // Emisor
            txtBox_llamadas_mod_idEmisor.Text = tabla.Rows[0]["id_emisor"].ToString();

            cmb_llamada_mod_tel_emisor.CargarComboXcliente(txtBox_llamadas_mod_idEmisor.Text, "");
            cmb_llamada_mod_tel_emisor.SelectedIndex = -1;

            string cod_nac_emisor = tabla.Rows[0]["nac_emisor"].ToString();
            string cod_area_emisor = tabla.Rows[0]["area_emisor"].ToString();
            string nro_emisor = tabla.Rows[0]["tel_emisor"].ToString();
            string emisor = "+" + cod_nac_emisor + " " + cod_area_emisor + " " + nro_emisor;

            Llamadas llamada = new Llamadas();
            cmb_llamada_mod_tel_emisor.SelectedIndex = llamada.GetPosNumero(txtBox_llamadas_mod_idEmisor.Text,
                                                                    cod_nac_emisor, cod_area_emisor, nro_emisor);

            //cmb_llamada_mod_tel_emisor.SelectedText = emisor;
            
            // Receptor
            txtBox_llamadas_mod_idReceptor.Text = tabla.Rows[0]["id_receptor"].ToString();

            cmb_llamada_mod_tel_receptor.CargarComboXcliente(txtBox_llamadas_mod_idReceptor.Text, "");
 
            string cod_nac_receptor = tabla.Rows[0]["nac_recept"].ToString();
            string cod_area_receptor = tabla.Rows[0]["area_recept"].ToString();
            string nro_receptor = tabla.Rows[0]["tel_recept"].ToString();
            string receptor = "+" + cod_nac_receptor + " " + cod_area_receptor + " " + nro_receptor;

            Llamadas llamada1 = new Llamadas();
            cmb_llamada_mod_tel_receptor.SelectedIndex = llamada1.GetPosNumero(txtBox_llamadas_mod_idReceptor.Text,
                                                                    cod_nac_receptor, cod_area_receptor, nro_receptor);
            
            // Fecha y hora Inicio

            cmb_llamada_mod_inicio_hs.CargarComboXhora();
            cmb_llamada_mod_inicio_mins.CargarComboXminXseg();
            cmb_llamada_mod_inicio_seg.CargarComboXminXseg();

            string dia_inicio = tabla.Rows[0]["dia_inicio"].ToString();
            string mes_inicio = tabla.Rows[0]["mes_inicio"].ToString();
            string año_inicio = tabla.Rows[0]["año_inicio"].ToString();
            string hora_inicio = tabla.Rows[0]["hora_inicio"].ToString();
            string min_inicio = tabla.Rows[0]["min_inicio"].ToString();
            string seg_inicio = tabla.Rows[0]["seg_inicio"].ToString();
            string fecha_inicio = dia_inicio + "/" + mes_inicio + "/" + año_inicio;

            txtbox_llamada_mod_fecha_inicio.Text = fecha_inicio;

            cmb_llamada_mod_inicio_hs.SelectedIndex = int.Parse(hora_inicio);
            cmb_llamada_mod_inicio_mins.SelectedIndex = int.Parse(min_inicio);
            cmb_llamada_mod_inicio_seg.SelectedIndex = int.Parse(seg_inicio);

            // Fecha y hora fin

            cmb_llamada_mod_fin_hs.CargarComboXhora();
            cmb_llamada_mod_fin_mins.CargarComboXminXseg();
            cmb_llamada_mod_fin_segs.CargarComboXminXseg();

            string dia_fin = tabla.Rows[0]["dia_fin"].ToString();
            string mes_fin = tabla.Rows[0]["mes_fin"].ToString();
            string año_fin = tabla.Rows[0]["año_fin"].ToString();
            string hora_fin = tabla.Rows[0]["hora_fin"].ToString();
            string min_fin = tabla.Rows[0]["min_fin"].ToString();
            string seg_fin = tabla.Rows[0]["seg_fin"].ToString();
            string fecha_fin = dia_fin + "/" + mes_fin + "/" + año_fin;

            txt_llamada_mod_fecha_fin.Text = fecha_fin;

            cmb_llamada_mod_fin_hs.SelectedIndex = int.Parse(hora_fin);
            cmb_llamada_mod_fin_mins.SelectedIndex = int.Parse(min_fin);
            cmb_llamada_mod_fin_segs.SelectedIndex = int.Parse(seg_fin);
        }

        private void btn_llamada_mod_buscar_emisor_Click(object sender, EventArgs e)
        {
            if (txtBox_llamadas_mod_idEmisor.Text == "")
            {
                MessageBox.Show("Ingrese un número de cliente emisor");
                cmb_llamada_mod_tel_emisor.CargarCombo();
            }
            else
            {
                Llamadas llamadas = new Llamadas();
                DataTable existEmisor = new DataTable();
                existEmisor = llamadas.Search_cliente(txtBox_llamadas_mod_idEmisor.Text);
                if (existEmisor.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado el cliente buscado");
                }
                else
                {
                    string nombre = existEmisor.Rows[0]["nombre_razonSocial"].ToString();
                    MessageBox.Show("El cliente emisor es " + nombre);
                    cmb_llamada_mod_tel_emisor.CargarComboXcliente(txtBox_llamadas_mod_idEmisor.Text, nombre);
                }
            }
        }
    }
}
