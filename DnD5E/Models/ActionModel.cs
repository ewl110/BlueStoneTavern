using DnD5E.Enums;

namespace DnD5E.Models
{
    public class ActionModel : BaseCard
    {
        public ActionTypesEnum Type { get; set; }
        public WeaponsEnum Weapon { get; set; } = WeaponsEnum.None;
    }
}
