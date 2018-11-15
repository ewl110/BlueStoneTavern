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
        Spell[] Spellbook { get; set; }
    }

    public class Spell
    {
        string CastingTime { get; set; }
        CharacterClasses[] Classes { get; set; }
        string[] Components { get; set; }
        string Description { get; set; }
        string Duration { get; set; }
        string Name { get; set; }
        string Range { get; set; }
        string Type { get; set; } // Concentration or Ritual
        SchoolOfMagic School { get; set; }
    }
}
