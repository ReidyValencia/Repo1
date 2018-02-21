using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms.Reportes.Panels
{
    public partial class pnlExistenciasInventario : pnlDeslizarMenuReportes
    {
        public pnlExistenciasInventario(Form owner):base(owner)
        {
            InitializeComponent();
        }

        private void mdateFechaFin_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
