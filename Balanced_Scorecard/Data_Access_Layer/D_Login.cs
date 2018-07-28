using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entities;

namespace Data_Access_Layer
{
    public class D_Login
    {
        public D_ConnectionBD connection;

        public DataTable LogQuery(E_User ObjUser)
        {
            DataTable table = new DataTable();
            try
            {
                connection = new D_ConnectionBD();
                SqlCommand command = new SqlCommand("QueryLog", connection.OpenConnection());
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Usr", ObjUser.Username);
                command.Parameters.AddWithValue("@Pass", ObjUser.Password);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(table);
                command.Connection = connection.CloseConnection();
            }
            catch (Exception ex)
            {

                throw new Exception("No se pudo solicitar los datos para el inicio de sesión", ex);
            }
            
            return table;
        }
    }
}
