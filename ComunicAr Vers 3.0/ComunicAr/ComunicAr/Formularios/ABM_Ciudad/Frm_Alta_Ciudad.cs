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

namespace ComunicAr.Formularios.ABM_Ciudad
{
    public partial class Frm_Alta_Ciudad : Form
    {
        public Frm_Alta_Ciudad()
        {
            InitializeComponent();
        }

        private void Frm_Alta_Ciudad_Load(object sender, EventArgs e)
        {
            cmb_alta_ciudad.CargarCombo();
            cmb_alta_ciudad.SelectedIndex = -1;
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Negocio.Ciudad ciudad = new Negocio.Ciudad();

                ciudad.Pp_nombreCiudad = txt_Nom_Ciud.Text;
                ciudad.Pp_codProvincia = cmb_alta_ciudad.SelectedValue.ToString();

                ciudad.Insertar();
            }
            else
            {
                return;
            }
        }
    }
}
