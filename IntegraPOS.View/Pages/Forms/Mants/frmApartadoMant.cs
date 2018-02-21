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
    public partial class frmApartadoMant : IntegraPOS.MasterPage 
    {
        public frmApartadoMant()
        {
            InitializeComponent();
        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmApartadosView vfrmApartadosView = new frmApartadosView();
                vfrmApartadosView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
