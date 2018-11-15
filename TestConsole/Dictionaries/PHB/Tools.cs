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
                        Currency = Currency.gp,
                        Price = 50
                    },
                    Description = "",
                    Name = "Alchemist's Tools",
                    Type = ToolTypes.artisansTools,
                    Weight = 8
                }
            },
            {
                "bagpipes",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 30
                    },
                    Description = "",
                    Name = "Bagpipes",
                    Type = ToolTypes.musicalInstrument,
                    Weight = 6
                }
            },
            {
                "brewersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 20
                    },
                    Description = "",
                    Name = "Brewer's Supplies",
                    Type = ToolTypes.artisansTools,
                    Weight = 9
                }
            },
            {
                "calligraphersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 10
                    },
                    Description = "",
                    Name = "Calligrapher's Supplies",
                    Type = ToolTypes.artisansTools,
                    Weight = 5
                }
            },
            {
                "carpentersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 8
                    },
                    Description = "",
                    Name = "Carpenter's Supplies",
                    Type = ToolTypes.artisansTools,
                    Weight = 6
                }
            },
            {
                "cartographersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 15
                    },
                    Description = "",
                    Name = "Cartographer's Supplies",
                    Type = ToolTypes.artisansTools,
                    Weight = 6
                }
            },
            {
                "cobblersSuppliers",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 5
                    },
                    Description = "",
                    Name = "Cobbler's Supplies",
                    Type = ToolTypes.artisansTools,
                    Weight = 5
                }
            },
            {
                "cooksUtensils",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Cook's Utensils",
                    Type = ToolTypes.artisansTools,
                    Weight = 8
                }
            },
            {
                "diceSet",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.sp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Dice Set",
                    Type = ToolTypes.gaming,
                    Weight = 0
                }
            },
            {
                "disguiseKit",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 25
                    },
                    Description = "",
                    Name = "Disguise Kit",
                    Type = ToolTypes.disguiseKit,
                    Weight = 3
                }
            },
            {
                "dragonchessSet",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Dragonchess Set",
                    Type = ToolTypes.gaming,
                    Weight = 0.5
                }
            },
            {
                "drum",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 6
                    },
                    Description = "",
                    Name = "Drum",
                    Type = ToolTypes.musicalInstrument,
                    Weight = 3
                }
            },
            {
                "dulcimer",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 25
                    },
                    Description = "",
                    Name = "Dulcimer",
                    Type = ToolTypes.musicalInstrument,
                    Weight = 10
                }
            },
            {
                "flute",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 2
                    },
                    Description = "",
                    Name = "Flute",
                    Type = ToolTypes.musicalInstrument,
                    Weight = 1
                }
            },
            {
                "forgeryKit",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 15
                    },
                    Description = "",
                    Name = "Forgery Kit",
                    Type = ToolTypes.forgeryKit,
                    Weight = 5
                }
            },
            {
                "glassblowersTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 30
                    },
                    Description = "",
                    Name = "Glassblower's Tools",
                    Type = ToolTypes.artisansTools,
                    Weight = 5
                }
            },
            {
                "herbalismKit",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 5
                    },
                    Description = "",
                    Name = "Herbalism Kit",
                    Type = ToolTypes.herbalismKit,
                    Weight = 3
                }
            },
            {
                "horn",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 3
                    },
                    Description = "",
                    Name = "Horn",
                    Type = ToolTypes.musicalInstrument,
                    Weight = 2
                }
            },
            {
                "jewelersTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 25
                    },
                    Description = "",
                    Name = "Jeweler's Tools",
                    Type = ToolTypes.artisansTools,
                    Weight = 2
                }
            },
            {
                "leatherworkersTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 5
                    },
                    Description = "",
                    Name = "Leather Worker's Tools",
                    Type = ToolTypes.artisansTools,
                    Weight = 5
                }
            },
            {
                "lute",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 35
                    },
                    Description = "",
                    Name = "Lute",
                    Type = ToolTypes.musicalInstrument,
                    Weight = 2
                }
            },
            {
                "lyre",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 30
                    },
                    Description = "",
                    Name = "Lyre",
                    Type = ToolTypes.musicalInstrument,
                    Weight = 2
                }
            },
            {
                "masonsTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 10
                    },
                    Description = "",
                    Name = "Mason's Tools",
                    Type = ToolTypes.artisansTools,
                    Weight = 8
                }
            },
            {
                "navigatorsTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 25
                    },
                    Description = "",
                    Name = "Navigator's Tools",
                    Type = ToolTypes.navigatorsTools,
                    Weight = 2
                }
            },
            {
                "paintersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 10
                    },
                    Description = "",
                    Name = "Painter's Supplies",
                    Type = ToolTypes.artisansTools,
                    Weight = 5
                }
            },
            {
                "panFlute",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 12
                    },
                    Description = "",
                    Name = "Pan Flute",
                    Type = ToolTypes.musicalInstrument,
                    Weight = 2
                }
            },
            {
                "playingCardSet",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.sp,
                        Price = 5
                    },
                    Description = "",
                    Name = "Playing Card Set",
                    Type = ToolTypes.gaming,
                    Weight = 0
                }
            },
            {
                "poisonersKit",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 50
                    },
                    Description = "",
                    Name = "Poisnoner's Kit",
                    Type = ToolTypes.poisonersKit,
                    Weight = 2
                }
            },
            {
                "pottersSupplies",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 10
                    },
                    Description = "",
                    Name = "Potter's Supplies",
                    Type = ToolTypes.artisansTools,
                    Weight = 3
                }
            },
            {
                "shawm",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 2
                    },
                    Description = "",
                    Name = "Shawm",
                    Type = ToolTypes.musicalInstrument,
                    Weight = 1
                }
            },
            {
                "smithsTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 20
                    },
                    Description = "",
                    Name = "Smith's Tools",
                    Type = ToolTypes.artisansTools,
                    Weight = 8
                }
            },
            {
                "thievesTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 25
                    },
                    Description = "",
                    Name = "Thieves' Tools",
                    Type = ToolTypes.thievesTools,
                    Weight = 1
                }
            },
            {
                "threeDragonAnteSet",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Three-Dragon Ante Set",
                    Type = ToolTypes.gaming,
                    Weight = 0
                }
            },
            {
                "tinkersTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 50
                    },
                    Description = "",
                    Name = "Tinker's Tools",
                    Type = ToolTypes.artisansTools,
                    Weight = 10
                }
            },
            {
                "viol",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 30
                    },
                    Description = "",
                    Name = "Viol",
                    Type = ToolTypes.musicalInstrument,
                    Weight = 1
                }
            },
            {
                "weaversTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Weaver's Tools",
                    Type = ToolTypes.artisansTools,
                    Weight = 5
                }
            },
            {
                "woodcarversTools",
                new Tool
                {
                    Cost = new Cost {
                        Currency = Currency.gp,
                        Price = 1
                    },
                    Description = "",
                    Name = "Woodcarver's Tools",
                    Type = ToolTypes.artisansTools,
                    Weight = 5
                }
            }
        };
    }
}
