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
    public partial class frmUnidadMant : IntegraPOS.MasterPage
    {
        public frmUnidadMant()
        {
            InitializeComponent();
        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmUnidadesView vFrmUnidadesView = new frmUnidadesView();
                vFrmUnidadesView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
