using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Data_Access_Layer;
using Entities;

namespace Business_Logic_Layer
{
    public class B_Metrica
    {
        D_Metrica objMetrica;
        public Task<DataTable> B_GetObjectives(int IdBSC)
        {
            return Task.Run(() => {
                return new D_Metrica().M_GetObjectives(IdBSC);
            });
        }

        public bool B_CreateMetrica(E_Metrica pObjMetrica)
        {
            if (String.IsNullOrEmpty(pObjMetrica.Metrica)) throw new Exception("El campo de texto de metrica está vacío, por favor intente de nuevo.");
            objMetrica = new D_Metrica();

            return objMetrica.InsertM_Metrica(pObjMetrica);
        }

        public Task<List<E_Metrica>> QueryToMetricaDg(int IdObjective)
        {
            objMetrica = new D_Metrica();
            return Task.Run(() => {
                return objMetrica.QueryMetricasDg(IdObjective);
            });
        }

        public void B_UpdateMetrica(E_Metrica B_Metrica)
        {
            if (String.IsNullOrEmpty(B_Metrica.Metrica)) throw new Exception("El campo de texto de métrica está vacío, por favor intente de nuevo.");
            try
            {
                objMetrica = new D_Metrica();
                objMetrica.UpdateMetrica(B_Metrica);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B_DeleteMetrica(E_Metrica e_Metrica)
        {
            try
            {
                objMetrica = new D_Metrica();
                objMetrica.DeleteMetrica(e_Metrica);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
