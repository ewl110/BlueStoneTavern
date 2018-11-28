using System;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class CharacterCard
    {
        public AbilityScoresModel AbilityScores { get; set; }
        public int Age { get; set; }
        public string Background { get; set; }
        public string Class { get; set; }
        public int HitDice { get; set; }
        public HitPointsModel HitPoints { get; set; }
        public Guid Id { get; set;  }
        public List<string> Languages { get; set; }
        public int Level { get; set; }
        public int PassivePerception { get; set; }
        public int ProficiencyBonus { get; set; }
        public List<string> ProficiencySkills { get; set; }
        public string Race { get; set; }
        public int Speed { get; set; }
    }
}
