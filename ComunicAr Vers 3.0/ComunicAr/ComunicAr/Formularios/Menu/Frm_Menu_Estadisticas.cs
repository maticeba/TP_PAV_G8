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
//using ComunicAr.Formularios.Estadisticas.Numeros;
//using ComunicAr.Formularios.Estadisticas.ServiciosFijos;
//using ComunicAr.Formularios.Estadisticas.Llamada;

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
            
        }

        private void bnt_menu_esta_numero_Click(object sender, EventArgs e)
        {
            
        }

        private void bnt_menu_esta_servicios_Click(object sender, EventArgs e)
        {

        }

        private void bnt_menu_esta_llamadas_Click(object sender, EventArgs e)
        {

        }

        private void bnt_menu_esta_factura_Click(object sender, EventArgs e)
        {

        }
    }
}
