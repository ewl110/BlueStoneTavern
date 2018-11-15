using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;
using TestConsole.Models;

namespace TestConsole.Dictionaries.PHB
{
    public static class Weapons
    {
        public static Dictionary<string, Weapon> List = new Dictionary<string, Weapon>() {
            {
                "battleaxe",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 10
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.slashing,
                        Dice = 8,
                        NumberOfDice = 1,
                        Versatile = 10
                    },
                    IsRanged = false,
                    Name = "Battleaxe",
                    Properties = new WeaponProperties {
                        Versatile = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 4
                }
            },
            {
                "blowgun",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 10
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 1,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Blowgun",
                    Properties = new WeaponProperties {
                        Ammunition = true,
                        Loading = true
                    },
                    Range = new WeaponRange {
                        Long = 25,
                        Short = 100
                    },
                    Type = WeaponTypes.martial,
                    Weight = 1
                }
            },
            {
                "club",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.sp,
                        Price = 1
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.bludgeoning,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Club",
                    Properties = new WeaponProperties {
                        Light = true
                    },
                    Type = WeaponTypes.simple,
                    Weight = 2
                }
            },
            {
                "crossbowHand",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 75
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Hand Crossbow",
                    Properties = new WeaponProperties {
                        Ammunition = true,
                        Light = true,
                        Loading = true
                    },
                    Range = new WeaponRange {
                        Long = 120,
                        Short = 30
                    },
                    Type = WeaponTypes.martial,
                    Weight = 3
                }
            },
            {
                "crossbowHeavy",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 50
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 10,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Heavy Crossbow",
                    Properties = new WeaponProperties {
                        Ammunition = true,
                        Heavy = true,
                        Loading = true,
                        TwoHanded = true
                    },
                    Range = new WeaponRange {
                        Long = 400,
                        Short = 100
                    },
                    Type = WeaponTypes.martial,
                    Weight = 18
                }
            },
            {
                "crossbowLight",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 25
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Light Crossbow",
                    Properties = new WeaponProperties {
                        Ammunition = true,
                        Loading = true,
                        TwoHanded = true
                    },
                    Range = new WeaponRange {
                        Long = 320,
                        Short = 80
                    },
                    Type = WeaponTypes.simple,
                    Weight = 5
                }
            },
            {
                "dagger",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 2
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Dagger",
                    Properties = new WeaponProperties {
                        Finesse = true,
                        Light = true,
                        Thrown = true
                    },
                    Range = new WeaponRange {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypes.simple,
                    Weight = 1
                }
            },
            {
                "dart",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.cp,
                        Price = 5
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Dart",
                    Properties = new WeaponProperties {
                        Finesse = true,
                        Thrown = true
                    },
                    Range = new WeaponRange {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypes.simple,
                    Weight = 0.25
                }
            },
            {
                "flail",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 10
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.bludgeoning,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Flail",
                    Type = WeaponTypes.martial,
                    Weight = 2
                }
            },
            {
                "glaive",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 20
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.slashing,
                        Dice = 10,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Glaive",
                    Properties = new WeaponProperties {
                        Heavy = true,
                        Reach = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 6
                }
            },
            {
                "greateaxe",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 30
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.slashing,
                        Dice = 8,
                        NumberOfDice = 12
                    },
                    IsRanged = false,
                    Name = "Greataxe",
                    Properties = new WeaponProperties {
                        Heavy = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 7
                }
            },
            {
                "greatclub",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.sp,
                        Price = 2
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.bludgeoning,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Greatclub",
                    Properties = new WeaponProperties {
                        TwoHanded = true
                    },
                    Type = WeaponTypes.simple,
                    Weight = 10
                }
            },
            {
                "greatsword",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 50
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.slashing,
                        Dice = 6,
                        NumberOfDice = 2
                    },
                    IsRanged = false,
                    Name = "Greatsword",
                    Properties = new WeaponProperties {
                        Heavy = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 6
                }
            },
            {
                "halberd",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 20
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.slashing,
                        Dice = 10,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Halberd",
                    Properties = new WeaponProperties {
                        Heavy = true,
                        Reach = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 6
                }
            },
            {
                "handaxe",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 5
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.slashing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Handaxe",
                    Properties = new WeaponProperties {
                        Light = true,
                        Thrown = true
                    },
                    Range = new WeaponRange {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypes.simple,
                    Weight = 2
                }
            },
            {
                "javelin",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.sp,
                        Price = 5
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Javelin",
                    Properties = new WeaponProperties {
                        Thrown = true
                    },
                    Range = new WeaponRange {
                        Long = 120,
                        Short = 30
                    },
                    Type = WeaponTypes.simple,
                    Weight = 2
                }
            },
            {
                "lance",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 10
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 12,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Lance",
                    Properties = new WeaponProperties {
                        Reach = true,
                        Special = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 6
                }
            },
            {
                "lightHammer",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 2
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.bludgeoning,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Light Hammer",
                    Properties = new WeaponProperties {
                        Light = true,
                        Thrown = true
                    },
                    Range = new WeaponRange {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypes.simple,
                    Weight = 2
                }
            },
            {
                "longbow",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 50
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Longbow",
                    Properties = new WeaponProperties {
                        Ammunition = true,
                        Heavy = true,
                        TwoHanded = true
                    },
                    Range = new WeaponRange {
                        Long = 600,
                        Short = 150
                    },
                    Type = WeaponTypes.martial,
                    Weight = 2
                }
            },
            {
                "longsword",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 15
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.slashing,
                        Dice = 8,
                        NumberOfDice = 1,
                        Versatile = 10
                    },
                    IsRanged = false,
                    Name = "Longsword",
                    Properties = new WeaponProperties {
                        Versatile = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 3
                }
            },
            {
                "mace",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 5
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.bludgeoning,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Mace",
                    Type = WeaponTypes.simple,
                    Weight = 4
                }
            },
            {
                "maul",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 10
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.slashing,
                        Dice = 6,
                        NumberOfDice = 2
                    },
                    IsRanged = false,
                    Name = "Maul",
                    Properties = new WeaponProperties {
                        Heavy = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 10
                }
            },
            {
                "morningstar",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 15
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Morningstar",
                    Type = WeaponTypes.martial,
                    Weight = 4
                }
            },
            {
                "net",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 1
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.bludgeoning,
                        Dice = 0,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Net",
                    Properties = new WeaponProperties {
                        Special = true,
                        Thrown = true
                    },
                    Range = new WeaponRange {
                        Long = 15,
                        Short = 5
                    },
                    Type = WeaponTypes.martial,
                    Weight = 3
                }
            },
            {
                "pike",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 5
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 10,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Pike",
                    Properties = new WeaponProperties {
                        Heavy = true,
                        Reach = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 18
                }
            },
            {
                "quarterstaff",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.sp,
                        Price = 2
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.bludgeoning,
                        Dice = 6,
                        NumberOfDice = 1,
                        Versatile = 8
                    },
                    IsRanged = false,
                    Name = "Quarterstaff",
                    Properties = new WeaponProperties {
                        Versatile = true
                    },
                    Type = WeaponTypes.simple,
                    Weight = 4
                }
            },
            {
                "rapier",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 25
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Rapier",
                    Properties = new WeaponProperties {
                        Finesse = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 2
                }
            },
            {
                "scimitar",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 25
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.slashing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Scimitar",
                    Properties = new WeaponProperties {
                        Finesse = true,
                        Light = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 3
                }
            },
            {
                "shortbow",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 25
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Shortbow",
                    Properties = new WeaponProperties {
                        Ammunition = true,
                        TwoHanded = true
                    },
                    Range = new WeaponRange {
                        Long = 320,
                        Short = 80
                    },
                    Type = WeaponTypes.simple,
                    Weight = 2
                }
            },
            {
                "shortsword",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 10
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Shortsword",
                    Properties = new WeaponProperties {
                        Finesse = true,
                        Light = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 2
                }
            },
            {
                "sickle",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 1
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.slashing,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Sickle",
                    Properties = new WeaponProperties {
                        Light = true
                    },
                    Type = WeaponTypes.simple,
                    Weight = 2
                }
            },
            {
                "sling",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.sp,
                        Price = 1
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.bludgeoning,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = "Sling",
                    Properties = new WeaponProperties {
                        Ammunition = true
                    },
                    Range = new WeaponRange {
                        Long = 120,
                        Short = 30
                    },
                    Type = WeaponTypes.simple,
                    Weight = 0
                }
            },
            {
                "spear",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 1
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 6,
                        NumberOfDice = 1,
                        Versatile = 8
                    },
                    IsRanged = true,
                    Name = "Spear",
                    Properties = new WeaponProperties {
                        Thrown = true,
                        Versatile = true
                    },
                    Range = new WeaponRange {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypes.simple,
                    Weight = 3
                }
            },
            {
                "trident",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 5
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 6,
                        NumberOfDice = 1,
                        Versatile = 8
                    },
                    IsRanged = true,
                    Name = "Trident",
                    Properties = new WeaponProperties {
                        Thrown = true,
                        Versatile = true
                    },
                    Range = new WeaponRange {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypes.martial,
                    Weight = 4
                }
            },
            {
                "unarmedStrike",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 0
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.bludgeoning,
                        Dice = 1,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Unarmed Strike",
                    Type = WeaponTypes.simple,
                    Weight = 0
                }
            },
            {
                "warPick",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 5
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.piercing,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "War Pick",
                    Type = WeaponTypes.martial,
                    Weight = 2
                }
            },
            {
                "warhammer",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 15
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.bludgeoning,
                        Dice = 8,
                        NumberOfDice = 1,
                        Versatile = 10
                    },
                    IsRanged = false,
                    Name = "Warhammer",
                    Properties = new WeaponProperties {
                        Versatile = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 2
                }
            },
            {
                "whip",
                new Weapon
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 2
                    },
                    Damage = new WeaponDamage {
                        DamageType = DamageTypes.slashing,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = "Whip",
                    Properties = new WeaponProperties {
                        Finesse = true,
                        Reach = true
                    },
                    Type = WeaponTypes.martial,
                    Weight = 3
                }
            }
        };
    }
}
