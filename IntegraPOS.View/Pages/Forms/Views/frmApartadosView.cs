using IntegraPOS.Pages.Forms.Mants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms.Views
{
    public partial class frmApartadosView : IntegraPOS.MasterPage
    {
        public frmApartadosView()
        {
            InitializeComponent();
        }

        #region Eventos Controles

        private void mlnkNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmApartadoMant vFrmApartadoMant = new frmApartadoMant();
                vFrmApartadoMant.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkModificar_Click(object sender, EventArgs e)
        {
            try
            {
                frmApartadoMant vFrmApartadoMant = new frmApartadoMant();
                vFrmApartadoMant.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkVolver_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion

        #region Evento de Teclas

        #endregion
    }
}
