using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Negocio;
using ComunicAr.Clases;


namespace ComunicAr.Formularios.ABM_Servicios.Contratados
{
    public partial class Frm_Modificacion_Servicios_Contratados : Form
    {
        public string cod_servicio { get; set; }
        public bool flag { get; set; }
        public Frm_Modificacion_Servicios_Contratados()
        {
            InitializeComponent();
        }

        private void Frm_Modificacion_Servicios_Load(object sender, EventArgs e)
        {
            if (flag == true)
            {
                cmb_tipo_servicio.Enabled = false;
                txt_fecha_desde.Enabled = false;
                btn_buscar_tipo_serv.Visible = false;
            }
            //cmb_tipo_servicio.CargarComboxTipo();
            Servicios_Contratados servicios = new Servicios_Contratados();
            MostrarDatos(servicios.Servicios_contratados_por_codigo(cod_servicio));
            //cmb_tipo_servicio.CargarComboxTipo();

        }

        private void MostrarDatos(DataTable tabla)
        {
            cmb_tipo_servicio.CargarComboxTipo();
            cmb_tipo_servicio.SelectedIndex = -1;
            string tipo = tabla.Rows[0]["tipo_servicio"].ToString();
            if (tipo == "A")
            {
                cmb_tipo_servicio.SelectedIndex = 0;
            }
            else if (tipo == "B")
            {
                cmb_tipo_servicio.SelectedIndex = 1;
            }
            else
            {
                cmb_tipo_servicio.SelectedIndex = 2;
            }

            cmb_servicio_ofrecido.CargarComboServicio(tipo);

            DataTable tabla1 = new DataTable();
            Servicios_Contratados servicio = new Servicios_Contratados();
            tabla1 = servicio.Search_servicio(tipo);

            for (int i = 0; i < tabla1.Rows.Count; i++)
            {
                if (tabla1.Rows[i][0].ToString() == tabla.Rows[0]["id_servicio"].ToString())
                {
                    cmb_servicio_ofrecido.SelectedIndex = i;
                }
            }

            Llamadas llamada = new Llamadas();
            DataTable tabla2 = new DataTable();
            string id_nro = tabla.Rows[0]["id_numero"].ToString();
            tabla2 = llamada.Search_datosNroXidNro(id_nro);

            string nro_cliente = tabla2.Rows[0]["nro_cliente"].ToString();

            txt_id_cliente.Text = tabla2.Rows[0]["nro_cliente"].ToString();

            cmb_numero.CargarComboXcliente(nro_cliente, tabla2.Rows[0]["nombre_cliente"].ToString());

            DataTable tabla3 = new DataTable();
            tabla3 = llamada.Search_numero(nro_cliente);

            for (int i = 0; i < tabla3.Rows.Count; i++)
            {
                if (tabla3.Rows[i]["id_numero"].ToString() == tabla2.Rows[0]["id_numero"].ToString())
                {
                    cmb_numero.SelectedIndex = i;
                }
            }

            string dia_desde = tabla.Rows[0]["dia_desde"].ToString();
            string mes_desde = tabla.Rows[0]["mes_desde"].ToString();
            string año_desde = tabla.Rows[0]["año_desde"].ToString();
            txt_fecha_desde.Text = dia_desde + "/" + mes_desde + "/" + año_desde;

            string dia_hasta = tabla.Rows[0]["dia_hasta"].ToString();
            string mes_hasta = tabla.Rows[0]["mes_hasta"].ToString();
            string año_hasta = tabla.Rows[0]["año_hasta"].ToString();
            txt_fecha_hasta.Text = dia_hasta + "/" + mes_hasta + "/" + año_hasta;
        }


        private void bttn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttn_aceptar_Click(object sender, EventArgs e)
        {
            TratamientosEspeciales tratamientos = new TratamientosEspeciales();
            if(tratamientos.Validar(Controls) == TratamientosEspeciales.Resultado.correcto)
            {
                Servicios_Contratados servicio = new Servicios_Contratados();

               
                servicio.Pp_tipo_servicio = cmb_tipo_servicio.SelectedValue.ToString();
                servicio.Pp_id_servicio = cmb_servicio_ofrecido.SelectedValue.ToString();
                servicio.Pp_fecha_desde = txt_fecha_desde.Text;
                servicio.Pp_fecha_hasta = txt_fecha_hasta.Text;
                servicio.Pp_id_numero = cmb_numero.SelectedValue.ToString();
                servicio.Pp_cod_servicio = cod_servicio;

                servicio.Modificar();

            }

            else
            {
                return;
            }
            this.Close();
        }

        private void txt_nombre_servicio_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_buscar_tipo_serv_Click(object sender, EventArgs e)
        {
            if (cmb_tipo_servicio.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccione un tipo de servicio");
            }
            else
            {
                cmb_servicio_ofrecido.CargarComboServicio(cmb_tipo_servicio.SelectedValue.ToString());

            }
        }
    }
}
