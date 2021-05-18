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

namespace ComunicAr.Formularios.ABM_Clientes
{
    public partial class Frm_Alta_Cliente : Form
    {
        public Frm_Alta_Cliente()
        {
            InitializeComponent();
        }

        private void btn_cliente_alta_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cliente_alta_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Negocio.Clientes cliente = new Negocio.Clientes();

                cliente.Pp_nombre = txt_cliente_alta_nombre.Text;
                cliente.Pp_calle = txt_cliente_alta_calle.Text;
                cliente.Pp_nro = txt_cliente_alta_nro.Text;
                cliente.Pp_piso = txt_cliente_alta_piso.Text;
                cliente.Pp_barrio = cmb_cliente_alta_barrio.SelectedValue.ToString();

                //cliente.Insertar(this.Controls);
                cliente.Insertar();
            }
            else
            {
                return;
            }
        }

        private void Frm_Alta_Cliente_Load(object sender, EventArgs e)
        {
            cmb_Provincias.CargarCombo();
            cmb_Provincias.SelectedIndex = -1;
            /*cmb_cliente_alta_barrio.CargarCombo();
            cmb_cliente_alta_barrio.SelectedIndex = -1; */
        }

        private void cmb_Provincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Provincias.SelectedIndex == -1)
            {
                cmb_Ciudades.SelectedIndex = -1;
            }
            else
            {
                cmb_Ciudades.Cargar_Combo_Ciudad(cmb_Provincias.SelectedValue.ToString());
               
            }
        }

        private void cmb_Ciudades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_Ciudades.SelectedIndex == -1)
            {
                cmb_cliente_alta_barrio.SelectedIndex = -1;
            }
            else
            {
                cmb_cliente_alta_barrio.Cargar_Combo_Barrio(cmb_Ciudades.SelectedValue.ToString());
            }
        }
    }
}
