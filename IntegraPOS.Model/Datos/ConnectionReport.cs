using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IntegraPOS.Model.Datos
{
    public class ConnectionReport
    {
        #region { Variables }

        private SqlConnection ps_conexion = null;
        private SqlCommand ps_command = null;
        private SqlTransaction ps_Transact;
        public readonly string DBConnection = ConfigurationManager.ConnectionStrings["Connection"].ConnectionString;

        #region { Method.Get-Set }

        public SqlCommand Ps_command
        {
            get { return ps_command; }
            set { ps_command = value; }
        }

        #endregion

        #endregion

        #region { Method.Public }

        public ConnectionReport()
        {
            ps_command = new SqlCommand();
        }

        public bool Conectar()
        {
            try
            {
                if (string.IsNullOrEmpty(DBConnection))return false;

                if (ps_conexion == null)
                {
                    ps_conexion = new SqlConnection
                    {
                        ConnectionString = DBConnection
                    };
                }

                ps_conexion.Open();
                if (ps_conexion.State == ConnectionState.Closed)ps_conexion.Open();

                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void Desconectar()
        {
            try { if (ps_conexion?.State == ConnectionState.Open) ps_conexion.Close(); }
            catch (Exception) { throw; }
        }


        public void BeginTransaction()
        {
            ps_Transact = ps_conexion.BeginTransaction();
        }

        public void Commit()
        {
            ps_Transact.Commit();
        }

        public void Rollback()
        {
            ps_Transact.Rollback();
        }

        public void CrearComando(string pe_sql)
        {
            ps_command.Connection = ps_conexion;
            ps_command.CommandType = CommandType.Text;
            ps_command.CommandText = pe_sql;
        }

        public void CrearComandoSP(string pe_sql)
        {
            ps_command.Connection = ps_conexion;
            ps_command.CommandType = CommandType.StoredProcedure;
            ps_command.CommandText = pe_sql;

        }

        public void ComandoSPParametros(object[] pe_Objects)
        {

            if ((pe_Objects.Any()) && ((pe_Objects.Count() % 2) == 0))
            {
                for (int i = 0; i < pe_Objects.Count(); i = i + 2)
                {
                    ps_command.Parameters.Add(new SqlParameter(pe_Objects[i].ToString(), pe_Objects[i + 1]));
                }
            }
        }

        public SqlDataReader CargarBD()
        {
            try { return ps_command.ExecuteReader(); }catch (Exception) { throw; }
        }

        public DataTable CargarBd()
        {
            try
            {
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(ps_command);
                DataTable datatable = new DataTable();
                sqlDataAdapter.Fill(datatable);
                return datatable;
            }
            catch (Exception) { throw; }
        }

        public XmlReader CargarBdXML()
        {
            try { return ps_command.ExecuteXmlReader(); }catch (Exception) { throw; }
        }

        public int TransacBD()
        {
            try { return this.ps_command.ExecuteNonQuery(); }catch (Exception) { throw; }
        }

        public void TransacBD_BT()
        {
            try
            {
                this.ps_command.Transaction = ps_Transact;
                this.ps_command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
