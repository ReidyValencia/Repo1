﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Views;

namespace IntegraPOS.Pages.Forms.Mants
{
    public partial class frmAbrirCajaMant : IntegraPOS.MasterPage
    {
        public frmAbrirCajaMant()
        {
            InitializeComponent();
        }


        private void mlblRecargar_Click(object sender, EventArgs e)
        {

        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
        {
            try
            {
                frmAbrirCajasView vFrmAbrirCajasView = new frmAbrirCajasView();
                vFrmAbrirCajasView.Show();
                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
