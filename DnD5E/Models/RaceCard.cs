using DnD5E.Enums;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class RaceCard : BaseCard
    {
        public AbilityScoresModel AbilityScores { get; set; }
        public ActionModel[] Actions { get; set; }
        public AgeRangeModel AgeRange { get; set; }
        public string[] Features { get; set; }
        public string[] Immunity { get; set; }
        public string[] Languages { get; set; }
        public ProficiencyModel Proficiencies { get; set; }
        public string[] Resistance { get; set; }
        public string Size { get; set; } = SizeEnum.medium.ToString();
        public int Speed { get; set; } = 30;
        public List<RaceCard> Variants { get; set; }
    }

    public class AgeRangeModel
    {
        public int Max { get; set; }
        public int Min { get; set; }
    }
}
