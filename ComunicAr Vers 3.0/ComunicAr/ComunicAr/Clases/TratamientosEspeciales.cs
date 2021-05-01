using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

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
        //FUNCION PARA CONSTRUIR INSERT
        public string ConstructorInsert(string NombreTabla, Control.ControlCollection controles)
        {
            string sql = "INSERT INTO " + NombreTabla + " (";
            string columna = "";
            string valorColumna = "";
            string tipoDatoColumna = "";
            string paqueteColumnas = "";
            string paqueteValores = "";
            DataTable Estructura = new DataTable();

            Estructura = BuscarEstructuraTabla(NombreTabla);
            for (int i = 0; i < Estructura.Columns.Count; i++)
            {
                columna = Estructura.Columns[i].Caption;
                tipoDatoColumna = Estructura.Columns[i].DataType.Name;
                valorColumna = BuscarColumnaEnControles(columna, controles);

                if (valorColumna != string.Empty)
                {
                    valorColumna = FormatearDato(valorColumna, tipoDatoColumna);

                    if (paqueteColumnas == "")
                    {
                        paqueteColumnas = columna;
                        paqueteValores = valorColumna;
                    }
                    else
                    {
                        paqueteColumnas += ", " + columna;
                        paqueteValores += ", " + valorColumna;
                    }
                }
            }
            sql += paqueteColumnas + ") VALUES (" + paqueteValores + ")";
            return sql;
        }

        private DataTable BuscarEstructuraTabla(string NombreTabla)
        {
            Acceso_BD BD = new Acceso_BD();
            return BD.EjecutarSelect("SELECT TOP 1 * FROM " + NombreTabla);
        }

        private string BuscarColumnaEnControles(string campo, Control.ControlCollection controles)
        {
            foreach (var item in controles)
            {
                if (item.GetType().Name == "TextBox01")
                {
                    if (((TextBox01)item).Pp_Campo == campo)
                    {
                        return ((TextBox01)item).Text;
                    }
                }
                if (item.GetType().Name == "ComboBox01")
                {
                    if (((ComboBox01)item).Pp_NombreCampo == campo)
                    {
                        return ((ComboBox01)item).SelectedValue.ToString();
                    }
                }
            }
            return "";
        }

        private string FormatearDato(string valorColumna, string tipoDatoColumna)
        {
            switch (tipoDatoColumna)
            {
                case "String":
                    return "'" + valorColumna + "'";
                case "Int 16":
                case "Int 32":
                case "Int 64":
                    return valorColumna;
                default:
                    return valorColumna;
            }
        }
        //FUNCION PARA CONSTRUIR MODIFICAR
    }

}
