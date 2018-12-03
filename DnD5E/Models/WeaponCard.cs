using DnD5E.Enums;

namespace DnD5E.Models
{
    public class WeaponCard : BaseCard
    {
        public CostModel Cost { get; set; }
        public WeaponDamageModel Damage { get; set; }
        public bool IsRanged { get; set; }
        public int NumberOfDice { get; set; }
        public WeaponPropertiesModel Properties { get; set; }
        public WeaponRangeModel Range { get; set; }
        public WeaponTypesEnum Type { get; set; }
        public double ItemWeight { get; set; }
    }

    public class WeaponDamageModel
    {
        public DamageTypesEnum DamageType { get; set; }
        public int Dice { get; set; }
        public int NumberOfDice { get; set; }
        public int Versatile { get; set; }
    }

    public class WeaponPropertiesModel
    {
        public bool Ammunition { get; set; }
        public bool Finesse { get; set; }
        public bool Heavy { get; set; }
        public bool Light { get; set; }
        public bool Loading { get; set; }
        public bool Reach { get; set; }
        public bool Special { get; set; }
        public bool Thrown { get; set; }
        public bool TwoHanded { get; set; }
        public bool Versatile { get; set; }
    }

    public class WeaponRangeModel
    {
        public int Long { get; set; }
        public int Short { get; set; }
    }
}
