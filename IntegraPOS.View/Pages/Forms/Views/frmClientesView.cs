using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Model.Entidades.Clases;
using IntegraPOS.Clases;
using IntegraPOS.Pages.Forms;
using System.Linq;

namespace IntegraPOS.Pages.Forms
{
    public partial class frmClientesView : IntegraPOS.MasterPage
    {
        #region Variables e instancias

        /// <summary>
        /// Almacena el código de Usuario que inició sesión en el sistema
        /// </summary>
        private int pe_CodigoUsuario = 1;

        /// <summary>
        /// Almacena el código de cliente que se quiere modificar.
        /// </summary>
        private int pe_CodigoCliente = 0;

        /// <summary>
        /// Almacena el estado de la ejecución del procedimiento almacenado
        /// </summary>
        private bool? ps_Estado = false;

        /// <summary>
        /// Almacena el mensaje de la ejecución del procedimiento almacenado
        /// </summary>
        private string ps_Mensaje = "";

        /// <summary>
        /// Instanacia del Modelo ClienteModel para obtener los clientes.
        /// </summary>
        private ClienteModel pe_ClienteModel = new ClienteModel();

        /// <summary>
        /// Lista de clientes 
        /// </summary>
        private List<ClienteModel> ps_ClienteModel;

        /// <summary>
        /// Instancia la clase MensajeView, en caso que se requiera presentar algún mensaje.
        /// </summary>
        private MensajeView vMensajeView = new MensajeView();

        #endregion

        #region Constructor 

        /// <summary>
        /// Constructor sin parametros.
        /// </summary>
        public frmClientesView()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructot con parametros.
        /// </summary>
        /// <param name="pe_CodUsuario"></param>
        public frmClientesView(int pe_CodUsuario) : this()
        {
            try
            {
                pe_CodigoUsuario = pe_CodUsuario;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion 

        private void frmClientesView_Load(object sender, EventArgs e)
        {
            try
            {
                pv_CargarClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Eventos Controles

        /// <summary>
        /// Inicia la busqueda de cliente(es) deacuerdo al dato de busqueda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mtxtDatoBusqueda_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                pv_CargarClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene y almacena el código de cliente de la celda a la que se le dio click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                foreach (DataGridViewRow row in mgvClientes.SelectedRows)
                {
                    pe_CodigoCliente = Convert.ToInt32(row.Cells["CodigoSistema"].Value.ToString());
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene y inicia el llamado al mantenimiento de cliente deacuerdo al código de cliente de la celda a la que se le dio doble click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pv_SeleccionarCliente();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Llama el formulario de mantenimiento de clientes para insertar uno nuevo
        /// si se presiona el botón del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                pv_InicializarFormCliente(1);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Llama el formulario de mantenimiento de clientes para modificar uno seleccionado
        /// si se presiona el botón del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkModificar_Click(object sender, EventArgs e)
        {
            try
            {
                pv_InicializarFormCliente(2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Llama el método para buscar clientes
        /// si se presiona el botón del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                pv_CargarClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Llama el método para recargar el view
        /// si se presiona el botón del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mlnkRecargar_Click(object sender, EventArgs e)
        {
            try
            {
                pv_RefrescarForm();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Llama al form principal si se presiona el botón del form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        private void mtxtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                switch (e.KeyChar)
                {
                    case (char)Keys.Enter:
                        pv_CargarClientes();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mgvClientes_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        pv_SeleccionarCliente();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Evento de Teclas

        /// <summary>
        /// Inicializa un evento o proceso de acuerdo a la tecla presionada.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmClientesView_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.F1:
                        pv_InicializarFormCliente(1);
                        break;
                    case Keys.F2:
                        pv_InicializarFormCliente(2);
                        break;
                    case Keys.F3:
                        //pv_InactivarCliente();
                        break;
                    case Keys.F4:
                        pv_CargarClientes();
                        break;
                    case Keys.F5:
                        pv_RefrescarForm();
                        break;
                    case Keys.Escape:
                        frmPrincipal vfrmPrincipal = new frmPrincipal();
                        vfrmPrincipal.Show();
                        Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Carga y presenta los clientes deacuerdo al dato de busqueda.
        /// </summary>
        private void pv_CargarClientes()
        {
            try
            {
                string vDatoBusqueda = (mtxtBuscarCodigo.Text.Equals("")) ? "%" : mtxtBuscarCodigo.Text;

                pe_ClienteModel.pb_ObtenerClientes(vDatoBusqueda, 500, "view", ref ps_ClienteModel);

                if (ps_ClienteModel.Count > 0)
                {
                    pe_CodigoCliente = ps_ClienteModel.Select(s => s.cliIntCodigo).FirstOrDefault();
                    mgvClientes.DataSource = ps_ClienteModel;
                }
                else if ((ps_ClienteModel.Count == 0) && (vDatoBusqueda.Equals("%")))
                {
                    vMensajeView.pb_MensajeSistema(this, 3, "Actualmente no se encuentran clientes registrados.");
                }
                else if ((ps_ClienteModel.Count == 0) && (!vDatoBusqueda.Equals("%")))
                {
                    vMensajeView.pb_MensajeSistema(this, 3, "No se encontraron coincidencias de acuerdo a su criterio de búsqueda.");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pv_InicializarFormCliente(int pe_Accion)
        {
            try
            {
                // Nuevo Cliente a insertar
                if (pe_Accion.Equals(1))
                {
                    frmClienteMant vFrmClienteMant = new frmClienteMant(0, pe_CodigoUsuario, pe_Accion);
                    vFrmClienteMant.Show();
                    this.Close();
                }
                else if (pe_Accion.Equals(2)) // Cliente a modificar
                {
                    if (!pe_CodigoCliente.Equals(0))
                    {
                        frmClienteMant vFrmClienteMant = new frmClienteMant(pe_CodigoCliente, pe_CodigoUsuario, pe_Accion);
                        vFrmClienteMant.Show();
                        this.Close();
                    }
                    else
                    {
                        vMensajeView.pb_MensajeSistema(this, 3, "Debe seleccionar un registro.");
                    }
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        /// <summary>
        /// Refresaca los datos del formulario.
        /// </summary>
        private void pv_RefrescarForm()
        {
            try
            {
                mtxtBuscarCodigo.Text = "";
                pv_CargarClientes();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pv_SeleccionarCliente()
        {
            try
            {
                foreach (DataGridViewRow row in mgvClientes.SelectedRows)
                {
                    pe_CodigoCliente = Convert.ToInt32(row.Cells["CodigoSistema"].Value.ToString());
                }

                pv_InicializarFormCliente(2);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
