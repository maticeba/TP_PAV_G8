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
    public partial class Frm_Mod_Cliente : Form
    {
        public string nro_Cliente { get; set; }
        public Frm_Mod_Cliente()
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
                cliente.Pp_nroCliente = nro_Cliente;

                cliente.Modificar();
                this.Close();

            }
            else
            {
                return;
            }
        }

        private void Frm_Mod_Cliente_Load(object sender, EventArgs e)
        {
            //cmb_cliente_alta_barrio.CargarCombo();
            //cmb_cliente_alta_barrio.SelectedIndex = -1;
            Clientes cliente = new Clientes();
            MostrarDatos(cliente.Clientes_por_Numero(nro_Cliente));
            
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_cliente_alta_nombre.Text = tabla.Rows[0]["nombre_razonSocial"].ToString();
            txt_cliente_alta_calle.Text = tabla.Rows[0]["calle"].ToString();
            txt_cliente_alta_nro.Text = tabla.Rows[0]["nro"].ToString();
            txt_cliente_alta_piso.Text = tabla.Rows[0]["piso"].ToString();
            //cmb_cliente_alta_barrio.SelectedValue = int.Parse(tabla.Rows[0]["cod_barrio"].ToString());
            DataTable ubicacion = new DataTable();
            Clientes busqueda = new Clientes();
            string cod_b = tabla.Rows[0]["cod_barrio"].ToString();
            ubicacion = busqueda.Obtener_ubicacion(cod_b);
            //cmb_Ciudades.Ciudad_Combo_Cargar(ubicacion.Rows[0]["cod_ciudad"].ToString());
            cmb_Provincias.CargarCombo();
            cmb_Provincias.SelectedValue = ubicacion.Rows[0]["cod_prov"].ToString();
            cmb_Ciudades.Cargar_Combo_Ciudad(ubicacion.Rows[0]["cod_prov"].ToString());
            cmb_Ciudades.SelectedValue= ubicacion.Rows[0]["cod_ciudad"].ToString();
            cmb_cliente_alta_barrio.Cargar_Combo_Barrio(ubicacion.Rows[0]["cod_ciudad"].ToString());
            cmb_cliente_alta_barrio.SelectedValue = int.Parse(tabla.Rows[0]["cod_barrio"].ToString());

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
