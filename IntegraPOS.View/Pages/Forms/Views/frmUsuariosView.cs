using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using IntegraPOS.Pages.Forms.Mants;

namespace IntegraPOS.Pages.Forms
{
    public partial class frmUsuariosView : IntegraPOS.MasterPage
    {
        public frmUsuariosView()
        {
            InitializeComponent();
        }
		
        #region Eventos Controles

        private void frmUsuariosView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleTransacciones";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("NombreUsuario", typeof(string));
                vTabla.Columns.Add("TipoCedula", typeof(string));
                vTabla.Columns.Add("Cedula", typeof(string));
                vTabla.Columns.Add("Estado", typeof(string));
                vTabla.Columns.Add("Perfil", typeof(string));

                vTabla.Rows.Add("Administrador", "Nacional", "1-5268-1489", "Activo", "Administrador");
                vTabla.Rows.Add("Luis Alvarado", "Jurídica", "5-76425-7263", "Inactivo", "Vendedor");
                vTabla.Rows.Add("Verónica Fonseca", "Nacional", "2-4583-19", "Activo", "Vendedor");

                mgvUsuarios.DataSource = vTabla;

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
                frmUsuarioMant vFrmUsuarioMant = new frmUsuarioMant();
                vFrmUsuarioMant.Show();
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
                frmUsuarioMant vFrmUsuarioMant = new frmUsuarioMant();
                vFrmUsuarioMant.Show();
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

        private void mgvUsuarios_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmUsuarioMant vFrmUsuarioMant = new frmUsuarioMant();
                        vFrmUsuarioMant.Show();
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
