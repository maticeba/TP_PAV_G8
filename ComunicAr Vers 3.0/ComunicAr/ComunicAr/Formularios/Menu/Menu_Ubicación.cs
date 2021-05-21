using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.Barrio;
using ComunicAr.Formularios.ABM_Provincia;
using ComunicAr.Formularios.ABM_Ciudad;

namespace ComunicAr.Formularios.Menu
{
    public partial class Menu_Ubicacion : Form
    {
        public Menu_Ubicacion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_menu_ubicacion_barrio_Click(object sender, EventArgs e)
        {
            Frm_ABM_Barrio barrio = new Frm_ABM_Barrio();
            barrio.ShowDialog();
        }

        private void btn_menu_ubicacion_ciudad_Click(object sender, EventArgs e)
        {
            Frm_ABM_Ciudad ciudad = new Frm_ABM_Ciudad();
            ciudad.ShowDialog();
        }

        private void btn_menu_ubicacion_provincia_Click(object sender, EventArgs e)
        {
            Frm_ABM_Provincia prov = new Frm_ABM_Provincia();
            prov.ShowDialog();
        }
    }
}
