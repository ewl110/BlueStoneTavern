using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DnD5E.Models
{
    public class CharacterModel : BaseModel
    {
        public AbilityScoresModel AbilityScores { get; set; }
        public string Background { get; set; }
        [Required]
        public List<string> Class { get; set; }
        public DateTime Created { get; set; }
        public List<string> Features { get; set; }
        public HitPointsModel HitPoints { get; set; }
        public DateTime LastUpdated { get; set; }
        [Required]
        public int Level { get; set; }
        [Required]
        public string Race { get; set; }
    }

    public class AbilityScoresModel
    {
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Cha { get; set; }
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Con { get; set; }
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Dex { get; set; }
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Int { get; set; }
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Str { get; set; }
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Wis { get; set; }
    }

    public class CreateCharacter
    {
        public string Background { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
    }

    public class HitPointsModel
    {
        public int HitDice { get; set; }
        public int HitDiceAvailable { get; set; }
        public int HitPointsCurrent { get; set; }
        public int HitPointsMax { get; set; }
    }
}
