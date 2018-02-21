using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Miscelaneos
{
    public class ConfigEmpresaModelMisc
    {
        #region Propiedades

        /// <summary>
        /// Almacena si se puede digitar un monto superior al precio del producto
        /// </summary>
        //public string BndEditMontoSupPrecio { get; set; }
        /// <summary>
        /// Almacena el formato del codigo de cliente
        /// </summary>
        //public string CnfClientes { get; set; }
        /// <summary>
        /// Almacena la cantidad de decimales a utilizar en el costo
        /// </summary>
        //public string CnfDecimalesCostos { get; set; }
        /// <summary>
        /// Almacena la cantidad de decimales a utilizar en el costo de inventario
        /// </summary>
        //public string CnfDecimalesCostosINV { get; set; }
        /// <summary>
        /// Almacena la cantidad de decimales a utilizar en el precio
        /// </summary>
        public string CnfDecimalesPrecio { get; set; }
        /// <summary>
        /// Almacena la cantidad de decimales a utilizar en los montos
        /// </summary>
        public string CnfDecimalesMontos { get; set; }
        /// <summary>
        /// Almacena la cuenta contable de crédito estándar para los clientes nuevos
        /// </summary>
        public string CnfCuentaCredito { get; set; }
        /// <summary>
        /// Almacena la configuración de niveles para el maestro de clientes
        /// </summary>
        public string CnfNivelesClientes { get; set; }
        /// <summary>
        /// Almacena el formato del codigo de productos
        /// </summary>
        //public string CnfInventario { get; set; }
        /// <summary>
        /// Almacena el formato de codigo para proveedores
        /// </summary>
        //public string CnfProveedores { get; set; }
        /// <summary>
        /// Almacena si la contabilidad se va a realizar por bodega
        /// </summary>
        public string ContabxBod { get; set; }
        /// <summary>
        /// Almacena la cantidad de decimales para los asientos
        /// </summary>
        public string DecimalAsiento { get; set; }
        /// <summary>
        /// Almacena si se puede editar el tipo de cambio
        /// </summary>
        public string EditTipoCambio { get; set; }
        /// <summary>
        /// Almacena la fecha de inicio del periodo
        /// </summary>
        public string FecIniPeriodo { get; set; }
        /// <summary>
        /// Almacena la fecha de inactividad del periodo
        /// </summary>
        public string FecInaPeriodo { get; set; }
        /// <summary>
        /// Almacena la fecha fin del periodo
        /// </summary>
        public string FecFinPeriodo { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public ConfigEmpresaModelMisc()
        {
            //BndEditMontoSupPrecio = "";
            //CnfClientes = "";
            //CnfDecimalesCostos = "";
            //CnfDecimalesCostosINV = "";
            CnfDecimalesPrecio = "";
            CnfDecimalesMontos = "";
            CnfCuentaCredito = "";
            //CnfInventario = "";
            //CnfProveedores = "";
            ContabxBod = "";
            DecimalAsiento = "";
            EditTipoCambio = "";
            FecIniPeriodo = "";
            FecInaPeriodo = "";
            FecFinPeriodo = "";
        }

        ~ConfigEmpresaModelMisc() { }

        #endregion

        #region Métodos Públicos

        public void pb_ObtenerConfigEmpresa(ref ConfigEmpresaModelMisc ps_ConfigEmpresaModelMisc)
        {
            try
            {
                pv_ObtenerConfigEmpresa(ref ps_ConfigEmpresaModelMisc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Privados

        public void pv_ObtenerConfigEmpresa(ref ConfigEmpresaModelMisc ps_ConfigEmpresaModelMisc)
        {
            try
            {
                vConnectionModel.pb_ObtenerConfigEmpresa(ref ps_ConfigEmpresaModelMisc);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
