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
    public partial class frmRecibosView : IntegraPOS.MasterPage
    {
        public frmRecibosView()
        {
            InitializeComponent();
        }

        private void frmRecibosView_Load(object sender, EventArgs e)
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

                vTabla.Rows.Add("Sucursal Principal", "REC-00001", "06-01-2018", "Fernando Araya", "₡", "1.00", "163,800.00", "Aplicada");
                vTabla.Rows.Add("Sucursal Secundaria", "REC-00002", "13-01-2018", "Denia Hernández", "$", "570.82", "79,300.46", "Aplicada");
                vTabla.Rows.Add("Sucursal Heredia", "REC-00003", "17-01-2018", "Maria Jose Picado", "€", "623.00", "284,960.00", "Aplicada");

                mgvRecibos.DataSource = vTabla;

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
                frmReciboMant vFrmReciboMant = new frmReciboMant();
                vFrmReciboMant.Show();
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
                frmReciboMant vFrmReciboMant = new frmReciboMant();
                vFrmReciboMant.Show();
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

        private void mgvRecibos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmReciboMant vFrmReciboMant = new frmReciboMant();
                        vFrmReciboMant.Show();
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
