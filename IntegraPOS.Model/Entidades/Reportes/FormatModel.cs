using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS.Model.Entidades.Reportes
{
    public class FormatModel
    {
        /// <summary>
        /// Código de la empresa.
        /// </summary>
        public int pe_empIntCodigo { get; set; }

        /// <summary>
        /// Codigo de transaccion.
        /// </summary>
        public string pe_traChrNumero { get; set; }

        /// <summary>
        /// Clasificación de la transaccion.
        /// </summary>
        public string pe_traChrClasificación { get; set; }

        /// <summary>
        /// Modulo
        /// </summary>
        public string pe_nomChrModulo { get; set; }

        /// <summary>
        /// Numero de formato.
        /// </summary>
        public string pe_numChrFormato { get; set; }

        /// <summary>
        /// Estado de transacción.
        /// </summary>
        public string pe_traChrEstado { get; set; }

        /// <summary>
        /// Acceso de formato.
        /// </summary>
        public string pe_accChrAcceso { get; set; }

        public FormatModel(int p_empIntCodigo,string p_traChrNumero, string p_traChrClasificación, string p_nomChrModulo, string p_numChrFormato, string p_traChrEstado, string p_accChrAcceso)
        {
            pe_empIntCodigo = p_empIntCodigo;
            pe_traChrNumero = p_traChrNumero;
            pe_traChrClasificación = p_traChrClasificación;
            pe_nomChrModulo = p_nomChrModulo;
            pe_numChrFormato = p_numChrFormato;
            pe_traChrEstado = p_traChrEstado;
            pe_accChrAcceso = p_accChrAcceso;
        }


    }
}
