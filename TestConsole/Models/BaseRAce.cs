using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class BaseRace : Base
    {
        public int Age { get; set; }
        public Alignments Alignment { get; set; }
        public string Asi { get; set; }
        public List<string> Feats { get; set; }
        public List<string> Features { get; set; }
        public List<string> Languages { get; set; }
        public Sizes Size { get; set; }
        public List<string> Skills { get; set; }
        public int Speed { get; set; }
        public List<string> Spells { get; set; }
    }
}