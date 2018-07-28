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
    public class D_Menu
    {
        D_ConnectionBD connectionBD;
        SqlCommand cmd;

        //Consulta para crear los botones en el panel vertical de la interfaz Menu
        public List<E_BalancedScorecard> QueryCMI(string username)
        {
            List<E_BalancedScorecard> returnedlist = null;
            try
            {
                SqlDataReader datareader;
                connectionBD = new D_ConnectionBD();
                cmd = new SqlCommand("QueryCMI", connectionBD.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Username", username);
                cmd.CommandTimeout = 0;
                datareader = cmd.ExecuteReader();
                returnedlist = new List<E_BalancedScorecard>();
                while (datareader.Read())
                {
                    E_BalancedScorecard objBSC = new E_BalancedScorecard();
                    objBSC.IdBalanced_Scorecard = datareader.GetInt32(0);
                    objBSC.BSNombre = datareader.GetString(1);
                    objBSC.N_Empresa = datareader.GetString(2);
                    objBSC.Vision = datareader.GetString(3);
                    objBSC.Mision = datareader.GetString(4);
                    objBSC.Agno = datareader.GetDateTime(5);
                    objBSC.Active = datareader.GetBoolean(6);
                    returnedlist.Add(objBSC);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd.Connection = connectionBD.CloseConnection();
                cmd.Dispose();
            }
            return returnedlist;
        }

        //Consulta para construir la interfaz del Menu con la información de base de datos
        public E_BalancedScorecard Select_BSC_Menu(int idBalancedScorecard)
        {
            connectionBD = new D_ConnectionBD();
            cmd = new SqlCommand("QueryMenu", connectionBD.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@IdBalanced_Scorecard", idBalancedScorecard);
            cmd.CommandTimeout = 0;
            E_BalancedScorecard bsc;
            SqlDataReader reader;
            try
            {
                reader = cmd.ExecuteReader();
                bsc = new E_BalancedScorecard();
                if (reader.Read())
                {
                    bsc.IdBalanced_Scorecard = reader.GetInt32(0);
                    bsc.BSNombre = reader.GetString(1);
                    bsc.N_Empresa = reader.GetString(2);
                    bsc.Vision = reader.GetString(3);
                    bsc.Mision = reader.GetString(4);
                    bsc.Agno = reader.GetDateTime(5);
                    bsc.Active = reader.GetBoolean(6);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Connection = connectionBD.CloseConnection();
                cmd.Dispose();
            }
            return bsc;
        }

        //Función para insertar Cuadros de Mando Integral en la base de datos
        public bool InsertBSC(E_BalancedScorecard ObjBSC, int UserId)
        {
            connectionBD = new D_ConnectionBD();
            cmd = new SqlCommand("InsertCMI", connectionBD.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@BS_Nombre", ObjBSC.BSNombre);
            cmd.Parameters.AddWithValue("@N_Empresa", ObjBSC.N_Empresa);
            cmd.Parameters.AddWithValue("@Vision", ObjBSC.Vision);
            cmd.Parameters.AddWithValue("@Mision", ObjBSC.Mision);
            cmd.Parameters.AddWithValue("@Agno", ObjBSC.Agno);
            cmd.Parameters.AddWithValue("@Activo", ObjBSC.Active);
            cmd.Parameters.AddWithValue("@IdUsuario", UserId);

            try
            {
                return connectionBD.EIDB(cmd);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar los datos en la base de datos", ex);
            }

        }
    }
}
