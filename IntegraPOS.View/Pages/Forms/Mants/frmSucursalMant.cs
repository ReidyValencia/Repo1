using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms.Mants
{
    public partial class frmSucursalMant : IntegraPOS.MasterPage
    {
        public frmSucursalMant()
        {
            InitializeComponent();
        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmSucursalesView vFrmSucursalesView = new frmSucursalesView();
                vFrmSucursalesView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
