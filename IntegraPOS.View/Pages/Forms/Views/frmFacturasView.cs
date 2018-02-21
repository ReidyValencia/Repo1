using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Model.Entidades.Clases;
using IntegraPOS.Clases;
using IntegraPOS.Model.Entidades.Reportes;
using IntegraPOS.Pages.Forms.Reportes;

namespace IntegraPOS.Pages.Forms.Views
{
    public partial class frmFacturasView : IntegraPOS.MasterPage
    {
        #region Variables e instancias

        /// <summary>
        /// Almacena el código de la transacción seleccionada
        /// </summary>
        private string pe_CodigoTransac = "";

        /// <summary>
        /// Instancia del modelo TransaccionEncabezadoModel para la carga de transacciones
        /// </summary>
        private TransaccionEncabezadoModel pe_TransaccionEncabezadoModel = new TransaccionEncabezadoModel();

        /// <summary>
        /// Lista de transacciones
        /// </summary>
        private List<TransaccionEncabezadoModel> ps_TransaccionEncabezadoModel;

        /// <summary>
        /// Instancia la clase MensajeView, en caso que se requiera presentar algún mensaje.
        /// </summary>
        private MensajeView vMensajeView = new MensajeView();

        #endregion

        #region Constructor

        public frmFacturasView()
        {
            InitializeComponent();
        }

        #endregion

        private void frmFacturasView_Load(object sender, EventArgs e)
        {
            try
            {
                pv_CargarTransacciones();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Eventos Controles

        private void mlnkNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmFacturaMant vFrmFacturaMant = new frmFacturaMant(this.Name);

                if (vFrmFacturaMant.vAsigancionCaja.Equals(true))
                {
                    vFrmFacturaMant.Show();
                    Close();
                }
                else
                {
                    vMensajeView.pb_MensajeSistema(this, 3, "Usuario no tiene ninguna caja asignada.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkVolver_Click(object sender, EventArgs e)
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

        #endregion

        #region Evento de Teclas



        #endregion

        #region Métodos

        /// <summary>
        /// Se cargan las transacciones de tipo factura para mostrar en el view
        /// </summary>
        private void pv_CargarTransacciones()
        {
            try
            {
                string vDatoBusqueda = (mtxtBuscar.Text.Equals("")) ? "%" : mtxtBuscar.Text;

                pe_TransaccionEncabezadoModel.pb_ObtenerTransaccionEncabezado(vDatoBusqueda, 500, "CLIVEN0001", ref ps_TransaccionEncabezadoModel);

                if (ps_TransaccionEncabezadoModel.Count > 0)
                {
                    pe_CodigoTransac = ps_TransaccionEncabezadoModel.Select(s => s.traChrNumero).FirstOrDefault();
                    mgvFacturas.DataSource = ps_TransaccionEncabezadoModel;
                }
                else if ((ps_TransaccionEncabezadoModel.Count == 0) && (!vDatoBusqueda.Equals("%")))
                {
                    vMensajeView.pb_MensajeSistema(this, 3, "No se encontraron coincidencias de acuerdo a su criterio de búsqueda.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mgvFacturas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowIndex = mgvFacturas.CurrentRow.Index;
            pe_TransaccionEncabezadoModel = ps_TransaccionEncabezadoModel[rowIndex];
           
        }

        #endregion

        private void mlnkImprimir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pe_TransaccionEncabezadoModel.traChrNumero))
            {
                vMensajeView.pb_MensajeSistema(this, 3, "Debe seleccionar un registro.");
            }
            else
            {
                var format = new FormatModel(pe_TransaccionEncabezadoModel.empIntCodigo, pe_TransaccionEncabezadoModel.traChrNumero, "CLIVEN", "COM", "001", pe_TransaccionEncabezadoModel.traChrEstado, "");
                var frmFormatoView = new frmFormatoView(format);
                if (frmFormatoView.ps_status)
                {
                    frmFormatoView.Show();
                }
                else
                {
                    vMensajeView.pb_MensajeSistema(this, 3, frmFormatoView.ps_mensaje);
                }
            }
            pe_TransaccionEncabezadoModel = new TransaccionEncabezadoModel();
        }
    }
}
