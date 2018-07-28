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
    public class B_CObjectives
    {
        D_CObjetives objCObjectives;
        public Task<DataTable> B_GetMonths()
        {
            return Task.Run(() => {
                return new D_CObjetives().GetMonths();
            });
        }

        public Task<List<E_ObjectiveControl>> QueryToOCDg(int Idobjective)
        {
            objCObjectives = new D_CObjetives();
            return Task.Run(() => {
                return objCObjectives.Query_ControlO_Dg(Idobjective);
            });
        }

        public bool B_CreateCObjective(E_ObjectiveControl OControl)
        {
            if (String.IsNullOrEmpty(OControl.Meta)) throw new Exception("El campo de texto de valor objetivo está vacío, por favor intente de nuevo.");
            objCObjectives = new D_CObjetives();

            return objCObjectives.InsertControlObj(OControl);
        }

        public void B_UpdateOControl(E_ObjectiveControl objectiveControl)
        {
            if (String.IsNullOrEmpty(objectiveControl.Meta)) throw new Exception("El campo de texto de valor objetivo está vacío, por favor intente de nuevo.");
            try
            {
                objCObjectives = new D_CObjetives();
                objCObjectives.UpdateControlObj(objectiveControl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
