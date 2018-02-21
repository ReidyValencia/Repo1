using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework;
using IntegraPOS.Model.Entidades.PopUps;
using IntegraPOS.Model.Entidades.Miscelaneos;
using System.Globalization;
using System.Text.RegularExpressions;
using IntegraPOS.Model.Entidades.Clases;
using IntegraPOS.Model;
using IntegraPOS.Clases;

namespace IntegraPOS.Pages.PopUps
{
    public partial class frmPopUpMedioPago : IntegraPOS.MasterPagePopUp
    {
        #region Variables, Instancias

        private ConfigEmpresaModelMisc pe_ConfigEmpresaModelMisc = new ConfigEmpresaModelMisc();
        private ConfigurationModel ps_ConfiguraciónModel = new ConfigurationModel();
        private MiscelaneosModel pe_MiscelaneosModel = new MiscelaneosModel();
        private MedioPagoModel pe_MedioPagoModel = new MedioPagoModel();
        public List<MedioPagoModel> ps_MedioPagoModel;
        private MensajeView vMensajeView = new MensajeView();


        /// <summary>
        /// Numero de la Transaccion 
        /// </summary>
        private string pe_NumTransac;
        /// <summary>
        /// Caja que se esta utilizando
        /// </summary>
        private string pe_Caja;
        /// <summary>
        /// Forma de pago de la transccion
        /// </summary>
        private int pe_FormaPago;
        /// <summary>
        /// Codigo de la moneda que se esta utilizando.
        /// </summary>
        private int pe_CodMoneda;
        /// <summary>
        /// Valor de la tasa.
        /// </summary>
        private decimal pe_ValorTasa;
        /// <summary>
        /// Total de la factura.
        /// </summary>
        private decimal pe_TotalPagar;

        private string vFechaSistema;
        private DateTime vFechaBaseDatos;

