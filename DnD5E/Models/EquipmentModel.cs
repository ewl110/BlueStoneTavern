using DnD5E.Enums;

namespace DnD5E.Models
{
    public class EquipmentModel : BaseCard
    {
        public int Quantity { get; set; } = 1;
        public EquipmentTypeEnum Type { get; set; } = EquipmentTypeEnum.Item;
        public WeaponsEnum Weapon { get; set; } = WeaponsEnum.None;
    }
}
