using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicAr.Formularios.Estadisticas.Llamadas
{
    public partial class Frm_Llamadas_Estadisticas : Form
    {
        public Frm_Llamadas_Estadisticas()
        {
            InitializeComponent();
        }
        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //LLAMADAS POR TIPO DE COMUNICACION
        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void Frm_Llamadas_Estadisticas_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }

        private void rb_mes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_rango_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rb_todos_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///TERMINA LLAMADAS POR TIPO DE COMUNICACION
        ///EMPIEZA LLAMADAS POR MES
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
