using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicAr.Clases
{
    class TextBox01 : TextBox
    {
        public string Pp_Tabla { get; set; }
        public string Pp_Campo { get; set; }
        public bool Pp_Validable { get; set; }
        public string Pp_MensajeError { get; set; }
    }
}
