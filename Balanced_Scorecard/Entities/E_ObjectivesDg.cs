using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class E_ObjectivesDg
    {
        public int IdObjective { get; set; }
        public string Perspective { get; set; }
        public string Objetive { get; set; }
        public string Indicator { get; set; }
        public string Value { get; set; }
        public string MaxMin { get; set; }
        public bool Active { get; set; }
    }
}
