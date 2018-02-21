using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Mants;

namespace IntegraPOS.Pages.Forms.Mants
{
    public partial class frmMonedaMant : IntegraPOS.MasterPage
    {
        public frmMonedaMant()
        {
            InitializeComponent();
        }

        private void frmMonedaMant_Load(object sender, EventArgs e)
        {

            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleUnidades";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Nombre", typeof(string));
                vTabla.Columns.Add("Simbolo", typeof(string));
                vTabla.Columns.Add("Prioridad", typeof(string));
                vTabla.Columns.Add("CodISO", typeof(string));

                vTabla.Rows.Add("Colón", "₡", "1", "[CRC] Colones");
                vTabla.Rows.Add("Dólar", "$", "2", "[USD] Dolares");
                vTabla.Rows.Add("Euro", "€", "3", "[EUR] Euros");

                mgvUnidades.DataSource = vTabla;

                DataTable vTabla1 = new DataTable();

                vTabla1.TableName = "DetalleUnidades";
                vTabla1.Rows.Clear();

                vTabla1.Columns.Add("Dia", typeof(string));
                vTabla1.Columns.Add("Compra", typeof(string));
                vTabla1.Columns.Add("Venta", typeof(string));

                vTabla1.Rows.Add("01-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("02-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("03-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("04-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("05-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("06-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("07-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("08-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("09-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("10-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("11-02-2018", "1.00", "1.00"); ;
                vTabla1.Rows.Add("12-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("13-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("14-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("15-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("16-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("17-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("18-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("19-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("20-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("21-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("22-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("23-02-2018", "1.00", "1.00");
                vTabla1.Rows.Add("24-02-2018", "1.00", "1.00");



                mgvFechas.DataSource = vTabla1;

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void mlnkCancelar_Click(object sender, EventArgs e)
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

    }
}
