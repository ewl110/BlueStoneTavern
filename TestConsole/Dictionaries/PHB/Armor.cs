using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;
using TestConsole.Models;

namespace TestConsole.Dictionaries.PHB
{
    public static class Armor
    {
        public static Dictionary<string, Models.Armor> List = new Dictionary<string, Models.Armor>() {
            {
                "breastplate",
                new Models.Armor
                {
                    ArmorClass = 14,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 400
                    },
                    Name = "Breastplate",
                    Stealth = true,
                    Type = ArmorTypesEnum.medium,
                    Weight = 20
                }
            },
            {
                "chainMail",
                new Models.Armor
                {
                    ArmorClass = 16,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 75
                    },
                    Name = "Chain Mail",
                    Stealth = false,
                    Strength = 13,
                    Type = ArmorTypesEnum.heavy,
                    Weight = 55
                }
            },
            {
                "chainShirt",
                new Models.Armor
                {
                    ArmorClass = 13,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 50
                    },
                    Name = "Chain Shirt",
                    Stealth = true,
                    Type = ArmorTypesEnum.medium,
                    Weight = 20
                }
            },
            {
                "halfPlate",
                new Models.Armor
                {
                    ArmorClass = 15,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 750
                    },
                    Name = "Half Plate",
                    Stealth = false,
                    Type = ArmorTypesEnum.medium,
                    Weight = 40
                }
            },
            {
                "hide",
                new Models.Armor
                {
                    ArmorClass = 12,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 10
                    },
                    Name = "Hide",
                    Stealth = true,
                    Type = ArmorTypesEnum.medium,
                    Weight = 12
                }
            },
            {
                "leather",
                new Models.Armor
                {
                    ArmorClass = 11,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 10
                    },
                    Name = "Leather",
                    Stealth = true,
                    Type = ArmorTypesEnum.light,
                    Weight = 10
                }
            },
            {
                "padded",
                new Models.Armor
                {
                    ArmorClass = 11,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 5
                    },
                    Name = "Padded",
                    Stealth = false,
                    Type = ArmorTypesEnum.light,
                    Weight = 8
                }
            },
            {
                "plate",
                new Models.Armor
                {
                    ArmorClass = 18,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 1500
                    },
                    Name = "Plate",
                    Stealth = false,
                    Strength = 15,
                    Type = ArmorTypesEnum.heavy,
                    Weight = 65
                }
            },
            {
                "ringMail",
                new Models.Armor
                {
                    ArmorClass = 14,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 30
                    },
                    Name = "Ring Mail",
                    Stealth = false,
                    Type = ArmorTypesEnum.heavy,
                    Weight = 40
                }
            },
            {
                "scaleMail",
                new Models.Armor
                {
                    ArmorClass = 14,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 50
                    },
                    Name = "Scale Mail",
                    Stealth = false,
                    Type = ArmorTypesEnum.medium,
                    Weight = 45
                }
            },
            {
                "shield",
                new Models.Armor
                {
                    ArmorClass = 2,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 10
                    },
                    Name = "Shield",
                    Stealth = true,
                    Type = ArmorTypesEnum.shield,
                    Weight = 6
                }
            },
            {
                "splint",
                new Models.Armor
                {
                    ArmorClass = 17,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 200
                    },
                    Name = "Splint",
                    Stealth = false,
                    Strength = 15,
                    Type = ArmorTypesEnum.heavy,
                    Weight = 60
                }
            },
            {
                "studdedLeather",
                new Models.Armor
                {
                    ArmorClass = 12,
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 45
                    },
                    Name = "Studded Leather",
                    Stealth = true,
                    Type = ArmorTypesEnum.light,
                    Weight = 13
                }
            }
        };
    }
}
