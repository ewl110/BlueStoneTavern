using DnD5E.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5E.Models
{
    public class FeatureModel : BaseModel
    {
        public List<ClassEnum> Class { get; set; }
        public string Key { get; set; }
        public List<RaceEnum> Race { get; set; }
    }
}
