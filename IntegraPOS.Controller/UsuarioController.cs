using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Controller
{
    public class UsuarioController
    {
        #region Propiedades

        public int empIntCodigo { get; set; }
        public int usuIntCodigo { get; set; }
        public string usuChrNombre { get; set; }
        public string usuChrCedula { get; set; }
        public string usuChrTipoCedula { get; set; }
        public string dirChrCodDireccion { get; set; }
        public string usuChrDireccionDet { get; set; }
        public string usuChrLogin { get; set; }
        public string usuBinClave { get; set; }
        public DateTime usuFecFechaClave { get; set; }
        public string usuBinPregunta { get; set; }
        public string usuBinRespuesta { get; set; }
        public int usuIntCantIntentos { get; set; }
        public bool usuBndCajero { get; set; }
        public int perIntCodigo { get; set; }
        public string usuChrEstado { get; set; }
        public int usuIntCodigoIng { get; set; }
        public DateTime usuFecFechaIng { get; set; }
        public int usuIntCodigoMod { get; set; }
        public DateTime usuFecFechaMod { get; set; }

        #endregion

        #region Metodos Publicos

        #region Constructor / Destructor

        public UsuarioController() { }

        ~UsuarioController() { }

        #endregion



        public void pb_InsertarUsuario()
        {
            throw new System.NotImplementedException();
        }

        public void pb_ActualizarUsuario()
        {
            throw new System.NotImplementedException();
        }

        public void pb_EliminarUsuario()
        {
            throw new System.NotImplementedException();
        }

        public void pb_ConsultarUsuarios()
        {
            throw new System.NotImplementedException();
        }

        public void pb_ValidarUsuario(string pe_usuChrLogin, string pe_usuBinClave, ref bool? ps_estadoProceso, ref string ps_mensaje)
        {
            try{
                char[] vCaracteres = { '@', '#', '$', '%', '^', '&', '*', '(', ')', ']', '*', '[', '!', '/', '=', '?', '¿' };

                for (int i = 0; i < pe_usuChrLogin.Length; i++) {
                    for (int j = 0; j < vCaracteres.Length; j++) {
                        if (pe_usuChrLogin.Substring(i, 1).Equals(vCaracteres[j].ToString())) {
                            ps_mensaje =  "El carácter '" + pe_usuChrLogin.Substring(i, 1) + "' no es válido como parte del nombre de usuario.";
                            ps_estadoProceso = false;
                        }
                    }
                }

                if(!ps_estadoProceso.Equals(false)) {
                    pv_ValidarUsuario(pe_usuChrLogin, pe_usuBinClave, ref ps_estadoProceso, ref ps_mensaje);
                }

            } catch(Exception ex) {
                throw ex;
            }           
        }

        #endregion

        #region Metodos Privados

        private void pv_ValidarUsuario(string pe_usuChrLogin, string pe_usuBinClave, ref bool? ps_estadoProceso, ref string ps_mensaje)
        {

        }

        #endregion
    }
}

