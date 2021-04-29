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

                cliente.Insertar();
            }
            else
            {
                return;
            }
        }

        private void Frm_Alta_Cliente_Load(object sender, EventArgs e)
        {
            cmb_cliente_alta_barrio.CargarCombo(); 
        }
    }
}
