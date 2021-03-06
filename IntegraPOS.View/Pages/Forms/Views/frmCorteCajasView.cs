﻿using IntegraPOS.Pages.Forms.Mants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms.Views
{
    public partial class frmCorteCajasView : IntegraPOS.MasterPage
    {
        public frmCorteCajasView()
        {
            InitializeComponent();
        }

        private void frmCorteCajasView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleCajas";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Nombre", typeof(string));
                vTabla.Columns.Add("Sucursal", typeof(string));
                vTabla.Columns.Add("Fecha", typeof(string));
                vTabla.Columns.Add("Cajero", typeof(string));
                vTabla.Columns.Add("Proceso", typeof(string));

                vTabla.Rows.Add("CAJ-001", "Sucursal Principal", "01-02-2018", "Catalina Arias", "Abierta");

                mgvCajas.DataSource = vTabla;
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
                frmCorteCajaMant vFrmCorteCajaMant = new frmCorteCajaMant();
                vFrmCorteCajaMant.Show();
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

        private void mgvCajas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmCorteCajaMant vFrmCorteCajaMant = new frmCorteCajaMant();
                        vFrmCorteCajaMant.Show();
                        Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
