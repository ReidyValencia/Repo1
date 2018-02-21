using IntegraPOS.Clases;
using IntegraPOS.Pages.Panels;
using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms
{
    public partial class frmPrincipal : IntegraPOS.MasterPage
    {
        #region Variables, Instancias

        pnlConfiguracion vPnlConfiguracion = null;   // Instancia el panel de configuración.
        pnlAdministracion vPnlAdministracion = null; // Instancia el panel administrativo.
        pnlComercial vPnlComercial = null;           // Instancia el panel comercial
        pnlProcesoCaja vPnlProcesoCaja = null;       // Instancia el panel de procesos de caja.
        pnlTransaccion vPnlTransaccion = null;       // Instancia el panel de transacciones.

        private MensajeView vMensajeView = new MensajeView(); // Instancia de MensajeView para la presentancion de datos.

        #endregion

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                vPnlConfiguracion = new pnlConfiguracion(this); // Instancia el panel de configuración.
                vPnlAdministracion = new pnlAdministracion(this); // Instancia el panel administrativo.
                vPnlComercial = new pnlComercial(this);           // Instancia el panel comercial
                vPnlProcesoCaja = new pnlProcesoCaja(this);       // Instancia el panel de procesos de caja.
                vPnlTransaccion = new pnlTransaccion(this);       // Instancia el panel de transacciones.
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Eventos del Menú

        #region Panel Configuración

        /// <summary>
        /// Muestra el Panel que contiene los accesos de configuración.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtileConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                if (vPnlConfiguracion != null && vPnlConfiguracion.Visible == true)
                {
                    vPnlConfiguracion.swipe(false);
                }
                else
                {
                    vPnlConfiguracion = new pnlConfiguracion(this); // Instancia el panel de configuración.

                    pv_SeleccionarMenu();
                    mpnlInicial.Visible = false;
                    mlnkLogo.Visible = false;

                    mtileConfiguracion.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(75)))));
                    mtileConfiguracion.UseCustomBackColor = true;
                    mtileConfiguracion.Enabled = false;

                    vPnlConfiguracion.Shown += vPnlConfiguracion_LogInSuccess;
                    vPnlConfiguracion.Closed += vPnlConfiguracion_SettingClosed;
                    vPnlConfiguracion.swipe(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cierra el Panel que contiene los accesos de configuración.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vPnlConfiguracion_LogInSuccess(object sender, EventArgs e) { }

        /// <summary>
        /// Cierra el Panel que contiene los accesos de configuración.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vPnlConfiguracion_SettingClosed(object sender, EventArgs e) { }

        #endregion

        #region Panel Administrativo

        /// <summary>
        /// Muestra el Panel que contiene los accesos administrativos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtileAdministrativo_Click(object sender, EventArgs e)
        {
            try
            {
                if (vPnlAdministracion != null && vPnlAdministracion.Visible == true)
                {
                    vPnlAdministracion.swipe(false);
                }
                else
                {
                    vPnlAdministracion = new pnlAdministracion(this); // Instancia el panel administrativo.

                    pv_SeleccionarMenu();
                    mpnlInicial.Visible = false;
                    mlnkLogo.Visible = false;

                    mtileAdministrativo.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(75)))));
                    mtileAdministrativo.UseCustomBackColor = true;
                    mtileAdministrativo.Enabled = false;

                    vPnlAdministracion.Shown += vPnlAdministracion_Closed;
                    vPnlAdministracion.Closed += vPnlAdministracion_Shown;
                    vPnlAdministracion.swipe(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cierra el Panel que contiene los accesos de configuración.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vPnlAdministracion_Shown(object sender, EventArgs e) { }

        /// <summary>
        /// Cierra el Panel que contiene los accesos de configuración.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vPnlAdministracion_Closed(object sender, EventArgs e) { }

        #endregion

        #region Panel Comercial

        /// <summary>
        /// Muestra el Panel que contiene los accesos comerciales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtileComercial_Click(object sender, EventArgs e)
        {
            try
            {
                if (vPnlComercial != null && vPnlComercial.Visible == true)
                {
                    vPnlComercial.swipe(false);
                }
                else
                {
                    vPnlComercial = new pnlComercial(this); // Instancia el panel comercial

                    pv_SeleccionarMenu();
                    mpnlInicial.Visible = false;
                    mlnkLogo.Visible = false;

                    mtileComercial.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(75)))));
                    mtileComercial.UseCustomBackColor = true;
                    mtileComercial.Enabled = false;

                    vPnlComercial.Shown += vPnlComercial_LogInSuccess;
                    vPnlComercial.Closed += vPnlComercial_SettingClosed;
                    vPnlComercial.swipe(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cierra el Panel que contiene los accesos comerciales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vPnlComercial_LogInSuccess(object sender, EventArgs e) { }

        /// <summary>
        /// Cierra el Panel que contiene los accesos comerciales.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vPnlComercial_SettingClosed(object sender, EventArgs e) { }

        #endregion

        #region Panel Proceso Caja

        /// <summary>
        /// Muestra el Panel que contiene los accesos de caja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtileProcesoCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (vPnlProcesoCaja != null && vPnlProcesoCaja.Visible == true)
                {
                    vPnlProcesoCaja.swipe(false);
                }
                else
                {
                    vPnlProcesoCaja = new pnlProcesoCaja(this); // Instancia el panel de procesos de caja.

                    pv_SeleccionarMenu();
                    mpnlInicial.Visible = false;
                    mlnkLogo.Visible = false;

                    mtileProcesoCaja.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(75)))));
                    mtileProcesoCaja.UseCustomBackColor = true;
                    mtileProcesoCaja.Enabled = false;

                    vPnlProcesoCaja.Shown += vPnlProcesoCaja_LogInSuccess;
                    vPnlProcesoCaja.Closed += vPnlProcesoCaja_SettingClosed;
                    vPnlProcesoCaja.swipe(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cierra el Panel que contiene los accesos de proceso de caja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vPnlProcesoCaja_LogInSuccess(object sender, EventArgs e) { }

        /// <summary>
        /// Cierra el Panel que contiene los accesos de proceso de caja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vPnlProcesoCaja_SettingClosed(object sender, EventArgs e) { }

        #endregion

        #region Panel Transacciones

        /// <summary>
        /// Muestra el Panel que contiene los accesos de transacciones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtileTransaccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (vPnlTransaccion != null && vPnlTransaccion.Visible == true)
                {
                    vPnlTransaccion.swipe(false);
                }
                else
                {
                    vPnlTransaccion = new pnlTransaccion(this); // Instancia el panel de transacciones.

                    pv_SeleccionarMenu();
                    mpnlInicial.Visible = false;
                    mlnkLogo.Visible = false;

                    mtileTransaccion.BackColor = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(75)))));
                    mtileTransaccion.UseCustomBackColor = true;
                    mtileTransaccion.Enabled = false;

                    vPnlTransaccion.Shown += vPnlTransaccion_LogInSuccess;
                    vPnlTransaccion.Closed += vPnlTransaccion_SettingClosed;
                    vPnlTransaccion.swipe(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Cierra el Panel que contiene los accesos de proceso de caja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vPnlTransaccion_LogInSuccess(object sender, EventArgs e) { }

        /// <summary>
        /// Cierra el Panel que contiene los accesos de proceso de caja.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void vPnlTransaccion_SettingClosed(object sender, EventArgs e) { }

        #endregion

        private void mtileFinalizarSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region PROTOTIPO

        //private void mtlMenu_Click(object sender, EventArgs e)
        //{
        //    //Reajusta el tamando del panel Inicial.
        //    mpnlInicial.Location = new Point(300, 35);
        //    mpnlInicial.Size = new Size(950, 660);

        //    // Muestra el Menu principal.
        //    _Menu = new pnlMenu(this);
        //    _Menu.SettingClosed += _Menu_SettingClosed;
        //    _Menu.LogInSuccess += _Menu_LogInSuccess;
        //    _Menu.swipe(true);
        //}

        //void _Menu_LogInSuccess(object sender, EventArgs e)
        //{
        //    _Menu.swipe(false);
        //}

        //void _Menu_SettingClosed(object sender, EventArgs e)
        //{
        //    //Reajusta el tamando del panel Inicial.
        //    mpnlInicial.Location = new Point(20, 35);
        //    mpnlInicial.Size = new Size(1240, 660);

        //    _Menu.swipe(false);
        //}

        #endregion

        private void mlnkFactura_Click(object sender, EventArgs e)
        {
            try
            {
                frmFacturaMant vFrmFacturaMant = new frmFacturaMant(this.Name);

                if (vFrmFacturaMant.vAsigancionCaja.Equals(true))
                {
                    vFrmFacturaMant.Show();
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

        private void mlnkProcesoCaja_Click(object sender, EventArgs e)
        {
            try
            {
                if (vPnlProcesoCaja != null && vPnlProcesoCaja.Visible == true)
                {
                    vPnlProcesoCaja.swipe(false);
                }
                else
                {
                    pnlProcesoCaja vPnlProcesoCaja = new pnlProcesoCaja(this); // Instancia el panel de procesos de caja.
                    vPnlProcesoCaja.Shown += vPnlProcesoCaja_LogInSuccess;
                    vPnlProcesoCaja.Closed += vPnlProcesoCaja_SettingClosed;
                    vPnlProcesoCaja.swipe(true);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Selección Menú Principal

        private void pv_SeleccionarMenu()
        {
            try
            {
                Color fondo = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(134)))), ((int)(((byte)(75)))));

                foreach (MetroPanel MPanel in Controls.OfType<MetroPanel>())
                {
                    foreach (MetroTile MTile in MPanel.Controls.OfType<MetroTile>())
                    {
                        if (MTile.BackColor.Equals(fondo))
                        {
                            string nombre = MTile.Name;
                            MTile.Enabled = true;
                            MTile.BackColor = Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(134)))), ((int)(((byte)(201)))));
                            nombre = nombre.Replace("mtile", "pnl");

                            switch (nombre)
                            {
                                case "pnlConfiguracion":
                                    vPnlConfiguracion.swipe(false);
                                    break;
                                case "pnlAdministrativo":
                                    vPnlAdministracion.swipe(false);
                                    break;
                                case "pnlComercial":
                                    vPnlComercial.swipe(false);
                                    break;
                                case "pnlProcesoCaja":
                                    vPnlProcesoCaja.swipe(false);
                                    break;
                                case "pnlTransaccion":
                                    vPnlTransaccion.swipe(false);
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void mlnkHome_Click(object sender, EventArgs e)
        {
            try
            {
                pv_SeleccionarMenu();
                mpnlInicial.Visible = true;
                mlnkLogo.Visible = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
