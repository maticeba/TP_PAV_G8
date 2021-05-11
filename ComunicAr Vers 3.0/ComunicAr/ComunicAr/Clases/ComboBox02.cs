using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ComunicAr.Clases
{
    class ComboBox02 : ComboBox
    {
        public string Pp_PK1 { get; set; }
        public string Pp_Descripcion2 { get; set; }
        public string Pp_Descripcion3 { get; set; }

        public string Pp_Descripcion1 { get; set; }

        public string Pp_Tabla { get; set; }
        public string Pp_NombreTabla { get; set; }
        public string Pp_NombreCampo { get; set; }

        public bool Pp_Conseleccion { get; set; }
        public bool Pp_Validable { get; set; }
        public bool Enable { get; set; }
        public string Pp_MensajeError { get; set; }

        Acceso_BD _BD = new Acceso_BD();

        public void CargarComboXcliente(string cliente, string nombre)
        {
            if (cliente == " ")
            {
                this.DisplayMember = "+xx xxx xxxxxxxx";
                this.SelectedIndex = -1;
            }
            else
            {
                string sql = @"SELECT " + Pp_PK1 + ", " + Pp_Descripcion2 + ", " + Pp_Descripcion3 + ", " + Pp_Descripcion1 + " FROM " + Pp_Tabla +
                                " WHERE nro_cliente = " + cliente;
                DataTable table = new DataTable();
                table = _BD.EjecutarSelect(sql);
                if (table.Rows.Count == 0)
                {
                    this.SelectedIndex = -1;
                    MessageBox.Show("El cliente " + nombre + " no tiene telefonos asignados");
                }
                else
                {
                    DataTable table2 = new DataTable();
                    DataColumn[] cols =
                    {
                    new DataColumn("id_numero", typeof(Int32)),
                    new DataColumn("nro_completo", typeof(string))
                    };
                    table2.Columns.AddRange(cols);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        string cod_nac = table.Rows[i]["cod_nacional"].ToString();
                        string cod_area = table.Rows[i]["cod_area"].ToString();
                        string nro_tel = table.Rows[i]["nro_telefono"].ToString();
                        Int32 id_numero = int.Parse(table.Rows[i][0].ToString());
                        string nro_completo = "+" + cod_nac + " " + cod_area + " " + nro_tel;
                        table2.Rows.Add(id_numero, nro_completo);
                    }
                    this.DisplayMember = "nro_completo";
                    this.ValueMember = "id_numero";
                    this.DataSource = table2;

                }
            }
        }

        public void CargarCombo()
        {
            DataTable table1 = new DataTable();
            DataColumn[] cols =
            {
                    new DataColumn("id_numero", typeof(string)),
                    new DataColumn("nro_completo", typeof(string))
                };
            table1.Columns.AddRange(cols);
            table1.Rows.Add("-1", "+xx xxx xxxxxxx");
            this.DisplayMember = "nro_completo";
            this.ValueMember = "id_numero";
            this.DataSource = table1;
        }

        public void CargarComboXhora()
        {
            DataTable table = new DataTable();
            DataColumn[] cols =
            {
                    new DataColumn("horas", typeof(string)),
                };
            table.Columns.AddRange(cols);
            table.Rows.Add("00");
            table.Rows.Add("01");
            table.Rows.Add("02");
            table.Rows.Add("03");
            table.Rows.Add("04");
            table.Rows.Add("05");
            table.Rows.Add("06");
            table.Rows.Add("07");
            table.Rows.Add("08");
            table.Rows.Add("09");
            table.Rows.Add("10");
            table.Rows.Add("11");
            table.Rows.Add("12");
            table.Rows.Add("13");
            table.Rows.Add("14");
            table.Rows.Add("15");
            table.Rows.Add("16");
            table.Rows.Add("17");
            table.Rows.Add("18");
            table.Rows.Add("19");
            table.Rows.Add("20");
            table.Rows.Add("21");
            table.Rows.Add("22");
            table.Rows.Add("23");
            this.DisplayMember = "horas";
            this.ValueMember = "horas";
            this.DataSource = table;
        }
        public void CargarComboXminXseg()
        {
            DataTable table = new DataTable();
            DataColumn[] cols =
            {
                    new DataColumn("minXsegs", typeof(string)),
                };
            table.Columns.AddRange(cols);
            table.Rows.Add("00");
            table.Rows.Add("01");
            table.Rows.Add("02");
            table.Rows.Add("03");
            table.Rows.Add("04");
            table.Rows.Add("05");
            table.Rows.Add("06");
            table.Rows.Add("07");
            table.Rows.Add("08");
            table.Rows.Add("09");
            table.Rows.Add("10");
            table.Rows.Add("11");
            table.Rows.Add("12");
            table.Rows.Add("13");
            table.Rows.Add("14");
            table.Rows.Add("15");
            table.Rows.Add("16");
            table.Rows.Add("17");
            table.Rows.Add("18");
            table.Rows.Add("19");
            table.Rows.Add("20");
            table.Rows.Add("21");
            table.Rows.Add("22");
            table.Rows.Add("23");
            table.Rows.Add("24");
            table.Rows.Add("25");
            table.Rows.Add("26");
            table.Rows.Add("27");
            table.Rows.Add("28");
            table.Rows.Add("29");
            table.Rows.Add("30");
            table.Rows.Add("31");
            table.Rows.Add("32");
            table.Rows.Add("33");
            table.Rows.Add("34");
            table.Rows.Add("35");
            table.Rows.Add("36");
            table.Rows.Add("37");
            table.Rows.Add("38");
            table.Rows.Add("39");
            table.Rows.Add("40");
            table.Rows.Add("41");
            table.Rows.Add("42");
            table.Rows.Add("43");
            table.Rows.Add("44");
            table.Rows.Add("45");
            table.Rows.Add("46");
            table.Rows.Add("47");
            table.Rows.Add("48");
            table.Rows.Add("49");
            table.Rows.Add("50");
            table.Rows.Add("51");
            table.Rows.Add("52");
            table.Rows.Add("53");
            table.Rows.Add("54");
            table.Rows.Add("55");
            table.Rows.Add("56");
            table.Rows.Add("57");
            table.Rows.Add("58");
            table.Rows.Add("59");
            this.DisplayMember = "minXsegs";
            this.ValueMember = "minXsegs";
            this.DataSource = table;
        }
    }
}
