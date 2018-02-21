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
    public partial class frmSucursalesView : IntegraPOS.MasterPage
    {
        public frmSucursalesView()
        {
            InitializeComponent();
        }

        #region Eventos Controles


        private void frmSucursalesView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleTransacciones";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Sucursal", typeof(string));
                vTabla.Columns.Add("Direccion", typeof(string));
                vTabla.Columns.Add("Estado", typeof(string));

                vTabla.Rows.Add("Sucursal Principal", "100 Este de la Sabana, San José", "Activa");
                vTabla.Rows.Add("Sucursal Secundaria", "250 Norte parque central, Alajuela", "Activa");
                vTabla.Rows.Add("Sucursal Heredia", "Heredia Centro", "Inactiva");

                mgvSucursales.DataSource = vTabla;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void mlnkNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmSucursalMant vFrmSucursalMant = new frmSucursalMant();
                vFrmSucursalMant.Show();
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
                frmSucursalMant vFrmSucursalMant = new frmSucursalMant();
                vFrmSucursalMant.Show();
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

        private void mgvSucursales_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmSucursalMant vFrmSucursalMant = new frmSucursalMant();
                        vFrmSucursalMant.Show();
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
