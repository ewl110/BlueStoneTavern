using DnD5E.Enums;

namespace DnD5E.Models
{
    public class ProficiencyModel : BaseModel
    {
        public string[] Skills { get; set; }
        public string[] Tools { get; set; }
        public ProficiencyTypesEnum Type { get; set; }
    }
}
