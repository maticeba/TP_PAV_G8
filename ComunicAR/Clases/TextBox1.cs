using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ComunicAR.Clases
{
    class TextBox1 : TextBox
    {
        public string Pp_Tabla { get; set; }
        public string Pp_Campo { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }
    }
}
