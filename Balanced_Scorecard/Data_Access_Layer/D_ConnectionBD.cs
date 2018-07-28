using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class D_ConnectionBD
    {
        private string cadena = "Server=LAPTOP-S1R3KM8P; DataBase=Project; Integrated Security=true";
        private SqlConnection connection;

        public SqlConnection OpenConnection()
        {
            try
            {
                connection = new SqlConnection(cadena);

                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return connection;
        }


        public SqlConnection CloseConnection()
        {
            try
            {
                connection = new SqlConnection(cadena);

                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return connection;
        }

        public bool BoolOpen()
        {
            try
            {
                connection = new SqlConnection(cadena);
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede abrir la conexión con la base de datos", ex);
            }
        }

        public bool BoolClose()
        {
            try
            {
                connection = new SqlConnection(cadena);
                if (connection.State != ConnectionState.Closed)
                {
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("No se puede cerrar la conexión con la base de datos", ex);
            }
        }
        internal bool EIDB(SqlCommand SQLC)
        {

            try
            {
                if (BoolOpen())
                {
                    SqlTransaction transaction = connection.BeginTransaction();
                    SQLC.Connection = connection;
                    SQLC.Transaction = transaction;
                    SQLC.ExecuteNonQuery();
                    transaction.Commit();
                    connection.Close();
                    return true;
                }
                connection.Close();
                return false;
            }
            catch (Exception ex)
            {
                SQLC.Transaction.Rollback();
                connection.Close();
                throw ex;
            }
        }

    }
}
