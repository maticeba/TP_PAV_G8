using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ComunicAR.Formularios.ABM_Clientes;

namespace ComunicAR.Formularios
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();


        }

        private void Form_Menu_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
              
                Formularios.ABM_Clientes.Form_ABM_Cliente Form_Cliente = new Formularios.ABM_Clientes.Form_ABM_Cliente();
                Form_Cliente.ShowDialog();

            }
        }
    }
}
