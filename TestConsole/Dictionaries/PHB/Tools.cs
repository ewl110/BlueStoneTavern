using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;
using TestConsole.Models;

namespace TestConsole.Dictionaries.PHB
{
    public static class Tools
    {
        public static Dictionary<string, Tool> List = new Dictionary<string, Tool>()
        {
            {
                "alchemistsSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 50
                    },
                    Description = "",
                    Name = "Alchemist's Tools",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 8
                }
            },
            {
                "bagpipes",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 30
                    },
                    Description = "",
                    Name = "Bagpipes",
                    Type = ToolTypesEnum.musicalInstrument,
                    Weight = 6
                }
            },
            {
                "brewersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 20
                    },
                    Description = "",
                    Name = "Brewer's Supplies",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 9
                }
            },
            {
                "calligraphersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 10
                    },
                    Description = "",
                    Name = "Calligrapher's Supplies",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 5
                }
            },
            {
                "carpentersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 8
                    },
                    Description = "",
                    Name = "Carpenter's Supplies",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 6
                }
            },
            {
                "cartographersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 15
                    },
                    Description = "",
                    Name = "Cartographer's Supplies",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 6
                }
            },
            {
                "cobblersSuppliers",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 5
                    },
                    Description = "",
                    Name = "Cobbler's Supplies",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 5
                }
            },
            {
                "cooksUtensils",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Cook's Utensils",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 8
                }
            },
            {
                "diceSet",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.sp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Dice Set",
                    Type = ToolTypesEnum.gaming,
                    Weight = 0
                }
            },
            {
                "disguiseKit",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 25
                    },
                    Description = "",
                    Name = "Disguise Kit",
                    Type = ToolTypesEnum.disguiseKit,
                    Weight = 3
                }
            },
            {
                "dragonchessSet",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Dragonchess Set",
                    Type = ToolTypesEnum.gaming,
                    Weight = 0.5
                }
            },
            {
                "drum",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 6
                    },
                    Description = "",
                    Name = "Drum",
                    Type = ToolTypesEnum.musicalInstrument,
                    Weight = 3
                }
            },
            {
                "dulcimer",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 25
                    },
                    Description = "",
                    Name = "Dulcimer",
                    Type = ToolTypesEnum.musicalInstrument,
                    Weight = 10
                }
            },
            {
                "flute",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 2
                    },
                    Description = "",
                    Name = "Flute",
                    Type = ToolTypesEnum.musicalInstrument,
                    Weight = 1
                }
            },
            {
                "forgeryKit",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 15
                    },
                    Description = "",
                    Name = "Forgery Kit",
                    Type = ToolTypesEnum.forgeryKit,
                    Weight = 5
                }
            },
            {
                "glassblowersTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 30
                    },
                    Description = "",
                    Name = "Glassblower's Tools",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 5
                }
            },
            {
                "herbalismKit",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 5
                    },
                    Description = "",
                    Name = "Herbalism Kit",
                    Type = ToolTypesEnum.herbalismKit,
                    Weight = 3
                }
            },
            {
                "horn",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 3
                    },
                    Description = "",
                    Name = "Horn",
                    Type = ToolTypesEnum.musicalInstrument,
                    Weight = 2
                }
            },
            {
                "jewelersTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 25
                    },
                    Description = "",
                    Name = "Jeweler's Tools",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 2
                }
            },
            {
                "leatherworkersTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 5
                    },
                    Description = "",
                    Name = "Leather Worker's Tools",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 5
                }
            },
            {
                "lute",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 35
                    },
                    Description = "",
                    Name = "Lute",
                    Type = ToolTypesEnum.musicalInstrument,
                    Weight = 2
                }
            },
            {
                "lyre",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 30
                    },
                    Description = "",
                    Name = "Lyre",
                    Type = ToolTypesEnum.musicalInstrument,
                    Weight = 2
                }
            },
            {
                "masonsTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 10
                    },
                    Description = "",
                    Name = "Mason's Tools",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 8
                }
            },
            {
                "navigatorsTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 25
                    },
                    Description = "",
                    Name = "Navigator's Tools",
                    Type = ToolTypesEnum.navigatorsTools,
                    Weight = 2
                }
            },
            {
                "paintersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 10
                    },
                    Description = "",
                    Name = "Painter's Supplies",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 5
                }
            },
            {
                "panFlute",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 12
                    },
                    Description = "",
                    Name = "Pan Flute",
                    Type = ToolTypesEnum.musicalInstrument,
                    Weight = 2
                }
            },
            {
                "playingCardSet",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.sp,
                        Price = 5
                    },
                    Description = "",
                    Name = "Playing Card Set",
                    Type = ToolTypesEnum.gaming,
                    Weight = 0
                }
            },
            {
                "poisonersKit",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 50
                    },
                    Description = "",
                    Name = "Poisnoner's Kit",
                    Type = ToolTypesEnum.poisonersKit,
                    Weight = 2
                }
            },
            {
                "pottersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 10
                    },
                    Description = "",
                    Name = "Potter's Supplies",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 3
                }
            },
            {
                "shawm",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 2
                    },
                    Description = "",
                    Name = "Shawm",
                    Type = ToolTypesEnum.musicalInstrument,
                    Weight = 1
                }
            },
            {
                "smithsTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 20
                    },
                    Description = "",
                    Name = "Smith's Tools",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 8
                }
            },
            {
                "thievesTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 25
                    },
                    Description = "",
                    Name = "Thieves' Tools",
                    Type = ToolTypesEnum.thievesTools,
                    Weight = 1
                }
            },
            {
                "threeDragonAnteSet",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Three-Dragon Ante Set",
                    Type = ToolTypesEnum.gaming,
                    Weight = 0
                }
            },
            {
                "tinkersTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 50
                    },
                    Description = "",
                    Name = "Tinker's Tools",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 10
                }
            },
            {
                "viol",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 30
                    },
                    Description = "",
                    Name = "Viol",
                    Type = ToolTypesEnum.musicalInstrument,
                    Weight = 1
                }
            },
            {
                "weaversTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Weaver's Tools",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 5
                }
            },
            {
                "woodcarversTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = CurrencyEnum.gp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Woodcarver's Tools",
                    Type = ToolTypesEnum.artisansTools,
                    Weight = 5
                }
            }
        };
    }
}
