using DnD5E.Enums;

namespace DnD5E.Models
{
    public class ProficiencyModel : BaseModel
    {
        public string[] Armor { get; set; }
        public string[] Skills { get; set; }
        public string[] Tools { get; set; }
        public string [] Weapons { get; set; }
        public ProficiencyTypesEnum Type { get; set; }
    }
}
