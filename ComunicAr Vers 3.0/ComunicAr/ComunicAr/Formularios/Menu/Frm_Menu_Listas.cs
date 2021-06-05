using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
