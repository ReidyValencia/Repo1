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
    public partial class frmUnidadesView : IntegraPOS.MasterPage
    {
        public frmUnidadesView()
        {
            InitializeComponent();
        }

        private void frmUnidadesView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleUnidades";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Unidad", typeof(string));
                vTabla.Columns.Add("Descripcion", typeof(string));
                vTabla.Columns.Add("EquivalenciaMH", typeof(string));

                vTabla.Rows.Add("kg", "Kilogramo", "");
                vTabla.Rows.Add("m", "Metro","");
                vTabla.Rows.Add("und", "Unidad", "");

                mgvUnidades.DataSource = vTabla;

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
                frmUnidadMant vFrmUnidadMant = new frmUnidadMant();
                vFrmUnidadMant.Show();
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
                frmUnidadMant vFrmUnidadMant = new frmUnidadMant();
                vFrmUnidadMant.Show();
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

    }
}
