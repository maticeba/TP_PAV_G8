using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Transaccion.Emision_de_Factura;

namespace ComunicAr.Formularios.Menu
{
    public partial class Frm_MenuGral : Form
    {
        public Frm_MenuGral()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_menu_gral_lista_Click(object sender, EventArgs e)
        {

        }

        private void btn_menu_gral_datos_Click(object sender, EventArgs e)
        {
            Frm_Menu_ABM Frm_menu_ABM = new Frm_Menu_ABM();
            Frm_menu_ABM.Show();
        }

        private void Frm_MenuGral_Load(object sender, EventArgs e)
        {

        }

        private void btn_gral_factura_Click(object sender, EventArgs e)
        {
            Frm_EmisionFactura Frm_Emision = new Frm_EmisionFactura();
            Frm_Emision.ShowDialog();
        }
    }
}
