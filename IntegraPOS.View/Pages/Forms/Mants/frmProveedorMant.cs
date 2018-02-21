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
    public partial class frmProveedorMant : IntegraPOS.MasterPage
    {
        public frmProveedorMant()
        {
            InitializeComponent();
        }

        private void mlnkGuardar_Click(object sender, EventArgs e)
        {
        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmProveedoresView vFrmProveedoresView = new frmProveedoresView();
                vFrmProveedoresView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
