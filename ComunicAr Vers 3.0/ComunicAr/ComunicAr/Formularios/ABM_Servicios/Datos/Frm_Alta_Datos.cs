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


namespace ComunicAr.Formularios.ABM_Servicios.Datos
{
    public partial class Frm_Alta_Datos : Form
    {
        public Frm_Alta_Datos()
        {
            InitializeComponent();
        }

        private void btn_aceptar_datos(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Negocio.Servicios_Datos datos = new Negocio.Servicios_Datos();
                datos.Pp_limite = txt_limite.Text;
                datos.Pp_descripcion = txt_descripcion.Text;
                datos.Pp_costofijo = txt_costoFijo.Text;


                datos.Insertar();
            }
            else
            {
                return;
            }
            this.Close();

        }
        private void btn_Cancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Alta_Datos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
