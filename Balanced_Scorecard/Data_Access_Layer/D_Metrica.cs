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
    public class D_Metrica
    {
        D_ConnectionBD connectionBD;
        SqlCommand cmd;

        public DataTable M_GetObjectives(int IdBSC)
        {
            connectionBD = new D_ConnectionBD();
            DataTable dt = new DataTable();
            String cadena = "select O.IdObjetivo, O.Objetivo" +
                            " from Objetivo O "+
                            "join Perspectiva P on P.IdPerspectiva = O.IdPerspectiva where P.IdBalanced_Scorecard = @IdBalanced_Scorecard";
            try
            {
                cmd = new SqlCommand(cadena, connectionBD.OpenConnection());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@IdBalanced_Scorecard", IdBSC);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

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
            return dt;
        }

        public bool InsertM_Metrica(E_Metrica ObjMetrica)
        {
            connectionBD = new D_ConnectionBD();
            string command = "insert into Metrica (Metrica, IdObjetivo) values (@Metrica, @IdObjetivo)";
            cmd = new SqlCommand(command, connectionBD.OpenConnection());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Metrica", ObjMetrica.Metrica);
            cmd.Parameters.AddWithValue("@IdObjetivo", ObjMetrica.IdObjective);

            try
            {
                return connectionBD.EIDB(cmd);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar los datos en la base de datos", ex);
            }

        }

        public List<E_Metrica> QueryMetricasDg(int IdObjective)
        {
            List<E_Metrica> returnedlist = null;
            try
            {
                SqlDataReader datareader;
                connectionBD = new D_ConnectionBD();
                cmd = new SqlCommand("QueryMetricas", connectionBD.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdObjetivo", IdObjective);
                cmd.CommandTimeout = 0;
                datareader = cmd.ExecuteReader();
                returnedlist = new List<E_Metrica>();
                while (datareader.Read())
                {
                    E_Metrica objMeDg = new E_Metrica();
                    objMeDg.IdObjective = datareader.GetInt32(0);
                    objMeDg.Perspective = datareader.GetString(1);
                    objMeDg.Objective = datareader.GetString(2);
                    objMeDg.IdMetrica = datareader.GetInt32(3);
                    objMeDg.Metrica = datareader.GetString(4);
                    returnedlist.Add(objMeDg);
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

        public void UpdateMetrica(E_Metrica metrica)
        {
            connectionBD = new D_ConnectionBD();
            cmd = new SqlCommand("UpdateMetrica", connectionBD.OpenConnection());
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdMetrica", metrica.IdMetrica));
                cmd.Parameters.Add(new SqlParameter("@Metrica", metrica.Metrica));
                cmd.Parameters.Add(new SqlParameter("@IdObjetivo", metrica.IdObjective));
                cmd.CommandTimeout = 0;
                cmd.ExecuteNonQuery();

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
        }

        public void DeleteMetrica(E_Metrica metrica)
        {
            string command = "delete from Metrica where IdMetrica = @IdMetrica";
            try
            {
                connectionBD = new D_ConnectionBD();
                cmd = new SqlCommand(command, connectionBD.OpenConnection());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@IdMetrica", metrica.IdMetrica));
                cmd.CommandTimeout = 0;
                cmd.ExecuteNonQuery();

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
        }
    }
}
