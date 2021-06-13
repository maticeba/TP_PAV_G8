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
using ComunicAr.Clases;

namespace ComunicAr.Formularios.Transaccion.Generar_Venta
{

    public partial class Frm_Generar_Ventas : Form
    {
        public int id_cliente { get; set; }
        public int id_Numero { get; set; }
        public string modelo { get; set; }

        public bool flag { get; set; }
        public bool flag2 { get; set; }

        

        public string codigo { get; set; }

        public int Pp_nro_telefono { get; set; }

        public int Pp_id_dispositivo { get; set; }

     

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
            txt_fecha.Text = DateTime.Now.ToString("dd-MM-yyyy");
            

        }

        private void MostrarCliente(DataTable tabla)
        {
            flag = true;
            txt_nombre_cliente.Text = tabla.Rows[0]["nombre_razonSocial"].ToString();
            id_cliente = Convert.ToInt32(tabla.Rows[0]["nro_cliente"].ToString());
            cmb_nmro_telefono.CargarComboXcliente(txt_id_cliente.Text, txt_nombre_cliente.Text);
            
            /*cmb_tipoDisp.CargarCombo();
            cmb_disp.CargarCombo();*/
        }
        private void bttn_CrearNuevo(object sender, EventArgs e)
        {

            Frm_Alta_Numeros Altas = new Frm_Alta_Numeros();
            Altas.id_cliente = id_cliente;
            Altas.flag = true;
            Altas.txt_aviso.Visible = true;
            Altas.ShowDialog();
            
            cmb_nmro_telefono.CargarComboXcliente(txt_id_cliente.Text, txt_nombre_cliente.Text);
            cmb_nmro_telefono.SelectedIndex = cmb_nmro_telefono.Items.Count-1;

            cmb_nmro_telefono.Enable = false;
            crearsoloDisp();
            
        } 
        
        private void button3_Click(object sender, EventArgs e)
        {
            Numeros num = new Numeros();
            if (flag2)
            {
                if (txt_Descuento.Text == "")
                {
                    txt_Descuento.Text = "0";
                }
                string sqlMod = @"UPDATE numero SET  "
                            + " cod_nacional = '" + ((num.Numeros_por_id(cmb_nmro_telefono.SelectedValue.ToString())).Rows[0]["cod_nacional"].ToString()) + "'"
                            + ", cod_area = " + ((num.Numeros_por_id(cmb_nmro_telefono.SelectedValue.ToString())).Rows[0]["cod_area"].ToString())
                            + ", nro_telefono = " + ((num.Numeros_por_id(cmb_nmro_telefono.SelectedValue.ToString())).Rows[0]["nro_telefono"].ToString())
                            + ", nro_cliente = " + ((num.Numeros_por_id(cmb_nmro_telefono.SelectedValue.ToString())).Rows[0]["nro_cliente"].ToString())
                            + ", id_dispositivo = " + cmb_disp.SelectedValue.ToString()
                            + " WHERE id_numero = " + ((num.Numeros_por_id(cmb_nmro_telefono.SelectedValue.ToString())).Rows[0]["id_numero"].ToString());

                BD.EjecutarModificar(sqlMod);

                string sqlIN = @"INSERT INTO venta_dispositivo (fecha_Venta, id_dispositivo, cant_cuotas, descuento) "
                                + " VALUES (" + "'" + txt_fecha.Text.ToString() + "',"
                                              + cmb_disp.SelectedValue.ToString() + ","
                                              + "'" + cmb_cantCuota.SelectedValue.ToString() + "',"
                                              + txt_Descuento.Text + ")";
                BD.Insertar(sqlIN);
                MessageBox.Show("Modificacion realizada con exito");

                
            }
            else
            {
                MessageBox.Show("No se ha seleccionado plan de cuotas, por favor ingrese las cuotas");
            }
            this.Close();
        }
        public void Modificar_Venta()
        {
            string sqlMod = @"INSERT INTO venta_dispositivo (fecha_Venta, id_dispositivo, cant_cuotas, descuento) "
                                + " VALUES (" + "'" + txt_fecha.Text.ToString() + "',"
                                              + cmb_disp.SelectedValue.ToString() + ","
                                              + "'" + cmb_cantCuota.SelectedValue.ToString() + "', "
                                              + txt_Descuento.Text + ")";



            BD.EjecutarModificar(sqlMod);
            MessageBox.Show("Modificacion realizada con exito");
        }
        private void bttn_crearSoloDisp_Click(object sender, EventArgs e)
        {
            crearsoloDisp();
        }

        public void crearsoloDisp()
        {
            if (flag)
            {

                cmb_disp.Enabled = true;
                cmb_tipoDisp.Enabled = true;
                cmb_cantCuota.Enabled = true;
                txt_Descuento.Enabled = true;
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
            /*string idNumero = cmb_nmro_telefono.SelectedValue.ToString();*/
            

        }
        private void btn_buscar_Click(object sender, EventArgs e)
        {
   
            Clientes cliente = new Clientes();
            MostrarCliente(cliente.Clientes_por_solo_Numero(txt_id_cliente.Text));
            
           
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_fecha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
