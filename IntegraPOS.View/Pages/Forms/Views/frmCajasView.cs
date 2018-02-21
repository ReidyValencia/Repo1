using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Views;
using IntegraPOS.Pages.Forms.Mants;
using IntegraPOS.Model.Entidades.Clases;

namespace IntegraPOS.Pages.Forms.Views
{
    public partial class frmCajasView : IntegraPOS.MasterPage
    {

        private CajaModel cajaModel;
        private List<CajaModel> oListCajas;

        public frmCajasView()
        {
            InitializeComponent();
        }

        private void frmCajasView_Load(object sender, EventArgs e)
        {
            try
            {
                cajaModel = new CajaModel();
                oListCajas = new List<CajaModel>();
                oListCajas = cajaModel.pb_getCajas("","");
                mgvCajas.AutoGenerateColumns = false;
                mgvCajas.DataSource = oListCajas;
                

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #region Eventos Controles

        private void mlnkNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmCajaMant vFrmCajaMant = new frmCajaMant();
                vFrmCajaMant.Show();
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
                frmCajaMant vFrmCajaMant = new frmCajaMant();
                vFrmCajaMant.Show();
                // Close();
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

        private void mgvCajas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmCajaMant vFrmCajaMant = new frmCajaMant();
                        vFrmCajaMant.Show();
                        Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarCaja_Click(object sender, EventArgs e)
        {
            cajaModel = new CajaModel();
            oListCajas = new List<CajaModel>();
            if (mtxtBuscarGeneral.Text != "")            
                txtBuscarCodigo.Text = "";
            
            oListCajas = cajaModel.pb_getCajas(txtBuscarCodigo.Text, mtxtBuscarGeneral.Text);
            mgvCajas.DataSource = oListCajas;
        }

        private void btnRefrescarBusqueda_Click(object sender, EventArgs e)
        {

        }
    }
}
