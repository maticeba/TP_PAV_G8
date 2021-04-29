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
            }
        }
    }
}
