using DnD5E.Enums;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class FeaturesModel : BaseModel
    {
        public string AbilityModifier { get; set; }
        public ActionModel Action { get; set; }
        public List<ClassEnum> Class { get; set; }
        public new List<string> Description { get; set; }
        public string Key { get; set; }
        public List<RaceEnum> Race { get; set; }
    }
}