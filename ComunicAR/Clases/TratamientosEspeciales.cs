using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ComunicAR.Clases
{
    class TratamientosEspeciales
    {
        public enum Resultado {correcto, error }
        public Resultado Validar (Control.ControlCollection controles) 
        {
            foreach (var item in controles) 
            {
                if (item.GetType().Name=="TextBox1")
                {
                    if (((TextBox1)item).Text=="")
                    {
                        MessageBox.Show(((TextBox1)item).Pp_MensajeError);
                        ((TextBox1)item).Focus();
                        return Resultado.error;


                    }
                        
                    
                }

            }
            return Resultado.correcto;
        }   
    }
}
