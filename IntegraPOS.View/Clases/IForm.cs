using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegraPOS
{
    public interface IForm
    {
        void pb_CargarCliente(int codigoCliente, string nombreCliente);
    }
}
