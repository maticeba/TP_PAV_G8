using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.ABM_Clientes;
using ComunicAr.Formularios.ABM_Llamadas;
using ComunicAr.Formularios.ABM_Dispositivos;
using ComunicAr.Formularios.ABM_Numeros;
using ComunicAr.Formularios.Menu;

namespace ComunicAr.Formularios
{
    public partial class Frm_Menu_ABM : Form
    {
        public Frm_Menu_ABM()
        {
            InitializeComponent();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /*


            if (cmb_Actual_Datos.SelectedIndex == 4)
            {
                Frm_ABM_Servicios_Contratados Frm_Servicios = new Servicios.Frm_ABM_Servicios_Contratados();
                Frm_Servicios.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;
            }

            if (cmb_Actual_Datos.SelectedIndex == 5)
            {
                Frm_ABM_Prepagos Frm_Servicios = new Frm_ABM_Prepagos();
                Frm_Servicios.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;
            }

            if (cmb_Actual_Datos.SelectedIndex == 6)
            {
                Frm_ABM_ServicioFijo Frm_Fijo = new Frm_ABM_ServicioFijo();
                Frm_Fijo.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;

            }

            if (cmb_Actual_Datos.SelectedIndex == 7)
            {
                Frm_ABM_Datos Frm_Datos = new Frm_ABM_Datos();
                Frm_Datos.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;

            }

            if (cmb_Actual_Datos.SelectedIndex == 8)
            {
                Frm_ABM_Barrio Frm_Datos = new Frm_ABM_Barrio();
                Frm_Datos.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;

            }
            if (cmb_Actual_Datos.SelectedIndex == 9)
            {
                Frm_ABM_Ciudad Frm_Ciudad = new Frm_ABM_Ciudad();
                Frm_Ciudad.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;
            }
            if (cmb_Actual_Datos.SelectedIndex == 10)
            {
                Frm_ABM_Provincia Frm_Provincia = new Frm_ABM_Provincia();
                Frm_Provincia.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;
            }

        }*/


        private void btn_menu_datos_cliente_Click(object sender, EventArgs e)
        {
            Frm_ABM_Cliente Clientes = new Frm_ABM_Cliente();
            Clientes.ShowDialog();
        }

        private void btn_menu_datos_nro_Click(object sender, EventArgs e)
        {
            Frm_ABM_Numeros Numeros = new Frm_ABM_Numeros();
            Numeros.ShowDialog();
        }

        private void btn_menu_datos_llamada_Click(object sender, EventArgs e)
        {
            Frm_ABM_Llamadas llamadas = new Frm_ABM_Llamadas();
            llamadas.ShowDialog();
        }

        private void btn_menu_datos_dispositivos_Click(object sender, EventArgs e)
        {
            Frm_ABM_Dispositivos dispositivos = new Frm_ABM_Dispositivos();
            dispositivos.ShowDialog();
        }

        private void btn_menu_datos_servicios_Click(object sender, EventArgs e)
        {
            Menu_Servicios servicios = new Menu_Servicios();
            servicios.ShowDialog();
        }

        private void btn_menu_datos_ubicación_Click(object sender, EventArgs e)
        {
            Menu_Ubicacion ubicacion = new Menu_Ubicacion();
            ubicacion.ShowDialog();
        }
    }
}
