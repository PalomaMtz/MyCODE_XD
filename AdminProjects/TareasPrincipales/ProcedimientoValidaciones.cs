using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Globalization;

namespace AdminProjects.TareasPrincipales
{
    public class ProcedimientoValidaciones
    {
        bool valido = false;

        public Boolean ValidarRFC(String _RFC)
        {
            //Método que tiene la función de validar el rfc
            valido = false;
            _RFC = _RFC.ToUpper();
            string expresion1 = "[A-Z]{4}[0-9]{6}[A-Z0-9]{3}",
                expresion2 = "[A-Z]{3}[0-9]{6}[A-Z0-9]{3}";

            if (Regex.IsMatch(_RFC, expresion1) || Regex.IsMatch(_RFC, expresion2))
            {
                if (Regex.Replace(_RFC, expresion1, String.Empty).Length == 0 || Regex.Replace(_RFC, expresion2, String.Empty).Length == 0)
                {
                    valido = true;
                }
            }
            return valido;

        }

        public Boolean ValidarTelefono(string _telefono)
        {
            valido = false;
            string expresion1 = "[+]{1}[0-9]{12}",
                expresion2 = "[0-9]{10}",
                expresion3 = "[0-9]{12}";            //Método que tiene la función de validar el numero de telefono
            if (Regex.IsMatch(_telefono, expresion1) || Regex.IsMatch(_telefono, expresion2) || Regex.IsMatch(_telefono, expresion3))
            {
                if (Regex.Replace(_telefono, expresion1, String.Empty).Length == 0 || Regex.Replace(_telefono, expresion2, String.Empty).Length == 0 || Regex.Replace(_telefono, expresion3, String.Empty).Length == 0)
                {
                    valido = true;
                }
            }
            return valido;

        }

        public Boolean ValidarCorreo(string _correo)
        {
            //Validamos el correo
            String expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            bool validado = false;

            if (Regex.IsMatch(_correo, expresion))
            {
                if (Regex.Replace(_correo, expresion, String.Empty).Length == 0)
                {
                    validado = true;
                }
            }
            return validado;
        }


        public bool ValidarEmail(string _correo)
        {
            valido= false;
           // regresar true  si el e-mail tiene formato valido
            try
            {
                return Regex.IsMatch(_correo,
                      @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                      @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                      RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

     }
}
