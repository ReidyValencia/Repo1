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
    public partial class frmMedioPagoMant : IntegraPOS.MasterPage
    {
        public frmMedioPagoMant()
        {
            InitializeComponent();
        }

        private void frmMedioPagoMant_Load(object sender, EventArgs e)
        {

        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmMediosPagoView vFrmMediosPagoView = new frmMediosPagoView();
                vFrmMediosPagoView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
