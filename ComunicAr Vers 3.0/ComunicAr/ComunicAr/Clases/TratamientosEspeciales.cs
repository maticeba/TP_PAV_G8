using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComunicAr.Clases
{
    class TratamientosEspeciales
    {
        public enum Resultado { correcto, error }
        public Resultado Validar(Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).Text == "")
                    {
                        MessageBox.Show(((TextBox01)item).Pp_MensajeError);
                        ((TextBox01)item).Focus();
                        return Resultado.error;
                    }
                }
            }
            return Resultado.correcto;
        }
    }
}
