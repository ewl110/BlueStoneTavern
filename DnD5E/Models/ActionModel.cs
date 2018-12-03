using DnD5E.Enums;

namespace DnD5E.Models
{
    public class ActionModel : BaseCard
    {
        public string Type { get; set; }
        public WeaponsEnum Weapon { get; set; }
    }
}
