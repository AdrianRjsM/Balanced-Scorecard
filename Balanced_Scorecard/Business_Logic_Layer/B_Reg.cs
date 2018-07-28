using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access_Layer;
using Entities;

namespace Business_Logic_Layer
{
    public class B_Reg
    {
        public bool ToRegister(int UserRoleId, String Username, String Password, String Name, String Surname1, String Surname2)
        {
            if (String.IsNullOrEmpty(Username)) throw new Exception("El campo de texto de nombre de usuario está vacío, por favor intente de nuevo.");
            if (String.IsNullOrEmpty(Password)) throw new Exception("El campo de texto de contraseña está vacío, por favor intente de nuevo.");
            if (String.IsNullOrEmpty(Name)) throw new Exception("El campo de texto de nombre está vacío, por favor intente de nuevo.");
            if (String.IsNullOrEmpty(Surname1)) throw new Exception("El campo de texto de primer apellido está vacío, por favor intente de nuevo.");
            if (String.IsNullOrEmpty(Surname2)) throw new Exception("El campo de texto de segundo apellido está vacío, por favor intente de nuevo.");

            E_Register register = new E_Register()
            {
                UserRoleId = UserRoleId,
                Username = Username,
                Password = Password,
                Name = Name,
                Surname1 = Surname1,
                Surname2 = Surname2
            };
            bool RegisterResult = new D_Registry().InsertUser(register);
            if (RegisterResult)
            {
                return true;
            }
            return false;
        }
    }
}
