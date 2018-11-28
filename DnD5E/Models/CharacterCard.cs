using System;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class CharacterCard
    {
        public AbilityScoresModel AbilityScores { get; set; }
        public int Age { get; set; }
        public CharacterBackgroundModel Background { get; set; }
        public string Class { get; set; }
        public int HitDice { get; set; }
        public HitPointsModel HitPoints { get; set; }
        public Guid Id { get; set; }
        public List<string> Immunity { get; set; }
        public List<string> Languages { get; set; }
        public int Level { get; set; }
        public int PassivePerception { get; set; }
        public int ProficiencyBonus { get; set; }
        public List<string> ProficiencyArmor { get; set; }
        public List<string> ProficiencySavingThrows { get; set; }
        public List<string> ProficiencySkills { get; set; }
        public List<string> ProficiencyTools { get; set; }
        public List<string> ProficiencyWeapons { get; set; }
        public string Race { get; set; }
        public List<string> Resistance { get; set; }
        public string Size { get; set; }
        public int Speed { get; set; }
    }

    public class CharacterBackgroundModel
    {
        public string Bond { get; set; }
        public string Description { get; set; }
        public CharacterFeatureModel Feature { get; set; }
        public string Flaw { get; set; }
        public string Ideal { get; set; }
        public string Name { get; set; }
        public string Personality { get; set; }
    }

    public class CharacterFeatureModel
    {
        public string[] Description { get; set; }
        public string Name { get; set; }
    }
}
