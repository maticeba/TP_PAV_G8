using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAR.Clases;
using ComunicAR.Negocio;




namespace ComunicAR.Formularios.ABM_Clientes
{
    public partial class Form_Altas_Clientes : Form
    {
        public Form_Altas_Clientes()
        {
            InitializeComponent();
        }

        private void Form_Altas_Clientes_Load(object sender, EventArgs e)
        {
            Acceso_BD BD = new Acceso_BD();
            DataTable tabla = new DataTable();
            string sql = "SELECT cod_barrio, nombre_barrio FROM barrios";
            tabla = BD.EjecutarSelect(sql);
            cb_Barrio.DisplayMember = "nombre_barrio";
            cb_Barrio.ValueMember = "cod_barrio";
            cb_Barrio.DataSource = tabla;

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if(Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Negocio.Clientes cliente = new Negocio.Clientes();

                cliente.Pp_nombre = textBox11.Text;
                cliente.Pp_calle = textBox14.Text;
                cliente.Pp_nro = textBox13.Text;
                cliente.Pp_piso = textBox12.Text;
                cliente.Pp_barrio = cb_Barrio.SelectedValue.ToString();

                cliente.Insertar();
            }
            else
            {
                return;
            }
        }
    }
}
