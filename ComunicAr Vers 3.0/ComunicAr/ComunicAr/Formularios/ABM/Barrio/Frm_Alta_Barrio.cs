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

namespace ComunicAr.Formularios.Barrio
{
    public partial class Frm_Alta_Barrio : Form
    {
        public Frm_Alta_Barrio()
        {
            InitializeComponent();
        }

        private void btn_cliente_alta_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Negocio.Barrios barrio = new Negocio.Barrios();

                barrio.Pp_nombre_barrio = txt_nombre_barrio.Text;
                barrio.Pp_codigo_ciudad = cmb_codigo_ciudad.SelectedValue.ToString();


                //cliente.Insertar(this.Controls);
                barrio.Insertar();
            }
            else
            {
                return;
            }
            this.Close();
        }

        private void btn_cliente_alta_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Alta_Barrio_Load(object sender, EventArgs e)
        {
            cmb_codigo_ciudad.CargarCombo();
            cmb_codigo_ciudad.SelectedIndex = -1;
        }
    }
}
