using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class E_BalancedScorecard
    {
        public int IdBalanced_Scorecard { get; set; }
        public String BSNombre { get; set; }
        public String N_Empresa { get; set; }
        public String Vision { get; set; }
        public String Mision { get; set; }
        public DateTime Agno { get; set; }
        public bool Active { get; set; }
    }
}
