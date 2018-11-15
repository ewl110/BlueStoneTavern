using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Models.Classes
{
    //public class Barbarian : BaseClass
    //{
    //    public new BarbarianLevel Levels { get; set; }
    //}

    public class Barbarian : BaseClass
    {
        public BarbarianLevels[] Levels { get; set; }
    }

    public class BarbarianLevels : Level
    {
        //public string[] Features { get; set; }
        public int RageDamage { get; set; }
        public int Rages { get; set; }
    }
}
