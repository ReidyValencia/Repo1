using IntegraPOS.Clases;
using IntegraPOS.Model.Entidades.Miscelaneos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.PopUps
{
    public partial class frmPopUpDirecciones : IntegraPOS.MasterPagePopUp
    {
        #region Variables locales

        private string ps_CodigoDireccion = "";
        private string pe_chrDatoBusqueda = null;
        private List<DireccionModelMisc> ps_DireccionModelMisc; // Instancia de DireccionModelMisc para ingreso de datos.
        public DireccionModelMisc pe_DireccionModelMisc = new DireccionModelMisc(); // Instancia de DireccionModelMisc para obtener datos de consulta.
        private MensajeView vMensajeView = new MensajeView(); // Instancia de MensajeView para la presentancion de datos.

        #endregion

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public frmPopUpDirecciones()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor con parámetros de entrada
        /// </summary>
        /// <param name="pe_chrDatoBusqueda"></param>
        public frmPopUpDirecciones(string pe_DatoBusqueda) : this()
        {
            try
            {
                pe_chrDatoBusqueda = pe_DatoBusqueda;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void frmPopUpDirecciones_Load(object sender, EventArgs e)
        {
            try
            {
                mtxtDatoBusqueda.Text = pe_chrDatoBusqueda;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Devuelve el número de direcciones encontrados
        /// </summary>
        /// <returns></returns>
        public int pb_CantidadDirecciones()
        {
            try
            {
                frmPopUpDirecciones_Load(null, null);
                pv_ObtenerDirecciones(pe_chrDatoBusqueda);

                return ps_DireccionModelMisc.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pv_SeleccionarDireccionGrid()
        {
            try
            {
                foreach (DataGridViewRow row in mgvDirecciones.SelectedRows)
                {
                    ps_CodigoDireccion = row.Cells["CodigoSistema"].Value.ToString();
                }

                pe_DireccionModelMisc = ps_DireccionModelMisc.Where(w => w.dirChrCodDireccion.Equals(ps_CodigoDireccion)).Cast<DireccionModelMisc>().First();
                Close(); // Oculta el PopUp Direcciones
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inicia la búsqueda de cliente de acuerdo al dato ingresado de búsqueda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkBusqDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                pv_ObtenerDirecciones(mtxtDatoBusqueda.Text);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene las direcciones que concuerden con el dato de ingresado.
        /// </summary>
        /// <param name="pe_chrDatoBusqueda"></param>
        private void pv_ObtenerDirecciones(string pe_chrDatoBusqueda)
        {
            try
            {
                pe_DireccionModelMisc.pb_ObtenerDirecciones(500, pe_chrDatoBusqueda, ref ps_DireccionModelMisc);

                if (ps_DireccionModelMisc.Count == 1)
                {
                    pe_DireccionModelMisc = ps_DireccionModelMisc.First();
                    Close(); // Oculta el Pop Up de Direcciones
                }
                else if (ps_DireccionModelMisc.Count > 1)
                {
                    mgvDirecciones.DataSource = ps_DireccionModelMisc;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene la fila seleccionada y devuelve al formulario principal un modelo de la entidad direccion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mgvDirecciones_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pv_SeleccionarDireccionGrid();
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

        private void mgvDirecciones_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        pv_SeleccionarDireccionGrid();
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
