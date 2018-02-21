using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms.Mants
{
    public partial class frmUsuarioMant : IntegraPOS.MasterPage
    {
        public frmUsuarioMant()
        {
            InitializeComponent();
        }

        private void frmUsuarioMant_Load(object sender, EventArgs e)
        {

        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuariosView vFrmUsuariosView = new frmUsuariosView();
                vFrmUsuariosView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
