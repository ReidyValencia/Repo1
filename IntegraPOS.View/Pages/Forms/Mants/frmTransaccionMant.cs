using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Views;

namespace IntegraPOS.Pages.Forms.Mants
{
    public partial class frmTransaccionMant : IntegraPOS.MasterPage
    {
        public frmTransaccionMant()
        {
            InitializeComponent();
        }

        private void frmTransaccionMant_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmTransaccionesView vFrmTransaccionesView = new frmTransaccionesView();
                vFrmTransaccionesView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
