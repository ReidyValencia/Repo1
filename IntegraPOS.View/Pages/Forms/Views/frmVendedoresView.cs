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
    public partial class frmVendedoresView : IntegraPOS.MasterPage
    {
        public frmVendedoresView()
        {
            InitializeComponent();
        }

        private void frmVendedoresView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleTransacciones";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Nombre", typeof(string));
                vTabla.Columns.Add("Correo", typeof(string));
                vTabla.Columns.Add("TipoVendedor", typeof(string));
                vTabla.Columns.Add("Estado", typeof(string));

                vTabla.Rows.Add("Catalina Arias", "catalina@hotmail.com", "Vendedor", "Activo");
                vTabla.Rows.Add("Andrés Solís", "andres@hotmail.com", "Vendedor", "Activo");
                vTabla.Rows.Add("Kendra Arguedas", "karguedas@gmail.com", "Asistente", "Activo");

                mgvVendedores.DataSource = vTabla;

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
                frmVendedorMant vFrmVendedorMant = new frmVendedorMant();
                vFrmVendedorMant.Show();
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
                frmVendedorMant vFrmVendedorMant = new frmVendedorMant();
                vFrmVendedorMant.Show();
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

        private void mgvVendedores_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmVendedorMant vFrmVendedorMant = new frmVendedorMant();
                        vFrmVendedorMant.Show();
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
