using IntegraPOS.Pages.Forms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms.Mants
{
    public partial class frmPedidoMant : IntegraPOS.MasterPage
    {
        public frmPedidoMant()
        {
            InitializeComponent();
        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmPedidosView vFrmPedidosView = new frmPedidosView();
                vFrmPedidosView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
