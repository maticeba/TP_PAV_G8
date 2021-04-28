using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ComunicAR.Clases
{
    class ComboBox02: ComboBox
    {
        public string Pp_PK { get; set; }
        public string Pp_Descripcion { get; set; }

        public string Pp_Tabla { get; set; }
        public string Pp_NombreTabla { get; set; }
        public string Pp_NombreCampo { get; set; }

        public bool Pp_Conseleccion { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }

        Acceso_BD BD = new Acceso_BD();

        public void CargarCombo()
        {
            string sql = "SELECT " + Pp_PK + ", " + Pp_Descripcion + " FROM " + Pp_Tabla;
            this.DisplayMember = Pp_Descripcion;
            this.ValueMember = Pp_PK;
            this.DataSource = BD.EjecutarSelect(sql);

        }
    }
}
