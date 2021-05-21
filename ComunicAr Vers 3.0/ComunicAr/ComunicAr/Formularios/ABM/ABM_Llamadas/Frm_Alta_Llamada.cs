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
    public partial class Frm_Alta_Llamadas : Form
    {
        public Frm_Alta_Llamadas()
        {
            InitializeComponent();
        }

        private void btn_cliente_alta_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cliente_alta_aceptar_Click(object sender, EventArgs e)
        {
            
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Llamadas llamada = new Llamadas();

                llamada.Pp_id_emisor = cmb_llamada_alta_tel_emisor.SelectedValue.ToString();
                llamada.Pp_id_receptor = cmb_llamada_alta_tel_receptor.SelectedValue.ToString();
                string fecha_inicio = txtbox_llamada_alta_fecha_inicio.Text;
                string hora_inicio = cmb_llamada_alta_inicio_hs.SelectedValue.ToString();
                string mins_inicio = cmb_llamada_alta_inicio_mins.SelectedValue.ToString();
                string segs_inicio = cmb_llamada_alta_inicio_seg.SelectedValue.ToString();
                string horario_inicio = hora_inicio + ":" + mins_inicio + ":" + segs_inicio;
                llamada.Pp_fecha_hora_inicio = fecha_inicio + " " + horario_inicio;
                string fecha_fin = txt_llamada_alta_fecha_fin.Text;
                string hora_fin = cmb_llamada_alta_fin_hs.SelectedValue.ToString();
                string mins_fin = cmb_llamada_alta_fin_mins.SelectedValue.ToString();
                string segs_fin = cmb_llamada_alta_fin_segs.SelectedValue.ToString();
                string horario_fin = hora_fin + ":" + mins_fin + ":" + segs_fin;
                llamada.Pp_fecha_hora_fin = fecha_fin + " " + horario_fin;

                string tipo_com = llamada.GetTypeCom(cmb_llamada_alta_tel_emisor.SelectedValue.ToString(),
                                                       cmb_llamada_alta_tel_receptor.SelectedValue.ToString());
                llamada.Pp_tipo_comunicación = tipo_com;

                string tipo_banda = llamada.GetTypeBanda(int.Parse(hora_inicio), int.Parse(mins_inicio), 
                                                         int.Parse(hora_fin), int.Parse(mins_fin));

                llamada.Pp_banda_horaria = tipo_banda;

                llamada.Insertar();
            }
            else
            {
                return;
            }
            this.Close();
        }

        private void btn_llamada_alta_buscar_emisor_Click(object sender, EventArgs e)
        {
            if (txtBox_llamadas_alta_idEmisor.Text == "")
            {
                MessageBox.Show("Ingrese un número de cliente emisor");
                cmb_llamada_alta_tel_emisor.CargarCombo();
            }
            else
            {
                Llamadas llamadas = new Llamadas();
                DataTable existEmisor = new DataTable();
                existEmisor = llamadas.Search_cliente(txtBox_llamadas_alta_idEmisor.Text);
                if (existEmisor.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado el cliente buscado");
                }
                else
                {
                    string nombre = existEmisor.Rows[0]["nombre_razonSocial"].ToString();
                    MessageBox.Show("El cliente emisor es " + nombre);
                    cmb_llamada_alta_tel_emisor.CargarComboXcliente(txtBox_llamadas_alta_idEmisor.Text, nombre);
                }
            }
        }

        private void btn_llamada_alta_buscar_receptor_Click(object sender, EventArgs e)
        {
            if (txtBox_llamadas_alta_idReceptor.Text == "")
            {
                MessageBox.Show("Ingrese un número de cliente receptor");
            }
            else
            {
                Llamadas llamadas = new Llamadas();
                DataTable existReceptor = new DataTable();
                existReceptor = llamadas.Search_cliente(txtBox_llamadas_alta_idReceptor.Text);
                if (existReceptor.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado el cliente buscado");
                }
                else
                {
                    string nombre = existReceptor.Rows[0]["nombre_razonSocial"].ToString();
                    MessageBox.Show("El cliente receptor es " + nombre);
                    cmb_llamada_alta_tel_receptor.CargarComboXcliente(txtBox_llamadas_alta_idReceptor.Text, nombre);
                }
            }
        }

        private void Frm_Alta_Llamadas_Load(object sender, EventArgs e)
        {
            cmb_llamada_alta_tel_emisor.CargarComboXcliente(" ", "");
            cmb_llamada_alta_tel_receptor.CargarComboXcliente(" ", "");
            cmb_llamada_alta_inicio_hs.CargarComboXhora();
            cmb_llamada_alta_inicio_mins.CargarComboXminXseg();
            cmb_llamada_alta_inicio_seg.CargarComboXminXseg();
            cmb_llamada_alta_fin_hs.CargarComboXhora();
            cmb_llamada_alta_fin_mins.CargarComboXminXseg();
            cmb_llamada_alta_fin_segs.CargarComboXminXseg();
        }
    }
}
