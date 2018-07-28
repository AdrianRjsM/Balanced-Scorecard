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
    public class B_Indicador
    {
        D_Indicador objIndicador;

        public Task<DataTable> B_GetMaxMinIndicator()
        {
            return Task.Run(() => {
                return new D_Indicador().GetMaxMinIndicator();
            });
        }

        public Task<DataTable> B_GetValueIndicator()
        {
            return Task.Run(() => {
                return new D_Indicador().GetValueIndicator();
            });
        }

        public Task<DataTable> B_GetPerspective(int IdBSC)
        {
            return Task.Run(() => {
                return new D_Indicador().GetPerspectives(IdBSC);
            });
        }

        public bool CreateIndicator(E_Indicador indicator)
        {
            objIndicador = new D_Indicador();
            if (String.IsNullOrEmpty(indicator.Indicador)) throw new Exception("El campo de texto de indicador está vacío, por favor intente de nuevo.");

            return objIndicador.InsertIndicator(indicator);
        }

        public Task<List<E_IndicatorDg>> QueryToDg(int CMI)
        {
            objIndicador = new D_Indicador();
            return Task.Run(() => {
                return objIndicador.QueryIndicatorsDg(CMI);
            });
        }

        public void B_UpdateIndicator(E_Indicador B_Indicator)
        {
            if (String.IsNullOrEmpty(B_Indicator.Indicador)) throw new Exception("El campo de texto de indicador está vacío, por favor intente de nuevo.");
            try
            {
                objIndicador = new D_Indicador();
                objIndicador.UpdateIndicator(B_Indicator);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void B_DeleteIndicator(E_Indicador B_Indicator)
        {
            try
            {
                objIndicador = new D_Indicador();
                objIndicador.DeleteIndicator(B_Indicator);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
