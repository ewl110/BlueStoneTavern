using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class BaseClass : Base
    {
        public Proficiencies[] Equipment { get; set; }
        //public bool HasRitualCasting { get; set; }
        public int HitDice { get; set; }
        public bool IsCaster { get; set; }
        public Languages[] Languages { get; set; }
        public Level[] Levels { get; set; }
        public Proficiencies[] Proficiencies { get; set; }
        public Abilities[] SavingThrows { get; set; }
        public Skill[] Skills { get; set; }
        //public Spell[] Spellbook { get; set; }
        //public string[] Features { get; set; }
        //public int ProficiencyBonus { get; set; }
    }

    public class Level
    {
        public string[] Features { get; set; }
        public int ProficiencyBonus { get; set; }
        //public SpellSlots SpellSlots { get; set; }
    }

    public class Proficiencies
    {
        public ArmorTypes[] Armor { get; set; }
        public ToolTypes[] Tools { get; set; }
        public WeaponTypes[] Weapons { get; set; }
    }
}
