using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms;
using IntegraPOS.Pages.Forms.Views;
using IntegraPOS.Pages.Forms.Mants;

namespace IntegraPOS.Pages.Panels
{
    public partial class pnlAdministracion : pnlDesplizarMenu
    {
        public pnlAdministracion(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void mlnkEmpresa_Click(object sender, EventArgs e)
        {
            try
            {
                frmEmpresasView vfrmEmpresasView = new frmEmpresasView();
                vfrmEmpresasView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkPerfiles_Click(object sender, EventArgs e)
        {
            try
            {
                frmPerfilesView vFrmPerfilesView = new frmPerfilesView();
                vFrmPerfilesView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                frmUsuariosView vFrmUsuariosView = new frmUsuariosView();
                vFrmUsuariosView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkSucursales_Click(object sender, EventArgs e)
        {
            try
            {
                frmSucursalesView vFrmSucursalesView = new frmSucursalesView();
                vFrmSucursalesView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkMonedas_Click(object sender, EventArgs e)
        {
            try
            {
                frmMonedaMant vFrmMonedaMant = new Forms.Mants.frmMonedaMant();
                vFrmMonedaMant.Show();
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
                frmAdministracionRpts vFrmAdministracionRpts = new frmAdministracionRpts();
                vFrmAdministracionRpts.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkInicio_Click(object sender, EventArgs e)
        {

        }
    }
}
