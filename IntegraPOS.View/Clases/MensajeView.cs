
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;

namespace IntegraPOS.Clases
{
    public class MensajeView
    {
        #region Constructor / Destructor

        /// <summary>
        /// Constructor de la Clase
        /// </summary>
        public MensajeView()
        {

        }

        /// <summary>
        /// Destructor de la Clase
        /// </summary>
        ~MensajeView()
        {

        }

        #endregion

        #region Metodos Publicos

        /// <summary>
        /// Metodo que presenta un mensaje al usuario de información, error, confirmación.
        /// </summary>
        /// <param name="pe_ventana">Ventana donde se hace el llamado</param>
        /// <param name="pe_tipo">Tipo de mensaje (1=Proceso Exitoso, 2=Infomación, 3=Validación, 4=Confirmar Si - No, 5=Error)</param>
        /// <param name="pe_mensaje"></param>
        public bool pb_MensajeSistema(Form pe_ventana, int pe_tipo, string pe_mensaje)
        {
            bool resultado = true;

            try
            {
                #region Tipo de mensajes
                /*
            MessageBoxIcon.Asterisk = Azul
            MessageBoxIcon.Error = Rojo
            MessageBoxIcon.Exclamation = Amarillo
            MessageBoxIcon.Hand = Rojo
            MessageBoxIcon.Information = Azul
            MessageBoxIcon.None = Gris
            MessageBoxIcon.Question = Verde
            MessageBoxIcon.Stop = Rojo
            MessageBoxIcon.Warning = Amarillo
                */
                #endregion

                switch (pe_tipo)
                {
                    case 1:
                        MetroMessageBox.Show(pe_ventana, pe_mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Question);
                        break;

                    case 2:
                        MetroMessageBox.Show(pe_ventana, pe_mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case 3:
                        MetroMessageBox.Show(pe_ventana, pe_mensaje, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;

                    case 4:
                        resultado = (MetroMessageBox.Show(pe_ventana, pe_mensaje, "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) ? true : false;
                        break;

                    case 5:
                        resultado = (MetroMessageBox.Show(pe_ventana, pe_mensaje, "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry) ? true : false;
                        break;
                }

                return resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

    }
}


