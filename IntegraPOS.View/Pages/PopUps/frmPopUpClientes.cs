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
using IntegraPOS.Clases;
using MetroFramework;
using IntegraPOS.Model.Entidades.Miscelaneos;

namespace IntegraPOS
{
    public partial class frmPopUpClientes : IntegraPOS.MasterPagePopUp
    {
        #region Variables locales

        private int ps_CodigoCliente = 0;
        private string pe_DatoBusqueda = null;
        private string pe_FormLlamado = null;
        private List<ClienteModel> ps_ClienteModel; // Instancia de ClienteModel para ingreso de datos.
        public ClienteModel pe_ClienteModel = new ClienteModel(); // Instancia de ClienteModel para obtener datos de consulta.
        private MensajeView vMensajeView = new MensajeView(); // Instancia de MensajeView para la presentancion de datos.
        private MiscelaneosModel pe_MiscelaneosModel = new MiscelaneosModel();
        private ConfigEmpresaModelMisc pe_ConfigEmpresaModelMisc = new ConfigEmpresaModelMisc();

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor sin parametros.
        /// </summary>
        public frmPopUpClientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Constructor con parametro de entrada.
        /// </summary>
        /// <param name="formulario">Nombre del formulario que lo instancia</param>
        /// <param name="datoBusqueda">Dato por el que se realiza la búsqueda por defecto</param>
        public frmPopUpClientes(string datoBusqueda, string llamado) : this()
        {
            try
            {
                pe_DatoBusqueda = datoBusqueda;
                pe_FormLlamado = llamado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        private void frmPopUpClientes_Load(object sender, EventArgs e)
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
        /// Devuelve el número de clientes encontrados
        /// </summary>
        /// <returns></returns> 
        public int pb_CantidadClientes()
        {
            try
            {
                frmPopUpClientes_Load(null, null);
                pv_ObtenerClientes(pe_DatoBusqueda, pe_FormLlamado);

                return ps_ClienteModel.Count;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene los clientes que concuerden con el dato de ingresado.
        /// </summary>
        /// <param name="pe_datoBusqueda"></param>
        private void pv_ObtenerClientes(string pe_datoBusqueda, string pe_FormLlamado)
        {
            try
            {
                pe_ClienteModel.pb_ObtenerClientes(pe_datoBusqueda, 500, "popup", ref ps_ClienteModel);

                switch (pe_FormLlamado)
                {
                    case "frmFacturaMant":
                        pv_FiltrarCodigos(ref ps_ClienteModel, 0);
                        break;
                    case "frmClienteMant":
                        pv_FiltrarCodigos(ref ps_ClienteModel, 1);
                        break;
                    default:
                        break;
                }

                if (ps_ClienteModel.Count.Equals(1))
                {
                    pe_ClienteModel = ps_ClienteModel.First();
                    Close(); // Oculta el PopUp Clientes
                }
                else if (ps_ClienteModel.Count > 1)
                {
                    mgvClientes.DataSource = ps_ClienteModel;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Obtiene la fila seleccionada y devuelve al formulario principal un modelo de la entidad cliente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mgridClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                pv_SeleccionarClienteGrid();
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

        private void mlnkBusqCliente_Click(object sender, EventArgs e)
        {
            try
            {
                pv_ObtenerClientes(mtxtDatoBusqueda.Text, pe_FormLlamado);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Filtra los códigos de penúltimo nivel para mostrar en el combobox de código del mantenimiento
        /// </summary>
        /// <param name="pe_ClienteModel"></param>
        public void pv_FiltrarCodigos(ref List<ClienteModel> pe_ClienteModel, int pe_nivel)
        {
            try
            {
                List<ClienteModel> ps_ListaFiltrada = new List<ClienteModel>();

                pe_ConfigEmpresaModelMisc.pb_ObtenerConfigEmpresa(ref pe_ConfigEmpresaModelMisc);
                string niveles = pe_ConfigEmpresaModelMisc.CnfNivelesClientes;
                int tamano = (niveles.Split('-').Length) - pe_nivel;

                foreach (ClienteModel cli in pe_ClienteModel)
                {
                    if (((cli.cliChrCodigoPri.Split('-')).Length).Equals(tamano))
                    {
                        ps_ListaFiltrada.Add(cli);
                    }
                }

                pe_ClienteModel = ps_ListaFiltrada;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void pv_SeleccionarClienteGrid()
        {
            try
            {
                foreach (DataGridViewRow row in mgvClientes.SelectedRows)
                {
                    ps_CodigoCliente = Convert.ToInt32(row.Cells["CodigoSistema"].Value.ToString());
                }

                pe_ClienteModel = ps_ClienteModel.Where(w => w.cliIntCodigo.Equals(ps_CodigoCliente)).Cast<ClienteModel>().FirstOrDefault();
                Close(); // Oculta el PopUp Cliente
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
                        pv_SeleccionarClienteGrid();
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
