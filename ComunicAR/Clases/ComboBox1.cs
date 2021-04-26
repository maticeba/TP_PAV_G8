using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ComunicAR.Clases
{
    class ComboBox1 : ComboBox
    {
        public string Pp_pk { get; set; }
        public string Pp_Descripcion { get; set; }
        public string Pp_Tabla { get; set; }
        Acceso_BD BD = new Acceso_BD();
        public void CargarCombo()
        {
            string sql = "SELECT" + Pp_pk + "FROM" + Pp_Tabla;
            DataTable tabla = new DataTable();
            tabla = BD.EjecutarSelect(sql);
            this.DisplayMember = Pp_Descripcion;
            this.ValueMember = Pp_pk;
            this.DataSource = tabla;
        }
     }

}
