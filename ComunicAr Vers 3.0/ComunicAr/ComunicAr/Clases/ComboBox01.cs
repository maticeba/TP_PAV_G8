using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ComunicAr.Clases
{
    public class ComboBox01 : ComboBox
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
        public void Cargar_con_Ref(string referencia)
        {
            string sql = "SELECT DISTINCT " + Pp_Descripcion + " FROM " + Pp_Tabla + " WHERE cod_nacional =" + referencia  ;
            this.DisplayMember = Pp_Descripcion;
            this.ValueMember = Pp_Descripcion;
            this.DataSource = _BD.EjecutarSelect(sql);
        }

        public void CargarComboDisp(int tipo)
        {
            if (tipo == 1)
            {
                string sql = "SELECT DISTINCT " + Pp_PK + ", " + Pp_Descripcion + " FROM " + Pp_Tabla + " WHERE id_tipo_dispositivo = '" + 1 + "'";
                
                this.DisplayMember = Pp_Descripcion;
                this.ValueMember = Pp_PK;
                this.DataSource = _BD.EjecutarSelect(sql);
            }

            if (tipo == 2)
            {
                string sql = "SELECT DISTINCT " + Pp_PK + ", " + Pp_Descripcion + " FROM " + Pp_Tabla + " WHERE id_tipo_dispositivo = '" + 2 + "'";

                this.DisplayMember = Pp_Descripcion;
                this.ValueMember = Pp_PK;
                this.DataSource = _BD.EjecutarSelect(sql);
            }
        }

        public void CargarComboDispMej(int tipo, string marca)
        {
            if (tipo == 1)
            {
                string sql = "SELECT DISTINCT " + Pp_PK + ", " + Pp_Descripcion + " FROM " + Pp_Tabla + " WHERE id_tipo_dispositivo = '" + 1 + "' AND marca = '" + marca + "'";

                this.DisplayMember = Pp_Descripcion;
                this.ValueMember = Pp_PK;
                this.DataSource = _BD.EjecutarSelect(sql);
            }

            if (tipo == 2)
            {
                string sql = "SELECT DISTINCT " + Pp_PK + ", " + Pp_Descripcion + " FROM " + Pp_Tabla + " WHERE id_tipo_dispositivo = '" + 2 + "' AND marca = '" + marca + "'";

                this.DisplayMember = Pp_Descripcion;
                this.ValueMember = Pp_PK;
                this.DataSource = _BD.EjecutarSelect(sql);
            }
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

        public void Cargar_Combo_Ciudad(string Prov)
        {
            string sql = "SELECT DISTINCT cod_ciudad, nombre_ciudad FROM Ciudad WHERE id_provincia = " + Prov;
            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);
            this.DisplayMember = "nombre_ciudad";
            this.ValueMember = "cod_ciudad";
            this.DataSource = tabla;
            this.SelectedIndex = -1;
        }

        public void Cargar_Combo_Barrio(string Ciudad)
        {
            string sql = "SELECT DISTINCT cod_barrio, nombre_barrio FROM Barrio WHERE id_ciudad = " + Ciudad;
            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);
            this.DisplayMember = "nombre_barrio";
            this.ValueMember = "cod_barrio";
            this.DataSource = tabla;
        }

        public void Ciudad_Combo_Cargar(string cod_ciudad)
        {
            string sql = "SELECT DISTINCT cod_ciudad, nombre_ciudad FROM Ciudad WHERE cod_ciudad = " + cod_ciudad;
            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);
            this.DisplayMember = "nombre_ciudad";
            this.ValueMember = "cod_ciudad";
            this.DataSource = tabla;
            
        }
        public void Provincia_Combo_Cargar(string cod_prov)
        {
            string sql = "SELECT DISTINCT cod_prov, nombre_prov FROM Provincia WHERE cod_prov = " + cod_prov;
            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);
            this.DisplayMember = "nombre_prov";
            this.ValueMember = "cod_prov";
            this.DataSource = tabla;
        }

        public void Cuotas_Combo_Cargar()
        {
            DataTable table = new DataTable();
            DataColumn[] cols =
            {
                    new DataColumn("cantidad", typeof(string))
            };
            table.Columns.AddRange(cols);
            table.Rows.Add("1");
            table.Rows.Add("3");
            table.Rows.Add("6");
            table.Rows.Add("12");
            this.DisplayMember = "cantidad";
            this.ValueMember = "cantidad";
            this.DataSource = table;
        }

        public void Codigo_Nacional()
        {
            string sql = "SELECT " + Pp_Descripcion + " FROM " + Pp_Tabla + " GROUP BY " + Pp_Descripcion + " ORDER BY " + Pp_Descripcion + " DESC ";
            this.DisplayMember = Pp_Descripcion;
            this.ValueMember = Pp_PK;
            this.DataSource = _BD.EjecutarSelect(sql);

        }

        public void Marca()
        {
            string sql = "SELECT DISTINCT " + Pp_Descripcion + " FROM " + Pp_Tabla;
            this.DisplayMember = Pp_Descripcion;
            this.ValueMember = Pp_PK;
            this.DataSource = _BD.EjecutarSelect(sql);
        }
    }
}
