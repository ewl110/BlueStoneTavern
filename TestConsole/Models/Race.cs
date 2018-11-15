using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestConsole.Models
{
    public class Race : Base
    {
        public int Age { get; set; }
        public string Alignment { get; set; }
        public string Asi { get; set; }
        public List<string> Feats { get; set; }
        public List<string> Languages { get; set; }
        public string Size { get; set; }
        public List<string> Skills { get; set; }
        public int Speed { get; set; }
        public List<string> Spells { get; set; }
    }
}
