using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Clases
{
    public class VendedorModel
    {
        #region Propiedades

        /// <summary>
        /// Almacena el código de la empresa
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Código del vendedor
        /// </summary>
        public int venIntCodigo { get; set; }
        /// <summary>
        /// Nombre del vendedor
        /// </summary>
        public string venChrNombre { get; set; }
        /// <summary>
        /// Tipo de vendedor
        /// </summary>
        public string venChrTipoVendedor { get; set; }
        /// <summary>
        /// Tipo de comisión del vendedor
        /// </summary>
        public string venChrTipoComision { get; set; }
        /// <summary>
        /// Porcentaje de comsisión del vendedor
        /// </summary>
        public decimal venMonPorcComision { get; set; }
        /// <summary>
        /// Correo electrónico del vendedor
        /// </summary>
        public string venChrEmail { get; set; }
        /// <summary>
        /// Teléfono del vendedor
        /// </summary>
        public string venChrTelefono { get; set; }
        /// <summary>
        /// Estado del vendedor
        /// </summary>
        public string venChrEstado { get; set; }
        /// <summary>
        /// Codigo de usuario que realiza los procesos al vendedor
        /// </summary>
        public int usuIntCodigo { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public VendedorModel()
        {
            empIntCodigo = 0;
            venIntCodigo = 0;
            venChrNombre = "";
            venChrTipoVendedor = "";
            venChrTipoComision = "";
            venMonPorcComision = 0;
            venChrEmail = "";
            venChrTelefono = "";
            venChrEstado = "";
            usuIntCodigo = 0;
        }

        #endregion

        #region Métodos Públicos

        public void pb_ObtenerVendedores(ref List<VendedorModel> ps_VendedorModel, string pe_chrDatoBusqueda)
        {
            try
            {
                pv_ObtenerVendedores(ref ps_VendedorModel, pe_chrDatoBusqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Privados

        private void pv_ObtenerVendedores(ref List<VendedorModel> ps_VendedorModel, string pe_chrDatoBusqueda)
        {
            try
            {
                vConnectionModel.pb_ObtenerVendedores(ref ps_VendedorModel, pe_chrDatoBusqueda);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
