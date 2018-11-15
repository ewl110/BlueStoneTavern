using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Models
{
    public class Abilities
    {
        Ability[] AbilityList { get; set; }
    }

    public class Ability : Base
    {
        public int AbilityScore { get; set; }
        public bool HasSavingThrow { get; set; }
    }
}
