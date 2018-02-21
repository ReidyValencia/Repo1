using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms
{
    public partial class frmEmpresaMant : IntegraPOS.MasterPage
    {
        public frmEmpresaMant()
        {
            InitializeComponent();
        }

        private void mlnkVolver_Click(object sender, EventArgs e)
        {
            
        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpresasView vfrmEmpresasView = new frmEmpresasView();
                vfrmEmpresasView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
