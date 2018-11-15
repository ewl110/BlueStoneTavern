using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class Spells
    {
        public Spell[] List { get; set; }
    }

    public class Spell : Base
    {
        public string CastingTime { get; set; }
        public CharacterClasses[] Classes { get; set; }
        public string[] Components { get; set; }
        public string Duration { get; set; }
        public int Level { get; set; }
        public string Range { get; set; }
        public string Type { get; set; } // Concentration or Ritual
        public SchoolsOfMagic School { get; set; }
    }
}
