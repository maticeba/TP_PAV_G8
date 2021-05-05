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

namespace ComunicAr.Formularios.ABM_Provincia
{
    public partial class Frm_Alta_Provincia : Form
    {
        public Frm_Alta_Provincia()
        {
            InitializeComponent();
        }

        private void Frm_Alta_Provincia_Load(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Negocio.Provincia provincia = new Negocio.Provincia();

                provincia.Pp_nombreProvincia = txt_nomProvincia.Text;

                provincia.Insertar();
            }
            else
            {
                return;
            }
        }
    }
}
