using DnD5E.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnD5E.Models
{
    public class RaceModel : BaseModel
    {
        public AbilityScoresModel AbilityScores { get; set; }
        public int Age { get; set; }
        public string Alignment { get; set; }
        [Required]
        public string Archetype { get; set; }
        public string Asi { get; set; }
        public List<string> Feats { get; set; }
        public bool HasDarkvision { get; set; }
        [Required]
        public string Key { get; set; }
        public List<string> Languages { get; set; }
        public SizeEnum Size { get; set; }
        public List<string> Skills { get; set; }
        public int Speed { get; set; }
        public List<string> Spells { get; set; }
    }
}
