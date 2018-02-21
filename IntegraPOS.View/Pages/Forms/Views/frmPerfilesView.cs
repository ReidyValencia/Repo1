using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms
{
    public partial class frmPerfilesView : IntegraPOS.MasterPage
    {
        public frmPerfilesView()
        {
            InitializeComponent();
        }

        #region Eventos Controles

        private void frmPerfilesView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleTransacciones";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("NombrePerfil", typeof(string));
                vTabla.Columns.Add("VisualizarReportes", typeof(bool));

                vTabla.Rows.Add("Administrador", true);
                vTabla.Rows.Add("Vendedor", false);

                mgvPerfiles.DataSource = vTabla;

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
                frmPerfilMant vFrmPerfilMant = new frmPerfilMant();
                vFrmPerfilMant.Show();
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
                frmPerfilMant vFrmPerfilMant = new frmPerfilMant();
                vFrmPerfilMant.Show();
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

        private void mgvPerfiles_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmPerfilMant vFrmPerfilMant = new frmPerfilMant();
                        vFrmPerfilMant.Show();
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
