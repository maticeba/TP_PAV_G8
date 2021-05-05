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
using ComunicAr.Negocio;


namespace ComunicAr.Formularios.ABM_Servicios.Datos
{
    public partial class Frm_ABM_Datos_Modificar : Form
    {
        public string cod_Datos { get; set; }
        public Frm_ABM_Datos_Modificar()
        {
            InitializeComponent();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales Tratamiento = new TratamientosEspeciales();
            if (Tratamiento.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Negocio.Servicios_Datos datos = new Negocio.Servicios_Datos();

                datos.Pp_limite = txt_limite_M.Text;
                datos.Pp_descripcion = txt_descripcion_M.Text;
                datos.Pp_costofijo = txt_costoFijo_M.Text;
                datos.Pp_recargo = txt_recargo_M.Text;
                datos.Pp_tipoServicio = txt_Tipo.Text;
                datos.Pp_codDatos = cod_Datos;



                //cliente.Insertar(this.Controls);
                datos.Modificar();
            }
            else
            {
                return;
            }
            this.Close();

        }

        private void Frm_ABM_Datos_Modificar_Load(object sender, EventArgs e)
        {
            Servicios_Datos datos = new Servicios_Datos();
            MostrarDatos(datos.DatosXCodigo(cod_Datos));
        }
        private void MostrarDatos(DataTable tabla)
        {
            txt_Cod.Text = tabla.Rows[0]["cod_datos"].ToString();
            txt_limite_M.Text = tabla.Rows[0]["limite_datos"].ToString();
            txt_descripcion_M.Text = tabla.Rows[0]["descripcion"].ToString();
            txt_costoFijo_M.Text = tabla.Rows[0]["costo_fijo"].ToString();
            txt_recargo_M.Text = tabla.Rows[0]["recargo"].ToString();
            txt_Tipo.Text = tabla.Rows[0]["tipo_servicio"].ToString();


        }
    }

}
