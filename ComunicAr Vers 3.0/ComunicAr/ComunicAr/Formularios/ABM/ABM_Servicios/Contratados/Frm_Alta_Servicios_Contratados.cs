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
using ComunicAr.Clases;

namespace ComunicAr.Formularios.ABM_Servicios.Contratados
{
    public partial class Frm_Alta_Servicios_Contratados : Form
    {

        public string cod_servicio { get; set; }
        public Frm_Alta_Servicios_Contratados()
        {
            InitializeComponent();
        }

       
        private void bttn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        } 

        private void bttn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            if (tratamientos.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Servicios_Contratados servicio = new Servicios_Contratados();


                servicio.Pp_tipo_servicio = cmb_Tipo.SelectedValue.ToString();
                servicio.Pp_id_servicio = cmb_Servicio.SelectedValue.ToString();
                servicio.Pp_fecha_desde = txt_fecha_desde.Text;
                servicio.Pp_fecha_hasta = txt_fecha_hasta.Text;
                servicio.Pp_id_numero = cmb_Numero.SelectedValue.ToString();
                servicio.Pp_cod_servicio = cod_servicio;

                servicio.Insertar();

            }

            else
            {
                return;
            }
            this.Close();
        }

        private void txt_tipo_servicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox011_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
        }

        private void Frm_Alta_Servicios_Contratados_Load(object sender, EventArgs e)
        {
            cmb_Tipo.CargarComboxTipo();
            cmb_Tipo.SelectedIndex = -1;
            
            
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            
            
            if (cmb_Tipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de servicio");
            }
            else
            {
                cmb_Servicio.CargarComboServicio(cmb_Tipo.SelectedValue.ToString());
               
            }
            //MessageBox.Show(cmb_Tipo.SelectedIndex.ToString());
        }

        private void btn_cliente_Click(object sender, EventArgs e)
        {
            if (textBox011.Text == "")
            {
                MessageBox.Show("Ingrese un número de cliente ");
                cmb_Numero.CargarCombo();
            }
            else
            {
                Llamadas llamadas = new Llamadas();
                DataTable existEmisor = new DataTable();
                existEmisor = llamadas.Search_cliente(textBox011.Text);
                if (existEmisor.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado el cliente buscado");
                }
                else
                {
                    string nombre = existEmisor.Rows[0]["nombre_razonSocial"].ToString();
                    MessageBox.Show("El cliente emisor es " + nombre);
                    cmb_Numero.CargarComboXcliente(textBox011.Text, nombre);
                }
            }
        }
    }
}
