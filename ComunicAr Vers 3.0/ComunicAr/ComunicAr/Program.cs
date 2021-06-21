using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComunicAr.Formularios.Estadisticas.Llamadas;
using ComunicAr.Formularios.Estadisticas.Servicios;

namespace ComunicAr
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Escritorio());
            //Application.Run(new Frm_Llamadas_Estadisticas());
            //Application.Run(new Frm_Servicios_Estadisiticas());
        }
    }

}
