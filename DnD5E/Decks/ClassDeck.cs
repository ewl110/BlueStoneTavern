using DnD5E.Enums;
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
                Name = ClassEnum.Barbarian.ToString(),
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
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Rage",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                },
                                new FeaturesModel
                                {
                                    Name = "Unarmored Defense",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
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
                                    AbilitiesEnum.Str.ToString(),
                                    AbilitiesEnum.Con.ToString(),
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.SimpleWeapon.GetAttributeOfType<DescriptionAttribute>().Description,
                                    WeaponsEnum.MartialWeapon.GetAttributeOfType<DescriptionAttribute>().Description
                                }
                            },
                            Rage = 2,
                            RageDamage = 2
                        }
                    },
                    {
                        2,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Danger Sense",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                },
                                new FeaturesModel
                                {
                                    Name = "Reckless Attack",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                }
                            },
                        }
                    },
                    {
                        3,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Primal Path",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                },
                            },
                            Rage = 3,
                            SetVariant = true,
                            Variants = new Dictionary<string, LevelModel>{
                                {
                                    ClassEnum.Berserker.ToString(),
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Frenzy",
                                                Description = new List<string>
                                                {
                                                    "Berserker feature"
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.TotemWarrior.ToString(),
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Spirit Seeker",
                                                Description = new List<string>
                                                {
                                                    "Totem warrior feature"
                                                }
                                            },
                                            new FeaturesModel
                                            {
                                                Name = "Totem spirit",
                                                Description = new List<string>
                                                {
                                                    "Totem warrior feature"
                                                }
                                            },
                                        },
                                    }
                                }
                            }
                        }
                    },
                    {
                        5,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Extra Attack",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                },
                                new FeaturesModel
                                {
                                    Name = "Fast Movement",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                },
                            },
                            Rage = 3
                        }
                    },
                    {
                        6,
                        new LevelModel
                        {
                            Rage = 4,
                            Variants = new Dictionary<string, LevelModel>{
                                {
                                    ClassEnum.Berserker.ToString(),
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Mindless Rage",
                                                Description = new List<string>
                                                {
                                                    "Berserker feature"
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.TotemWarrior.ToString(),
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Aspect of the Beast",
                                                Description = new List<string>
                                                {
                                                    "Totem warrior feature"
                                                }
                                            },
                                        },
                                    }
                                }
                            }
                        }
                    },
                    {
                        7,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Feral Instinct",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                },
                            },
                        }
                    },
                    {
                        9,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Brutal Critical",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                },
                            },
                            RageDamage = 3
                        }
                    },
                    {
                        10,
                        new LevelModel
                        {
                            Variants = new Dictionary<string, LevelModel>{
                                {
                                    ClassEnum.Berserker.ToString(),
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Intimidating Presence",
                                                Description = new List<string>
                                                {
                                                    "Berserker feature"
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.TotemWarrior.ToString(),
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Spirit Walker",
                                                Description = new List<string>
                                                {
                                                    "Totem warrior feature"
                                                }
                                            },
                                        },
                                    }
                                }
                            }
                        }
                    },
                    {
                        11,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Relentless Rage",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                },
                            },
                        }
                    },
                    {
                        12,
                        new LevelModel
                        {
                            Rage = 5
                        }
                    },
                    {
                        14,
                        new LevelModel
                        {
                            Variants = new Dictionary<string, LevelModel>{
                                {
                                    ClassEnum.Berserker.ToString(),
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Retaliation",
                                                Description = new List<string>
                                                {
                                                    "Berserker feature"
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.TotemWarrior.ToString(),
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Totemic Attunement",
                                                Description = new List<string>
                                                {
                                                    "Totem warrior feature"
                                                }
                                            },
                                        },
                                    }
                                }
                            }
                        }
                    },
                    {
                        15,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Persistent Rage",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                },
                            },
                        }
                    },
                    {
                        16,
                        new LevelModel
                        {
                            RageDamage = 4
                        }
                    },
                    {
                        17,
                        new LevelModel
                        {
                            Rage = 6
                        }
                    },
                    {
                        18,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Indomitable Might",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                },
                            },
                        }
                    },
                    {
                        20,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Primal Champion",
                                    Description = new List<string>
                                    {
                                        "Barbarian feature"
                                    }
                                },
                            },
                        }
                    },
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Bard.ToString(),
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
                Equipment = new List<EquipmentModel>
                {
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Dagger.ToString(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Dagger
                    },
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Rapier.ToString(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Rapier
                    },
                    new EquipmentModel
                    {
                        Name = ArmorEnum.Leather.ToString(),
                        Type = EquipmentTypeEnum.Armor,
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.EntertainersPack.GetAttributeOfType<DescriptionAttribute>().Description,
                        Type = EquipmentTypeEnum.Item,
                    },
                    new EquipmentModel
                    {
                        Name = ToolsEnum.selectInstrument.GetAttributeOfType<DescriptionAttribute>().Description,
                        Type = EquipmentTypeEnum.Tool,
                    },
                },
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
                                    Name = "Bardic Inspiration",
                                    Description = new List<string>
                                    {
                                        "You can inspire others through stirring words or music. To do so, you use a Bonus Action on Your Turn to choose one creature other than yourself within 60 feet of you who can hear you. That creature gains one Bardic Inspiration die, a d6.",
                                        "Once within the next 10 minutes, the creature can roll the die and add the number rolled to one ability check, Attack roll, or saving throw it makes. The creature can wait until after it rolls The D20 before deciding to use the Bardic Inspiration die, but must decide before the DM says whether the roll succeeds or fails. Once the Bardic Inspiration die is rolled, it is lost. A creature can have only one Bardic Inspiration die at a time.",
                                        "You can use this feature a number of times equal to your Charisma modifier (a minimum of once). You regain any expended uses when you finish a Long Rest.",
                                        "Your Bardic Inspiration die changes when you reach certain levels in this class. The die becomes a d8 at 5th level, a d10 at 10th level, and a d12 at 15th level.",
                                    },
                                    Action = new ActionModel
                                    {
                                        Name = "Bardic Inspiration",
                                        Description = "Bard feature",
                                        Type = ActionTypesEnum.Bonus.ToString()
                                    },
                                },
                                new FeaturesModel
                                {
                                    Name = "Spellcasting",
                                    Description = new List<string>
                                    {
                                        "Charisma is your Spellcasting ability for your bard Spells. Your magic comes from the heart and soul you pour into the Performance of your music or oration. You use your Charisma whenever a spell refers to your Spellcasting ability. In addition, you use your Charisma modifier when Setting the saving throw DC for a bard spell you cast and when Making an Attack roll with one."
                                    },
                                    AbilityModifier = AbilitiesEnum.Cha.ToString()
                                },
                            },
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
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.SimpleWeapon.GetAttributeOfType<DescriptionAttribute>().Description,
                                    WeaponsEnum.Longsword.ToString(),
                                    WeaponsEnum.Rapier.ToString(),
                                    WeaponsEnum.Shortsword.ToString(),
                                    WeaponsEnum.CrossbowHand.GetAttributeOfType<DescriptionAttribute>().Description
                                }
                            },
                        }
                    },
                    {
                        2,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Jack of All Trades",
                                    Description = new List<string>
                                    {
                                        "Starting at 2nd level, you can add half your proficiency bonus, rounded down, to any ability check you make that doesn't already include your proficiency bonus."
                                    }
                                },
                                new FeaturesModel
                                {
                                    Name = "Song of Rest",
                                    Description = new List<string>
                                    {
                                        "Beginning at 2nd level, you can use soothing music or oration to help revitalize your wounded allies during a Short Rest. If you or any friendly creatures who can hear your Performance regain Hit Points by spending Hit Dice at the end of the Short Rest, each of those creatures regains an extra 1d6 Hit Points.",
                                        "The extra Hit Points increase when you reach certain levels in this class: to 1d8 at 9th level, to 1d10 at 13th level, and to 1d12 at 17th level."
                                    },
                                    AbilityModifier = AbilitiesEnum.Cha.ToString()
                                },
                            },
                        }
                    },
                    {
                        3,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Bardic College",
                                    Description = new List<string>
                                    {
                                        "Select yoru college of expertise."
                                    }
                                },
                                new FeaturesModel
                                {
                                    Name = "Expertise",
                                    Description = new List<string>
                                    {
                                        "At 3rd level, choose two of your skill proficiencies. Your proficiency bonus is doubled for any ability check you make that uses either of the chosen proficiencies.",
                                        "At 10th level, you can choose another two skill proficiencies to gain this benefit."
                                    }
                                },
                            },
                            SetVariant = true,
                            Variants = new Dictionary<string, LevelModel>{
                                {
                                    ClassEnum.CollegeOfLore.ToString(),
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Bonus Proficiencies",
                                                Description = new List<string>
                                                {
                                                    "When you join the College of Lore at 3rd level, you gain proficiency with three Skills of your choice."
                                                },
                                            },
                                            new FeaturesModel
                                            {
                                                Name = "Cutting Words",
                                                Description = new List<string>
                                                {
                                                    "Also at 3rd level, you learn how to use your wit to distract, confuse, and otherwise sap the confidence and competence of others. When a creature that you can see within 60 feet of you makes an Attack roll, an ability check, or a damage roll, you can use your reaction to expend one of your uses of Bardic Inspiration, rolling a Bardic Inspiration die and subtracting the number rolled from the creature’s roll. You can choose to use this feature after the creature makes its roll, but before the GM determines whether the Attack roll or ability check succeeds or fails, or before the creature deals its damage. The creature is immune if it can’t hear you or if it’s immune to being Charmed."
                                                },
                                            }
                                        },
                                        Proficiencies = new ProficiencyModel
                                        {
                                            Skills = new string[]
                                            {
                                                SkillsEnum.SelectSkill.ToString(),
                                                SkillsEnum.SelectSkill.ToString(),
                                                SkillsEnum.SelectSkill.ToString(),
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    },
                    {
                        5,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Font of Inspiration",
                                    Description = new List<string>
                                    {
                                        "Beginning when you reach 5th level, you regain all of your expended uses of Bardic Inspiration when you finish a short or Long Rest."
                                    }
                                },
                            },
                        }
                    },
                    {
                        6,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Countercharm",
                                    Description = new List<string>
                                    {
                                        "At 6th level, you gain the ability to use musical notes or words of power to disrupt mind-influencing effects. As an action, you can start a Performance that lasts until the end of your next turn. During that time, you and any friendly creatures within 30 feet of you have advantage on Saving Throws against being Frightened or Charmed. A creature must be able to hear you to gain this benefit. The Performance ends early if you are Incapacitated or silenced or if you voluntarily end it (no action required)."
                                    },
                                    Action = new ActionModel
                                    {
                                        Name = "Countercharm",
                                        Description = "Bard feature",
                                        Type = ActionTypesEnum.Option.ToString()
                                    }
                                },
                            },
                            Variants = new Dictionary<string, LevelModel>{
                                {
                                    ClassEnum.CollegeOfLore.ToString(),
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Additional Magical Secrets",
                                                Description = new List<string>
                                                {
                                                    "At 6th level, you learn two Spells of your choice from any class. A spell you choose must be of a level you can cast, as shown on the Bard table, or a cantrip.",
                                                    "The chosen Spells count as bard Spells for you but don’t count against the number of bard Spells you know."
                                                },
                                            }
                                        },
                                    }
                                }
                            }
                        }
                    },
                    {
                        10,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Magical Secrets",
                                    Description = new List<string>
                                    {
                                        "By 10th level, you have plundered magical knowledge from a wide spectrum of disciplines. Choose two Spells from any class, including this one. A spell you choose must be of a level you can cast, as shown on the Bard table, or a cantrip.",
                                        "The chosen Spells count as bard Spells for you and are included in the number in the Spells Known column of the Bard table.",
                                        "You learn two additional Spells from any class at 14th level and again at 18th level."
                                    },
                                },
                            },
                        }
                    },
                    {
                        14,
                        new LevelModel
                        {
                            Variants = new Dictionary<string, LevelModel>{
                                {
                                    ClassEnum.CollegeOfLore.ToString(),
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Peerless Skill",
                                                Description = new List<string>
                                                {
                                                    "Starting at 14th level, when you make an ability check, you can expend one use of Bardic Inspiration. Roll a Bardic Inspiration die and add the number rolled to your ability check. You can choose to do so after you roll the die for the ability check, but before the GM tells you whether you succeed or fail."
                                                },
                                            }
                                        },
                                    }
                                }
                            }
                        }
                    },
                    {
                        20,
                        new LevelModel
                        {
                            Features = new List<FeaturesModel>
                            {
                                new FeaturesModel
                                {
                                    Name = "Superior Inspiration",
                                    Description = new List<string>
                                    {
                                        "At 20th level, when you roll initiative and have no uses of Bardic Inspiration left, you regain one use."
                                    },
                                },
                            },
                        }
                    },
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Cleric.ToString(),
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
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.SimpleWeapon.GetAttributeOfType<DescriptionAttribute>().Description,
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Druid.ToString(),
                AbilityScores = new AbilityScoresModel
                {
                    Str = 13,
                    Dex = 8,
                    Con = 14,
                    Int = 10,
                    Wis = 15,
                    Cha = 12
                },
                Description = "You are a priest of the Old Faith, wielding the powers of nature - moonlight and plant growth, fire and lightning - and adopting animal forms.",
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
                                    Description = new List<string>
                                    {
                                        "Wisdom is your spellcasting ability for your druid spells. You use your Wisdom whenever a spell refers to your spellcasting ability.",
                                        "To cast a spell, you must expend a slot of the spell’s level or higher. You regain all expended spell slots when you finish a long rest."
                                    },
                                    AbilityModifier = AbilitiesEnum.Wis.ToString(),
                                    Action = new ActionModel
                                    {
                                        Name = "Spellcasting",
                                        Description = "Druid feature",
                                        Type = ActionTypesEnum.Attack.ToString(),
                                        Weapon = WeaponsEnum.None
                                    }
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
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.Club.ToString(),
                                    WeaponsEnum.Dagger.ToString(),
                                    WeaponsEnum.Dart.ToString(),
                                    WeaponsEnum.Javelin.ToString(),
                                    WeaponsEnum.Mace.ToString(),
                                    WeaponsEnum.Quarterstaff.ToString(),
                                    WeaponsEnum.Scimitar.ToString(),
                                    WeaponsEnum.Sickle.ToString(),
                                    WeaponsEnum.Sling.ToString(),
                                    WeaponsEnum.Spear.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Fighter.ToString(),
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
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.SimpleWeapon.GetAttributeOfType<DescriptionAttribute>().Description,
                                    WeaponsEnum.MartialWeapon.GetAttributeOfType<DescriptionAttribute>().Description
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Monk.ToString(),
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
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.SimpleWeapon.GetAttributeOfType<DescriptionAttribute>().Description,
                                    WeaponsEnum.Shortsword.ToString(),
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Paladin.ToString(),
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
                                    AbilitiesEnum.Wis.ToString(),
                                    AbilitiesEnum.Cha.ToString(),
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.SimpleWeapon.GetAttributeOfType<DescriptionAttribute>().Description,
                                    WeaponsEnum.MartialWeapon.GetAttributeOfType<DescriptionAttribute>().Description
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Ranger.ToString(),
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
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.SimpleWeapon.GetAttributeOfType<DescriptionAttribute>().Description,
                                    WeaponsEnum.MartialWeapon.GetAttributeOfType<DescriptionAttribute>().Description
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Rogue.ToString(),
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
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.SimpleWeapon.GetAttributeOfType<DescriptionAttribute>().Description,
                                    WeaponsEnum.Longsword.ToString(),
                                    WeaponsEnum.Rapier.ToString(),
                                    WeaponsEnum.Shortsword.ToString(),
                                    WeaponsEnum.CrossbowHand.GetAttributeOfType<DescriptionAttribute>().Description
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Sorcerer.ToString(),
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
                Equipment = new List<EquipmentModel>
                {
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Dagger.ToString(),
                        Quantity = 2,
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Dagger
                    },
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Dart.ToString(),
                        Quantity = 20,
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Dart
                    },
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Quarterstaff.ToString(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Quarterstaff
                    },
                    new EquipmentModel
                    {
                        Name = ToolsEnum.drum.ToString(),
                        Description = "A drum crafted from a bear's skull",
                        Type = EquipmentTypeEnum.Tool
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.HuntingTrap.GetAttributeOfType<DescriptionAttribute>().Description,
                        Type = EquipmentTypeEnum.Item
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.TravelersClothes.GetAttributeOfType<DescriptionAttribute>().Description,
                        Type = EquipmentTypeEnum.Item
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.ExlporersPack.GetAttributeOfType<DescriptionAttribute>().Description,
                        Type = EquipmentTypeEnum.Item
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.ComponentPouch.GetAttributeOfType<DescriptionAttribute>().Description,
                        Type = EquipmentTypeEnum.Item
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.BeltPouch.GetAttributeOfType<DescriptionAttribute>().Description,
                        Type = EquipmentTypeEnum.Item
                    },
                },
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
                                    Description = new List<string>
                                    {
                                        "Charisma is your spellcasting ability for your sorcerer spells. You use your Charisma whenever a spell refers to your spellcasting ability.",
                                        "To cast a spell, you must expend a slot of the spell’s level or higher. You regain all expended spell slots when you finish a long rest."
                                    },
                                    AbilityModifier = AbilitiesEnum.Cha.ToString(),
                                    Action = new ActionModel
                                    {
                                        Name = "Spellcasting",
                                        Description = "Sorcerer feature",
                                        Type = ActionTypesEnum.Attack.ToString(),
                                        Weapon = WeaponsEnum.None
                                    }
                                }
                            },
                            Proficiencies = new ProficiencyModel
                            {
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Con.ToString(),
                                    AbilitiesEnum.Cha.ToString(),
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.Dagger.ToString(),
                                    WeaponsEnum.Dart.ToString(),
                                    WeaponsEnum.Sling.ToString(),
                                    WeaponsEnum.Quarterstaff.ToString(),
                                    WeaponsEnum.CrossbowLight.GetAttributeOfType<DescriptionAttribute>().Description
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Warlock.ToString(),
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
                                    Description = new List<string>
                                    {
                                        "Charisma is your spellcasting ability for your warlock spells. You use your Charisma whenever a spell refers to your spellcasting ability.",
                                        "To cast a spell, you must expend a slot of the spell’s level or higher. You regain all expended spell slots when you finish a long rest."
                                    },
                                    AbilityModifier = AbilitiesEnum.Cha.ToString(),
                                    Action = new ActionModel
                                    {
                                        Name = "Spellcasting",
                                        Description = "Warlock feature",
                                        Type = ActionTypesEnum.Attack.ToString(),
                                        Weapon = WeaponsEnum.None
                                    }
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
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.SimpleWeapon.GetAttributeOfType<DescriptionAttribute>().Description,
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Wizard.ToString(),
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
                                    Description = new List<string>
                                    {
                                        "Intelligence is your spellcasting ability for your wizard spells. You use your Intelligence whenever a spell refers to your spellcasting ability.",
                                        "To cast a spell, you must expend a slot of the spell’s level or higher. You regain all expended spell slots when you finish a long or short rest."
                                    },
                                    AbilityModifier = AbilitiesEnum.Int.ToString(),
                                    Action = new ActionModel
                                    {
                                        Name = "Spellcasting",
                                        Description = "Wizard feature",
                                        Type = ActionTypesEnum.Attack.ToString(),
                                        Weapon = WeaponsEnum.None
                                    }
                                }
                            },
                            Proficiencies = new ProficiencyModel
                            {
                                SavingThrows = new string[]
                                {
                                    AbilitiesEnum.Int.ToString(),
                                    AbilitiesEnum.Wis.ToString(),
                                },
                                Weapons = new string[]
                                {
                                    WeaponsEnum.Dagger.ToString(),
                                    WeaponsEnum.Dart.ToString(),
                                    WeaponsEnum.Sling.ToString(),
                                    WeaponsEnum.Quarterstaff.ToString(),
                                    WeaponsEnum.CrossbowLight.GetAttributeOfType<DescriptionAttribute>().Description
                                }
                            },
                        }
                    }
                },
            }
        };
    }
}
