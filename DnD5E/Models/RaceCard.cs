using DnD5E.Enums;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class RaceCard : BaseCard
    {
        public AbilityScoresModel AbilityScores { get; set; }
        public ActionModel[] Actions { get; set; }
        public AgeRangeModel AgeRange { get; set; }
        public List<FeaturesModel> Features { get; set; }
        public List<DamageTypesEnum> Immunity { get; set; }
        public ProficiencyModel Proficiencies { get; set; }
        public List<DamageTypesEnum> Resistance { get; set; }
        public SizeEnum Size { get; set; } = SizeEnum.Medium;
        public int Speed { get; set; } = 30;
        public List<RaceCard> Variants { get; set; }
    }

    public class AgeRangeModel
    {
        public int Max { get; set; }
        public int Min { get; set; }
    }
}
