using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class E_Indicador
    {
        public int IdIndicador { get; set; }
        public String Indicador { get; set; }
        public int IdTipoValor { get; set; }
        public int IdMaxMin { get; set; }
        public int IdPerspectiva { get; set; }
        public bool Activo { get; set; }
    }
}
