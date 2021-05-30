using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Clases;

namespace ComunicAr.Formularios.Transaccion.Detalles_Servicios.Detalle_Servicios_Datos
{
    public partial class Frm_Descuento_Datos : Form
    {
        public string Pp_codigo_servicios { get; set; }
        public float Pp_descuento { get; set; }

        public Frm_Descuento_Datos()
        {
            InitializeComponent();
        }
        
        private void Frm_Descuento_Datos_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string desc = txt_desc.Text;
            Acceso_BD BD = new Acceso_BD();
            string sql = @"UPDATE Servicios_contratados SET descuento = " + desc +
                " WHERE cod_servicio = " + Pp_codigo_servicios;
            BD.Insertar(sql);
            this.Close();
        }
    }
}
