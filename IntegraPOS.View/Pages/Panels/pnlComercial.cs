using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms;
using IntegraPOS.Pages.Forms.Reportes;
using IntegraPOS.Pages.Forms.Views;

namespace IntegraPOS.Pages.Panels
{
    public partial class pnlComercial : pnlDesplizarMenu
    {
        public pnlComercial(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void mlnkClientes_Click(object sender, EventArgs e)
        {
            try
            {
                frmClientesView vFrmClientesView = new frmClientesView();
                vFrmClientesView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkProveeddores_Click(object sender, EventArgs e)
        {
            try
            {
                frmProveedoresView vFrmProveedoresView = new frmProveedoresView();
                vFrmProveedoresView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkVendedores_Click(object sender, EventArgs e)
        {
            try
            {
                frmVendedoresView vFrmVendedoresView = new frmVendedoresView();
                vFrmVendedoresView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkBodegas_Click(object sender, EventArgs e)
        {
            try
            {
                frmBodegasView vFrmBodegasView = new frmBodegasView();
                vFrmBodegasView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkCajas_Click(object sender, EventArgs e)
        {
            try
            {
                frmCajasView vFrmCajasView = new frmCajasView();
                vFrmCajasView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkProductos_Click(object sender, EventArgs e)
        {
            try
            {
                frmProductosView vFrmProductosView = new frmProductosView();
                vFrmProductosView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkUnidades_Click(object sender, EventArgs e)
        {
            try
            {
                frmUnidadesView vFrmUnidadesView = new frmUnidadesView();
                vFrmUnidadesView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkMedioPago_Click(object sender, EventArgs e)
        {
            try
            {
                frmMediosPagoView vFrmMediosPagoView = new frmMediosPagoView();
                vFrmMediosPagoView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkReportes_Click(object sender, EventArgs e)
        {
            try
            {
                frmComercialRpts vFrmComercialRpts = new frmComercialRpts();
                vFrmComercialRpts.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
