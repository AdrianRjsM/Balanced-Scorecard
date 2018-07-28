using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using System.Data;
using Entities;

namespace Business_Logic_Layer
{
    public class B_Objective
    {

        D_Objective objObjective;

        //ComboBox Indicadores de Objetivos
        public Task<DataTable> B_GetO_Indicators(int idbsc)
        {
            return Task.Run(() => {
                return new D_Objective().GetO_Indicators(idbsc);
            });
        }

        //Insertar datos en la tabla objetivo
        public bool B_CreateObjetive(E_Objetivo pObjObjetive)
        {
            if (String.IsNullOrEmpty(pObjObjetive.Objetivo)) throw new Exception("El campo de texto de objetivo está vacío, por favor intente de nuevo.");
            objObjective = new D_Objective();

            return objObjective.InsertO_Objetivo(pObjObjetive);
        }

        public Task<List<E_ObjectivesDg>> QueryToObjectiveDg(int CMI)
        {
            objObjective = new D_Objective();
            return Task.Run(() => {
                return objObjective.QueryObjectivesDg(CMI);
            });
        }

        public void B_UpdateObjective(E_Objetivo B_Objective)
        {
            if (String.IsNullOrEmpty(B_Objective.Objetivo)) throw new Exception("El campo de texto de objetivo está vacío, por favor intente de nuevo.");
            try
            {
                objObjective = new D_Objective();
                objObjective.UpdateObjective(B_Objective);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B_DeleteObjective(E_Objetivo e_Objetivo)
        {
            try
            {
                objObjective = new D_Objective();
                objObjective.DeleteObjective(e_Objetivo);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
