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
using ComunicAr.Formularios.Servicios;
using ComunicAr.Formularios.ABM_Servicios.Datos;
using ComunicAr.Formularios.ABM_Servicios.Fijos;
using ComunicAr.Formularios.ABM_Llamadas;
using ComunicAr.Formularios.ABM_Dispositivos;
using ComunicAr.Formularios.ABM_Servicios.Prepagos;
using ComunicAr.Formularios.Barrio;

namespace ComunicAr.Formularios
{
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }
        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void cmb_Actual_Datos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmb_Actual_Datos.SelectedIndex == 0)
            {
                Frm_ABM_Cliente Frm_Cliente = new Frm_ABM_Cliente();
                Frm_Cliente.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;
            }

            if (cmb_Actual_Datos.SelectedIndex == 2)
            {
                Frm_ABM_Llamadas Frm_Llamada = new Frm_ABM_Llamadas();
                Frm_Llamada.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;
            }

            if (cmb_Actual_Datos.SelectedIndex == 3)
            {
                Frm_ABM_Dispositivos Frm_Dispositivo = new Frm_ABM_Dispositivos();
                Frm_Dispositivo.ShowDialog();
                cmb_Actual_Datos.SelectedIndex = -1;
            }

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

        }

        private void Frm_Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
