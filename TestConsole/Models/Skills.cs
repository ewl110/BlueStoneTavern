using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Models
{
    public class Skills
    {
        Skill[] List { get; set; }
    }

    public class Skill : Base {
        public string Ability { get; set; }
        public bool IsProficient { get; set; }
    }
}
