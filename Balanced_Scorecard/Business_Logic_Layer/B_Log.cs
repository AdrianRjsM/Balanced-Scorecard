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
    public class B_Log
    {
        D_Login ObjLogin;

        public DataTable Business_Log(E_User ObjUsr)
        {
            ObjLogin = new D_Login();
            return ObjLogin.LogQuery(ObjUsr);
        }

        public static void SaveCredentials(int UserId, int UserRoleId, String Username, String Name, String Surname1, String Surname2)
        {
            Credentials.CurUser.UserId = UserId;
            Credentials.CurUser.UserRoleId = UserRoleId;
            Credentials.CurUser.Username = Username;
            Credentials.CurUser.Name = Name;
            Credentials.CurUser.Surname1 = Surname1;
            Credentials.CurUser.Surname2 = Surname2;
        }

    }
}
