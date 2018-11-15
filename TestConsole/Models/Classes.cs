using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class Class : Base
    {
        public Class[] Archetypes { get; set; }
        public Proficiencies[] Equipment { get; set; }
        public bool HasRitualCasting { get; set; }
        public int HitDice { get; set; }
        public bool IsCaster { get; set; }
        public Languages[] Languages { get; set; }
        //public Level[] Levels { get; set; }
        public Proficiencies[] Proficiencies { get; set; }
        public Abilities[] SavingThrows { get; set; }
        public Skill[] Skills { get; set; }
        public Spell[] Spellbook { get; set; }
    }

    //public class Level
    //{
    //    public string[] Features { get; set; }
    //    public int Lvl { get; set; }
    //    public int ProficiencyBonus { get; set; }
    //    public Skills[] Skills { get; set; }
    //    public SpellSlots SpellSlots { get; set; }
    //}

    //public class Proficiencies
    //{
    //    public ArmorTypes[] Armor { get; set; }
    //    public ToolTypes[] Tools { get; set; }
    //    public WeaponTypes[] Weapons { get; set; }
    //}

    public class SpellSlots
    {
        public int Cantrips { get; set; }
        public int _1 { get; set; }
        public int _2 { get; set; }
        public int _3 { get; set; }
        public int _4 { get; set; }
        public int _5 { get; set; }
        public int _6 { get; set; }
        public int _7 { get; set; }
        public int _8 { get; set; }
        public int _9 { get; set; }
    }
}
