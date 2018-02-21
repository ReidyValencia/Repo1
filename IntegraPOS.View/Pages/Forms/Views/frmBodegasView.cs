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
    public partial class frmBodegasView : IntegraPOS.MasterPage
    {
        public frmBodegasView()
        {
            InitializeComponent();
        }

        private void frmBodegasView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleBodegas";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("CodigoBodega", typeof(string));
                vTabla.Columns.Add("Descripcion", typeof(string));
                vTabla.Columns.Add("Sucursal", typeof(string));
                vTabla.Columns.Add("TipoBodega", typeof(string));
                vTabla.Columns.Add("Encargado", typeof(string));

                vTabla.Rows.Add("BOD01", "Bodega Principal", "Sucursal Principal", "Fisica", "José Rodríguez");
                vTabla.Rows.Add("BOD02", "Bodega Secundaria", "Sucursal Secundaria", "Fisica", "María Castillo");
                vTabla.Rows.Add("BOD03", "Bodega Reserva 01", "Sucursal Principal", "Reserva", "Cristian López");
                vTabla.Rows.Add("BOD04", "Bodega Reserva 02", "Sucursal Principal", "Reserva", "Melissa Araya");
                vTabla.Rows.Add("BOD05", "Bodega accesorios", "Sucursal Heredia", "Accesorios", "Benjamín Ortega");

                mgvBodegas.DataSource = vTabla;

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
                frmBodegaMant vFrmBodegaMant = new frmBodegaMant();
                vFrmBodegaMant.Show();
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
                frmBodegaMant vFrmBodegaMant = new frmBodegaMant();
                vFrmBodegaMant.Show();
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

        private void mgvBodegas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmBodegaMant vFrmBodegaMant = new frmBodegaMant();
                        vFrmBodegaMant.Show();
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
