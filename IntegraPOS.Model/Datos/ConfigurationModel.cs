using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model
{
    public class ConfigurationModel
    {

        #region Propiedades

        /// <summary>
        /// Código de empresa con la que va a trabajar la aplicación.
        /// </summary>
        public readonly string codEmpresa = ConfigurationManager.AppSettings["codEmpresa"];

        /// <summary>
        /// Código de usuario con el que va a trabajar la aplicación.
        /// </summary>
        public readonly string codUsuario = ConfigurationManager.AppSettings["codUsuarioDefault"];

        /// <summary>
        /// Código de sucursal con la que va a trabajar la aplicación.
        /// </summary>
        public readonly string codSucursal = ConfigurationManager.AppSettings["codSucursalDefault"];

        /// <summary>
        /// Código de caja con la que va a trabajar por defecto la aplicación.
        /// </summary>
        public readonly string codCaja = ConfigurationManager.AppSettings["codCajaDefault"];

        /// <summary>
        /// Código del tipo de transaccion para ventas con el que va a trabajar por defecto la aplicación.
        /// </summary>
        public readonly string codTipoTransacVenta = ConfigurationManager.AppSettings["codTipoTransacVentaDefault"];

        /// <summary>
        /// Código de bodega con la que va a trabajar por defecto la aplicación.
        /// </summary>
        public readonly string codBodega = ConfigurationManager.AppSettings["codBodegaDefault"];

        /// <summary>
        /// Lista de Cajas configuradas.
        /// </summary>
        //public readonly string listaCajas = ConfigurationManager.AppSettings[""];

        /// <summary>
        /// Lista de Bodegas configuradas.
        /// </summary>
        //public string listaBodegas { get; set; }

        #endregion

        #region Constructor / Destructor

        public ConfigurationModel() { }

        ~ConfigurationModel() { }

        #endregion

    }
}
