using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using Entities;

namespace Business_Logic_Layer
{
    public class B_Menu
    {
        D_Menu objMenu;

        public List<E_BalancedScorecard> BalancedScorecards(string username)
        {
            try
            {
                objMenu = new D_Menu();
                return objMenu.QueryCMI(username);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool CreateBSC(E_BalancedScorecard ObjBSC)
        {
            objMenu = new D_Menu();
            if (String.IsNullOrEmpty(ObjBSC.BSNombre)) throw new Exception("El campo de texto de nombre de cuadro de mando integral está vacío, por favor intente de nuevo.");
            if (String.IsNullOrEmpty(ObjBSC.N_Empresa)) throw new Exception("El campo de texto de nombre de la empresa está vacío, por favor intente de nuevo.");
            if (String.IsNullOrEmpty(ObjBSC.Vision)) throw new Exception("El campo de texto de visión de la empresa está vacío, por favor intente de nuevo.");
            if (String.IsNullOrEmpty(ObjBSC.Mision)) throw new Exception("El campo de texto de misión de la empresa está vacío, por favor intente de nuevo.");

            return objMenu.InsertBSC(ObjBSC, Credentials.CurUser.UserId);
        }

        public E_BalancedScorecard B_BSC_Menu(int idBalancedScorecard)
        {
            objMenu = new D_Menu();
            return objMenu.Select_BSC_Menu(idBalancedScorecard);
        }
    }
}
