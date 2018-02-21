using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms
{
    public partial class frmPerfilMant : IntegraPOS.MasterPage
    {
        public frmPerfilMant()
        {
            InitializeComponent();
        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmPerfilesView vFrmPerfilesView = new frmPerfilesView();
                vFrmPerfilesView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
