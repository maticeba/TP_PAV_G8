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
    public partial class Frm_ABM_Baja_Dispositivo : Form
    {
        public string id_dispositivo { get; set; }
        public Frm_ABM_Baja_Dispositivo()
        {
            InitializeComponent();
        }

        private void Frm_ABM_Baja_Dispositivo_Load(object sender, EventArgs e)
        {
            //Cmb_tipo_dispositivo.CargarCombo();
            Dispositivos dispositivo = new Dispositivos();
            MostrarDispo(dispositivo.FiltroXid(id_dispositivo));


        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void MostrarDispo(DataTable tabla)
        {
            txt_id_dispositivo_B.Text = tabla.Rows[0]["id_dispositivo"].ToString();
            txt_fecha_elaboracion_B.Text = tabla.Rows[0]["fecha_elaboracion"].ToString();
            txt_marca_B.Text = tabla.Rows[0]["marca"].ToString();
            txt_modelo_B.Text = tabla.Rows[0]["modelo"].ToString();
            txt_caracteristicas_B.Text = tabla.Rows[0]["caracteristicas"].ToString();
            txt_precio.Text = tabla.Rows[0]["precio"].ToString();
            Cmb_tipo_dispositivo.SelectedText = tabla.Rows[0]["nombre_tipo"].ToString();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            Dispositivos dispositivos = new Dispositivos() { Pp_id_dispositivo = id_dispositivo };

            if (MessageBox.Show("¿Esta seguro que desea eliminarlo definitivamente?", "AVISO", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                dispositivos.Borrar();
                MessageBox.Show("El Dispositivo fue borrado con exito!");

            }
            this.Close();
        }
    }
}
