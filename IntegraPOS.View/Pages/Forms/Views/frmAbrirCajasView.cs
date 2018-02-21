using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Mants;

namespace IntegraPOS.Pages.Forms.Views
{
    public partial class frmAbrirCajasView : IntegraPOS.MasterPage
    {
        public frmAbrirCajasView()
        {
            InitializeComponent();
        }

        private void frmAbrirCajasView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleCajas";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Nombre", typeof(string));
                vTabla.Columns.Add("Sucursal", typeof(string));
                vTabla.Columns.Add("FechaCierre", typeof(string));
                vTabla.Columns.Add("Proceso", typeof(string));

                vTabla.Rows.Add("CAJ-002", "Sucursal Principal", "09-01-2018", "Cerrada");
                vTabla.Rows.Add("CAJ-003", "Sucursal Secundaria", "02-02-2018", "Cerrada");

                mgvCajas.DataSource = vTabla;
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
                frmAbrirCajaMant vFrmAbrirCajaMant = new frmAbrirCajaMant();
                vFrmAbrirCajaMant.Show();
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

        /// <summary>
        /// Evento que se ejecuta al presionar la tecla enter en una celda del grid view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void mgvCajas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmAbrirCajaMant vFrmAbrirCajaMant = new frmAbrirCajaMant();
                        vFrmAbrirCajaMant.Show();
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
