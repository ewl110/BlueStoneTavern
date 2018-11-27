using DnD5E.Enums;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class FeatureModel : BaseModel
    {
        public List<ClassEnum> Class { get; set; }
        public new string[] Description { get; set; }
        public string Key { get; set; }
        public List<RaceEnum> Race { get; set; }

        // should descriptions be a string array?
    }
}
