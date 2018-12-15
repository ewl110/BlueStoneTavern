using DnD5E.Enums;
using System.Collections.Generic;

namespace DnD5E.Models
{
    public class ProficiencyModel : BaseModel
    {
        public List<ArmorEnum> Armor { get; set; }
        public List<LanguagesEnum> Languages { get; set; }
        public List<AbilitiesEnum> SavingThrows { get; set; }
        public List<SkillsEnum> Skills { get; set; }
        public List<ToolsEnum> Tools { get; set; }
        public List<WeaponsEnum> Weapons { get; set; }
    }
}
