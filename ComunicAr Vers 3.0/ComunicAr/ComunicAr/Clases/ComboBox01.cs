﻿using System;
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
                    new DataColumn("id", typeof(Int32)),
                    new DataColumn("tipo", typeof(string))
            };
            table2.Columns.AddRange(cols);
            table2.Rows.Add(0, "Datos");
            table2.Rows.Add(1, "Fijos");
            table2.Rows.Add(2, "Prepagos");
            this.DisplayMember = "tipo";
            this.ValueMember = "id";
            this.DataSource = table2;
        }

        public void CargarComboServicio(string tipo)
        {
            
            if (tipo == "0")
            {
                string sql = "SELECT DISTINCT cod_datos as cod , descripcion FROM servicios_datos " ;
                DataTable tabla = new DataTable();
                tabla = _BD.EjecutarSelect(sql);
                this.DisplayMember = "descripcion";
                this.ValueMember = "cod";
                this.DataSource = tabla;

            }
            else if (tipo == "1")
            {
                string sql = "SELECT DISTINCT cod_servicio as cod, descripcion FROM servicio_fijo ";
                DataTable tabla = new DataTable();
                tabla = _BD.EjecutarSelect(sql);
                this.DisplayMember = "descripcion";
                this.ValueMember = "cod";
                this.DataSource = tabla;
            }

            else if (tipo == "2")
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
