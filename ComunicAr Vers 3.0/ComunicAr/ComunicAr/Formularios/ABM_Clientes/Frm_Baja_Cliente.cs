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

namespace ComunicAr.Formularios.ABM_Clientes
{
    public partial class Frm_Baja_Cliente : Form
    {
        public string nro_Cliente { get; set; }
        public Frm_Baja_Cliente()
        {
            InitializeComponent();
        }

        private void btn_cliente_alta_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_cliente_alta_aceptar_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes() { Pp_nroCliente = nro_Cliente };
            if (MessageBox.Show("¿Esta seguro de Borrar?", "Importante", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                clientes.Borrar();
                MessageBox.Show("Se borró correctamente el cliente");
            }
        }

        private void Frm_Mod_Cliente_Load(object sender, EventArgs e)
        {
            cmb_cliente_alta_barrio.CargarCombo();
            cmb_cliente_alta_barrio.SelectedIndex = -1;
            Clientes cliente = new Clientes();
            MostrarDatos(cliente.Clientes_por_Numero(nro_Cliente)); 
            
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_cliente_alta_nombre.Text = tabla.Rows[0]["nombre_razonSocial"].ToString();
            txt_cliente_alta_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_cliente_alta_nro.Text = tabla.Rows[0]["nro"].ToString();
            txt_cliente_alta_piso.Text = tabla.Rows[0]["piso"].ToString();
            cmb_cliente_alta_barrio.SelectedValue = int.Parse(tabla.Rows[0]["cod_barrio"].ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
