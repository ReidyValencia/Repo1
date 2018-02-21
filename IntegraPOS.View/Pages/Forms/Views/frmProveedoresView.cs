using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Views;
using IntegraPOS.Pages.Forms.Mants;

namespace IntegraPOS.Pages.Forms.Views
{
    public partial class frmProveedoresView : IntegraPOS.MasterPage
    {
        public frmProveedoresView()
        {
            InitializeComponent();
        }

        #region Eventos Controles

        private void frmProveedoresView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleTransacciones";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("CodigoProveedor", typeof(string));
                vTabla.Columns.Add("Nombre", typeof(string));
                vTabla.Columns.Add("Estado", typeof(string));

                vTabla.Rows.Add("01", "Proveedores Nacionales", "Activo");
                vTabla.Rows.Add("01-01", "Dos Pinos", "Activo");;
                vTabla.Rows.Add("02", "Proveedores Internacionales", "Activo");
                vTabla.Rows.Add("02-01", "Office Depot", "Inactivo");
                vTabla.Rows.Add("02-02", "DELL", "Activo");

                mgvProveedores.DataSource = vTabla;

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
                frmProveedorMant vFrmProveedorMant = new frmProveedorMant();
                vFrmProveedorMant.Show();
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
                frmProveedorMant vFrmProveedorMant = new frmProveedorMant();
                vFrmProveedorMant.Show();
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

        #region Eveno de Teclas



        #endregion

        private void mgvProveedores_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmProveedorMant vFrmProveedorMant = new frmProveedorMant();
                        vFrmProveedorMant.Show();
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
