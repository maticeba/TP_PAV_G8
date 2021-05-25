using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Negocio_Transacciones;
using ComunicAr.Negocio;
using ComunicAr.Formularios.ABM_Llamadas;
using ComunicAr.Formularios.ABM_Numeros;
using System.Data;
using ComunicAr.Clases;

namespace ComunicAr.Formularios.Transaccion.Generar_Venta
{

    public partial class Frm_Generar_Ventas : Form
    {
        public string id_cliente { get; set; }
        public int id_Numero { get; set; }
        public string modelo { get; set; }

        public bool flag { get; set; }
        public bool flag2 { get; set; }

        public string codigo { get; set; }

        Acceso_BD BD = new Acceso_BD();
        public Frm_Generar_Ventas()
        {
            InitializeComponent();
        }

  
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Generar_Venta_Load(object sender, EventArgs e)
        {
            flag = false;
            

        }

        private void MostrarCliente(DataTable tabla)
        {
            flag = true;
            txt_nombre_cliente.Text = tabla.Rows[0]["nombre_razonSocial"].ToString();
            cmb_nmro_telefono.CargarComboXcliente(txt_id_cliente.Text, txt_nombre_cliente.Text);
            /*cmb_tipoDisp.CargarCombo();
            cmb_disp.CargarCombo();*/
        }
        private void bttn_CrearNuevo(object sender, EventArgs e)
        {
            Frm_Alta_Numeros Altas = new Frm_Alta_Numeros();
            Altas.ShowDialog();
        } 
        
        private void button3_Click(object sender, EventArgs e)
        {
            Numeros num = new Numeros();
            if (flag2)
            {
                string sqlMod = @"UPDATE numero SET  "
                            + " cod_nacional = '" + ((num.Numeros_por_id(cmb_nmro_telefono.SelectedValue.ToString())).Rows[0]["cod_nacional"].ToString()) + "'"
                            + ", cod_area = " + ((num.Numeros_por_id(cmb_nmro_telefono.SelectedValue.ToString())).Rows[0]["cod_area"].ToString())
                            + ", nro_telefono = " + ((num.Numeros_por_id(cmb_nmro_telefono.SelectedValue.ToString())).Rows[0]["nro_telefono"].ToString())
                            + ", nro_cliente = " + ((num.Numeros_por_id(cmb_nmro_telefono.SelectedValue.ToString())).Rows[0]["nro_cliente"].ToString())
                            + ", id_dispositivo = " + cmb_disp.SelectedValue.ToString()
                            + " WHERE id_numero = " + ((num.Numeros_por_id(cmb_nmro_telefono.SelectedValue.ToString())).Rows[0]["id_numero"].ToString());

                BD.EjecutarModificar(sqlMod);
                MessageBox.Show("Modificacion realizada con exito");
            }
            else
            {
                MessageBox.Show("No se ha seleccionado plan de cuotas, por favor ingrese las cuotas");
            }
        }
        private void bttn_crearSoloDisp_Click(object sender, EventArgs e)
        {
            if (flag)
            {

                
                cmb_disp.Enabled = true;
                cmb_tipoDisp.Enabled = true;
                System.Console.WriteLine(cmb_tipoDisp.SelectedIndex);
                cmb_tipoDisp.CargarCombo();
                cmb_cantCuota.Cuotas_Combo_Cargar();
                flag2 = true;

            }
            else
            {
                MessageBox.Show("No se ha seleccionado un numero, por favor ingrse el id de cliente");
            }
        }
        private void cmb_tipoDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmb_tipoDisp.SelectedIndex == 0)
            {
                cmb_disp.CargarComboDisp(1);
            }
            else
            {
                cmb_disp.CargarComboDisp(2);
            }
        }
        private void cmb_disp_SelectedIndexChanged(object sender, EventArgs e)
        {
            modelo = cmb_disp.SelectedValue.ToString();
            System.Console.WriteLine(modelo);
            Dispositivos disp = new Dispositivos();
            txt_precio.Text = (disp.FiltroXid(modelo)).Rows[0]["precio"].ToString();

            System.Console.WriteLine(cmb_tipoDisp.SelectedIndex);
            
        }
        private void MostrarDisp(DataTable tabla)
        {
            
            

        }
        private void cmb_nmro_telefono_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idNumero = cmb_nmro_telefono.SelectedValue.ToString();
            string[] id_numero = idNumero.Split(' ');
            
           

        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
   
            Clientes cliente = new Clientes();
            MostrarCliente(cliente.Clientes_por_solo_Numero(txt_id_cliente.Text));
            
           
        }

       

        private void button4_Click(object sender, EventArgs e)
        {

        }

        
    }
}
