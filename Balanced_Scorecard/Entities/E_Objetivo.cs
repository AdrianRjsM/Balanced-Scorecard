using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class E_Objetivo
    {
        public int IdObjetivo { get; set; }
        public string Objetivo { get; set; }
        public int IdPerspectiva { get; set; }
        public int IdIndicador { get; set; }
        public bool Activo { get; set; }
    }
}
