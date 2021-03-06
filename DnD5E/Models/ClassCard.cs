﻿using DnD5E.Enums;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class ClassCard : BaseCard
    {
        public AbilityScoresModel AbilityScores { get; set; }
        public List<ActionModel> Actions { get; set; }
        public AbilitiesEnum[] ASI { get; set; }
        //public ClassEnum? BaseClass { get; set; }
        public List<EquipmentModel> Equipment { get; set; }
        public int HitDice { get; set; }
        public Dictionary<int, LevelModel> Levels { get; set; }
        //public ProficiencyModel Proficiencies { get; set; }
    }

    public class LevelModel : BaseCard
    {
        public int BardicInspiration { get; set; } = 0;
        public int CombatDice { get; set; } = 0;
        public List<FeaturesModel> Features { get; set; }
        public List<DamageTypesEnum> Immunity { get; set; }
        public int KiPoints { get; set; } = 0;
        public ProficiencyModel Proficiencies { get; set; }
        public int Rage { get; set; } = 0;
        public int RageDamage { get; set; } = 0;
        public List<DamageTypesEnum> Resistance { get; set;}
        public bool SetVariant { get; set; }
        public int SneakAttack { get; set; } = 0;
        public SpellsModel Spells { get; set; }
        public SpellSlotsModel SpellSlots { get; set; }
        public Dictionary<ClassEnum, LevelModel> Variants { get; set; }
    }

    public class SpellsModel
    {
        public List<SpellsEnum> Cantrips { get; set; }
        public List<SpellsEnum> _1 { get; set; }
        public List<SpellsEnum> _2 { get; set; }
        public List<SpellsEnum> _3 { get; set; }
        public List<SpellsEnum> _4 { get; set; }
        public List<SpellsEnum> _5 { get; set; }
        public List<SpellsEnum> _6 { get; set; }
        public List<SpellsEnum> _7 { get; set; }
        public List<SpellsEnum> _8 { get; set; }
        public List<SpellsEnum> _9 { get; set; }
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
