using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class E_User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int UserRoleId { get; set; }
        public int PersonId { get; set; }
        public bool Active { get; set; }

    }
}
