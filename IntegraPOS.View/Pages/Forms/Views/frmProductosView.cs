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
    public partial class frmProductosView : IntegraPOS.MasterPage
    {
        public frmProductosView()
        {
            InitializeComponent();
        }

        private void frmProductosView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleTransacciones";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("CodigoProducto", typeof(string));
                vTabla.Columns.Add("TipoProducto", typeof(string));
                vTabla.Columns.Add("Descripcion", typeof(string));
                vTabla.Columns.Add("Estado", typeof(string));

                vTabla.Rows.Add("01", "Producto", "Madera", "Activo");
                vTabla.Rows.Add("01-001", "Producto", "Formaleta 4x4", "Activo");
                vTabla.Rows.Add("02", "Accesorio", "Eléctrico", "Activo");

                mgvProductos.DataSource = vTabla;

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
                frmProductoMant vFrmProductosMant = new frmProductoMant();
                vFrmProductosMant.Show();
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
                frmProductoMant vFrmProductosMant = new frmProductoMant();
                vFrmProductosMant.Show();
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

        private void mgvProductos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmProductoMant vFrmProductosMant = new frmProductoMant();
                        vFrmProductosMant.Show();
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
