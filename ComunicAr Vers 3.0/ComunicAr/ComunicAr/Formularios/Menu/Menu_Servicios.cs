using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.Servicios;
using ComunicAr.Formularios.ABM_Servicios.Datos;
using ComunicAr.Formularios.ABM_Servicios.Fijos;
using ComunicAr.Formularios.ABM_Servicios.Prepagos;

namespace ComunicAr.Formularios.Menu
{
    public partial class Menu_Servicios : Form
    {
        public Menu_Servicios()
        {
            InitializeComponent();
        }

        private void btn_menu_servicios_datos_Click(object sender, EventArgs e)
        {
            Frm_ABM_Datos datos = new Frm_ABM_Datos();
            datos.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_menu_servicios_fijo_Click(object sender, EventArgs e)
        {
            Frm_ABM_ServicioFijo fijo = new Frm_ABM_ServicioFijo();
            fijo.ShowDialog();
        }

        private void btn_menu_servicios_prepago_Click(object sender, EventArgs e)
        {
            Frm_ABM_Prepagos prepagos = new Frm_ABM_Prepagos();
            prepagos.ShowDialog();
        }

        private void btn_menu_servicios_contratados_Click(object sender, EventArgs e)
        {
            Frm_ABM_Servicios_Contratados contratados = new Frm_ABM_Servicios_Contratados();
            contratados.ShowDialog();
        }
    }
}
