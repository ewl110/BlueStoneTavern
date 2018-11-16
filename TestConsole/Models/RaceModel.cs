using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class RaceModel : Base
    {
        public AbilityScoresModel AbilityScores { get; set; }
        public int Age { get; set; }
        public string Alignment { get; set; }
        public string Asi { get; set; }
        public List<string> Feats { get; set; }
        public bool HasDarkvision { get; set; }
        public List<string> Languages { get; set; }
        public SizesEnum Size { get; set; }
        public List<string> Skills { get; set; }
        public int Speed { get; set; }
        public List<string> Spells { get; set; }
    }

    public class AbilityScoresModel
    {
        public int Cha { get; set; }
        public int Con { get; set; }
        public int Dex { get; set; }
        public int Int { get; set; }
        public int Str { get; set; }
        public int Wis { get; set; }
    }
}