        private int vValidarMonto = 0;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public frmPopUpMedioPago()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor con Parametro
        /// </summary>
        /// <param name="pe_FormaPago">Forna de Pago (Contado / Credito)</param>
        /// <param name="pe_CodMoneda">Codigo de moneda de la transacción</param>
        /// <param name="pe_ValorTasa">Valor de la Tasa de la transacción</param>
        /// <param name="pe_TotalPagar">Total de la transacción</param>
        public frmPopUpMedioPago(string pe_NumTransac, string pe_Caja, int pe_FormaPago, int pe_CodMoneda, decimal pe_ValorTasa, decimal pe_TotalPagar) : this()
        {
            try
            {
                this.pe_NumTransac = pe_NumTransac;
                this.pe_Caja = pe_Caja;
                this.pe_FormaPago = pe_FormaPago;
                this.pe_CodMoneda = pe_CodMoneda;
                this.pe_ValorTasa = pe_ValorTasa;
                this.pe_TotalPagar = pe_TotalPagar;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region PopUp Load

        private void frmPopUpMedioPago_Load(object sender, EventArgs e)
        {
            try
            {
                pe_ConfigEmpresaModelMisc.pb_ObtenerConfigEmpresa(ref pe_ConfigEmpresaModelMisc);

                pv_CargarMontos();
                pv_CargarMediosPago();

                vValidarMonto = 1;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Devuelve el numero de medios de pagos encontadros deacuerdo a la caja.
        /// </summary>
        /// <returns></returns>
        private int pb_CantidadMedioPago()
        {
            try
            {
                pv_CargarMediosPago();
                return ps_MedioPagoModel.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos Privados

        /// <summary>
        /// Carga el monto total de la transacción en el tile de Total
        /// </summary>
        private void pv_CargarMontos()
        {
            try
            {
                int decimales = Convert.ToInt32(pe_ConfigEmpresaModelMisc.CnfDecimalesMontos);
                lblTotalPagar.Text = pe_TotalPagar.ToString("N" + decimales, CultureInfo.InvariantCulture);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Carga la lista de medios de pago para mostrar en el popup
        /// </summary>
        private void pv_CargarMediosPago()
        {
            try
            {
                pe_MedioPagoModel.pb_ObtenerMediosPago(pe_Caja, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), pe_CodMoneda, pe_ValorTasa, pe_FormaPago, ref ps_MedioPagoModel);

                mgvMediosPago.DataSource = ps_MedioPagoModel;

                pv_CargarCamposNoEditables();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Carga los campos del gridview no editables
        /// </summary>
        private void pv_CargarCamposNoEditables()
        {
            try
            {
                foreach (DataGridViewRow row in mgvMediosPago.Rows)
                {
                    /*************** Nombre ***************/
                    row.Cells["NombreMedPago"].ReadOnly = true;
                    row.Cells["NombreMedPago"].Style.BackColor = Color.Gainsboro;
                    /*************** Documento ***************/
                    row.Cells["Documento"].ReadOnly = true;
                    row.Cells["Documento"].Style.BackColor = Color.Gainsboro;
                    /*************** Banco ***************/
                    row.Cells["Banco"].ReadOnly = true;
                    row.Cells["Banco"].Style.BackColor = Color.Gainsboro;
                    /*************** FechaDoc ***************/
                    row.Cells["FechaDoc"].ReadOnly = true;
                    row.Cells["FechaDoc"].Style.BackColor = Color.Gainsboro;
                    row.Cells["FechaDoc"].Value = "";
                    /*************** Moneda ***************/
                    row.Cells["SimboloMoneda"].ReadOnly = true;
                    row.Cells["SimboloMoneda"].Style.BackColor = Color.Gainsboro;
                    /*************** MontoMndTransac ***************/
                    row.Cells["MonMndTransac"].ReadOnly = true;
                    row.Cells["MonMndTransac"].Style.BackColor = Color.Gainsboro;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Habilita los campos editables segun el tipo de medio de pago seleccionado
        /// </summary>
        /// <param name="pe_rowIndex"></param>
        private void pv_ValidarCamposNoEditables(int pe_rowIndex)
        {
            try
            {
                // Se obtiene el tipo de medio de pago
                string vTipo = mgvMediosPago.Rows[pe_rowIndex].Cells["TipoMedPago"].Value.ToString();

                // se limpian todos los campos del gridview
                pv_LimpiarCampos();

                // si es de tipo cheque o tarjeta y con un valor diferente de cero habilita los campos
                if ((vTipo.Equals("CHKS") || vTipo.Equals("TARJ")) && !Convert.ToDecimal(mgvMediosPago.Rows[pe_rowIndex].Cells["MonMedPago"].Value).Equals(0))
                {
                    /******************* Documento ******************/
                    mgvMediosPago.Rows[pe_rowIndex].Cells["Documento"].ReadOnly = false;
                    mgvMediosPago.Rows[pe_rowIndex].Cells["Documento"].Style.BackColor = Color.White;
                    /******************* Banco ******************/
                    mgvMediosPago.Rows[pe_rowIndex].Cells["Banco"].ReadOnly = false;
                    mgvMediosPago.Rows[pe_rowIndex].Cells["Banco"].Style.BackColor = Color.White;
                    /******************* Fecha de documento ******************/
                    mgvMediosPago.Rows[pe_rowIndex].Cells["FechaDoc"].Value = DateTime.Now.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
                }
                // Si el monto es cero, se deshabilitan los campos
                else if (Convert.ToDecimal(mgvMediosPago.Rows[pe_rowIndex].Cells["MonMedPago"].Value).Equals(0))
                {
                    /******************* Documento ******************/
                    mgvMediosPago.Rows[pe_rowIndex].Cells["Documento"].ReadOnly = true;
                    mgvMediosPago.Rows[pe_rowIndex].Cells["Documento"].Style.BackColor = Color.Gainsboro;
                    /******************* Banco ******************/
                    mgvMediosPago.Rows[pe_rowIndex].Cells["Banco"].ReadOnly = true;
                    mgvMediosPago.Rows[pe_rowIndex].Cells["Banco"].Style.BackColor = Color.Gainsboro;
                    /******************* Fecha de documento ******************/
                    mgvMediosPago.Rows[pe_rowIndex].Cells["FechaDoc"].Value = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Carga la lista de medios de pago para el detalle de medios de pago de la transacción
        /// </summary>
        private void pv_CargarDetalleMedioPago()
        {
            try
            {
                ps_MedioPagoModel = new List<MedioPagoModel>();
                
                foreach (DataGridViewRow row in mgvMediosPago.Rows)
                {
                    if (!Convert.ToDecimal(row.Cells["MonMndTransac"].Value).Equals(0))
                    {
                        MedioPagoModel vMedioPagoModel = new MedioPagoModel();

                        var vFecha = (row.Cells["FechaDoc"].Value.Equals("")) ? DateTime.Now.ToString("dd-MM-yyy") : row.Cells["FechaDoc"].Value;

                        pe_MiscelaneosModel.pb_AplicarFormatoFecha(vFecha.ToString().Replace('/', '-'), ref vFechaSistema, ref vFechaBaseDatos, "FormatoBaseDatos");

                        vMedioPagoModel.empIntCodigo = Convert.ToInt32(ps_ConfiguraciónModel.codEmpresa);
                        vMedioPagoModel.traChrNumero = pe_NumTransac;
                        vMedioPagoModel.mpgChrCodigo = row.Cells["CodSistema"].Value.ToString();
                        vMedioPagoModel.dmpIntPosicion = row.Index + 1;
                        vMedioPagoModel.dmpChrDocumento = row.Cells["Documento"].Value.ToString();
                        vMedioPagoModel.dmpChrBancoEmisor = row.Cells["Banco"].Value.ToString();
                        vMedioPagoModel.dmpFecFechaDoc = vFechaBaseDatos.ToString("yyyy-MM-dd");
                        vMedioPagoModel.mpgMonMontoMPago = row.Cells["MonMedPago"].Value.ToString();
                        vMedioPagoModel.mpgMonMontoFactor = Convert.ToDecimal(row.Cells["MonFactor"].Value.ToString());
                        vMedioPagoModel.mpgMonMontoTransac = row.Cells["MonMndTransac"].Value.ToString();
                        vMedioPagoModel.usuIntCodigo = 1;
                        vMedioPagoModel.mpgFecFecha = DateTime.Now;

                        ps_MedioPagoModel.Add(vMedioPagoModel);
                    }
                }

                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Valida que se ingresen números en el campo de monto
        /// </summary>
        /// <returns></returns>
        private bool pv_ValidarMontosMedioPago()
        {
            bool estado = false;
            try
            {
                string regexpNumero = @"[0-9]{1,9}(\.[0-9]{0,2})?$";

                foreach (DataGridViewRow row in mgvMediosPago.Rows)
                {
                    Regex numero = new Regex(regexpNumero);
                    estado = (numero.IsMatch(row.Cells["MonMedPago"].Value.ToString())) ? true : false;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return estado;
        }

        private void pv_LimpiarCampos()
        {
            try
            {
                foreach (DataGridViewRow row in mgvMediosPago.Rows)
                {
                    row.Cells["Documento"].Value = "";
                    row.Cells["Banco"].Value = "";
                    row.Cells["FechaDoc"].Value = "";
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Eventos de Controles

        /// <summary>
        /// Cerrar el popup
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Evento que se ejecuta cuando el valor de una celda cambia 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mgvMediosPago_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (vValidarMonto.Equals(1))
                {
                    int decimales = Convert.ToInt32(pe_ConfigEmpresaModelMisc.CnfDecimalesMontos);
                    decimal totalMPago = 0;

                    foreach (DataGridViewRow row in mgvMediosPago.Rows)
                    {
                        if (row.Index.Equals(e.RowIndex) && row.Cells["MonMedPago"].ColumnIndex.Equals(e.ColumnIndex))
                        {
                            decimal vMontoMpago = (row.Cells["MonMedPago"].Value.Equals("")) ? 0 : Convert.ToDecimal(row.Cells["MonMedPago"].Value);
                            decimal vFactor = Convert.ToDecimal(row.Cells["MonFactor"].Value);
                            row.Cells["MonMndTransac"].Value = (vMontoMpago * vFactor).ToString("N" + decimales, CultureInfo.InvariantCulture);
                            row.Cells["MonMedPago"].Value = vMontoMpago.ToString("N" + decimales, CultureInfo.InvariantCulture);

                            pv_ValidarCamposNoEditables(row.Index);
                        }

                        totalMPago += Convert.ToDecimal(row.Cells["MonMndTransac"].Value.ToString());
                    }

                    lblTotalMedPago.Text = totalMPago.ToString("N" + decimales, CultureInfo.InvariantCulture);
                    lblDiferencia.Text = (Convert.ToDecimal(lblTotalMedPago.Text) - Convert.ToDecimal(pe_TotalPagar)).ToString("N" + decimales, CultureInfo.InvariantCulture);
                    lblCambio.Text = lblDiferencia.Text;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Evento para guardar el detalle de medios de pago y la transacción
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (pv_ValidarMontosMedioPago())
                {
                    pv_CargarDetalleMedioPago();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Evento que controla la edición de una celda para validar el tipo de dato de entrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mgvMediosPago_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DataGridViewTextBoxEditingControl txtControl = (DataGridViewTextBoxEditingControl)e.Control;

                var grid = (MetroGrid)sender;

                DataGridViewTextBoxCell celda = (DataGridViewTextBoxCell)grid.CurrentCell;

                if (celda.ColumnIndex.Equals(mgvMediosPago.Rows[celda.RowIndex].Cells["MonMedPago"].ColumnIndex))
                {
                    txtControl.KeyPress += new KeyPressEventHandler(TxtControl_KeyPressDigitos);
                }
                else
                {
                    txtControl.KeyPress += new KeyPressEventHandler(TxtControl_KeyPressCaracteres);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Evento para validar que solo se puedan ingresar números en una celda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtControl_KeyPressDigitos(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (Char.IsDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (e.KeyChar == ',')
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Evento para validar que solo se puedan ingresar caracteres en una celda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TxtControl_KeyPressCaracteres(object sender, KeyPressEventArgs e)
        {
            try
            {
                char[] chars = { '-', '.' };

                if (Char.IsLetterOrDigit(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (Char.IsSeparator(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (chars.Contains(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Evento para el botón de totalizar monto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mgvMediosPago_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (!e.RowIndex.Equals(-1))
                {
                    if (e.ColumnIndex.Equals(mgvMediosPago.Rows[e.RowIndex].Cells["Totalizar"].ColumnIndex))
                    {
                        int decimales = Convert.ToInt32(pe_ConfigEmpresaModelMisc.CnfDecimalesMontos);

                        foreach (DataGridViewRow row in mgvMediosPago.Rows)
                        {
                            row.Cells["MonMedPago"].Value = (0).ToString("N" + decimales, CultureInfo.InvariantCulture);
                        }

                        mgvMediosPago.Rows[e.RowIndex].Cells["MonMedPago"].Value = lblTotalPagar.Text;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Evento de teclas

        private void mgvMediosPago_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                switch (e.KeyChar)
                {
                    case (Char)Keys.Escape: //Cierra el popup
                        Close();
                        break;
                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
