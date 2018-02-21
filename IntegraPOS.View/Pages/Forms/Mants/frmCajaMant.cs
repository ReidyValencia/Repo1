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
    public partial class frmCajaMant : IntegraPOS.MasterPage
    {
        public frmCajaMant()
        {
            InitializeComponent();
        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmCajasView vFrmCajasView = new frmCajasView();
                vFrmCajasView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkNuevo_Click(object sender, EventArgs e)
        {

        }

        private void mlnkRecargar_Click(object sender, EventArgs e)
        {

        }
    }
}
