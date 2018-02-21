using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Model.Entidades.PopUps;
using System.Linq;
using System.Globalization;
using IntegraPOS.Clases;

namespace IntegraPOS.Pages.PopUps
{
    public partial class frmPopUpProductos : IntegraPOS.MasterPagePopUp
    {
        #region Variables locales

        private int ps_CodigoProducto = 0;
        private string pe_CodigoBodega = null;
        private string pe_DatoBusqueda = null;
        private string pe_FechaHasta = null;
        private List<PopUpProductoModel> ps_PopUpProductoModel; // Instancia una lista de Productos.
        public PopUpProductoModel pe_PopUpProductoModel = new PopUpProductoModel(); // Instancia de PopUpProductoModel para obtener datos de consulta.
        private MensajeView vMensajeView = new MensajeView(); // Instancia de MensajeView para la presentancion de datos.

        #endregion

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public frmPopUpProductos()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor con parametros de entrada
        /// </summary>
        /// <param name="codigoBodega">Codigo de la bodega donde se va a verificar la existencia de producto</param>
        /// <param name="datoBusqueda">dato como filtro del busqueda para los prodcutos</param>
        public frmPopUpProductos(string codigoBodega, string datoBusqueda, string fechaHasta) : this()
        {
            try
            {
                pe_CodigoBodega = codigoBodega;
                pe_DatoBusqueda = datoBusqueda;
                pe_FechaHasta = fechaHasta;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void frmPopUpProductos_Load(object sender, EventArgs e)
        {
            try
            {
                mtxtDatoBusqueda.Text = pe_DatoBusqueda;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Devuelve el numero de productos encontrados.
        /// </summary>
        /// <returns></returns>
        public int pb_CantidadProductos()
        {
            try
            {
                frmPopUpProductos_Load(null, null);
                pv_ObtenerProductos(pe_CodigoBodega, pe_DatoBusqueda, pe_FechaHasta);

                return ps_PopUpProductoModel.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void pv_SeleccionarProductoGrid()
        {
            try
            {
                foreach (DataGridViewRow row in mgvProductos.SelectedRows)
                {
                    ps_CodigoProducto = Convert.ToInt32(row.Cells["CodigoSistema"].Value.ToString());
                }

                pe_PopUpProductoModel = ps_PopUpProductoModel.Where(w => w.prdIntCodigo.Equals(ps_CodigoProducto)).Cast<PopUpProductoModel>().First();
                Close(); // Oculta el PopUp Producto.
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inicia la búsqueda de productos deacuerdo al dato ingresado de busqueda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkBusqProducto_Click(object sender, EventArgs e)
        {
            try
            {
                pv_ObtenerProductos(pe_CodigoBodega, mtxtDatoBusqueda.Text, pe_FechaHasta);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los productos que concuerden con el dato ingresado.
        /// </summary>
        /// <param name="pe_codigoBodega">Codigo de Bodega</param>
        /// <param name="pe_datoBusqueda">Dato como filtro de busqueda</param>
        /// <param name="pe_FechaHasta">Fecha hasta donde se va a validar la existencia de producto</param>
        private void pv_ObtenerProductos(string pe_codigoBodega, string pe_datoBusqueda, string pe_FechaHasta)
        {
            try
            {
                pe_PopUpProductoModel.pb_ObtenerProductos(pe_codigoBodega, pe_datoBusqueda, 500, pe_FechaHasta, ref ps_PopUpProductoModel);

                if (ps_PopUpProductoModel.Count == 1)
                {
                    pe_PopUpProductoModel = ps_PopUpProductoModel.First();
                    Close(); // Oculta el PopUp Productos
                }
                else if (ps_PopUpProductoModel.Count > 1)
                {
                    mgvProductos.DataSource = ps_PopUpProductoModel;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene la fila seleccionada y devuelve al formulario principal un modelo de la entidad PopUpProducto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mgridProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pv_SeleccionarProductoGrid();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkCerrar_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mgvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        pv_SeleccionarProductoGrid();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
