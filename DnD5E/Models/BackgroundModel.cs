using DnD5E.Enums;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class BackgroundModel : BaseModel
    {
        public string Key { get; set; }
        public List<LanguagesEnum> Languages { get; set; }
        public List<SkillsEnum> Skills { get; set; }
        public List<ToolsEnum> Tools { get; set; }
    }
}
