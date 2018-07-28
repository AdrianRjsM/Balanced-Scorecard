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
    public class D_CObjetives
    {
        D_ConnectionBD connectionBD;
        SqlCommand cmd;

        public DataTable GetMonths()
        {
            connectionBD = new D_ConnectionBD();
            DataTable dt = new DataTable();
            string command = "select * from Mes";
            try
            {
                cmd = new SqlCommand(command, connectionBD.OpenConnection());
                cmd.CommandType = CommandType.Text;

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

        public List<E_ObjectiveControl> Query_ControlO_Dg(int IdObjective)
        {
            List<E_ObjectiveControl> returnedlist = null;
            try
            {
                SqlDataReader datareader;
                connectionBD = new D_ConnectionBD();
                cmd = new SqlCommand("QueryControlOb", connectionBD.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdObjetivo", IdObjective);
                cmd.CommandTimeout = 0;
                datareader = cmd.ExecuteReader();
                returnedlist = new List<E_ObjectiveControl>();
                while (datareader.Read())
                {
                    E_ObjectiveControl objOCDg = new E_ObjectiveControl();
                    objOCDg.IdValorObjetivo = datareader.GetInt32(0);
                    objOCDg.Perspectiva = datareader.GetString(1);
                    objOCDg.Objetivo = datareader.GetString(2);
                    objOCDg.Mes = datareader.GetString(3);
                    objOCDg.IdObjetivo = datareader.GetInt32(4);
                    objOCDg.Meta = datareader.GetString(5);
                    objOCDg.Alcanzado = datareader.GetString(6);
                    objOCDg.IdMes = datareader.GetInt32(7);
                    objOCDg.Valor = datareader.GetString(8);
                    objOCDg.TipoDato = datareader.GetString(9);
                    objOCDg.MaxMin = datareader.GetString(10);
                    objOCDg.Indicador = datareader.GetString(11);
                    returnedlist.Add(objOCDg);
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

        public bool InsertControlObj(E_ObjectiveControl objectiveControl)
        {
            connectionBD = new D_ConnectionBD();
            cmd = new SqlCommand("InsertValorObjetivo", connectionBD.OpenConnection());
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ValorObjetivo", objectiveControl.Meta));
                cmd.Parameters.Add(new SqlParameter("@ValorReal", objectiveControl.Alcanzado));
                cmd.Parameters.Add(new SqlParameter("@IdObjetivo", objectiveControl.IdObjetivo)); 
                cmd.Parameters.Add(new SqlParameter("@IdMes", objectiveControl.IdMes));
                return connectionBD.EIDB(cmd);
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

        public void UpdateControlObj(E_ObjectiveControl OControl)
        {
            connectionBD = new D_ConnectionBD();
            cmd = new SqlCommand("UpdateControlObj", connectionBD.OpenConnection());
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdValorObjetivo", OControl.IdValorObjetivo));
                cmd.Parameters.Add(new SqlParameter("@ValorObjetivo", OControl.Meta));
                cmd.Parameters.Add(new SqlParameter("@ValorReal", OControl.Alcanzado));
                cmd.Parameters.Add(new SqlParameter("@IdObjetivo", OControl.IdObjetivo));
                cmd.Parameters.Add(new SqlParameter("@IdMes", OControl.IdMes));
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
