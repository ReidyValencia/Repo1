using IntegraPOS.Pages.Forms.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Panels
{
    public partial class pnlTransaccion : IntegraPOS.Pages.Panels.pnlDesplizarMenu
    {
       
        public pnlTransaccion(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        private void mlnkEntradaProd_Click(object sender, EventArgs e)
        {
            try
            {
                frmEntradasInvView vFrmEntradasInvView = new frmEntradasInvView();
                vFrmEntradasInvView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkCotizaciones_Click(object sender, EventArgs e)
        {
            try
            {
                frmCotizacionesView vFrmCotizacionesView = new frmCotizacionesView();
                vFrmCotizacionesView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkPedidos_Click(object sender, EventArgs e)
        {
            try
            {
                frmPedidosView vFrmPedidosView = new frmPedidosView();
                vFrmPedidosView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkFacturas_Click(object sender, EventArgs e)
        {
            try
            {
                frmFacturasView vFrmFacturasView = new frmFacturasView();
                vFrmFacturasView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkRecibos_Click(object sender, EventArgs e)
        {
            try
            {
                frmRecibosView vFrmRecibosView = new frmRecibosView();
                vFrmRecibosView.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkApartados_Click(object sender, EventArgs e)
        {
            try
            {
                frmApartadosView vFrmApartadosView = new frmApartadosView();
                vFrmApartadosView.Show();
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
                frmTransaccionRpts vFrmTransaccionRpts = new frmTransaccionRpts();
                vFrmTransaccionRpts.Show();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
