using System.Collections.Generic;

namespace DnD5E.Models
{
    public class BackgroundCard : BaseCard
    {
        public string[] Bond { get; set; }
        public string[] Equipment { get; set; }
        public FeaturesModel Feature { get; set; }
        public string[] Flaw { get; set; }
        public string[] Ideal { get; set; }
        public List<string> Languages { get; set; }
        public MoneyModel Money { get; set; }
        public string[] Personality { get; set; }
        public ProficiencyModel Proficiencies { get; set; }
    }
}