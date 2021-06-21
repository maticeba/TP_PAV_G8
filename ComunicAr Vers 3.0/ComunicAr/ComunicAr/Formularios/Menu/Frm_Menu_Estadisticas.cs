using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.Estadisticas.Clientes;
//using ComunicAr.Formularios.Estadisticas.Dispositivos;
//using ComunicAr.Formularios.Estadisticas.DispVendidos;
using ComunicAr.Formularios.Estadisticas.Numeros;
using ComunicAr.Formularios.Estadisticas.Servicios;
//using ComunicAr.Formularios.Estadisticas.Llamada;
using ComunicAr.Formularios.Estadisticas.Dispositivos;

namespace ComunicAr.Formularios.Menu
{
    public partial class Frm_Menu_Estadisticas : Form
    {
        public Frm_Menu_Estadisticas()
        {
            InitializeComponent();
        }

        private void bnt_menu_esta_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_menu_esta_cliente_Click(object sender, EventArgs e)
        {
            Frm_Estadistica_Cliente estad_cliente = new Frm_Estadistica_Cliente();
            estad_cliente.ShowDialog();
        }

        private void bnt_menu_esta_dispositivos_Click(object sender, EventArgs e)
        {
            Frm_DispVend_Estadisticas dispv = new Frm_DispVend_Estadisticas();
            dispv.ShowDialog();
        }

        private void bnt_menu_esta_numero_Click(object sender, EventArgs e)
        {
            Frm_Estadisticas_Numeros nros = new Frm_Estadisticas_Numeros();
            nros.ShowDialog();
        }

        private void bnt_menu_esta_servicios_Click(object sender, EventArgs e)
        {
            Frm_Servicios_Estadisiticas servicios = new Frm_Servicios_Estadisiticas();
            servicios.ShowDialog();
        }

        private void bnt_menu_esta_llamadas_Click(object sender, EventArgs e)
        {

        }

        private void bnt_menu_esta_factura_Click(object sender, EventArgs e)
        {

        }
    }
}
