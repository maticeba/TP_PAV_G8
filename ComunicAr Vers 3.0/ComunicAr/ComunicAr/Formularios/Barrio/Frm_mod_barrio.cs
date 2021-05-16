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
using ComunicAr.Formularios.Barrio;
using ComunicAr.Negocio; 
namespace ComunicAr.Formularios.Barrio
{
    public partial class Frm_mod_barrio : Form
    {

        public string codigo_barrio { get; set; }
        public Frm_mod_barrio()
        {
            InitializeComponent();
        }

        private void btn_cliente_mod_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Negocio.Barrios barrio = new Negocio.Barrios();

                barrio.Pp_nombre_barrio = txt_nombre_barrio.Text;
                barrio.Pp_codigo_ciudad = cmb_codigo_ciudad.SelectedValue.ToString();
                barrio.Pp_codigo_barrio = codigo_barrio.ToString();

                //cliente.Insertar(this.Controls);
                barrio.Modificar();
            }
            else
            {
                return;
            }
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_nombre_barrio.Text = tabla.Rows[0]["nombre_barrio"].ToString();
            cmb_codigo_ciudad.SelectedValue = tabla.Rows[0]["id_ciudad"].ToString();
            
        }

        private void Frm_mod_barrio_Load(object sender, EventArgs e)
        {
            cmb_codigo_ciudad.CargarCombo();
            cmb_codigo_ciudad.SelectedIndex = -1;
            Barrios barrio = new Barrios();
            MostrarDatos(barrio.Barrios_por_codigo(codigo_barrio));
           
        }

        private void btn_cliente_alta_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
