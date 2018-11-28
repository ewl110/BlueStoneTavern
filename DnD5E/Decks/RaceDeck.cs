using DnD5E.Enums;
using DnD5E.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace DnD5E.Decks
{
    public static class RaceDeck
    {
        public static List<RaceCard> Cards = new List<RaceCard>() {
            new RaceCard()
            {
                AbilityScores = new AbilityScoresModel
                {
                    Str = 2,
                    Dex = 0,
                    Con = 0,
                    Int = 0,
                    Wis = 0,
                    Cha = 1
                },
                Actions = new ActionModel[]
                {
                    new ActionModel
                    {
                        Description = "Dragonborn trait",
                        Name = "Breath Weapon",
                        Type = ActionTypesEnum.Action.ToString()
                    },
                },
                AgeRange = new AgeRangeModel
                {
                    Max = 80,
                    Min = 15
                },
                Languages = new List<string>
                {
                    LanguagesEnum.Common.ToString(),
                    LanguagesEnum.Draconic.ToString(),
                },
                Name = "Dragonborn",
                Variants = new List<RaceCard>()
                {
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Draconic Ancestry (Black)",
                                Description = new string[]
                                {
                                    "You have an acid breath weapon and resistance to acid damage."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Breath weapon:",
                                Description = new string[]
                                {
                                    "You can use your action to exhale acid in a 5 ft. by 30 ft. line. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest."
                                }
                            }
                        },
                        Name = "Dragonborn (Black)",
                        Resistance = new string[]
                        {
                            DamageTypesEnum.Acid.ToString()
                        },
                        Weight = (int)RarityEnum.Uncommon
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name ="Draconic Ancestry (Blue)",
                                Description = new string[]
                                {
                                    "You have a lightning breath weapon and resistance to lightning damage."
                                }
                            },
                            new FeaturesModel
                            {
                                Name ="Breath weapon",
                                Description = new string[]
                                {
                                    "You can use your action to exhale lightning in a 5 ft. by 30 ft. line. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest."
                                }
                            }
                        },
                        Name = "Dragonborn (Blue)",
                        Resistance = new string[]
                        {
                            DamageTypesEnum.Lightning.ToString()
                        },
                        Weight = (int)RarityEnum.Uncommon
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name ="Draconic Ancestry (Brass)",
                                Description = new string[]
                                {
                                    "You have a fire breath weapon and resistance to fire damage.",
                                }
                            },
                            new FeaturesModel
                            {
                                Name ="Breath weapon",
                                Description = new string[]
                                {
                                    "You can use your action to exhale fire in a 5 ft. by 30 ft. line. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
                                }
                            }
                        },
                        Name = "Dragonborn (Brass)",
                        Resistance = new string[]
                        {
                            DamageTypesEnum.Fire.ToString()
                        },
                        Weight = (int)RarityEnum.Common
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Draconic Ancestry (Bronze)",
                                Description = new string[]
                                {
                                    "You have a lightning breath weapon and resistance to lightning damage."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Breath weapon",
                                Description = new string[]
                                {
                                    "You can use your action to exhale lightning in a 5 ft. by 30 ft. line. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest."
                                }
                            }
                        },
                        Name = "Dragonborn (Bronze)",
                        Resistance = new string[]
                        {
                            DamageTypesEnum.Lightning.ToString()
                        },
                        Weight = (int)RarityEnum.Common
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name ="Draconic Ancestry (Copper)",
                                Description = new string[]
                                {
                                    "You have an acid breath weapon and resistance to acid damage."
                                }
                            },
                            new FeaturesModel
                            {
                                Name ="Breath weapon",
                                Description = new string[]
                                {
                                    "You can use your action to exhale acid in a 5 ft. by 30 ft. line. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest."
                                }
                            }
                        },
                        Name = "Dragonborn (Copper)",
                        Resistance = new string[]
                        {
                            DamageTypesEnum.Acid.ToString()
                        },
                        Weight = (int)RarityEnum.Common
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name ="Draconic Ancestry (Gold)",
                                Description = new string[]
                                {
                                    "You have a fire breath weapon and resistance to fire damage."
                                }
                            },
                            new FeaturesModel
                            {
                                Name ="Breath weapon (Gold)",
                                Description = new string[]
                                {
                                    "You can use your action to exhale fire in a 15 ft. cone. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest."
                                }
                            }
                        },
                        Name = "Dragonborn (Gold)",
                        Resistance = new string[]
                        {
                            DamageTypesEnum.Fire.ToString()
                        },
                        Weight = (int)RarityEnum.Common
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Draconic Ancestry (Green)",
                                Description = new string[]
                                {
                                    "You have a poison breath weapon and resistance to poison damage."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Breath weapon",
                                Description = new string[]
                                {
                                    "You can use your action to exhale fire in a 15 ft. cone. Each creature in the affected area must make a CON saving throw (DC = 8 + CON modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest."
                                }
                            }
                        },
                        Name = "Dragonborn (Green)",
                        Resistance = new string[]
                        {
                            DamageTypesEnum.Poison.ToString()
                        },
                        Weight = (int)RarityEnum.Uncommon
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Draconic Ancestry (Red)",
                                Description = new string[]
                                {
                                    "You have a fire breath weapon and resistance to fire damage."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Breath weapon",
                                Description = new string[]
                                {
                                    "You can use your action to exhale fire in a 15 ft. cone. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest."
                                }
                            }
                        },
                        Name = "Dragonborn (Red)",
                        Resistance = new string[]
                        {
                            DamageTypesEnum.Fire.ToString()
                        },
                        Weight = (int)RarityEnum.Uncommon
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Draconic Ancestry (Silver)",
                                Description = new string[]
                                {
                                    "You have a cold breath weapon and resistance to cold damage.",
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Breath weapon",
                                Description = new string[]
                                {
                                    "You can use your action to exhale fire in a 15 ft. cone. Each creature in the affected area must make a CON saving throw (DC = 8 + CON modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.",
                                }
                            }
                        },
                        Name = "Dragonborn (Silver)",
                        Resistance = new string[]
                        {
                            DamageTypesEnum.Cold.ToString()
                        },
                        Weight = (int)RarityEnum.Common
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Draconic Ancestry (White)",
                                Description = new string[]
                                {
                                    "You have a cold breath weapon and resistance to cold damage."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Breath weapon",
                                Description = new string[]
                                {
                                    "You can use your action to exhale fire in a 15 ft. cone. Each creature in the affected area must make a CON saving throw (DC = 8 + CON modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest."
                                }
                            }
                        },
                        Name = "Dragonborn (White)",
                        Resistance = new string[]
                        {
                            DamageTypesEnum.Cold.ToString()
                        },
                        Weight = (int)RarityEnum.Uncommon
                    },
                },
                Weight = (int)RarityEnum.Uncommon
            },
            new RaceCard()
            {
                AbilityScores = new AbilityScoresModel
                {
                    Str = 0,
                    Dex = 0,
                    Con = 2,
                    Int = 0,
                    Wis = 0,
                    Cha = 0
                },
                AgeRange = new AgeRangeModel
                {
                    Max = 350,
                    Min = 50
                },
                Features = new List<FeaturesModel>
                {
                    new FeaturesModel
                    {
                        Name = "Speed",
                        Description = new string[]
                        {
                            "Your speed is not reduced by wearing heavy armor."
                        }
                    },
                    new FeaturesModel
                    {
                        Name = "Darkvision",
                        Description = new string[]
                        {
                            "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray."
                        }
                    },
                    new FeaturesModel
                    {
                        Name = "Dwarven Resilience",
                        Description = new string[]
                        {
                            "You have advantage on saving throws against poison, and you have resistance against poison damage."
                        }
                    },
                    new FeaturesModel
                    {
                        Name = "Dwarven Combat Training",
                        Description = new string[]
                        {
                            "You have proficiency with the battleaxe, handaxe, throwing hammer, and warhammer."
                        }
                    },
                    new FeaturesModel
                    {
                        Name = "Stonecunning",
                        Description = new string[]
                        {
                            "Whenever you make an Intelligence (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus."
                        }
                    }
                },
                Languages = new List<string>
                {
                    LanguagesEnum.Common.ToString(),
                    LanguagesEnum.Dwarvish.ToString(),
                },
                Name = "Dwarf",
                Proficiencies = new ProficiencyModel
                {
                    Tools = new string[]
                    {
                        "You gain proficiency with the artisan's tools of your choice: smith's tools, brewer's supplies, or mason's tools."
                    },
                    Weapons = new string[]
                    {}
                },
                Resistance = new string[]
                {
                    DamageTypesEnum.Poison.ToString()
                },
                Speed = 25,
                Variants = new List<RaceCard>()
                {
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 1,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name ="Superior Darkvision",
                                Description = new string[]
                                {
                                    "Your darkvision has a radius of 120 feet."
                                }
                            },
                            new FeaturesModel
                            {
                                Name ="Duergar Resilience",
                                Description = new string[]
                                {
                                    "You have advantage on saving throws against illusions and against being charmed or paralyzed."
                                }
                            },
                            new FeaturesModel
                            {
                                Name ="Duergar Magic",
                                Description = new string[]
                                {
                                    "When you reach 3rd level, you can cast the enlarge/reduce spell on yourself once with this trait, using only the spell's enlarge option. When you reach 5th level, you can cast the invisibility spell on yourself once with this trait. You don't need material components for either spell, and you can't cast them while you're in direct sunlight, although sunlight has no effect on them once cast. You regain the ability to cast these spells with this trait when you finish a long rest. Intelligence is your spellcasting ability for these spells."
                                }
                            },
                            new FeaturesModel
                            {
                                Name ="Sunlight Sensitivity",
                                Description = new string[]
                                {
                                    "You have disadvantage on attack rolls and on Wisdom (Perception) checks that rely on sight when you, the target of your attack, or whatever you are trying to perceive is in direct sunlight."
                                }
                            }
                        },
                        Languages = new List<string>
                        {
                            LanguagesEnum.Undercommon.ToString()
                        },
                        Name = "Duergar",
                        Weight = (int)RarityEnum.VeryRare
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 1,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Dwarven Toughness",
                                Description = new string[]
                                {
                                    "Your hit point maximum increases by 1, and it increases by 1 every time you gain a level."
                                }
                            }
                        },
                        Name = "Hill Dwarf",
                        Weight = (int)RarityEnum.Common
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 2,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Dwarven Armor Training",
                                Description = new string[]
                                {
                                    "You have proficiency with light and medium armor."
                                }
                            }
                        },
                        Name = "Mountain Dwarf",
                        Weight = (int)RarityEnum.Common
                    },
                },
                Weight = (int)RarityEnum.Common
            },
            new RaceCard()
            {
                AbilityScores = new AbilityScoresModel
                {
                    Str = 0,
                    Dex = 2,
                    Con = 0,
                    Int = 0,
                    Wis = 0,
                    Cha = 0
                },
                AgeRange = new AgeRangeModel
                {
                    Max = 750,
                    Min = 100
                },
                Features = new List<FeaturesModel>
                {
                    new FeaturesModel
                    {
                        Name = "Darkvision",
                        Description = new string[]
                        {
                            "Accustomed to twilit forests and the night sky, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray."
                        }
                    },
                    new FeaturesModel
                    {
                        Name = "Keen Senses",
                        Description = new string[]
                        {
                            "You have proficiency in the Perception skill."
                        }
                    },
                    new FeaturesModel
                    {
                        Name = "Fey Ancestry",
                        Description = new string[]
                        {
                            "You have advantage on saving throws against being charmed, and magic can't put you to sleep."
                        }
                    },
                    new FeaturesModel
                    {
                        Name = "Trance",
                        Description = new string[]
                        {
                            "Elves do not sleep. Instead they meditate deeply, remaining semi-conscious, for 4 hours a day. The Common word for this meditation is \"trance\". While meditating, you dream after a fashion; such dreams are actually mental exercises that have become reflexive after years of practice. After resting in this way, you gain the same benefit a human would from 8 hours of sleep."
                        }
                    }
                },
                Languages = new List<string>
                {
                    LanguagesEnum.Common.ToString(),
                    LanguagesEnum.Elvish.ToString(),
                },
                Name = "Elf",
                Proficiencies = new ProficiencyModel
                {
                    Skills = new string[]
                    {
                        SkillsEnum.Perception.ToString()
                    }
                },
                Variants = new List<RaceCard>()
                {
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 1
                        },
                        Description = "Descendants of an earlier, dark-skinned race of elf, the Drow were banished from the surface for following the goddess Lolth down her path of evil and corruption.",
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Superior Darkvision",
                                Description = new string[]
                                {
                                    "Your darkvision has a range of 120 feet, instead of 60."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Sunlight Sensitivity",
                                Description = new string[]
                                {
                                    "You have disadvantage on attack rolls and Wisdom (Perception) checks that rely on sight when you, the target of the attack, or whatever you are trying to perceive is in direct sunlight."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Drow Magic",
                                Description = new string[]
                                {
                                    "You know the dancing lights cantrip. When you reach 3rd level, you can cast faerie fire once, and it recharges after a long rest. When you reach 5th level, you can cast darkness once, and it recharges after a long rest. Charisma is your spellcasting ability for these spells."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Drow Weapon Training",
                                Description = new string[]
                                {
                                    "You have proficiency with rapiers, shortswords, and hand crossbows."
                                }
                            }
                        },
                        Name = "Drow",
                        Weight = (int)RarityEnum.VeryRare
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 1,
                            Wis = 0,
                            Cha = 0
                        },
                        Description = "As a high elf, you have a keen mind and a mastery of at least basic magical theory.",
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Elf Weapon Training",
                                Description = new string[]
                                {
                                    "You have proficiency with the longsword, shortsword, shortbow, and longbow."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Cantrip",
                                Description = new string[]
                                {
                                    "You know one cantrip of your choice from the wizard list. INT is your spellcasting ability for it."
                                }
                            },
                        },
                        Languages = new List<string>
                        {
                            LanguagesEnum.SelectLanguage.GetAttributeOfType<DescriptionAttribute>().Description
                        },
                        Name = "High Elf",
                        Weight = (int)RarityEnum.Common
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 1,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Description = "Sea elves fell in love with the wild beauty of the ocean in the earliest days of the multiverse. While other elves traveled from realm to realm, the sea elves navigated the deepest currents and explored the waters across a hundred worlds. Today, they live in small, hidden communities in the ocean shallows and on the Elemental Plane of Water.",
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Sea Elf Training",
                                Description = new string[]
                                {
                                    "You have proficiency with the spear, trident, light crossbow, and net."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Child of the Sea",
                                Description = new string[]
                                {
                                    "You have a swimming speed of 30 feet, and you can breathe air and water."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Friend of the Sea",
                                Description = new string[]
                                {
                                    "Using gestures and sounds, you can communicate simple ideas with any beast that has an innate swimming speed."
                                }
                            },
                        },
                        Languages = new List<string>
                        {
                            LanguagesEnum.Aquan.ToString()
                        },
                        Name = "Sea Elf",
                        Weight = (int)RarityEnum.Rare
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 1,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Description = "Sworn to the Raven Queen's service, the mysterious shadar-kai venture into the Material Plane from the Shadowfell to advance her will. Once they were fey like the rest of their elven kin, and now they exist in a strange state between life and death. Eladrin and shadar-kai are like reflections of each other: one bursting with emotion, the other nearly devoid of it.",
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Necrotic Resistance",
                                Description = new string[]
                                {
                                    "You have resistance to necrotic damage."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Blessing of the Raven Queen",
                                Description = new string[]
                                {
                                    "As a bonus action, you can magically teleport up to 30 ft. to an unoccupied space you can see. Once you use this trait, you can't do so again until you finish a long rest. Starting at 3rd level, you also gain resistance to all damage when you teleport using this trait. The resistance lasts until the start of your next turn. During that time, you appear ghostly and translucent."
                                }
                            },
                        },
                        Name = "Shadar-Kai",
                        Resistance = new string[]
                        {
                            DamageTypesEnum.Necrotic.ToString()
                        },
                        Weight = (int)RarityEnum.VeryRare
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 0,
                            Int = 0,
                            Wis = 1,
                            Cha = 0
                        },
                        Description = "As a wood elf, you have keen senses and intuition, and your fleet feet carry you quickly and stealthily through your native forests.",
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Elf Weapon Training",
                                Description = new string[]
                                {
                                    "You have proficiency with the longsword, shortsword, shortbow, and longbow."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Fleet of Foot",
                                Description = new string[]
                                {
                                    "Your base walking speed increases to 35 feet."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Mask of the Wild",
                                Description = new string[]
                                {
                                    "You can attempt to hide even when you are only lightly obscured by foliage, heavy rain, falling snow, mist, and other natural phenomena."
                                }
                            },
                        },
                        Name = "Wood Elf",
                        Speed = 35,
                        Weight = (int)RarityEnum.Common
                    },
                },
                Weight = (int)RarityEnum.Common
            },
            new RaceCard()
            {
                AbilityScores = new AbilityScoresModel
                {
                    Str = 0,
                    Dex = 0,
                    Con = 0,
                    Int = 2,
                    Wis = 0,
                    Cha = 0
                },
                AgeRange = new AgeRangeModel
                {
                    Max = 350,
                    Min = 40
                },
                Features = new List<FeaturesModel>
                {
                    new FeaturesModel
                    {
                        Name = "Darkvision",
                        Description = new string[]
                        {
                            "Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray."
                        }
                    },
                    new FeaturesModel
                    {
                        Name = "Gnome Cunning",
                        Description = new string[]
                        {
                            "You have advantage on all Intelligence, Wisdom, and Charisma saves against magic."
                        }
                    },
                },
                Languages = new List<string>
                {
                    LanguagesEnum.Common.ToString(),
                    LanguagesEnum.Gnomish.ToString(),
                },
                Name = "Gnome",
                Size = SizeEnum.small.ToString(),
                Speed = 25,
                Variants = new List<RaceCard>()
                {
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 1,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Description = "Forest gnomes and rock gnomes are the gnomes most commonly encountered in the lands of the surface world. There is another subrace of gnomes rarely seen by any surface-dweller: deep gnomes, also known as svirfneblin. Guarded, and suspicious of outsiders, svirfneblin are cunning and taciturn, but can be just as kind-hearted, loyal, and compassionate as their surface cousins.",
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Superior Darkvision",
                                Description = new string[]
                                {
                                    "Your darkvision has a radius of 120 feet."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Stone Camouflage",
                                Description = new string[]
                                {
                                    "You have advantage on Dexterity (stealth) checks to hide in rocky terrain."
                                }
                            },
                        },
                        Languages = new List<string>
                        {
                            LanguagesEnum.Undercommon.ToString()
                        },
                        Name = "Deep Gnome",
                        Weight = (int)RarityEnum.Rare
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 1,
                            Con = 0,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Description = "Forest gnomes have a knack for stealth and illusion, and are generally rather secretive. They gather in hidden forest communities, befriending the local fey and animals.",
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Natural Illusionist",
                                Description = new string[]
                                {
                                    "You know the minor illusion cantrip. Intelligence is your spellcasting modifier for it."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Speak with Small Beasts",
                                Description = new string[]
                                {
                                    "Through sound and gestures, you may communicate simple ideas with Small or smaller beasts."
                                }
                            },
                        },
                        Name = "Forest Gnome",
                        Weight = (int)RarityEnum.Common
                    },
                    new RaceCard
                    {
                        AbilityScores = new AbilityScoresModel
                        {
                            Str = 0,
                            Dex = 0,
                            Con = 1,
                            Int = 0,
                            Wis = 0,
                            Cha = 0
                        },
                        Description = "Rock gnomes are naturally inventive and quite hardy for such a small creature. Also known as tinker gnomes, they are well known for their contraptions, ranging from revolutionary to eccentric.",
                        Features = new List<FeaturesModel>
                        {
                            new FeaturesModel
                            {
                                Name = "Artificer's Lore",
                                Description = new string[]
                                {
                                    "Whenever you make an Intelligence (History) check related to magical, alchemical, or technological items, you can add twice your proficiency bonus instead of any other proficiency bonus that may apply."
                                }
                            },
                            new FeaturesModel
                            {
                                Name = "Tinker",
                                Description = new string[]
                                {
                                    "You have proficiency with artisan tools (tinker's tools). Using those tools, you can spend 1 hour and 10 gp worth of materials to construct a Tiny clockwork device (AC 5, 1 hp). The device ceases to function after 24 hours (unless you spend 1 hour repairing it to keep the device functioning), or when you use your action to dismantle it; at that time, you can reclaim the materials used to create it. You can have up to three such devices active at a time. When you create a device, choose one of the following options:",
                                    "<i>Clockwork Toy:</i> This toy is a c1ockwork animal, monster, or person, such as a frog, mouse, bird, dragon, or soldier. When placed on the ground, the toy moves 5 feet across the ground on each of your turns in a random direction. It makes noises as appropriate to the creature it represents.<br /><i>Fire Starter:</i> The device produces a miniature flame, which you can use to light a candle, torch, or campfire. Using the device requires your action.<br /><i>Music Box:</i> When opened, this music box plays a single song at a moderate volume. The box stops playing when it reaches the song's end or when it is closed.",
                                    "At your DM's discretion, you may make other objects with effects similar in power to these. The prestidigitation cantrip is a good baseline for such effects."
                                }
                            },
                        },
                        Name = "Rock Gnome",
                        Weight = (int)RarityEnum.Common
                    }
                },
                Weight = (int)RarityEnum.Common
            },
        };
    }
}