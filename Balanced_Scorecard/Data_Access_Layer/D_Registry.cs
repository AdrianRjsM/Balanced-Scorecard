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
    public class D_Registry
    {
        public D_ConnectionBD connection;
        

        public bool InsertUser(E_Register ObjSign)
        {
            connection = new D_ConnectionBD();

            SqlCommand command = new SqlCommand("InsertUser", connection.OpenConnection());
            command.CommandType = CommandType.StoredProcedure;

            command.Parameters.AddWithValue("@NombreUsuario", ObjSign.Username);
            command.Parameters.AddWithValue("@Contrasegna", ObjSign.Password);
            command.Parameters.AddWithValue("@IdTipo_Usuario", ObjSign.UserRoleId);
            command.Parameters.AddWithValue("@Activo", 1);
            command.Parameters.AddWithValue("@Nombre", ObjSign.Name);
            command.Parameters.AddWithValue("@Apellido1", ObjSign.Surname1);
            command.Parameters.AddWithValue("@Apellido2", ObjSign.Surname2);

            try
            {
                return connection.EIDB(command);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

    }
}
