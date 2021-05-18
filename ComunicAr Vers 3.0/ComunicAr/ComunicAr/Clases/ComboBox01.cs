using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ComunicAr.Clases
{
    class ComboBox01 : ComboBox
    {
        public string Pp_PK { get; set; }
        public string Pp_Descripcion { get; set; }

        public string Pp_Tabla { get; set; }
        public string Pp_NombreTabla { get; set; }
        public string Pp_NombreCampo { get; set; }

        public bool Pp_Conseleccion { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }

        Acceso_BD _BD = new Acceso_BD();

        public void CargarCombo()
        {
            string sql = "SELECT DISTINCT " + Pp_PK + ", " + Pp_Descripcion + " FROM " + Pp_Tabla;
            this.DisplayMember = Pp_Descripcion;
            this.ValueMember = Pp_PK;
            this.DataSource = _BD.EjecutarSelect(sql);

        }

        public void CargarComboxTipo()
        {
            DataTable table2 = new DataTable();
            DataColumn[] cols =
            {
                    new DataColumn("id", typeof(string)),
                    new DataColumn("tipo", typeof(string))
            };
            table2.Columns.AddRange(cols);
            table2.Rows.Add("A", "Datos");
            table2.Rows.Add("B", "Fijos");
            table2.Rows.Add("C", "Prepagos");
            this.DisplayMember = "tipo";
            this.ValueMember = "id";
            this.DataSource = table2;
        }

        public void CargarComboServicio(string tipo)
        {
            
            if (tipo == "A")
            {
                string sql = "SELECT DISTINCT cod_datos as cod , descripcion FROM servicios_datos " ;
                DataTable tabla = new DataTable();
                tabla = _BD.EjecutarSelect(sql);
                this.DisplayMember = "descripcion";
                this.ValueMember = "cod";
                this.DataSource = tabla;

            }
            else if (tipo == "B")
            {
                string sql = "SELECT DISTINCT cod_servicio as cod, descripcion FROM servicios_fijos ";
                DataTable tabla = new DataTable();
                tabla = _BD.EjecutarSelect(sql);
                this.DisplayMember = "descripcion";
                this.ValueMember = "cod";
                this.DataSource = tabla;
            }

            else if (tipo == "C")
            {
                string sql = "SELECT DISTINCT id_pack as cod, descripcion FROM servicios_prepago ";
                DataTable tabla = new DataTable();
                tabla = _BD.EjecutarSelect(sql);
                this.DisplayMember = "descripcion";
                this.ValueMember = "cod";
                this.DataSource = tabla;
            }
            else
            {
                MessageBox.Show("aca hay un problema " + tipo);
            }




        }

    }
}
