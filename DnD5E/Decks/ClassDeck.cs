﻿using DnD5E.Enums;
using DnD5E.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace DnD5E.Decks
{
    public static class ClassDeck
    {
        public static List<ClassCard> Cards = new List<ClassCard>() {
            new ClassCard()
            {
                Name = "Barbarian",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 15,
                    Dex = 13,
                    Con = 14,
                    Int = 8,
                    Wis = 12,
                    Cha = 10
                },
                Description = "You are a fierce warrior of primitive background who can enter battle rage.",
                HitDice = 12,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Proficiencies = new ProficiencyModel
                            {
                                Armor = new string[]
                                {
                                    ArmorEnum.Light.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Medium.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Shield.ToString()
                                },
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Str.ToString(),
                                    AbilitiesEnum.Con.ToString(),
                                }
                            },
                            Rage = 2,
                            RageDamage = 2
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = "Bard",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 10,
                    Dex = 14,
                    Con = 13,
                    Int = 12,
                    Wis = 8,
                    Cha = 15
                },
                Description = "You are an inspiring magician whose power echoes the music of creation.",
                HitDice = 8,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Proficiencies = new ProficiencyModel
                            {
                                Armor = new string[]
                                {
                                    ArmorEnum.Light.GetAttributeOfType<DescriptionAttribute>().Description,
                                },
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Dex.ToString(),
                                    AbilitiesEnum.Cha.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = "Cleric",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 14,
                    Dex = 8,
                    Con = 13,
                    Int = 10,
                    Wis = 15,
                    Cha = 12
                },
                Description = "You are a priestly champion who wields divine magic in service of a higher power.",
                HitDice = 8,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Proficiencies = new ProficiencyModel
                            {
                                Armor = new string[]
                                {
                                    ArmorEnum.Light.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Medium.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Shield.ToString()
                                },
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Wis.ToString(),
                                    AbilitiesEnum.Cha.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = "Druid",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 13,
                    Dex = 8,
                    Con = 14,
                    Int = 10,
                    Wis = 15,
                    Cha = 12
                },
                Description = "You are a priest of the Old Faith, wielding the powers of nature &mdash; moonlight and plant growth, fire and lightning &mdash; and adopting animal forms.",
                HitDice = 8,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Spellcasting",
                                    Description = new string[]
                                    {
                                        "Wisdom is your spellcasting ability for your druid spells. You use your Wisdom whenever a spell refers to your spellcasting ability.",
                                        "To cast a spell, you must expend a slot of the spell’s level or higher. You regain all expended spell slots when you finish a long rest."
                                    },
                                    AbilityModifier = AbilitiesEnum.Wis.ToString(),
                                }
                            },
                            Proficiencies = new ProficiencyModel
                            {
                                Armor = new string[]
                                {
                                    ArmorEnum.Light.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Medium.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Shield.ToString()
                                },
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Int.ToString(),
                                    AbilitiesEnum.Wis.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = "Fighter",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 15,
                    Dex = 13,
                    Con = 14,
                    Int = 8,
                    Wis = 12,
                    Cha = 10
                },
                Description = "You are a master of martial combat, skilled with a variety of weapons and armor.",
                HitDice = 10,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Proficiencies = new ProficiencyModel
                            {
                                Armor = new string[]
                                {
                                    ArmorEnum.Light.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Medium.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Heavy.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Shield.ToString()
                                },
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Str.ToString(),
                                    AbilitiesEnum.Con.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = "Monk",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 13,
                    Dex = 15,
                    Con = 12,
                    Int = 8,
                    Wis = 14,
                    Cha = 10
                },
                Description = "You are a master of martial arts, harnessing the power of the body in pursuit of physical and spiritual perfection.",
                HitDice = 8,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Proficiencies = new ProficiencyModel
                            {
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Str.ToString(),
                                    AbilitiesEnum.Dex.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = "Paladin",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 15,
                    Dex = 13,
                    Con = 10,
                    Int = 12,
                    Wis = 8,
                    Cha = 14
                },
                Description = "You are a holy warrior bound to a sacred oath.",
                HitDice = 8,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Proficiencies = new ProficiencyModel
                            {
                                Armor = new string[]
                                {
                                    ArmorEnum.Light.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Medium.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Heavy.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Shield.ToString()
                                },
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Wis.ToString(),
                                    AbilitiesEnum.Cha.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = "Ranger",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 13,
                    Dex = 15,
                    Con = 10,
                    Int = 12,
                    Wis = 14,
                    Cha = 8
                },
                Description = "You are a warrior who uses martial prowess and nature magic to combat threats on the edges of civilization.",
                HitDice = 10,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Proficiencies = new ProficiencyModel
                            {
                                Armor = new string[]
                                {
                                    ArmorEnum.Light.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Medium.GetAttributeOfType<DescriptionAttribute>().Description,
                                    ArmorEnum.Shield.ToString()
                                },
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Str.ToString(),
                                    AbilitiesEnum.Dex.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = "Rogue",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 12,
                    Dex = 15,
                    Con = 10,
                    Int = 14,
                    Wis = 13,
                    Cha = 8
                },
                Description = "You are a scoundrel who uses stealth and trickery to overcome obstacles.",
                HitDice = 8,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Proficiencies = new ProficiencyModel
                            {
                                Armor = new string[]
                                {
                                    ArmorEnum.Light.GetAttributeOfType<DescriptionAttribute>().Description,
                                },
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Dex.ToString(),
                                    AbilitiesEnum.Int.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = "Sorceror",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 10,
                    Dex = 13,
                    Con = 14,
                    Int = 12,
                    Wis = 8,
                    Cha = 15
                },
                Description = "You are a spellcaster who draws on inherent magic from a gift or bloodline.",
                HitDice = 6,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Spellcasting",
                                    Description = new string[]
                                    {
                                        "Charisma is your spellcasting ability for your sorcerer spells. You use your Charisma whenever a spell refers to your spellcasting ability.",
                                        "To cast a spell, you must expend a slot of the spell’s level or higher. You regain all expended spell slots when you finish a long rest."
                                    },
                                    AbilityModifier = AbilitiesEnum.Cha.ToString(),
                                }
                            },
                            Proficiencies = new ProficiencyModel
                            {
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Con.ToString(),
                                    AbilitiesEnum.Cha.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = "Warlock",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 8,
                    Dex = 10,
                    Con = 14,
                    Int = 13,
                    Wis = 12,
                    Cha = 15
                },
                Description = "You are a wielder of magic that isderived from a bargain with an extraplanar entity.",
                HitDice = 8,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Spellcasting",
                                    Description = new string[]
                                    {
                                        "Charisma is your spellcasting ability for your warlock spells. You use your Charisma whenever a spell refers to your spellcasting ability.",
                                        "To cast a spell, you must expend a slot of the spell’s level or higher. You regain all expended spell slots when you finish a long rest."
                                    },
                                    AbilityModifier = AbilitiesEnum.Cha.ToString(),
                                }
                            },
                            Proficiencies = new ProficiencyModel
                            {
                                Armor = new string[]
                                {
                                    ArmorEnum.Light.GetAttributeOfType<DescriptionAttribute>().Description,
                                },
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Wis.ToString(),
                                    AbilitiesEnum.Cha.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = "Wizard",
                AbilityScores = new AbilityScoresModel
                {
                    Str = 8,
                    Dex = 14,
                    Con = 13,
                    Int = 15,
                    Wis = 12,
                    Cha = 10
                },
                Description = "You are a scholarly magic-user capable of maipulating the structures of reality.",
                HitDice = 6,
                Levels = new Dictionary<int, LevelModel>()
                {
                    {
                        1,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Spellcasting",
                                    Description = new string[]
                                    {
                                        "Intelligence is your spellcasting ability for your wizard spells. You use your Intelligence whenever a spell refers to your spellcasting ability.",
                                        "To cast a spell, you must expend a slot of the spell’s level or higher. You regain all expended spell slots when you finish a long or short rest."
                                    },
                                    AbilityModifier = AbilitiesEnum.Int.ToString(),
                                }
                            },
                            Proficiencies = new ProficiencyModel
                            {
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Int.ToString(),
                                    AbilitiesEnum.Wis.ToString(),
                                }
                            },
                        }
                    }
                },
            }
        };
    }
}
