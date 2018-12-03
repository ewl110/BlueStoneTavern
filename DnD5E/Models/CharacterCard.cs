using DnD5E.Enums;
using System;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class CharacterCard
    {
        public AbilityScoresModel AbilityScores { get; set; }
        public List<ActionModel> ActionAttack { get; set; }
        public List<ActionModel> ActionBonus { get; set; }
        public List<ActionModel> ActionOption { get; set; }
        public List<ActionModel> ActionReaction { get; set; }
        public int Age { get; set; }
        public int Attack { get; set; }
        public CharacterBackgroundModel Background { get; set; }
        public Dictionary<string, CharacterClassModel> Class { get; set; } // Switch to dictionary with string key to make adding class specific features easier?
        public CharacterClassModel ClassPrimary { get; set; }
        public string ClassDescription { get; set; }
        public List<FeaturesModel> ClassFeatures { get; set; }
        public string Equipment { get; set; }
        public FactionCard Faction { get; set; }
        public int HitDice { get; set; }
        public HitPointsModel HitPoints { get; set; }
        public Guid Id { get; set; }
        public List<string> Immunity { get; set; }
        public List<string> Languages { get; set; }
        public int PassivePerception { get; set; }
        public int ProficiencyBonus { get; set; }
        public List<string> ProficiencyArmor { get; set; }
        public List<string> ProficiencySavingThrows { get; set; }
        public List<string> ProficiencySkills { get; set; }
        public List<string> ProficiencyTools { get; set; }
        public List<string> ProficiencyWeapons { get; set; }
        public string Race { get; set; }
        public List<FeaturesModel> RaceTraits { get; set; }
        public List<string> Resistance { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }
        public int TotalLevel { get; set; }
    }

    public class CharacterBackgroundModel : BaseCard
    {
        public string Bond { get; set; }
        public CharacterFeatureModel Feature { get; set; }
        public string Flaw { get; set; }
        public string Ideal { get; set; }
        public string Personality { get; set; }
    }

    public class CharacterClassModel : BaseCard
    {
        public List<FeaturesModel> Features { get; set; }
        public int Level { get; set; }
        public string Variant { get; set; }
    }

    public class CharacterFeatureModel
    {
        public List<string> Description { get; set; }
        public string Name { get; set; }
    }
}
