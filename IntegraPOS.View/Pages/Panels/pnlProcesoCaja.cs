using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Views;

namespace IntegraPOS.Pages.Panels
{
    public partial class pnlProcesoCaja : pnlDesplizarMenu
    {
        public pnlProcesoCaja(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void mlnkAperturaCaja_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbrirCajasView vFrmAbrirCajasView = new frmAbrirCajasView();
                vFrmAbrirCajasView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkCorteCaja_Click(object sender, EventArgs e)
        {
            try
            {
                frmCorteCajasView vFrmCorteCajasView = new frmCorteCajasView();
                vFrmCorteCajasView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkCierreCaja_Click(object sender, EventArgs e)
        {
            try
            {
                frmCierreCajasView vFrmCierreCajasView = new frmCierreCajasView();
                vFrmCierreCajasView.Show();
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
                frmProcesoCajaRpts vFrmProcesoCajaRpts = new frmProcesoCajaRpts();
                vFrmProcesoCajaRpts.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
