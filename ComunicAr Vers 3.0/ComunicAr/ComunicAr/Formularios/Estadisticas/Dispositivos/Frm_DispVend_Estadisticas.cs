using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicAr.Formularios.Estadisticas.Dispositivos
{
    public partial class Frm_DispVend_Estadisticas : Form
    {
        public Frm_DispVend_Estadisticas()
        {
            InitializeComponent();
        }

        private void Frm_DispVend_Estadisticas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
