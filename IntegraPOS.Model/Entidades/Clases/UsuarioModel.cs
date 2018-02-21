using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IntegraPOS.Model.Entidades.Clases
{
    /// <summary>
    /// Mantiene el objeto para usuarios de sistema
    /// </summary>
    public class UsuarioModel
    {
        #region Propiedades

        /// <summary>
        /// Mantiene el código de empresa al cual pertenece el usuario
        /// </summary>
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

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public UsuarioModel() {

            empIntCodigo = 0;
            usuIntCodigo = 0;
            usuChrNombre = "";
            usuChrCedula = "";
            usuChrTipoCedula = "";
            dirChrCodDireccion = "";
            usuChrDireccionDet = "";
            usuChrLogin = "";
            usuBinClave = "";
            usuFecFechaClave = DateTime.Now;
            usuBinPregunta = "";
            usuBinRespuesta = "";
            usuIntCantIntentos = 0;
            usuBndCajero = false;
            perIntCodigo = 0;
            usuChrEstado = "";
            usuIntCodigoIng = 0;
        }

        ~UsuarioModel() { }

        #endregion

        #region Metodos Publicos

        public void pb_InsertarUsuario(UsuarioModel p_usuario)
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

        public void pb_ValidarUsuario(UsuarioModel pe_UsuarioModel, ref UsuarioModel ps_UsuarioModel, ref bool? ps_estadoProceso, ref string ps_mensaje)
        {
            try
            {
                pv_ValidarUsuario(pe_UsuarioModel, ref ps_UsuarioModel, ref ps_estadoProceso, ref ps_mensaje);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Metodos Privados

        private void pv_ValidarUsuario(UsuarioModel pe_UsuarioModel, ref UsuarioModel ps_UsuarioModel, ref bool? ps_estadoProceso, ref string ps_mensaje)
        {
            try
            {
                vConnectionModel.pb_ValidarUsuario(pe_UsuarioModel, ref ps_UsuarioModel, ref ps_estadoProceso, ref ps_mensaje);

            } catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
