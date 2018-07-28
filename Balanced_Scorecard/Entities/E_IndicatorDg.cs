using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class E_IndicatorDg
    {
        public int IdIndicador { get; set; }
        public string Perspectiva { get; set; }
        public string Indicador { get; set; }
        public string Valor { get; set; }
        public string MaxMin { get; set; }
        public bool Activo { get; set; }
    }
}
