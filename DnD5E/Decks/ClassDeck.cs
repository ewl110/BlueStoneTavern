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
                Description = "You are a fierce warrior of primitive background who can enter a battle rage.",
                Equipment = new List<EquipmentModel>
                {
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Greataxe.ToString(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Greataxe
                    },
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Handaxe.ToString(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Handaxe,
                        Quantity = 2
                    },
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Javelin.ToString(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Javelin,
                        Quantity = 4
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.ExlporersPack.GetAttributeOfType<DescriptionAttribute>().Description,
                        Type = EquipmentTypeEnum.Item,
                    },
                },
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
                                        "On your turn, you can enter a rage as a bonus action. While raging, you gain the following benefits if you aren't wearing heavy armor:",
                                        "You have advantage on all Strength checks and Strength saving throws.<br />When you make a melee weapon attack using Strength, you gain a bonus to the damage roll that increases as you gain levels as a barbarian, as shown in the Rage Damage column of the Barbarian table.<br />You have resistance to bludgeoning, piercing, and slashing damage.",
                                        "If you are able to cast spells, you can't cast them or concentrate on them while raging.",
                                        "Your rage lasts for 1 minute. It ends early if you are knocked unconscious or if your turn ends and you haven't attacked a hostile creature since your last turn or taken damage since then. You can also end your rage on your turn as a bonus action.",
                                        "Once you have raged the number of times shown for your barbarian level in the Rages column of the Barbarian table, you must finish a long rest before you can rage again."
                                    },
                                    Action = new ActionModel
                                    {
                                        Name = "Rage",
                                        Description = "Barbarian feature",
                                        Type = ActionTypesEnum.Bonus
                                    },
                                },
                                new FeaturesModel
                                {
                                    Name = "Unarmored Defense",
                                    Description = new List<string>
                                    {
                                        "While you are not wearing any armor, your Armor Class equals 10 + your Dexterity modifier + your Constitution modifier. You can use a shield and still gain this benefit."
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
                                        "At 2nd level, you have advantage on Dexterity saving throws against effects that you can see, such as traps or spells. You do not gain this benefit if you are blinded, deafened, or incapacitated."
                                    }
                                },
                                new FeaturesModel
                                {
                                    Name = "Reckless Attack",
                                    Description = new List<string>
                                    {
                                        "Starting at 2nd level, when you make your first attack on your turn, you can decide to attack recklessly. Doing so gives you advantage on all melee weapon attack rolls using Strength during that turn, but attack rolls against you are rolled with advantage until the beginning of your next turn."
                                    },
                                    Action = new ActionModel
                                    {
                                        Name = "Reckless Attack",
                                        Description = "Barbarian feature",
                                        Type = ActionTypesEnum.Attack,
                                    },
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
                            Variants = new Dictionary<ClassEnum, LevelModel>{
                                {
                                    ClassEnum.PathOfTheAncestralGuardian,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Ancestral Protectors",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, while you're raging, the first creature you hit with an attack on your turn becomes the target of spiritual warriors, which hinder its attacks. Until the start of your next turn, that target has disadvantage on any attack roll that isn't against you, and when the target hits a creature other than you with an attack, that creature has resistance to the damage dealt by the attack. The effect on the target ends early if your rage ends."
                                                }
                                            }

                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheBerserker,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Frenzy",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, you can go into a frenzy when you rage. If you do so, for the duration of your rage you can make a single melee weapon attack as a bonus action on each of your turns after this one. When the rage ends you gain one level of exhaustion."
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheStormHerald,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Storm Aura",
                                                Description = new List<string>
                                                {
                                                    "Starting at 3rd level, you emanate an aura while you rage. The aura extends 10 feet from you in every direction, but not through total cover.",
                                                    "Your aura has an effect that activates when you enter your rage, and you can activate the effect again on each of your turns as a bonus action. Choose desert, sea, or tundra. Your aura's effect depends on that chosen environment. You can change your environment choice whenever you gain a level in this class.",
                                                    "If your aura's effects require a saving throw, the DC equals 8 + your proficiency bonus + your Constitution modifier.",
                                                    "<b>Desert:</b> All other creatures in your aura take 2 fire damage each. The damage increases when you reach certain levels in this class, increasing to 3 at 5th level, 4 at 10th level, 5 at 15th level, and 6 at 20th level.<br /><b>Sea:</b> You can choose one other creature you can see in your aura. The target must make a Dexterity saving throw. The target takes 1d6 lightning damage on a failed save, or half as much damage on a successful one. The damage increases when you reach certain levels in this class, increasing to 2d6 at 10th level, 3d6 at 15th level, and 4d6 at 20th level.<br /><b>Tundra:</b> Each creature of your choice in your aura gains 2 temporary hit points, as icy spirits inure it to suffering. The temporary hit points increase when you reach certain levels in this class, increasing to 3 at 5th level, 4 at 10th level, 5 at 15th level, and 6 at 20th level.  ",
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheTotemWarrior,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Spirit Seeker",
                                                Description = new List<string>
                                                {
                                                    "You gain the ability to cast the Beast Sense and Speak with Animals spells, but only as rituals."
                                                }
                                            },
                                            new FeaturesModel
                                            {
                                                Name = "Totem spirit",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, when you adopt this path, you choose a totem spirit and gain its feature. You must make or acquire a physical totem object that incorporates a part of the totem animal. At your option, you also gain minor physical attributes that are reminiscent of your totem spirit.",
                                                    "Your totem animal might be an animal related to those listed here but more appropriate to your homeland.",
                                                    "<b>Bear:</b> While raging you have resistance to all damage except psychic damage.<br /><b>Eagle:</b> While you're raging and aren't wearing heavy armor, other creatures have disadvantage on opportunity attack rolls against you, you can also use the Dash action as a bonus action on your turn.<br/><b>Wolf:</b> While you're raging, your friends have advantage on melee attack rolls against any creature within 5 feet of you that is hostile to you.<br /><b>Elk (SCAG):</b> While you're raging and aren't wearing heavy armor, your walking speed increases by 15 feet.<br /><b>Tiger (SCAG):</b> While raging, you can add 10 feet to your long jump distance and 3 feet to your high jump distance.",
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheZealot,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Divine Fury",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, while you're raging, the first creature you hit on each of your turns with a weapon attack takes extra damage equal to 1d6 + half your barbarian level. The extra damage is necrotic or radiant; you choose the type of damage when you gain this feature."
                                                }
                                            },
                                            new FeaturesModel
                                            {
                                                Name = "Warrior of the Gods",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, if a spell has the sole effect of restoring you to life (but not undeath), the caster doesn't need material components to cast the spell on you."
                                                }
                                            },
                                        },
                                    }
                                },
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
                                        "Beginning at 5th level, you can attack twice, instead of once, whenever you take the Attack action on your turn."
                                    }
                                },
                                new FeaturesModel
                                {
                                    Name = "Fast Movement",
                                    Description = new List<string>
                                    {
                                        "Starting at 5th level, your speed increases by 10 feet while you aren't wearing heavy armor."
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
                            Variants = new Dictionary<ClassEnum, LevelModel>{
                                {
                                    ClassEnum.PathOfTheAncestralGuardian,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Spirit Shield",
                                                Description = new List<string>
                                                {
                                                    "Beginning at 6th level, if you are raging and another creature you can see within 30 feet of you takes damage, you can use your reaction to reduce that damage by 2d6.",
                                                    "When you reach certain levels in this class, you can reduce the damage by more: by 3d6 at 10th level and by 4d6 at 14th level."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Spirit Shield",
                                                    Description = "Path of the Ancestral Guardian feature",
                                                    Type = ActionTypesEnum.Reaction
                                                }
                                            }

                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheBerserker,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Mindless Rage",
                                                Description = new List<string>
                                                {
                                                    "Beginning at 6th level, you can't be charmed or frightened while raging. If you are charmed or frightened when you enter your rage, the effect is suspended for the duration of the rage."
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheStormHerald,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Storm Soul",
                                                Description = new List<string>
                                                {
                                                    "At 6th level, the storm grants you benefits even when your aura isn't active.",
                                                    "<b>Desert:</b> You gain resistance to fire damage, and you don't suffer the effects of extreme heat. Moreover, as an action, you can touch a flammable object that isn't being worn or carried by anyone else and set it on fire.<br /><b>Sea:</b> You gain resistance to lightning damage, and you can breathe underwater. You also gain a swimming speed of 30 feet.<br /><b>Tundra:</b> You gain resistance to cold damage, and you don't suffer the effects of extreme cold. Moreover, as an action, you can touch water and turn a 5-foot cube of it into ice, which melts after 1 minute. This action fails if a creature is in the cube.",
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheTotemWarrior,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Aspect of the Beast",
                                                Description = new List<string>
                                                {
                                                    "At 6th level, you gain a magical benefit based on the totem animal of your choice. You can choose the same animal you selected at 3rd level or a different one.",
                                                    "<b>Bear:</b> Your carrying capacity (including maximum load and maximum lift) is doubled and you have advantage on Strength checks made to push, pull, lift, or break objects.<br /><b>Eagle:</b> You can see up to 1 mile away with no difficulty. You are able to discern even fine details as though looking at something no more than 100 feet away from you. Additionally, dim light doesn't impose disadvantage on your Wisdom (Perception) checks.<br/><b>Wolf:</b> You can track other creatures while traveling at a fast pace, and you can move stealthily while traveling at a normal pace.<br /><b>Elk (SCAG):</b> Whether mounted or on foot, your travel pace is doubled, as is the travel pace of up to ten companions while they're within 60 feet of you and you're not incapacitated.<br /><b>Tiger (SCAG):</b> You gain proficiency in two skills from the following list: Athletics, Acrobatics, Stealth, and Survival.",
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheZealot,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Fanatical Focus",
                                                Description = new List<string>
                                                {
                                                    "Starting at 6th level, if you fail a saving throw while you're raging, you can reroll it, and you must use the new roll. You can use this ability only once per rage."
                                                }
                                            },
                                        },
                                    }
                                },
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
                                        "By 7th level, you have advantage on initiative rolls.",
                                        "Additionally, if you are surprised at the beginning of combat and aren't incapacitated, you can act normally on your first turn, but only if you enter your rage before doing anything else on that turn."
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
                                        "Beginning at 9th level, you can roll one additional weapon damage die when determining the extra damage for a critical hit with a melee attack.",
                                        "This increases to two additional dice at 13th level and three additional dice at 17th level."
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
                            Variants = new Dictionary<ClassEnum, LevelModel>{
                                {
                                    ClassEnum.PathOfTheAncestralGuardian,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Consult the Spirits",
                                                Description = new List<string>
                                                {
                                                    "At 10th level, you cast the Augury or Clairvoyance spell, without using a spell slot or material components. Rather than creating a spherical sensor, it invisibly summons one of your ancestral spirits to the chosen location. Wisdom is your spellcasting ability for these spells.",
                                                    "After you cast either spell in this way, you can't use this feature again until you finish a short or long rest."
                                                }
                                            }

                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheBerserker,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Intimidating Presence",
                                                Description = new List<string>
                                                {
                                                    "Beginning at 10th level, you can use your action to frighten someone. Choose one creature that you can see within 30 feet of you. If the creature can see or hear you, it must succeed on a Wisdom saving throw (DC equal to 8 + your proficiency bonus + your Charisma modifier) or be frightened of you until the end of your next turn. On subsequent turns, you can use your action to extend the duration of this effect on the frightened creature until the end of your next turn. This effect ends if the creature ends its turn out of line of sight or more than 60 feet away from you.",
                                                    "If the creature succeeds on its saving throw, you can't use this feature on that creature again for 24 hours."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Intimidating Presence",
                                                    Description = "Path of the Berserker feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheStormHerald,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Shielding Storm",
                                                Description = new List<string>
                                                {
                                                    "At 10th level, each creature of your choice has the damage resistance you gained from the Storm Soul feature while the creature is in your Storm Aura. ",
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheTotemWarrior,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Spirit Walker",
                                                Description = new List<string>
                                                {
                                                    "At 10th level, you can cast the Commune with Nature spell, but only as a ritual.",
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheZealot,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Zealous Presence",
                                                Description = new List<string>
                                                {
                                                    "At 10th level, as a bonus action, you unleash a battle cry infused with divine energy. Up to ten other creatures of your choice within 60 feet of you that can hear you gain advantage on attack rolls and saving throws until the start of your next turn.",
                                                    "Once you use this feature, you can't use it again until you finish a long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "ZealousPresence",
                                                    Description = "Path of the Zealot feature",
                                                    Type = ActionTypesEnum.Bonus
                                                }
                                            },
                                        },
                                    }
                                },
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
                                        "Starting at 11th level, if you drop to 0 hit points while you're raging and don't die outright, you can make a DC 10 Constitution saving throw. If you succeed, you drop to 1 hit point instead.",
                                        "Each time you use this feature after the first, the DC increases by 5. When you finish a short or long rest, the DC resets to 10."
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
                            Variants = new Dictionary<ClassEnum, LevelModel>{
                                {
                                    ClassEnum.PathOfTheAncestralGuardian,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Vengeful Ancestors",
                                                Description = new List<string>
                                                {
                                                    "At 14th level, when you use your Spirit Shield to reduce the damage of an attack, the attacker takes an amount of force damage equal to the damage that your Spirit Shield prevents."
                                                }
                                            }

                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheBerserker,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Retaliation",
                                                Description = new List<string>
                                                {
                                                    "Starting at 14th level, when you take damage from a creature that is within 5 feet of you, you can use your reaction to make a melee weapon attack against that creature."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Retaliation",
                                                    Description = "Path of the Berserker feature",
                                                    Type = ActionTypesEnum.Reaction
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheStormHerald,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Raging Storm",
                                                Description = new List<string>
                                                {
                                                    "At 14th level, the power of the storm grows mightier.",
                                                    "<b>Desert:</b> Immediately after a creature in your aura hits you with an attack, you can use your reaction to force that creature to make a Dexterity saving throw. On a failed save, the creature takes fire damage equal to half your barbarian level.<br /><b>Sea:</b> When you hit a creature in your aura with an attack, you can use your reaction to force that creature to make a Strength saving throw. On a failed save, the creature is knocked prone, as if struck by a wave.<br /><b>Tundra:</b> Whenever the effect of your Storm Aura is activated, you can choose one creature you can see in the aura. That creature must succeed on a Strength saving throw, or its speed is reduced to 0 until the start of your next turn, as magical frost covers it.",
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheTotemWarrior,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Totemic Attunement",
                                                Description = new List<string>
                                                {
                                                    "At 14th level you gain a magical benefit based on a totem animal of your choice. You can choose the same animal you selected previously or a different one.",
                                                    "<b>Bear:</b> While you're raging any creature within 5 feet of you that's hostile to you has disadvantage on attack rolls against targets other than you or another character with this feature. An enemy is immune to this effect if it can't see or hear you or if it can't be frightened.<br /><b>Eagle:</b> While raging you have a flying speed equal to your current walking speed. This benefit works only in short bursts; you fall if you end your turn in the air and nothing else is holding you aloft.<br/><b>Wolf:</b>While you're raging you can use a bonus action on your turn to knock a Large or smaller creature prone when you hit it with melee weapon attack.<br /><b>Elk (SCAG):</b> While raging, you can use a bonus action during your move to pass through the space of a Large or smaller creature. That creature must succeed on a Strength saving throw (DC 8 + your Strength bonus + your proficiency bonus) or be knocked prone and take bludgeoning damage equal to 1d12 + your Strength modifier.<br /><b>Tiger (SCAG):</b> While you're raging, if you move at least 20 feet in a straight line toward a Large or smaller target right before making a melee weapon attack against it, you can use a bonus action to make an additional melee weapon attack against it.",
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.PathOfTheZealot,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Rage Beyond Death",
                                                Description = new List<string>
                                                {
                                                    "Beginning at 14th level, while you're raging, having 0 hit points doesn't knock you unconscious. You still must make death saving throws, and you suffer the normal effects of taking damage while at 0 hit points. However, if you would die due to failing death saving throws, you don't die until your rage ends, and you die then only if you still have 0 hit points."
                                                }
                                            },
                                        },
                                    }
                                },
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
                                        "Beginning at 15th level, your rage ends early only if you fall unconscious or if you choose to end it."
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
                                        "Beginning at 18th level, if your total for a Strength check is less than your Strength score, you can use that score in place of the total."
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
                                        "At 20th level, you embody the power of the wilds. Your Strength and Constitution scores increase by 4. Your maximum for those scores is now 24."
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
                                        Type = ActionTypesEnum.Bonus
                                    },
                                },
                                new FeaturesModel
                                {
                                    Name = "Spellcasting",
                                    Description = new List<string>
                                    {
                                        "Charisma is your Spellcasting ability for your bard Spells. Your magic comes from the heart and soul you pour into the Performance of your music or oration. You use your Charisma whenever a spell refers to your Spellcasting ability. In addition, you use your Charisma modifier when Setting the saving throw DC for a bard spell you cast and when Making an Attack roll with one.",
                                        "You know two cantrips of your choice from the bard spell list. You learn additional bard cantrips of your choice at higher levels, learning a 3rd cantrip at 4th level and a 4th at 10th level.",
                                        "You know four 1st-level spells of your choice from the bard spell list. You learn an additional bard spell of your choice at each level except 12th, 16th, 19th, and 20th. Each of these spells must be of a level for which you have spell slots.",
                                        "Additionally, when you gain a level in this class, you can choose one of the bard spells you know and replace it with another spell from the bard spell list, which also must be of a level for which you have spell slots.",
                                        "You can cast any bard spell you know as a <b>ritual</b> if that spell has the ritual tag.",
                                        "You can use a musical instrument as a <b>spellcasting focus</b> for your bard spells."
                                    },
                                    AbilityModifier = AbilitiesEnum.Cha.ToString(),
                                    Action = new ActionModel
                                    {
                                        Name = "Spellcasting",
                                        Description = "Bard feature",
                                        Type = ActionTypesEnum.Attack
                                    }
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
                                    AbilityModifier = AbilitiesEnum.Cha.ToString(),
                                    Action = new ActionModel
                                    {
                                        Name = "Song of Rest",
                                        Description = "Bard feature",
                                        Type = ActionTypesEnum.Option
                                    }
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
                            Variants = new Dictionary<ClassEnum, LevelModel>{
                                {
                                    ClassEnum.CollegeOfLore,
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
                                                Action = new ActionModel
                                                {
                                                    Name = "Cutting Words",
                                                    Description = "College of Lore feature",
                                                    Type = ActionTypesEnum.Reaction
                                                }
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
                                        Type = ActionTypesEnum.Option
                                    }
                                },
                            },
                            Variants = new Dictionary<ClassEnum, LevelModel>{
                                {
                                    ClassEnum.CollegeOfLore,
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
                            Variants = new Dictionary<ClassEnum, LevelModel>{
                                {
                                    ClassEnum.CollegeOfLore,
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
                                        Type = ActionTypesEnum.Attack,
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
                                        Type = ActionTypesEnum.Attack,
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
                                        Type = ActionTypesEnum.Attack,
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
                                        Type = ActionTypesEnum.Attack,
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
