using DnD5E.Enums;
using DnD5E.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace DnD5E.Dictionaries
{
    public class WeaponDictionary
    {
        public static Dictionary<WeaponsEnum, WeaponCard> List = new Dictionary<WeaponsEnum, WeaponCard>()
        {
            {
                WeaponsEnum.Battleaxe,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 10
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Slashing,
                        Dice = 8,
                        NumberOfDice = 1,
                        Versatile = 10
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Battleaxe.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Versatile = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 4
                }
            },
            {
                WeaponsEnum.Blowgun,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 10
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 1,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = WeaponsEnum.Blowgun.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Ammunition = true,
                        Loading = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 25,
                        Short = 100
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 1
                }
            },
            {
                WeaponsEnum.Club,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.SP,
                        Price = 1
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Bludgeoning,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Club.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Light = true
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.CrossbowHand,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 75
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = WeaponsEnum.CrossbowHand.GetAttributeOfType<DescriptionAttribute>().Description,
                    Properties = new WeaponPropertiesModel {
                        Ammunition = true,
                        Light = true,
                        Loading = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 120,
                        Short = 30
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 3
                }
            },
            {
                WeaponsEnum.CrossbowHeavy,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 50
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 10,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = WeaponsEnum.CrossbowHeavy.GetAttributeOfType<DescriptionAttribute>().Description,
                    Properties = new WeaponPropertiesModel {
                        Ammunition = true,
                        Heavy = true,
                        Loading = true,
                        TwoHanded = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 400,
                        Short = 100
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 18
                }
            },
            {
                WeaponsEnum.CrossbowLight,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 25
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = WeaponsEnum.CrossbowLight.GetAttributeOfType<DescriptionAttribute>().Description,
                    Properties = new WeaponPropertiesModel {
                        Ammunition = true,
                        Loading = true,
                        TwoHanded = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 320,
                        Short = 80
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 5
                }
            },
            {
                WeaponsEnum.Dagger,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 2
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Dagger.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Finesse = true,
                        Light = true,
                        Thrown = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 1
                }
            },
            {
                WeaponsEnum.Dart,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.CP,
                        Price = 5
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = WeaponsEnum.Dart.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Finesse = true,
                        Thrown = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 0.25
                }
            },
            {
                WeaponsEnum.Flail,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 10
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Bludgeoning,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Flail.ToString(),
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.Glaive,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 20
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Slashing,
                        Dice = 10,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Glaive.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Heavy = true,
                        Reach = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 6
                }
            },
            {
                WeaponsEnum.Greataxe,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 30
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Slashing,
                        Dice = 8,
                        NumberOfDice = 12
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Greataxe.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Heavy = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 7
                }
            },
            {
                WeaponsEnum.Greatclub,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.SP,
                        Price = 2
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Bludgeoning,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Greatclub.ToString(),
                    Properties = new WeaponPropertiesModel {
                        TwoHanded = true
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 10
                }
            },
            {
                WeaponsEnum.Greatsword,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 50
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Slashing,
                        Dice = 6,
                        NumberOfDice = 2
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Greatsword.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Heavy = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 6
                }
            },
            {
                WeaponsEnum.Halberd,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 20
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Slashing,
                        Dice = 10,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Halberd.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Heavy = true,
                        Reach = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 6
                }
            },
            {
                WeaponsEnum.Handaxe,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 5
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Slashing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Handaxe.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Light = true,
                        Thrown = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.Javelin,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.SP,
                        Price = 5
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Javelin.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Thrown = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 120,
                        Short = 30
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.Lance,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 10
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 12,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Lance.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Reach = true,
                        Special = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 6
                }
            },
            {
                WeaponsEnum.HammerLight,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 2
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Bludgeoning,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.HammerLight.GetAttributeOfType<DescriptionAttribute>().Description,
                    Properties = new WeaponPropertiesModel {
                        Light = true,
                        Thrown = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.Longbow,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 50
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = WeaponsEnum.Longbow.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Ammunition = true,
                        Heavy = true,
                        TwoHanded = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 600,
                        Short = 150
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.Longsword,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 15
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Slashing,
                        Dice = 8,
                        NumberOfDice = 1,
                        Versatile = 10
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Longsword.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Versatile = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 3
                }
            },
            {
                WeaponsEnum.Mace,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 5
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Bludgeoning,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Mace.ToString(),
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 4
                }
            },
            {
                WeaponsEnum.Maul,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 10
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Slashing,
                        Dice = 6,
                        NumberOfDice = 2
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Mace.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Heavy = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 10
                }
            },
            {
                WeaponsEnum.Morningstar,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 15
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Morningstar.ToString(),
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 4
                }
            },
            {
                WeaponsEnum.Net,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 1
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Bludgeoning,
                        Dice = 0,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = WeaponsEnum.Net.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Special = true,
                        Thrown = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 15,
                        Short = 5
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 3
                }
            },
            {
                WeaponsEnum.Pike,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 5
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 10,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Pike.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Heavy = true,
                        Reach = true,
                        TwoHanded = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 18
                }
            },
            {
                WeaponsEnum.Quarterstaff,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.SP,
                        Price = 2
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Bludgeoning,
                        Dice = 6,
                        NumberOfDice = 1,
                        Versatile = 8
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Quarterstaff.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Versatile = true
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 4
                }
            },
            {
                WeaponsEnum.Rapier,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 25
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Rapier.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Finesse = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.Scimitar,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 25
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Slashing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Scimitar.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Finesse = true,
                        Light = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 3
                }
            },
            {
                WeaponsEnum.Shortbow,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 25
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = WeaponsEnum.Shortbow.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Ammunition = true,
                        TwoHanded = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 320,
                        Short = 80
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.Shortsword,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 10
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 6,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Shortsword.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Finesse = true,
                        Light = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.Sickle,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 1
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Slashing,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Sickle.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Light = true
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.Sling,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.SP,
                        Price = 1
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Bludgeoning,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = true,
                    Name = WeaponsEnum.Sling.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Ammunition = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 120,
                        Short = 30
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 0
                }
            },
            {
                WeaponsEnum.Spear,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 1
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 6,
                        NumberOfDice = 1,
                        Versatile = 8
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Spear.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Thrown = true,
                        Versatile = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 3
                }
            },
            {
                WeaponsEnum.Trident,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 5
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 6,
                        NumberOfDice = 1,
                        Versatile = 8
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Trident.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Thrown = true,
                        Versatile = true
                    },
                    Range = new WeaponRangeModel {
                        Long = 60,
                        Short = 20
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 4
                }
            },
            {
                WeaponsEnum.UnarmedStrike,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 0
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Bludgeoning,
                        Dice = 1,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.UnarmedStrike.GetAttributeOfType<DescriptionAttribute>().Description,
                    Type = WeaponTypesEnum.Simple,
                    ItemWeight = 0
                }
            },
            {
                WeaponsEnum.Warhammer,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 15
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Bludgeoning,
                        Dice = 8,
                        NumberOfDice = 1,
                        Versatile = 10
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Warhammer.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Versatile = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.WarPick,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 5
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Piercing,
                        Dice = 8,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.WarPick.GetAttributeOfType<DescriptionAttribute>().Description,
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 2
                }
            },
            {
                WeaponsEnum.Whip,
                new WeaponCard
                {
                    Cost = new CostModel {
                        Currency = CurrencyEnum.GP,
                        Price = 2
                    },
                    Damage = new WeaponDamageModel {
                        DamageType = DamageTypesEnum.Slashing,
                        Dice = 4,
                        NumberOfDice = 1
                    },
                    IsRanged = false,
                    Name = WeaponsEnum.Whip.ToString(),
                    Properties = new WeaponPropertiesModel {
                        Finesse = true,
                        Reach = true
                    },
                    Type = WeaponTypesEnum.Martial,
                    ItemWeight = 3
                }
            }
        };
    }
}
