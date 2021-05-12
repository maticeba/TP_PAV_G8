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

namespace ComunicAr.Formularios.ABM_Dispositivos
{
    public partial class Frm_ABM_Alta_Dispositivo : Form
    {
        public Frm_ABM_Alta_Dispositivo()
        {
            InitializeComponent();
        }
        private void Frm_ABM_Alta_Dispositivo_Load(object sender, EventArgs e)
        {
            Cmb_tipo_dispositivo.CargarCombo();
        }
        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Negocio.Dispositivos dispositivos = new Negocio.Dispositivos();
                dispositivos.Pp_fecha_elaboracion = txt_fecha_elaboracion.Text;
                dispositivos.Pp_marca = txt_marca.Text;
                dispositivos.Pp_modelo = txt_modelo.Text;
                dispositivos.Pp_caracteristicas = txt_caracteristicas.Text;
                dispositivos.Pp_precio = txt_precio.Text;
                dispositivos.Pp_id_tipo_dispositivo = Cmb_tipo_dispositivo.SelectedValue.ToString();

                //cliente.Insertar(this.Controls);
                dispositivos.Insertar();
            }
            else
            {
                return;
            }
            this.Close();
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
                this.Close();

        }
    }
}
