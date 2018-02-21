using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework.Controls;

namespace IntegraPOS.View.Clases
{
    public class RegExp
    {
        private string regexpCorreo = @"([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";
        private string regexpNombre = @"[a-zA-ZñÑ\s]{2,100}";
        private string regexpTelefono = @"^[+-] ?\d+(\.\d+)?$";
        private string regexpNumero = @"[0-9]{1,9}(\.[0-9]{0,2})?$";
        private string regexpLetras = @"[a-zA-ZñÑ\s]";
        private string regexpLetraNumero = @"[a-zA-ZñÑ\d]";

        public RegExp()
        {
        }

        ~RegExp()
        {
        }

        public bool pb_ValidarRegExp(MetroTextBox pe_control, string pe_tipo)
        {
            bool estado = true;

            switch (pe_tipo)
            {
                case "correo":
                    Regex correo = new Regex(regexpCorreo);
                    estado = (correo.IsMatch(pe_control.Text)) ? true : false;
                    break;

                case "nombre":
                    Regex nombre = new Regex(regexpNombre);
                    estado = (nombre.IsMatch(pe_control.Text)) ? true : false;
                    break;

                case "telefono":
                    Regex telefono  = new Regex(regexpTelefono);
                    estado = (telefono.IsMatch(pe_control.Text)) ? true : false;
                    break;

                case "numero":
                    Regex numero = new Regex(regexpNumero);
                    estado = (numero.IsMatch(pe_control.Text)) ? true : false;
                    break;

                case "letras":
                    Regex letras= new Regex(regexpLetras);
                    estado = (letras.IsMatch(pe_control.Text)) ? true : false;
                    break;
                case "letraNumero":
                    Regex letraNumero = new Regex(regexpLetraNumero);
                    estado = (letraNumero.IsMatch(pe_control.Text)) ? true : false;
                    break;

                default:
                    break;
            }

            return estado;
        }
    }
}
