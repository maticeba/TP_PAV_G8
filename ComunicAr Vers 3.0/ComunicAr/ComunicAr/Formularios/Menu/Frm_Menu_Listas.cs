using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.Reportes.Clientes;

namespace ComunicAr.Formularios.Menu
{
    public partial class Frm_Menu_Listas : Form
    {
        public Frm_Menu_Listas()
        {
            InitializeComponent();
        }

        private void bnt_menu_lista_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_menu_lista_cliente_Click(object sender, EventArgs e)
        {
            Reporte_para_Clientes Rep_cliente = new Reporte_para_Clientes();
            Rep_cliente.ShowDialog();
        }
    }
}
