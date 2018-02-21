using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Views;

namespace IntegraPOS.Pages.Panels
{
    public partial class pnlConfiguracion : pnlDesplizarMenu
    {
        public pnlConfiguracion(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void mlnkTransacciones_Click(object sender, EventArgs e)
        {
            try
            {
                frmTransaccionesView vFrmTransaccionesView = new frmTransaccionesView();
                vFrmTransaccionesView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
