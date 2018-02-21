using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntegraPOS.Model.Entidades.Clases;
using IntegraPOS.View.Clases;
using IntegraPOS.Pages.Forms;
using IntegraPOS.Clases;

namespace IntegraPOS
{
    public partial class frmAcceso : MetroFramework.Forms.MetroForm
    {
        #region Variables locales

        private bool? ps_estadoProceso;
        private string ps_mensaje;
        private UsuarioModel ps_UsuarioModel = new UsuarioModel(); // Instancia de UsuarioModel para ingreso de datos.
        //private UsuarioModel pe_UsuarioModel = new UsuarioModel(); // Instancia de UsuarioModel para obtener datos de consulta.
        private MensajeView vMensajeView = new MensajeView(); // Instancia de MensajeView para la presentancion de datos.

        #endregion

        public frmAcceso()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void pv_Accesar()
        {
            try
            {
                if (pv_ValidarDatos())
                {
                    RegExp regExp = new RegExp();

                    if (regExp.pb_ValidarRegExp(mtxtUsuario, "nombre"))
                    {
                        ps_UsuarioModel.usuChrLogin = mtxtUsuario.Text;
                        ps_UsuarioModel.usuBinClave = mtxtContrasena.Text;

                        ps_UsuarioModel.pb_ValidarUsuario(ps_UsuarioModel, ref ps_UsuarioModel, ref ps_estadoProceso, ref ps_mensaje);

                        if (ps_estadoProceso.Equals(true))
                        {
                            frmPrincipal vFrmPrincipal = new frmPrincipal();
                            vFrmPrincipal.Show();
                            Hide();
                        }
                        else
                        {
                            vMensajeView.pb_MensajeSistema(this, 5, ps_mensaje);
                        }
                    }
                    else
                    {
                        vMensajeView.pb_MensajeSistema(this, 3, "Formato incorrecto del nombre de usuario.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Inicia el proceso de consulta para validar el acceso del usuario.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mbtnAccesar_Click(object sender, EventArgs e)
        {
            try
            {
                pv_Accesar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Valida que no existan campos vacios, o caracteres no validos.
        /// </summary>
        /// <returns></returns>
        private bool pv_ValidarDatos()
        {

            try
            {

                if (string.IsNullOrEmpty(mtxtUsuario.Text))
                {
                    //MetroFramework.MetroMessageBox.Show(this, "Por favor ingrese un usuario.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtxtUsuario.WaterMark = "Ingrese un usuario";
                    mtxtUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    mtxtUsuario.Focus();
                    return false;
                }
                else if (string.IsNullOrEmpty(mtxtContrasena.Text))
                {
                    //MetroFramework.MetroMessageBox.Show(this, "Por favor ingrese una contraseña.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mtxtContrasena.WaterMark = "Ingrese una contraseña";
                    mtxtContrasena.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
                    mtxtContrasena.Focus();
                    return false;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        #region Evento de Teclas

        /// <summary>
        /// Inicializa un evento o proceso de acuerdo a la tecla presionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                switch (e.KeyChar)
                {
                    case (char)Keys.Enter:
                        pv_Accesar();
                        e.Handled = true;
                        break;

                    case (char)Keys.Escape:
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

        /// <summary>
        /// Inicializa un evento o proceso de acuerdo a la tecla presionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                switch (e.KeyChar)
                {
                    case (char)Keys.Enter:
                        pv_Accesar();
                        e.Handled = true;
                        break;

                    case (char)Keys.Escape:
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
