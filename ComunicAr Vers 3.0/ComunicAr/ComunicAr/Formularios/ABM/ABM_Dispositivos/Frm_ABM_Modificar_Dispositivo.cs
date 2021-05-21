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
using ComunicAr.Formularios.ABM_Dispositivos;



namespace ComunicAr.Formularios.ABM_Dispositivos
{
    public partial class Frm_ABM_Modificar_Dispositivo : Form
    {
        public string id_dispositivo { get; set; }
        public Frm_ABM_Modificar_Dispositivo()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Modificar_Dispositivo_Load(object sender, EventArgs e)
        {
            Cmb_tipo_dispositivo.CargarCombo();
            Dispositivos dispositivo = new Dispositivos();
            MostrarDispo(dispositivo.FiltroXid(id_dispositivo));

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Negocio.Dispositivos dispositivos = new Negocio.Dispositivos();

                dispositivos.Pp_fecha_elaboracion = txt_fecha_elaboracion_M.Text;
                dispositivos.Pp_precio = txt_precio_M.Text;
                dispositivos.Pp_modelo = txt_modelo_M.Text;
                dispositivos.Pp_caracteristicas = txt_caracteristicas_M.Text;
                dispositivos.Pp_marca = txt_marca_M.Text;
                dispositivos.Pp_id_dispositivo = id_dispositivo ;
                dispositivos.Pp_id_tipo_dispositivo = Cmb_tipo_dispositivo.SelectedValue.ToString();



                //cliente.Insertar(this.Controls);
                dispositivos.Modificar();
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
        private void MostrarDispo(DataTable tabla)
        {
            txt_id_dispositivo_M.Text = tabla.Rows[0]["id_dispositivo"].ToString();
            txt_fecha_elaboracion_M.Text = tabla.Rows[0]["fecha_elaboracion"].ToString();
            txt_marca_M.Text = tabla.Rows[0]["marca"].ToString();
            txt_modelo_M.Text = tabla.Rows[0]["modelo"].ToString();
            txt_caracteristicas_M.Text = tabla.Rows[0]["caracteristicas"].ToString();
            txt_precio_M.Text = tabla.Rows[0]["precio"].ToString();
            Cmb_tipo_dispositivo.SelectedIndex = int.Parse(tabla.Rows[0]["id_tipo_dispositivo"].ToString())-1;
        }
    }
}
