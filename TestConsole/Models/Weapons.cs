using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class Weapons
    {
        Weapon[] List { get; set; }
    }

    public class Weapon : Base
    {
        public Cost Cost { get; set; }
        public WeaponDamage Damage { get; set; }
        public bool IsRanged { get; set; }
        public int NumberOfDice { get; set; }
        public WeaponProperties Properties { get; set; }
        public WeaponRange Range { get; set; }
        public WeaponTypes Type { get; set; }
        public double Weight { get; set; }
    }

    public class WeaponDamage
    {
        public DamageTypes DamageType { get; set; }
        public int Dice { get; set; }
        public int NumberOfDice { get; set; }
        public int Versatile { get; set; }
    }

    public class WeaponProperties
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

    public class WeaponRange
    {
        public int Long { get; set; }
        public int Short { get; set; }
    }
}
