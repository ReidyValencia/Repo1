using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;

namespace IntegraPOS.Clases
{
    public class ValidarControles
    {

        private MensajeView vMensajeView = new MensajeView(); // Instancia de MensajeView para la presentancion de datos.


        #region Constructor / Destructor

        /// <summary>
        /// Constructor
        /// </summary>
        public ValidarControles()
        {
        }

        /// <summary>
        /// Destructor
        /// </summary>
        ~ValidarControles()
        {
        }

        #endregion

        /// <summary>
        /// Valida los valores de controles del formulario. 
        /// </summary>
        /// <param name="pe_ventana">Ventana de donde se hace el llamado</param>
        /// <returns></returns>
        public bool pb_ValidarControles(Form pe_ventana)
        {
            try
            {
                bool vEstado = true;
                string vLabel = "";
                MetroComboBox mcombo = null;

                foreach (Control ctrl in pe_ventana.Controls)
                {
                    switch (ctrl.GetType().Name)
                    {
                        #region MetroLabel

                        case "MetroLabel":
                            if (ctrl.Name.Contains("Error"))
                            {
                                ctrl.Visible = false;
                            }
                            break;

                        #endregion

                        #region MetroTexbox

                        case "MetroTextBox":
                            if (string.IsNullOrEmpty(ctrl.Text) && ctrl.ForeColor.Name.Equals("Maroon"))
                            {
                                vLabel = ctrl.Name + "Error";

                                foreach (MetroLabel ctrlLabel in pe_ventana.Controls.OfType<MetroLabel>().Where(w => w.Name.Equals(vLabel)))
                                {
                                        ctrlLabel.Visible = true;
                                        break;                                  
                                }
                                
                                vEstado = false;
                            }
                            break;

                        #endregion

                        #region MetroComboBox

                        case "MetroComboBox":
                            if (ctrl.ForeColor.Name.Equals("Maroon"))
                            {
                                mcombo = (MetroComboBox)ctrl;

                                if (mcombo.SelectedIndex.Equals(0))
                                {
                                    vLabel = ctrl.Name + "Error";

                                    foreach (MetroLabel ctrlLabel in pe_ventana.Controls.OfType<MetroLabel>().Where(w => w.Name.Equals(vLabel)))
                                    {
                                        ctrlLabel.Visible = true;
                                        break;
                                    }

                                    vEstado = false;
                                }
                            }
                            break;

                        #endregion

                        #region MaskedTextBox

                        case "MaskedTextBox":

                            MaskedTextBox maskTexto = (MaskedTextBox) ctrl;
                            var lengMascara = maskTexto.Mask.Length;
                            var lengTexto = maskTexto.Text.Length;

                            if(lengTexto < lengMascara)
                            {
                                vLabel = ctrl.Name + "Error";

                                foreach (MetroLabel ctrlLabel in pe_ventana.Controls.OfType<MetroLabel>().Where(w => w.Name.Equals(vLabel)))
                                {
                                    ctrlLabel.Visible = true;
                                    break;
                                }

                                vEstado = false;
                            }                           

                            break;

                        #endregion

                        default:
                            break;
                    }
                }

                if (vEstado.Equals(false))
                {
                    vMensajeView.pb_MensajeSistema(pe_ventana, 3, "Los campos marcados con asterisco son necesarios.");
                }
                return vEstado;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
