using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;
using TestConsole.Enums.Classes;
using TestConsole.Models;
using TestConsole.Models.Classes;

namespace TestConsole.Dictionaries.PHB.Classes
{
    public static class Barbarian
    {
        public static Dictionary<int, BarbarianLevels> Levels = new Dictionary<int, BarbarianLevels>() {
            {
                1,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.rage.ToString(),
                        BarbarianFeaturesEnum.unarmoredAttack.ToString()
                    },
                    ProficiencyBonus = 2,
                    Rages = 2,
                    RageDamage = 2
                }
            },
            {
                2,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.dangerSense.ToString(),
                        BarbarianFeaturesEnum.recklessAttack.ToString()
                    },
                    ProficiencyBonus = 2,
                    Rages = 2,
                    RageDamage = 2
                }
            },
            {
                3,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.archetype.ToString()
                    },
                    ProficiencyBonus = 2,
                    Rages = 3,
                    RageDamage = 2
                }
            },
            {
                4,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.asi.ToString()
                    },
                    ProficiencyBonus = 2,
                    Rages = 3,
                    RageDamage = 2
                }
            },
            {
                5,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.extraAttack.ToString(),
                        BarbarianFeaturesEnum.fastMovement.ToString()
                    },
                    ProficiencyBonus = 3,
                    Rages = 3,
                    RageDamage = 2
                }
            },
            {
                6,
                new BarbarianLevels {
                    Features = new string[]{},
                    ProficiencyBonus = 3,
                    Rages = 4,
                    RageDamage = 2
                }
            },
            {
                7,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.feralInstinct.ToString()
                    },
                    ProficiencyBonus = 3,
                    Rages = 4,
                    RageDamage = 2
                }
            },
            {
                8,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.feralInstinct.ToString()
                    },
                    ProficiencyBonus = 3,
                    Rages = 4,
                    RageDamage = 2
                }
            },
            {
                9,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.brutalCritical.ToString()
                    },
                    ProficiencyBonus = 4,
                    Rages = 4,
                    RageDamage = 3
                }
            },
            {
                10,
                new BarbarianLevels {
                    Features = new string[]{},
                    ProficiencyBonus = 4,
                    Rages = 4,
                    RageDamage = 3
                }
            },
            {
                11,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.relentlessRage.ToString()
                    },
                    ProficiencyBonus = 4,
                    Rages = 4,
                    RageDamage = 3
                }
            },
            {
                12,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.asi.ToString()
                    },
                    ProficiencyBonus = 4,
                    Rages = 5,
                    RageDamage = 3
                }
            },
            {
                13,
                new BarbarianLevels {
                    Features = new string[]{},
                    ProficiencyBonus = 5,
                    Rages = 5,
                    RageDamage = 3
                }
            },
            {
                14,
                new BarbarianLevels {
                    Features = new string[]{},
                    ProficiencyBonus = 5,
                    Rages = 5,
                    RageDamage = 3
                }
            },
            {
                15,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.persistentRage.ToString()
                    },
                    ProficiencyBonus = 5,
                    Rages = 5,
                    RageDamage = 3
                }
            },
            {
                16,
                new BarbarianLevels {
                    Features = new string[]{},
                    ProficiencyBonus = 5,
                    Rages = 5,
                    RageDamage = 4
                }
            },
            {
                17,
                new BarbarianLevels {
                    Features = new string[]{},
                    ProficiencyBonus = 6,
                    Rages = 6,
                    RageDamage = 4
                }
            },
            {
                18,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.indomitableMight.ToString()
                    },
                    ProficiencyBonus = 6,
                    Rages = 6,
                    RageDamage = 4
                }
            },
            {
                19,
                new BarbarianLevels {
                    Features = new string[]{},
                    ProficiencyBonus = 6,
                    Rages = 6,
                    RageDamage = 4
                }
            },
            {
                20,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.primalChampion.ToString()
                    },
                    ProficiencyBonus = 6,
                    Rages = 20,
                    RageDamage = 4
                }
            }
        };

        public static Dictionary<int, BarbarianLevels> BerserkerLevels = new Dictionary<int, BarbarianLevels>() {
            {
                3,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.frenzy.ToString()
                    }
                }
            },
            {
                6,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.mindlessRage.ToString()
                    }
                }
            },
            {
                10,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.intimidatingPresence.ToString()
                    }
                }
            },
            {
                14,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.retaliation.ToString()
                    }
                }
            }
        };

        public static Dictionary<int, BarbarianLevels> TotemWarriorLevels = new Dictionary<int, BarbarianLevels>() {
            {
                3,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.spiritSeeker.ToString(),
                        BarbarianFeaturesEnum.totemSpirit.ToString()
                    }
                }
            },
            {
                6,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.aspectOfTheBeast.ToString()
                    }
                }
            },
            {
                10,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.spiritWalker.ToString()
                    }
                }
            },
            {
                14,
                new BarbarianLevels {
                    Features = new string[]{
                        BarbarianFeaturesEnum.totemicAttunement.ToString()
                    }
                }
            }
        };

        public static Dictionary<string, ClassFeatures> Features = new Dictionary<string, ClassFeatures>()
        {
            
        };
    }
}
