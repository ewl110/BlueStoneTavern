using DnD5E.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5E.Models
{
    public class CharacterModel
    {
        public string Background { get; set; }
        public string Class { get; set; }
        public string Description { get; set; }
        public HitPointsModel HitPoints { get; set; }
        public int Level { get; set; }
        public string Name { get; set; }
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
