using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicAr.Formularios.Transaccion.Generar_Venta
{
    public partial class Frm_Generar_Venta : Form
    {
        public Frm_Generar_Venta()
        {
            InitializeComponent();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            /*if (txt_Venta_Cliente.Text == "")
            {
                MessageBox.Show("Ingrese un número de cliente");
                cmb_llamada_alta_tel_emisor.CargarCombo();
            }
            else
            {
                Llamadas llamadas = new Llamadas();
                DataTable existEmisor = new DataTable();
                existEmisor = llamadas.Search_cliente(txtBox_llamadas_alta_idEmisor.Text);
                if (existEmisor.Rows.Count == 0)
                {
                    MessageBox.Show("No se ha encontrado el cliente buscado");
                }
                else
                {
                    string nombre = existEmisor.Rows[0]["nombre_razonSocial"].ToString();
                    MessageBox.Show("El cliente emisor es " + nombre);
                    cmb_llamada_alta_tel_emisor.CargarComboXcliente(txtBox_llamadas_alta_idEmisor.Text, nombre);
                }
                
            }
            */
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
