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
    public class D_Objective
    {
        D_ConnectionBD connectionBD;
        SqlCommand cmd;

        public List<E_ObjectivesDg> QueryObjectivesDg(int CMI)
        {
            List<E_ObjectivesDg> returnedlist = null;
            try
            {
                SqlDataReader datareader;
                connectionBD = new D_ConnectionBD();
                cmd = new SqlCommand("QueryObjectives", connectionBD.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdBalanced_Scorecard", CMI);
                cmd.CommandTimeout = 0;
                datareader = cmd.ExecuteReader();
                returnedlist = new List<E_ObjectivesDg>();
                while (datareader.Read())
                {
                    E_ObjectivesDg objObDg = new E_ObjectivesDg();
                    objObDg.IdObjective = datareader.GetInt32(0);
                    objObDg.Perspective = datareader.GetString(1);
                    objObDg.Objetive = datareader.GetString(2);
                    objObDg.Indicator = datareader.GetString(3);
                    objObDg.Value = datareader.GetString(4);
                    objObDg.MaxMin = datareader.GetString(5);
                    objObDg.Active = datareader.GetBoolean(6);
                    returnedlist.Add(objObDg);
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

        //Insert en la tabla Objetivo
        public DataTable GetO_Indicators(int IdBSC)
        {
            connectionBD = new D_ConnectionBD();
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("QueryIndicators", connectionBD.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
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
        public bool InsertO_Objetivo(E_Objetivo ObjObjetive)
        {
            connectionBD = new D_ConnectionBD();
            string command = "insert into Objetivo (Objetivo, IdPerspectiva, IdIndicador, Activo) values (@Objetivo, @IdPerspectiva, @IdIndicador, @Activo)";
            cmd = new SqlCommand(command, connectionBD.OpenConnection());
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Objetivo", ObjObjetive.Objetivo);
            cmd.Parameters.AddWithValue("@IdPerspectiva", ObjObjetive.IdPerspectiva);
            cmd.Parameters.AddWithValue("@IdIndicador", ObjObjetive.IdIndicador);
            cmd.Parameters.AddWithValue("@Activo", ObjObjetive.Activo);

            try
            {
                return connectionBD.EIDB(cmd);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar los datos en la base de datos", ex);
            }

        }

        public void UpdateObjective(E_Objetivo objective)
        {
            connectionBD = new D_ConnectionBD();
            cmd = new SqlCommand("UpdateObjective", connectionBD.OpenConnection());
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdObjetivo", objective.IdObjetivo));
                cmd.Parameters.Add(new SqlParameter("@Objetivo", objective.Objetivo));
                cmd.Parameters.Add(new SqlParameter("@IdPerspectiva", objective.IdPerspectiva));
                cmd.Parameters.Add(new SqlParameter("@IdIndicador", objective.IdIndicador));
                cmd.Parameters.Add(new SqlParameter("@Activo", objective.Activo));
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

        public void DeleteObjective(E_Objetivo objetivo)
        {
            string command = "delete from Objetivo where IdObjetivo = @IdObjetivo";
            try
            {
                connectionBD = new D_ConnectionBD();
                cmd = new SqlCommand(command, connectionBD.OpenConnection());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@IdObjetivo", objetivo.IdObjetivo));
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
