using DnD5E.Enums;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class ClassCard : BaseCard
    {
        public AbilityScoresModel AbilityScores { get; set; }
        public List<ActionModel> Actions { get; set; }
        //public ClassEnum? BaseClass { get; set; }
        public List<EquipmentModel> Equipment { get; set; }
        public int HitDice { get; set; }
        public Dictionary<int, LevelModel> Levels { get; set; }
        //public ProficiencyModel Proficiencies { get; set; }
    }

    public class LevelModel : BaseCard
    {
        public int? BardicInspiration { get; set; }
        public int? CombatDice { get; set; }
        public List<FeaturesModel> Features { get; set; }
        public int? KiPoints { get; set; }
        public ProficiencyModel Proficiencies { get; set; }
        public int? Rage { get; set; }
        public int? RageDamage { get; set; }
        public bool SetVariant { get; set; }
        public int? SneakAttack { get; set; }
        public SpellsModel Spells { get; set; }
        public SpellSlotsModel SpellSlots { get; set; }
        public Dictionary<ClassEnum, LevelModel> Variants { get; set; }
    }

    public class SpellsModel
    {
        public string[] Cantrips { get; set; }
        public string[] _1 { get; set; }
        public string[] _2 { get; set; }
        public string[] _3 { get; set; }
        public string[] _4 { get; set; }
        public string[] _5 { get; set; }
        public string[] _6 { get; set; }
        public string[] _7 { get; set; }
        public string[] _8 { get; set; }
        public string[] _9 { get; set; }
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
