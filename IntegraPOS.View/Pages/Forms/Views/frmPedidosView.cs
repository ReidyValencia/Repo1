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
    public partial class frmPedidosView : IntegraPOS.MasterPage
    {
        public frmPedidosView()
        {
            InitializeComponent();
        }

        private void frmPedidosView_Load(object sender, EventArgs e)
        {
            DataTable vTabla = new DataTable();

            vTabla.TableName = "DetallePedidos";
            vTabla.Rows.Clear();

            vTabla.Columns.Add("Sucursal", typeof(string));
            vTabla.Columns.Add("Documento", typeof(string));
            vTabla.Columns.Add("FechaDocumento", typeof(string));
            vTabla.Columns.Add("Cliente", typeof(string));
            vTabla.Columns.Add("Moneda", typeof(string));
            vTabla.Columns.Add("Tasa", typeof(string));
            vTabla.Columns.Add("MontoMndLocal", typeof(string));
            vTabla.Columns.Add("Estado", typeof(string));


            vTabla.Rows.Add("Sucursal Heredia", "PED-00001", "12-01-2018", "Maria Jose Picado", "₡", "1.00", "24,960.00", "Anulada");
            vTabla.Rows.Add("Sucursal Principal", "PED-00002", "13-01-2018", "Luisana Ortega", "$", "570.82", "86,254.93", "Aplicada");
            vTabla.Rows.Add("Sucursal Principal", "PED-00003", "21-01-2018", "Antonio Cardoza", "€", "623.00", "192,000.00", "Aplicada");
            vTabla.Rows.Add("Sucursal Secundaria", "PED-00004", "26-01-2018", "Denia Hernández", "₡", "1.00", "79,300.00", "Anulado");
            vTabla.Rows.Add("Sucursal Principal", "PED-00005", "05-02-2018", "Fernando Araya", "$", "570.82", "163,800.37", "Aplicada");

            mgvPedidos.DataSource = vTabla;
        }

        #region Eventos Controles

        private void mlnkNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                frmPedidoMant vFrmPedidoMant = new frmPedidoMant();
                vFrmPedidoMant.Show();
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
                frmPedidoMant vFrmPedidoMant = new frmPedidoMant();
                vFrmPedidoMant.Show();
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

        private void mgvPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmPedidoMant vFrmPedidoMant = new frmPedidoMant();
                        vFrmPedidoMant.Show();
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
