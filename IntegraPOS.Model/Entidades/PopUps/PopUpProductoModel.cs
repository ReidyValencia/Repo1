using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.PopUps
{
    public class PopUpProductoModel
    {
        #region Propiedades

        /// <summary>
        /// Código de empresa
        /// </summary>
        public int empIntCodigo { get; set; }
        /// <summary>
        /// Código de producto
        /// </summary>
        public int prdIntCodigo { get; set; }
        /// <summary>
        /// Tipo de producto "Producto", "Accesorio"
        /// </summary>
        public string prdChrTipoItem { get; set; }
        /// <summary>
        /// Código principal del producto
        /// </summary>
        public string prdChrCodigoPri { get; set; }
        /// <summary>
        /// Nombre del producto
        /// </summary>
        public string prdChrNombrePri { get; set; }
        /// <summary>
        /// Código secundario del producto
        /// </summary>
        public string prdChrCodigoSec { get; set; }
        /// <summary>
        /// Descripción del producto
        /// </summary>
        public string prdChrDescripcion { get; set; }
        /// <summary>
        /// Codigo de la Unidad Principal del producto
        /// </summary>
        public string undChrCodigo { get; set; }
        /// <summary>
        /// Monto factor para generar la unidad.
        /// </summary>
        public decimal pxuMonFactor { get; set; }
        /// <summary>
        /// Existencia del producto en la bodega
        /// </summary>
        public string prdMonExistencia { get; set; }
        /// <summary>
        /// Precio del producto
        /// </summary>
        public string prdMonPrecioBase { get; set; }
        /// <summary>
        /// Dias de garantia del producto
        /// </summary>
        public int prdIntDiasGarantiaV { get; set; }
        /// <summary>
        /// Estado actual del producto
        /// </summary>
        public string prdChrEstado { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public PopUpProductoModel()
        {
            empIntCodigo = 0;
            prdIntCodigo = 0;
            prdChrTipoItem = "";
            prdChrCodigoPri = "";
            prdChrNombrePri = "";
            prdChrDescripcion = "";
            undChrCodigo = "";
            prdMonExistencia = "";
            prdMonPrecioBase = "";
            prdChrEstado = "";
        }

        ~PopUpProductoModel() { }

        #endregion

        #region Metodos Publicos

        public void pb_ObtenerProductos(string pe_codBodega, string pe_datoBusqueda, int pe_topRegistros, string pe_FechaHasta, ref List<PopUpProductoModel> ps_PopUpProductoModel)
        {
            try
            {
                pv_ObtenerProductos(pe_codBodega, pe_datoBusqueda, pe_topRegistros, pe_FechaHasta, ref ps_PopUpProductoModel);
                ps_PopUpProductoModel.Select(s =>
                {
                    s.prdMonPrecioBase = decimal.Parse(s.prdMonPrecioBase).ToString("N2", CultureInfo.InvariantCulture);
                    s.prdMonExistencia = decimal.Parse(s.prdMonExistencia).ToString("N2", CultureInfo.InvariantCulture);
                    return s;
                }).ToList();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Metodos Privados

        private void pv_ObtenerProductos(string pe_codBodega, string pe_datoBusqueda, int pe_topRegistros, string pe_FechaHasta, ref List<PopUpProductoModel> ps_PopUpProductoModel)
        {
            try
            {
                vConnectionModel.pb_ObtenerPopUpProducto(pe_codBodega, pe_datoBusqueda, pe_topRegistros, pe_FechaHasta, ref ps_PopUpProductoModel);
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
