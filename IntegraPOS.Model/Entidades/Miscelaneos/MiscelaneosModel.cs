using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IntegraPOS.Model.Entidades.Clases;
using MetroFramework.Controls;
using System.Drawing.Printing;

namespace IntegraPOS.Model.Entidades.Miscelaneos
{
    public class MiscelaneosModel
    {

        #region Propiedades

        public string cnfChrNombre { get; set; }
        public string cnfChrDato { get; set; }

        #endregion

        #region Instancia ConnectionModel

        private ConnectionModel vConnectionModel = new ConnectionModel();

        #endregion

        #region Constructor / Destructor

        public MiscelaneosModel()
        {
            cnfChrNombre = "";
            cnfChrDato = "";
        }

        ~MiscelaneosModel() { }

        #endregion

        #region Métodos Públicos

        public void pb_AplicarFormato(ref string pe_Cadena, string pe_Formato, char pe_Delimitador)
        {
            try
            {
                pv_AplicarFormato(ref pe_Cadena, pe_Formato, pe_Delimitador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		
		public void pb_AplicarFormatoFecha(string pe_Fecha, ref string ps_FechaSistema, ref DateTime ps_FechaBaseDatos, string pe_TipoFormato)
        {
            try
            {
                var vFecha = pe_Fecha.Split('-');

                switch (pe_TipoFormato)
                {
                    case "FormatoSistema":
                        ps_FechaSistema = vFecha[2] + "-" + vFecha[1] + "-" + vFecha[0];
                        break;

                    case "FormatoBaseDatos":
                        ps_FechaBaseDatos = Convert.ToDateTime(vFecha[2] + "-" + vFecha[1] + "-" + vFecha[0]);
                        break;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
		

        /// <summary>
        /// Carga de opciones ComboBox de la pagina
        /// </summary>
        /// <param name="mBox"></param>
        public void pb_CargaComboBox(ref MetroComboBox mBox)
        {
            var dicloadOpciones = new Dictionary<string, string>();
            var opcion = string.Empty;
            switch (mBox.Name)
            {
                case "mcboxEstadoCliente": {opcion = "EstadosGenerales"; break;}
                case "mcboxEstadoTransac": {opcion = "EstadoTransac"; break; }
                case "mcboxFormato":    {opcion = "FormatoReportes"; break;}
                case "mcboxDespliegue": {opcion = "DespliegueReportes"; break;}
                case "mcboxTipoInforme":{opcion = "TipoInforme"; break;}
                case "mcboxFormaPago":  {opcion = "FormaPago"; break; }
                default:
                {
                    break;
                }
            }
            if (string.IsNullOrEmpty(opcion)) return;
            dicloadOpciones = pv_CargaMiscelaneas(opcion);
            if (dicloadOpciones.Count == 0){return; }
            mBox.DataSource = new BindingSource(dicloadOpciones, null);
            mBox.DisplayMember = "Key";
            mBox.ValueMember = "Value";
        }

        /// <summary>
        /// Carga los calendarios con respecto a la fecha de inactividad, inicio de periodo y fin de perido.
        /// </summary>
        /// <param name="pe_Calendario"></param>
        public void pv_CargaCalendario(ref MetroDateTime pe_Calendario)
        {
            try
            {
                var _configEmpresaModelMisc = new ConfigEmpresaModelMisc();
                _configEmpresaModelMisc.pb_ObtenerConfigEmpresa(ref _configEmpresaModelMisc);

                //Si la fecha de inactividad es menor a la fecha de inicio de periodo, no se puede seleccionar nada menor a la fecha de inicio
                pe_Calendario.MinDate = DateTime.Parse(DateTime.Parse(_configEmpresaModelMisc.FecInaPeriodo) <
                                                       DateTime.Parse(_configEmpresaModelMisc.FecIniPeriodo) ? _configEmpresaModelMisc.FecIniPeriodo : _configEmpresaModelMisc.FecInaPeriodo);

                pe_Calendario.MaxDate = DateTime.Parse(_configEmpresaModelMisc.FecFinPeriodo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pe_estado"></param>
        /// <param name="mBox"></param>
        public void pb_ListadoEstadosTransacciones(string pe_estado, ref MetroComboBox mBox)
        {
            try
            {
                var _estadoModel = new TransaccionEstadoModel();
                mBox.DataSource = _estadoModel.pb_GetTransaccionEstadoModel(pe_estado);
                mBox.DisplayMember = "estChrNombreAct";
                mBox.ValueMember = "estChrCodigo";
            }
            catch (Exception)
            {
                    
                throw;
            }
        }

        /// <summary>
        /// Optiene que parametros se configuran para la impresión de documentos
        /// </summary>
        /// <returns></returns>
        public PrinterSettings pb_ParametrosConfig_Impresora()
        {
            PrinterSettings _printer = new PrinterSettings();
            return _printer;
        }

        #endregion

        #region Métodos Privados

        private Dictionary<string, string> pv_CargaMiscelaneas(string pe_opcion)
        {
            var vDictionary = vConnectionModel.pb_PTV_CargasMiscelaneos(pe_opcion);
            return vDictionary;

        }


        private void pv_AplicarFormato(ref string pe_Cadena, string pe_Formato, char pe_Delimitador)
        {
            try
            {
                vConnectionModel.pb_AplicarFormato(ref pe_Cadena, pe_Formato, pe_Delimitador);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        #endregion

    }


    public class OpcionesCargasMiscelaneos
    {
        public string PVT_Valor { get; set; }
        public string PVT_Descripcion { get; set; }
    }
}
