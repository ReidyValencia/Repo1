using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Clases
{
    public class DetalleProductoModel
    {
        #region Variables e instancias

        #endregion

        #region Propiedades

        public int empIntCodigo { get; set; }
        public string traChrNumero { get; set; }
        public int dprdIntConsecutivo { get; set; }
        public int prdIntCodigo { get; set; }
        public string dprdChrNombre { get; set; }
        public string bodChrCodigo { get; set; }
        public string undChrCodigo { get; set; }
        public decimal pxuMonFactor { get; set; }
        public DateTime dprdFecFechaGarantia { get; set; }
        public decimal dprdMonCantIngresada { get; set; }
        public decimal dprdMonPorcDescuento { get; set; }
        public decimal dprdMonPorcImpuesto { get; set; }
        public decimal dprdMonCostUnitario { get; set; }
        public decimal dprdMonPrecUnitario { get; set; }
        public decimal dprdMonTotalDescuento { get; set; }
        public string dprdChrMotivoDescuento { get; set; }
        public decimal dprdMonTotalNeto { get; set; }
        public int usuIntCodigo { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public DetalleProductoModel()
        {
            try
            {
                empIntCodigo = 0;
                traChrNumero = "";
                dprdIntConsecutivo = 0;
                prdIntCodigo = 0;
                dprdChrNombre = "";
                bodChrCodigo = "";
                undChrCodigo = "";
                pxuMonFactor = 0;
                dprdFecFechaGarantia = DateTime.Now;
                dprdMonCantIngresada = 0;
                dprdMonPorcDescuento = 0;
                dprdMonPorcImpuesto = 0;
                dprdMonCostUnitario = 0;
                dprdMonPrecUnitario = 0;
                dprdMonTotalDescuento = 0;
                dprdChrMotivoDescuento = "";
                dprdMonTotalNeto = 0;
                usuIntCodigo = 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        ~DetalleProductoModel() { }

        #endregion

        #region  Métodos Públicos

        public void pb_ObtenerDetalleProducto()
        {
            try
            {

            }
            catch (Exception ex )
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Privados

        private void pv_ObtenerDetalleProducto()
        {
            try
            {

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}
