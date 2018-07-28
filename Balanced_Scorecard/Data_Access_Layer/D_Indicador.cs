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
    public class D_Indicador
    {
        D_ConnectionBD connectionBD;
        SqlCommand cmd;

        public DataTable GetMaxMinIndicator()
        {
            connectionBD = new D_ConnectionBD();
            DataTable dt = new DataTable();
            string command = "select * from TipoMaxMin_Indicador";
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

        public DataTable GetValueIndicator()
        {
            connectionBD = new D_ConnectionBD();
            DataTable dt = new DataTable();
            string command = "select * from TipoValor_Indicador";
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

        public DataTable GetPerspectives(int IdBSC)
        {
            connectionBD = new D_ConnectionBD();
            DataTable dt = new DataTable();
            try
            {
                cmd = new SqlCommand("QueryPerspectives", connectionBD.OpenConnection());
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

        public bool InsertIndicator(E_Indicador Indicator)
        {
            connectionBD = new D_ConnectionBD();
            cmd = new SqlCommand("InsertIndicator", connectionBD.OpenConnection());
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Indicador", Indicator.Indicador);
            cmd.Parameters.AddWithValue("@IdTipoValor_Indicador", Indicator.IdTipoValor);
            cmd.Parameters.AddWithValue("@IdTipoMaxMin_Indicador", Indicator.IdMaxMin);
            cmd.Parameters.AddWithValue("@IdPerspectiva", Indicator.IdPerspectiva);
            cmd.Parameters.AddWithValue("@Activo", Indicator.Activo);

            try
            {
                return connectionBD.EIDB(cmd);
            }
            catch (Exception ex)
            {

                throw new Exception("Error al insertar los datos en la base de datos", ex);
            }

        }

        public List<E_IndicatorDg> QueryIndicatorsDg(int CMI)
        {
            List<E_IndicatorDg> returnedlist = null;
            try
            {
                SqlDataReader datareader;
                connectionBD = new D_ConnectionBD();
                cmd = new SqlCommand("QueryIndicators", connectionBD.OpenConnection());
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@IdBalanced_Scorecard", CMI);
                cmd.CommandTimeout = 0;
                datareader = cmd.ExecuteReader();
                returnedlist = new List<E_IndicatorDg>();
                while (datareader.Read())
                {
                    E_IndicatorDg objInDg = new E_IndicatorDg();
                    objInDg.IdIndicador = datareader.GetInt32(0);
                    objInDg.Perspectiva = datareader.GetString(1);
                    objInDg.Indicador = datareader.GetString(2);
                    objInDg.Valor = datareader.GetString(3);
                    objInDg.MaxMin = datareader.GetString(4);
                    objInDg.Activo = datareader.GetBoolean(5);
                    returnedlist.Add(objInDg);
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

        public void UpdateIndicator(E_Indicador e_Indicador)
        {
            connectionBD = new D_ConnectionBD();
            cmd = new SqlCommand("UpdateIndicator", connectionBD.OpenConnection());
            try
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@IdIndicador", e_Indicador.IdIndicador));
                cmd.Parameters.Add(new SqlParameter("@Indicador", e_Indicador.Indicador));
                cmd.Parameters.Add(new SqlParameter("@IdTipoValor", e_Indicador.IdTipoValor));
                cmd.Parameters.Add(new SqlParameter("@IdMaxMin", e_Indicador.IdMaxMin));
                cmd.Parameters.Add(new SqlParameter("@IdPerspectiva", e_Indicador.IdPerspectiva));
                cmd.Parameters.Add(new SqlParameter("@Activo", e_Indicador.Activo));
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
        public void DeleteIndicator(E_Indicador e_Indicador)
        {
            string command = "delete from Indicador where IdIndicador = @IdIndicador";
            try
            {
                connectionBD = new D_ConnectionBD();
                cmd = new SqlCommand(command, connectionBD.OpenConnection());
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@IdIndicador", e_Indicador.IdIndicador));
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
