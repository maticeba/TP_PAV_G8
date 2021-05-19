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

namespace ComunicAr.Formularios.ABM_Numeros
{
    public partial class Frm_Alta_Numeros : Form
    {
        public string id_numero { get; set; }
        public Frm_Alta_Numeros()
        {
            InitializeComponent();
        }

        private void Frm_Alta_Numeros_Load(object sender, EventArgs e)
        {
            cmb_nro_cliente.CargarCombo();
            cmb_nro_cliente.SelectedIndex = -1;
            
            cmb_id_disp.CargarCombo();
            cmb_id_disp.SelectedIndex = -1;
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            if (tratamientos.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Numeros numeros = new Numeros();


                
                numeros.Pp_cod_nacional = txt_cod_nacional.Text;
                numeros.Pp_cod_area = txt_cod_area.Text;
                numeros.Pp_nro_telefono = txt_nro_telefono.Text;
                numeros.Pp_nro_cliente = cmb_nro_cliente.SelectedValue.ToString();
                numeros.Pp_id_dispositivo = cmb_id_disp.SelectedValue.ToString();
                numeros.Pp_id_numero = id_numero;

                numeros.Insertar();

            }

            else
            {
                return;
            }
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
