using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Mants;

namespace IntegraPOS.Pages.Forms
{
    public partial class frmMonedasView : IntegraPOS.MasterPage
    {
        public frmMonedasView()
        {
            InitializeComponent();
        }

        #region Eventos Controles

        private void mlnkNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmMonedaMant vFrmMonedaMant = new frmMonedaMant();
                vFrmMonedaMant.Show();
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
                frmMonedaMant vFrmMonedaMant = new frmMonedaMant();
                vFrmMonedaMant.Show();
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
