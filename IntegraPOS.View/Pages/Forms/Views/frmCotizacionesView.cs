using IntegraPOS.Pages.Forms.Mants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms.Views
{
    public partial class frmCotizacionesView : IntegraPOS.MasterPage
    {
        public frmCotizacionesView()
        {
            InitializeComponent();
        }

        private void frmCotizacionesView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleCotizaciones";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Sucursal", typeof(string));
                vTabla.Columns.Add("Documento", typeof(string));
                vTabla.Columns.Add("FechaDocumento", typeof(string));
                vTabla.Columns.Add("Cliente", typeof(string));
                vTabla.Columns.Add("Moneda", typeof(string));
                vTabla.Columns.Add("Tasa", typeof(string));
                vTabla.Columns.Add("MontoMndLocal", typeof(string));
                vTabla.Columns.Add("Estado", typeof(string));

                vTabla.Rows.Add("Sucursal Principal", "COT-00001", "12-01-2018", "Fernando Araya", "₡", "1.00", "163,800.00", "Aplicada");
                vTabla.Rows.Add("Sucursal Secundaria", "COT-00002", "15-01-2018", "Denia Hernández", "₡", "1.00", "79,300.00", "Aplicada");
                vTabla.Rows.Add("Sucursal Heredia", "COT-00003", "21-01-2018", "Maria Jose Picado", "€", "623.00", "284,960.00", "Anulada");
                vTabla.Rows.Add("Sucursal Principal", "COT-00004", "02-02-2018", "Antonio Cardoza", "$", "570.82", "33,100.56", "Aplicada");
                vTabla.Rows.Add("Sucursal Heredia", "COT-00005", "06-02-2018", "Luisana Ortega", "₡", "1.00", "700,862.00", "Aplicada");

                mgvCotizaciones.DataSource = vTabla;

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
                frmCotizacionMant vFrmCotizacionMant = new frmCotizacionMant();
                vFrmCotizacionMant.Show();
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
                frmCotizacionMant vFrmCotizacionMant = new frmCotizacionMant();
                vFrmCotizacionMant.Show();
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

        private void mgvCotizaciones_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmCotizacionMant vFrmCotizacionMant = new frmCotizacionMant();
                        vFrmCotizacionMant.Show();
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
