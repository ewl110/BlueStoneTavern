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
        public int Speed { get; set; }
    }

    public class CreateCharacter
    {
        public string Background { get; set; }
        public string Class { get; set; }
        public string Race { get; set; }
    }
}
