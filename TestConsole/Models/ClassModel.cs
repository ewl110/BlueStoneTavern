using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class ClassModel : Base
    {
        //public Proficiencies[] Equipment { get; set; } Add directly to character model
        //public bool HasRitualCasting { get; set; } Spellcasters only
        public int HitDice { get; set; }
        public bool IsCaster { get; set; }
        public LanguagesEnum[] Languages { get; set; }
        public ClassesEnum? ParentClass { get; set; }
        public Proficiencies[] Proficiencies { get; set; }
        public AbilitiesEnum[] SavingThrows { get; set; }
        public Skill[] Skills { get; set; }
        //public Spell[] Spellbook { get; set; } spellcasters only
    }

    public class Level
    {
        public string[] Features { get; set; }
        public int ProficiencyBonus { get; set; }
    }

    public class Proficiencies
    {
        public ArmorTypesEnum[] Armor { get; set; }
        public ToolTypesEnum[] Tools { get; set; }
        public WeaponTypesEnum[] Weapons { get; set; }
    }
}
