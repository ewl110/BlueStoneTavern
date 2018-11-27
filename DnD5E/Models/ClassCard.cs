using DnD5E.Enums;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class ClassCard : BaseCard
    {
        public ClassEnum? BaseClass { get; set; }
        public int HitDice { get; set; }
        public Dictionary<int, LevelModel> Levels { get; set; }
    }

    public class LevelModel
    {
        public string[] Features { get; set; }
        public int ProficiencyBonus { get; set; }
        public ProficiencyModel Proficiencies { get; set; }
        public SpellSlotsModel SpellSlots { get; set; }
    }

    public class SpellSlotsModel
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
