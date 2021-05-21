using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.Menu;

namespace ComunicAr
{
    public partial class Escritorio : Form
    {
        public Escritorio()
        {
            InitializeComponent();
        }

        private void Escritorio_Load(object sender, EventArgs e)
        {
            Frm_MenuGral Menu = new Frm_MenuGral();
            Menu.ShowDialog();
        }
    }
}
