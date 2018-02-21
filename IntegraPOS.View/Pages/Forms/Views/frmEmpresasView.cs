using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace IntegraPOS.Pages.Forms
{
    public partial class frmEmpresasView : IntegraPOS.MasterPage
    {
        public frmEmpresasView()
        {
            InitializeComponent();
        }

	    #region Eventos Controles

        private void frmEmpresasView_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable vTabla = new DataTable();

                vTabla.TableName = "DetalleTransacciones";
                vTabla.Rows.Clear();

                vTabla.Columns.Add("Empresa", typeof(string));
                vTabla.Columns.Add("Cedula", typeof(string));
                vTabla.Columns.Add("Direccion", typeof(string));
                vTabla.Columns.Add("PaginaWeb", typeof(string));

                vTabla.Rows.Add("Clínica bíblica", "50698523", "100 Norte, Parque Central, San Jose", "www.clinicabiblica@hotmail.com");
                vTabla.Rows.Add("Dos Pinos", "506872145", "Coyol, Alajuela", "www.dospinos@hotmail.com");

                mgvEmpresas.DataSource = vTabla;

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
                frmEmpresaMant vfrmEmpresaMant = new frmEmpresaMant();
                vfrmEmpresaMant.Show();
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
                frmEmpresaMant vfrmEmpresaMant = new frmEmpresaMant();
                vfrmEmpresaMant.Show();
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

        private void mgvEmpresas_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        frmEmpresaMant vfrmEmpresaMant = new frmEmpresaMant();
                        vfrmEmpresaMant.Show();
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
