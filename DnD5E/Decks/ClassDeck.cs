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
                Name = ClassEnum.Barbarian.GetEnumText(),
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
                        Name = WeaponsEnum.Greataxe.GetEnumText(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Greataxe
                    },
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Handaxe.GetEnumText(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Handaxe,
                        Quantity = 2
                    },
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Javelin.GetEnumText(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Javelin,
                        Quantity = 4
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.ExlporersPack.GetEnumText(),
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
                                Armor = new List<ArmorEnum>
                                {
                                    ArmorEnum.Light,
                                    ArmorEnum.Medium,
                                    ArmorEnum.Shield
                                },
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Str,
                                    AbilitiesEnum.Con,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.SimpleWeapon,
                                    WeaponsEnum.MartialWeapon
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
                Name = ClassEnum.Bard.GetEnumText(),
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
                        Name = WeaponsEnum.Dagger.GetEnumText(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Dagger
                    },
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Rapier.GetEnumText(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Rapier
                    },
                    new EquipmentModel
                    {
                        Name = ArmorEnum.Leather.GetEnumText(),
                        Type = EquipmentTypeEnum.Armor,
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.EntertainersPack.GetEnumText(),
                        Type = EquipmentTypeEnum.Item,
                    },
                    new EquipmentModel
                    {
                        Name = ToolsEnum.selectInstrument.GetEnumText(),
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
                                    AbilityModifier = AbilitiesEnum.Cha,
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
                                Armor = new List<ArmorEnum>
                                {
                                    ArmorEnum.Light,
                                },
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Dex,
                                    AbilitiesEnum.Cha,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.SimpleWeapon,
                                    WeaponsEnum.Longsword,
                                    WeaponsEnum.Rapier,
                                    WeaponsEnum.Shortsword,
                                    WeaponsEnum.CrossbowHand
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
                                    AbilityModifier = AbilitiesEnum.Cha,
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
                            Variants = new Dictionary<ClassEnum, LevelModel>
                            {
                                {
                                    ClassEnum.CollegeOfGlamour,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Mantle of Inspiration",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, as a bonus action, you can expend one use of your Bardic Inspiration to grant yourself a wondrous appearance. When you do so, choose a number of creatures you can see and that can see you within 60 feet of you, up to a number equal to your Charisma modifier (minimum of one). Each of them gains 5 temporary hit points. When a creature gains these temporary hit points, it can immediately use its reaction to move up to its speed, without provoking opportunity attacks.",
                                                    "The number of temporary hit points increases when you reach certain levels in this class, increasing to 8 at 5th level, 11 at 10th level, and 14 at 15th level."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Mantle of Inspiration",
                                                    Description = "College of Glamour feature",
                                                    Type = ActionTypesEnum.Bonus
                                                }
                                            },
                                            new FeaturesModel
                                            {
                                                Name = "Enthralling Performance",
                                                Description = new List<string>
                                                {
                                                    "Starting at 3rd level, if you perform for at least 1 minute, you can attempt to inspire wonder in your audience. At the end of the performance, choose a number of humanoids within 60 feet of you who watched and listened to all of it, up to a number equal to your Charisma modifier (minimum of one). Each target must succeed on a Wisdom saving throw against your spell save DC or be charmed by you. While charmed in this way, the target idolizes you, it speaks glowingly of you to anyone who talks to it, and it hinders anyone who opposes you, although it avoids violence unless it was already inclined to fight on your behalf. This effect ends on a target after 1 hour, if it takes any damage, if you attack it, or if it witnesses you attacking or damaging any of its allies.",
                                                    "If a target succeeds on its saving throw, the target has no hint that you tried to charm it.",
                                                    "Once you use this feature, you can't use it again until you finish a short or long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Enthralling Performance",
                                                    Description = "College of Glamour feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            }
                                        },
                                    }
                                },
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
                                            Skills = new List<SkillsEnum>
                                            {
                                                SkillsEnum.SelectSkill,
                                                SkillsEnum.SelectSkill,
                                                SkillsEnum.SelectSkill,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.CollegeOfSwords,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Bonus Proficiencies",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, you gain proficiency with medium armor and the scimitar."
                                                }
                                            },
                                            new FeaturesModel
                                            {
                                                Name = "Fighting Style",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, choose one of the following options. You can't take a Fighting Style option more than once, even if something in the game lets you choose again.",
                                                    "<b>Dueling:</b> When you are wielding a melee weapon in one hand and no other weapons, you gain a +2 bonus to damage rolls with that weapon.<br /><b>Two-Weapon Fighting:</b> When you engage in two-weapon fighting, you can add your ability modifier to the damage of the second attack."
                                                },
                                            },
                                            new FeaturesModel
                                            {
                                                Name = "Blade Flourish",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, whenever you take the Attack action on your turn, your walking speed increases by 10 feet until the end of the turn, and if a weapon attack that you make as part of this action hits a creature, you can use one of the following Blade Flourish options of your choice. You can use only one Blade Flourish option per turn.",
                                                    "<b>Defensive Flourish:</b> You can expend one use of your Bardic Inspiration to cause the weapon to deal extra damage to the target you hit. The damage equals the number you roll on the Bardic Inspiration die. You also add the number rolled to your AC until the start of your next turn.<br /><b>Slashing Flourish:</b> You can expend one use of your Bardic Inspiration to cause the weapon to deal extra damage to the target you hit and to any other creature of your choice that you can see within 5 feet of you. The damage equals the number you roll on the Bardic Inspiration die.<br /><b>Mobile Flourish:</b> You can expend one use of your Bardic Inspiration to cause the weapon to deal extra damage to the target you hit. The damage equals the number you roll on the Bardic Inspiration die. You can also push the target up to 5 feet away from you, plus a number of feet equal to the number you roll on that die. You can then immediately use your reaction to move up to your walking speed to an unoccupied space within 5 feet of the target."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Blade Flourish",
                                                    Description = "College of Swords feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            }
                                        },
                                        Proficiencies = new ProficiencyModel
                                        {
                                            Armor = new List<ArmorEnum>
                                            {
                                                ArmorEnum.Medium
                                            },
                                            Weapons = new List<WeaponsEnum>
                                            {
                                                WeaponsEnum.Scimitar
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.CollegeOfValor,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Bonus Proficiencies",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, you gain proficiency with medium armor, shields, and martial weapons."
                                                }
                                            },
                                            new FeaturesModel
                                            {
                                                Name = "Combat Inspiration",
                                                Description = new List<string>
                                                {
                                                    "Also at 3rd level, a creature that has a Bardic Inspiration die from you can roll that die and add the number rolled to a weapon damage roll it just made. Alternatively, when an attack roll is made against the creature, it can use its reaction to roll the Bardic Inspiration die and add the number rolled to its AC against that attack, after seeing the roll but before knowing whether it hits or misses."
                                                },
                                            },
                                        },
                                        Proficiencies = new ProficiencyModel
                                        {
                                            Armor = new List<ArmorEnum>
                                            {
                                                ArmorEnum.Medium,
                                                ArmorEnum.Shield
                                            },
                                            Weapons = new List<WeaponsEnum>
                                            {
                                                WeaponsEnum.MartialWeapon
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.CollegeOfWhispers,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Psychic Blades",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, when you hit a creature with a weapon attack, you can expend one use of your Bardic Inspiration to deal an extra 2d6 psychic damage to that target. You can do so only once per round on your turn.",
                                                    "The psychic damage increases when you reach certain levels in this class, increasing to 3d6 at 5th level, 5d6 at 10th level, and 8d6 at 15th level."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Psychic Blades",
                                                    Description = "College of Whispers feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            },
                                            new FeaturesModel
                                            {
                                                Name = "Words of Terror",
                                                Description = new List<string>
                                                {
                                                    "At 3rd level, if you speak to a humanoid alone for at least 1 minute, you can attempt to seed paranoia in its mind. At the end of the conversation, the target must succeed on a Wisdom saving throw against your spell save DC or be frightened of you or another creature of your choice. The target is frightened in this way for 1 hour, until it is attacked or damaged, or until it witnesses its allies being attacked or damaged.",
                                                    "If the target succeeds on its saving throw, the target has no hint that you tried to frighten it.",
                                                    "Once you use this feature, you can't use it again until you finish a short or long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Words of Terror",
                                                    Description = "College of Whispers feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            }
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
                                    ClassEnum.CollegeOfGlamour,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Mantle of Majesty",
                                                Description = new List<string>
                                                {
                                                    "At 6th level, as a bonus action, you cast Command, without expending a spell slot, and you take on an appearance of unearthly beauty for 1 minute or until your concentration ends (as if you were concentrating on a spell). During this time, you can cast Command as a bonus action on each of your turns, without expending a spell slot.",
                                                    "Any creature charmed by you automatically fails its saving throw against the Command you cast with this feature.",
                                                    "Once you use this feature, you can't use it again until you finish a long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Mantle of Majesty",
                                                    Description = "College of Glamour feature",
                                                    Type = ActionTypesEnum.Bonus
                                                }
                                            },
                                        },
                                    }
                                },
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
                                                    "At 6th level, you learn two spells of your choice from any classes. A spell you choose must be of a level you can cast, as shown on the Bard table, or a cantrip. The chosen spells count as bard spells for you but don't count against the number of bard spells you know."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.CollegeOfSwords,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Extra Attack",
                                                Description = new List<string>
                                                {
                                                    "Starting at 6th level, you can attack twice, instead of once, whenever you take the Attack action on your turn"
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.CollegeOfValor,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Extra Attack",
                                                Description = new List<string>
                                                {
                                                    "Starting at 6th level, you can attack twice, instead of once, whenever you take the Attack action on your turn."
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.CollegeOfWhispers,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Mantle of Whispers",
                                                Description = new List<string>
                                                {
                                                    "At 6th level, when a humanoid dies within 30 feet of you, you can magically capture its shadow using your reaction. You retain this shadow until you use it or you finish a long rest.",
                                                    "You can use the shadow as an action. When you do so, it vanishes, magically transforming into a disguise that appears on you. You now look like the dead person, but healthy and alive. This disguise lasts for 1 hour or until you end it as a bonus action.",
                                                    "While you're in the disguise, you gain access to all information that the humanoid would freely share with a casual acquaintance. Such information includes general details on its background and personal life, but doesn't include secrets. The information is enough that you can pass yourself off as the person by drawing on its memories.",
                                                    "Another creature can see through this disguise by succeeding on a Wisdom (Insight) check contested by your Charisma (Deception) check. You gain a +5 bonus to your check.",
                                                    "Once you capture a shadow with this feature, you can't capture another one with it until you finish a short or long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Mantle of Whispers",
                                                    Description = "College of Whispers feature",
                                                    Type = ActionTypesEnum.Reaction
                                                }
                                            },
                                        },
                                    }
                                },
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
                                    ClassEnum.CollegeOfGlamour,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Unbreakable Majesty",
                                                Description = new List<string>
                                                {
                                                    "At 14th level, as a bonus action, you can assume a magically majestic presence for 1 minute or until you are incapacitated. For the duration, whenever any creature tries to attack you for the first time on a turn, the attacker must make a Charisma saving throw against your spell save DC. On a failed save, it can't attack you on this turn, and it must choose a new target for its attack or the attack is wasted. On a successful save, it can attack you on this turn, but it has disadvantage on any saving throw it makes against your spells on your next turn.",
                                                    "Once you assume this majestic presence, you can't do so again until you finish a short or long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Unbreakable Majesty",
                                                    Description = "College of Glamour feature",
                                                    Type = ActionTypesEnum.Bonus
                                                }
                                            },
                                        },
                                    }
                                },
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
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.CollegeOfSwords,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Masters Flourish",
                                                Description = new List<string>
                                                {
                                                    "Starting at 14th level, whenever you use a Blade Flourish option, you can roll a d6 and use it instead of expending a Bardic Inspiration die."
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.CollegeOfValor,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Battle Magic",
                                                Description = new List<string>
                                                {
                                                    "At 14th level, when you use your action to a cast a bard spell, you can make one weapon attack as a bonus action."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Battle Magic",
                                                    Description = "College of Valor feature",
                                                    Type = ActionTypesEnum.Bonus
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.CollegeOfWhispers,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Shadow Lore",
                                                Description = new List<string>
                                                {
                                                    "At 14th level, as an action, you magically whisper a phrase that only one creature of your choice within 30 feet of you can hear. The target must make a Wisdom saving throw against your spell save DC. It automatically succeeds if it doesn't share a language with you or if it can't hear you. On a successful saving throw, your whisper sounds like unintelligible mumbling and has no effect.",
                                                    "On a failed saving throw, the target is charmed by you for the next 8 hours or until you or your allies attack it, damage it, or force it to make a saving throw. It interprets the whispers as a description of its most mortifying secret. You gain no knowledge of this secret, but the target is convinced you know it.",
                                                    "The charmed creature obeys your commands for fear that you will reveal its secret. It won't risk its life for you or fight for you, unless it was already inclined to do so. It grants you favors and gifts it would offer to a close friend.",
                                                    "When the effect ends, the creature has no understanding of why it held you in such fear.",
                                                    "Once you use this feature, you can't use it again until you finish a long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Shadow Lore",
                                                    Description = "College of Whispers feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            },
                                        },
                                    }
                                },
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
                Name = ClassEnum.Cleric.GetEnumText(),
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
                Equipment = new List<EquipmentModel>
                {
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Mace.GetEnumText(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Mace
                    },
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.CrossbowLight.GetEnumText(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.CrossbowLight
                    },
                    new EquipmentModel
                    {
                        Name = ArmorEnum.ScaleMail.GetEnumText(),
                        Type = EquipmentTypeEnum.Armor,
                    },
                    new EquipmentModel
                    {
                        Name = ArmorEnum.Shield.GetEnumText(),
                        Type = EquipmentTypeEnum.Armor,
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.PriestsPack.GetEnumText(),
                        Type = EquipmentTypeEnum.Item,
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.HolySymbol.GetEnumText(),
                        Type = EquipmentTypeEnum.Item,
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
                                    Name = "Spellcasting",
                                    Description = new List<string>
                                    {
                                        "Wisdom is your spellcasting ability for your cleric spells. You use your Wisdom whenever a cleric spell refers to your spellcasting ability. In addition, you use your Wisdom modifier when Setting the saving throw DC for a cleric spell you cast and when making an attack roll with one.",
                                        "At 1st level, you know three cantrips of your choice from the cleric spell list. You learn additional cleric cantrips of your choice at higher levels, as shown in the Cantrips Known column of the Cleric table.",
                                        "The Cleric table shows how many spell slots you have to cast your cleric spells of 1st level and higher. To cast one of these spells, you must expend a slot of the spell's level or higher. You regain all expended spell slots when you finish a long rest.",
                                        "You prepare the list of cleric spells that are available for you to cast, choosing from the cleric spell list. When you do so, choose a number of cleric spells equal to your Wisdom modifier + your cleric level (minimum of one spell). The spells must be of a level for which you have spell slots.",
                                        "You can cast a cleric spell as a ritual if that spell has the ritual tag and you have the spell prepared.",
                                        "You can change your list of prepared spells when you finish a long rest.",
                                        "You can use a holy symbol as a spellcasting focus for your cleric spells."
                                    },
                                    AbilityModifier = AbilitiesEnum.Wis,
                                    Action = new ActionModel
                                    {
                                        Name = "Spellcasting",
                                        Description = "Cleric feature",
                                        Type = ActionTypesEnum.Attack
                                    }
                                },
                            },
                            Proficiencies = new ProficiencyModel
                            {
                                Armor = new List<ArmorEnum>
                                {
                                    ArmorEnum.Light,
                                    ArmorEnum.Medium,
                                    ArmorEnum.Shield
                                },
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Wis,
                                    AbilitiesEnum.Cha,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.SimpleWeapon,
                                }
                            },
                            SetVariant = true,
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 3,
                                _1 = 2,
                            },
                            Variants = new Dictionary<ClassEnum, LevelModel>
                            {
                                {
                                    ClassEnum.DomainArcana,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Arcane Initiate",
                                                Description = new List<string>
                                                {
                                                    "At 1st level, you gain proficiency in the Arcana skill, and you gain two cantrips of your choice from the wizard spell list. For you, these cantrips count as cleric cantrips."
                                                }
                                            }
                                        },
                                        Proficiencies = new ProficiencyModel
                                        {
                                            Skills = new List<SkillsEnum>
                                            {
                                                SkillsEnum.Arcana
                                            }
                                        },
                                        Spells = new SpellsModel {
                                            Cantrips = new List<SpellsEnum>
                                            {
                                                SpellsEnum.CantripWizard,
                                                SpellsEnum.CantripWizard
                                            },
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.DetectMagic,
                                                SpellsEnum.MagicMissile,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainDeath,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Reaper",
                                                Description = new List<string>
                                                {
                                                    "At 1st level, you learn one necromancy cantrip of your choice from any spell list. When you cast a necromancy cantrip that normally targets only one creature, the spell can instead target two creatures within range and within 5 feet of each other."
                                                }
                                            }
                                        },
                                        Proficiencies = new ProficiencyModel
                                        {
                                            Weapons = new List<WeaponsEnum>
                                            {
                                                WeaponsEnum.MartialWeapon,
                                            }
                                        },
                                        Spells = new SpellsModel {
                                            Cantrips = new List<SpellsEnum>
                                            {
                                                SpellsEnum.CantripNecromancy,
                                            },
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.FalseLife,
                                                SpellsEnum.RayOfSickness,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainForge,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Blessing of the Forge",
                                                Description = new List<string>
                                                {
                                                    "At 1st level, at the end of a long rest, touch one nonmagical object that is a suit of armor or a simple or martial weapon. Until the end of your next long rest, the object becomes a magic item, granting a +1 bonus to AC if it's armor or a +1 bonus to attack and damage rolls if it's a weapon.",
                                                    "Once you use this feature, you can't use it again until you finish a long rest."
                                                }
                                            }
                                        },
                                        Proficiencies = new ProficiencyModel
                                        {
                                            Armor = new List<ArmorEnum>
                                            {
                                                ArmorEnum.Heavy,
                                            },
                                            Tools = new List<ToolsEnum>
                                            {
                                                ToolsEnum.smithsTools,
                                            }
                                        },
                                        Spells = new SpellsModel {
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Identify,
                                                SpellsEnum.SearingSmite,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainGrave,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Circle of Mortality",
                                                Description = new List<string>
                                                {
                                                    "At 1st level, when you would normally roll one or more dice to restore hit points with a spell to a creature at 0 hit points, you instead use the highest number possible for each die.",
                                                    "In addition, you learn the Spare the Dying cantrip, which doesn't count against the number of cleric cantrips you know. For you, it has a range of 30 feet, and you can cast it as a bonus action."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Circle of Mortality",
                                                    Description = "Grave Domain Feature",
                                                    Type = ActionTypesEnum.Bonus
                                                }
                                            },
                                            new FeaturesModel
                                            {
                                                Name = "Eyes of the Grave",
                                                Description = new List<string>
                                                {
                                                    "At 1st level, as an action, you can open your awareness to magically detect undead. Until the end of your next turn, you know the location of any undead within 60 feet of you that isn't behind total cover and that isn't protected from divination magic. This sense doesn't tell you anything about a creature's capabilities or identity.",
                                                    "You can use this feature a number of times equal to your Wisdom modifier (minimum of once). You regain all expended uses when you finish a long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Eyes of the Grave",
                                                    Description = "Grave Domain Feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            }
                                        },
                                        Spells = new SpellsModel {
                                            Cantrips = new List<SpellsEnum>
                                            {
                                                SpellsEnum.SpareTheDying
                                            },
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Bane,
                                                SpellsEnum.FalseLife,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainKnowledge,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Blessing of Knowledge",
                                                Description = new List<string>
                                                {
                                                    "At 1st level, you learn two languages of your choice. You also become proficient in your choice of two of the following skills: Arcana, History, Nature, or Religion.",
                                                    "Your proficiency bonus is doubled for any ability check you make that uses either of those skills."
                                                },
                                            },
                                        },
                                        Proficiencies = new ProficiencyModel
                                        {
                                            Languages = new List<LanguagesEnum>
                                            {
                                                LanguagesEnum.SelectLanguage,
                                                LanguagesEnum.SelectLanguage
                                            }
                                        },
                                        Spells = new SpellsModel {
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Command,
                                                SpellsEnum.Identify,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainLife,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Disciple of Life",
                                                Description = new List<string>
                                                {
                                                    "Also starting at 1st level, whenever you use a spell of 1st level or higher to restore hit points to a creature, the creature regains additional hit points equal to 2 + the spell's level."
                                                },
                                            },
                                        },
                                        Proficiencies = new ProficiencyModel
                                        {
                                            Armor = new List<ArmorEnum>
                                            {
                                                ArmorEnum.Heavy
                                            },
                                        },
                                        Spells = new SpellsModel {
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Bless,
                                                SpellsEnum.CureWounds,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainLight,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Warding Flare",
                                                Description = new List<string>
                                                {
                                                    "Also at 1st level, when you are attacked by a creature within 30 feet of you that you can see, you can use your reaction to impose disadvantage on the attack roll, causing light to flare before the attacker before it hits or misses. An attacker that can't be blinded is immune to this feature.",
                                                    "You can use this feature a number of times equal to your Wisdom modifier (a minimum of once). You regain all expended uses when you finish a long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Warding Flare",
                                                    Description = "Ligth Domain feature",
                                                    Type = ActionTypesEnum.Reaction
                                                }
                                            },
                                        },
                                        Spells = new SpellsModel {
                                            Cantrips = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Light
                                            },
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Bless,
                                                SpellsEnum.CureWounds,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainNature,
                                    new LevelModel
                                    {
                                        Proficiencies = new ProficiencyModel
                                        {
                                            Armor = new List<ArmorEnum>
                                            {
                                                ArmorEnum.Heavy
                                            },
                                        },
                                        Spells = new SpellsModel {
                                            Cantrips = new List<SpellsEnum>
                                            {
                                                SpellsEnum.CantripDruid
                                            },
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.AnimalFriendship,
                                                SpellsEnum.SpeakWithAnimals,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainTempest,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Wrath of the Storm",
                                                Description = new List<string>
                                                {
                                                    "Also at 1st level, when a creature within 5 feet of you that you can see hits you with an attack, you can use your reaction to cause the creature to make a Dexterity saving throw. The creature takes 2d8 lightning or thunder damage (your choice) on a failed saving throw, and half as much damage on a successful one.",
                                                    "You can use this feature a number of times equal to your Wisdom modifier (a minimum of once). You regain all expended uses when you finish a long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Wrath of the Storm",
                                                    Description = "Tempest Domain feature",
                                                    Type = ActionTypesEnum.Reaction
                                                }
                                            }
                                        },
                                        Proficiencies = new ProficiencyModel
                                        {
                                            Armor = new List<ArmorEnum>
                                            {
                                                ArmorEnum.Heavy
                                            },
                                            Weapons = new List<WeaponsEnum>
                                            {
                                                WeaponsEnum.MartialWeapon
                                            }
                                        },
                                        Spells = new SpellsModel {
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.FogCloud,
                                                SpellsEnum.Thunderwave,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainTrickery,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Blessing of the Trickster",
                                                Description = new List<string>
                                                {
                                                    "At 1st level, you can use your action to touch a willing creature other than yourself to give it advantage on Dexterity (Stealth) checks. This blessing lasts for 1 hour or until you use this feature again."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Blessing of the Trickster",
                                                    Description = "Trickery Domain feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            }
                                        },
                                        Spells = new SpellsModel {
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.CharmPerson,
                                                SpellsEnum.DisguiseSelf,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainWar,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "War Priest",
                                                Description = new List<string>
                                                {
                                                    "You can use this feature a number of times equal to your Wisdom modifier (a minimum of once). You regain all expended uses when you finish a long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "War Priest",
                                                    Description = "War Domain feature",
                                                    Type = ActionTypesEnum.Bonus
                                                }
                                            }
                                        },
                                        Proficiencies = new ProficiencyModel
                                        {
                                            Armor = new List<ArmorEnum>
                                            {
                                                ArmorEnum.Heavy,
                                            },
                                            Weapons = new List<WeaponsEnum>
                                            {
                                                WeaponsEnum.MartialWeapon
                                            },
                                        },
                                        Spells = new SpellsModel {
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.DivineFavor,
                                                SpellsEnum.ShieldOfFaith,
                                            }
                                        }
                                    }
                                },
                            }
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
                                    Name = "Channel Divinity",
                                    Description = new List<string>
                                    {
                                        "At 2nd level, you start with two abilities: Turn Undead and an effect determined by your domain. Some domains grant you additional effects as you advance in levels, as noted in the domain description.",
                                        "When you use your Channel Divinity, you choose which effect to create. You must then finish a short or long rest to use your Channel Divinity again.",
                                        "Some Channel Divinity effects require saving throws. When you use such an effect from this class, the DC equals your cleric spell save DC.",
                                        "Beginning at 6th level, you can use your Channel Divinity twice between rests, and beginning at 18th level, you can use it three times between rests. When you finish a short or long rest, you regain your expended uses."
                                    },
                                },
                                new FeaturesModel
                                {
                                    Name = "Channel Divinity: Turn Undead",
                                    Description = new List<string>
                                    {
                                        "As an action, each undead that can see or hear you within 30 feet of you must make a Wisdom saving throw. If the creature fails its saving throw, it is turned for 1 minute or until it takes any damage.",
                                        "A turned creature must spend its turns trying to move as far away from you as it can, and it can't willingly move to a space within 30 feet of you. It also can't take reactions. For its action, it can use only the Dash action or try to escape from an effect that prevents it from moving. If there's nowhere to move, the creature can use the Dodge action."
                                    },
                                    Action = new ActionModel
                                    {
                                        Name = "Channel Divinity: Turn Undead",
                                        Description = "Cleric feature",
                                        Type = ActionTypesEnum.Option
                                    }
                                },
                            },
                            Variants = new Dictionary<ClassEnum, LevelModel>
                            {
                                {
                                    ClassEnum.DomainArcana,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Arcane Abjuration",
                                                Description = new List<string>
                                                {
                                                    "Starting at 2nd level, as an action, you present your holy symbol, and one celestial, elemental, fey, or fiend of your choice that is within 30 feet of you must make a Wisdom saving throw, provided that the creature can see or hear you. If the creature fails its saving throw, it is turned for 1 minute or until it takes any damage.",
                                                    "A turned creature must spend its turns trying to move as far away from you as it can, and it can't willingly end its move in a space within 30 feet of you. It also can't take reactions. For its action, it can use the Dash action or try to escape from an effect that prevents it from moving. If there's nowhere to move, then the creature can use the Dodge action.",
                                                    "After you reach 5th level, when a creature fails its saving throw against your Arcane Abjuration feature, the creature is banished for 1 minute (as in the Banishment spell, no concentration required) if it isn't on its plane of origin and if its challenge rating is at or below a certain threshold, as shown below.",
                                                    "<i>5th Level:</i> CR 1/2 or lower<br /><i>8th Level:</i> CR 1 or lower<br /><i>11th Level:</i> CR 2 or lower<br /><i>14th Level:</i> CR 3 or lower<br /><i>17th Level:</i> CR 4 or lower"
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Channel Divinity: Arcane Abjuraton",
                                                    Description = "Arcana Domain Feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainDeath,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Touch of Death",
                                                Description = new List<string>
                                                {
                                                    "Starting at 2nd level, when you hit a creature with a melee attack, you can use Channel Divinity to deal extra necrotic damage to the target. The damage equals 5 + twice your cleric level."
                                                },
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainForge,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Artisan's Blessing",
                                                Description = new List<string>
                                                {
                                                    "Starting at 2nd level, you can conduct an hour-long ritual that crafts a nonmagical item that must include some metal. The creation is completed at the end of the hour, coalescing in an unoccupied space of your choice on a surface within 5 feet of you.",
                                                    "The thing you create can be something that is worth no more than 100 gp. As part of this ritual, you must lay out metal, which can include coins, with a value equal to the creation. The metal irretrievably coalesces and transforms into the creation at the ritual's end, magically forming even nonmetal parts of the creation.",
                                                    "The ritual can create a duplicate of a nonmagical item that contains metal, such as a key, if you possess the original during the ritual."
                                                }
                                            }
                                        },
                                        Spells = new SpellsModel {
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Identify,
                                                SpellsEnum.SearingSmite,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainGrave,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Path to the Grave",
                                                Description = new List<string>
                                                {
                                                    "Starting at 2nd level, as an action, you choose one creature you can see within 30 feet of you, cursing it until the end of your next turn. The next time you or an ally of yours hits the cursed creature with an attack, the creature has vulnerability to all of that attack's damage, and then the curse ends."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Channel Divinity: Path to the Grave",
                                                    Description = "Grave Domain Feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainKnowledge,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Knowledge of the Ages",
                                                Description = new List<string>
                                                {
                                                    "Starting at 2nd level, as an action, you choose one skill or tool. For 10 minutes, you have proficiency with the chosen skill or tool."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Channel Divinity: Knowledge of the Ages",
                                                    Description = "Knowledge Domain feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainLife,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Preserve Life",
                                                Description = new List<string>
                                                {
                                                    "Starting at 2nd level, as an action, you present your holy symbol and evoke healing energy that can restore a number of hit points equal to five times your cleric level. Choose any creatures within 30 feet of you, and divide those hit points among them. This feature can restore a creature to no more than half of its hit point maximum. You can't use this feature on an undead or a construct."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Channel Divinity: Preserve Life",
                                                    Description = "Life Domain feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainLight,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Radiance of the Dawn",
                                                Description = new List<string>
                                                {
                                                    "Starting at 2nd level, as an action, you present your holy symbol, and any magical darkness within 30 feet of you is dispelled. Additionally, each hostile creature within 30 feet of you must make a Constitution saving throw. A creature takes radiant damage equal to 2d10 + your cleric level on a failed saving throw, and half as much damage on a successful one. A creature that has total cover from you is not affected."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Channel Divinity: Radiance of the Dawn",
                                                    Description = "Ligth Domain feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainNature,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Charm Animals and Plants",
                                                Description = new List<string>
                                                {
                                                    "Starting at 2nd level, as an action, you present your holy symbol and invoke the name of your deity. Each beast or plant creature that can see you within 30 feet of you must make a Wisdom saving throw. If the creature fails its saving throw, it is charmed by you for 1 minute or until it takes damage. While it is charmed by you, it is friendly to you and other creatures you designate."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Channel Divinity: Charm Animals and Plants",
                                                    Description = "Nature Domain feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainTempest,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Destructive Wrath",
                                                Description = new List<string>
                                                {
                                                    "Starting at 2nd level, when you roll lightning or thunder damage, you can use your Channel Divinity to deal maximum damage, instead of rolling."
                                                },
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainTrickery,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Invoke Duplicity",
                                                Description = new List<string>
                                                {
                                                    "Starting at 2nd level, as an action, you create a perfect illusion of yourself that lasts for 1 minute, or until you lose your concentration (as if you were concentrating on a spell). The illusion appears in an unoccupied space that you can see within 30 feet of you. As a bonus action on your turn, you can move the illusion up to 30 feet to a space you can see, but it must remain within 120 feet of you.",
                                                    "For the duration, you can cast spells as though you were in the illusion's space, but you must use your own senses. Additionally, when both you and your illusion are within 5 feet of a creature that can see the illusion, you have advantage on attack rolls against that creature, given how distracting the illusion is to the target."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Channel Divinity: Invoke Duplicity",
                                                    Description = "Trickery Domain feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainWar,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Guided Strike",
                                                Description = new List<string>
                                                {
                                                    "Starting at 2nd level, when you make an attack roll, you can use your Channel Divinity to gain a +10 bonus to the roll. You make this choice after you see the roll, but before the DM says whether the attack hits or misses."
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        }
                    },
                    {
                        3,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 3,
                                _1 = 4,
                                _2 = 2
                            },
                            Variants = new Dictionary<ClassEnum, LevelModel>
                            {
                                {
                                    ClassEnum.DomainArcana,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _2 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.MagicWeapon,
                                                SpellsEnum.NystulsMagicAura
                                            },
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainDeath,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _2 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.BlindnessDeafness,
                                                SpellsEnum.RayOfEnfeeblement
                                            },
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainForge,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _2 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.HeatMetal,
                                                SpellsEnum.MagicWeapon,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainGrave,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _2 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.GentleRepose,
                                                SpellsEnum.RayOfEnfeeblement,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainKnowledge,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _2 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Augury,
                                                SpellsEnum.Suggestion,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainLife,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _2 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.LesserRestoration,
                                                SpellsEnum.SpiritualWeapon,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainLight,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _2 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.FlamingSphere,
                                                SpellsEnum.ScorchingRay,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainNature,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _2 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Barkskin,
                                                SpellsEnum.SpikeGrowth,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainTempest,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _2 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.GustOfWind,
                                                SpellsEnum.Shatter,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainTrickery,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _2 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.MirrorImage,
                                                SpellsEnum.PassWithoutTrace,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainWar,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _2 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.MagicWeapon,
                                                SpellsEnum.SpiritualWeapon,
                                            }
                                        }
                                    }
                                },
                            }
                        }
                    },
                    {
                        4,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 4,
                                _1 = 4,
                                _2 = 3
                            },
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
                                    Name = "Destroy Undead",
                                    Description = new List<string>
                                    {
                                        "Starting at 5th level, when an undead of CR 1/2 or lower fails its saving throw against your Turn Undead feature, the creature is instantly destroyed. The CR of undead increases as you gain levels.",
                                        "<i>5th Level:</i> CR 1/2 or lower<br /><i>8th Level:</i> CR 1 or lower<br /><i>11th Level:</i> CR 2 or lower<br /><i>14th Level:</i> CR 3 or lower<br /><i>17th Level:</i> CR 4 or lower"
                                    },
                                },
                            },
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 4,
                                _1 = 4,
                                _2 = 3,
                                _3 = 2
                            },
                            Variants = new Dictionary<ClassEnum, LevelModel>
                            {
                                {
                                    ClassEnum.DomainArcana,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _3 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.DispelMagic,
                                                SpellsEnum.MagicCircle
                                            },
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainDeath,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _3 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.AnimateDead,
                                                SpellsEnum.VampiricTouch
                                            },
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainForge,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _3 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.ElementalWeapon,
                                                SpellsEnum.ProtectionFromEnergy,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainGrave,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _3 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Revivify,
                                                SpellsEnum.VampiricTouch,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainKnowledge,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _3 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Nondetection,
                                                SpellsEnum.SpeakWithDead,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainLife,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _3 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.BeaconOfHope,
                                                SpellsEnum.Revivify,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainLight,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _3 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Daylight,
                                                SpellsEnum.Fireball,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainNature,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _3 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.PlantGrowth,
                                                SpellsEnum.WindWall,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainTempest,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _3 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.CallLightning,
                                                SpellsEnum.SleetStorm,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainTrickery,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _3 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Blink,
                                                SpellsEnum.DispelMagic,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainWar,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _3 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.CrusadersMantle,
                                                SpellsEnum.SpiritGuardians,
                                            }
                                        }
                                    }
                                },
                            }
                        }
                    },
                    {
                        6,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 4,
                                _1 = 4,
                                _2 = 3,
                                _3 = 3
                            },
                            Variants = new Dictionary<ClassEnum, LevelModel>
                            {
                                {
                                    ClassEnum.DomainArcana,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Spell Breaker",
                                                Description = new List<string>
                                                {
                                                    "Starting at 6th level, when you restore hit points to an ally with a spell of 1st level or higher, you can also end one spell of your choice on that creature. The level of the spell you end must be equal to or lower than the level of the spell slot you use to cast the healing spell."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainDeath,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Inescapable Destruction",
                                                Description = new List<string>
                                                {
                                                    "Starting at 6th level, necrotic damage dealt by your cleric spells and Channel Divinity options ignore resistance to necrotic damage."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainForge,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Soul of the Forge",
                                                Description = new List<string>
                                                {
                                                    "Starting at 6th level, you get a number of special abilities:",
                                                    "You gain resistance to fire damage.<br />While wearing heavy armor, you gain a +1 bonus to AC."
                                                }
                                            }
                                        },
                                        Resistance = new List<DamageTypesEnum>
                                        {
                                            DamageTypesEnum.Fire
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainGrave,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Sentinel at Death's Door",
                                                Description = new List<string>
                                                {
                                                    "At 6th level, as a reaction when you or a creature that you can see within 30 feet of you suffers a critical hit, you can turn that attack into a normal hit. Any effects triggered by a critical hit are canceled.",
                                                    "You can use this feature a number of times equal to your Wisdom modifier (minimum of once). You regain all expended uses when you finish a long rest."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Sentinel at Death's Door",
                                                    Description = "Grave Domain Feature",
                                                    Type = ActionTypesEnum.Reaction
                                                }
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainKnowledge,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Read Thoughts",
                                                Description = new List<string>
                                                {
                                                    "At 6th level, as an action, choose one creature that you can see within 60 feet of you. That creature must make a Wisdom saving throw. If the creature succeeds on the saving throw, you can't use this feature on it again until you finish a long rest.",
                                                    "If the creature fails its save, you can read its surface thoughts (those foremost in its mind, reflecting its current emotions and what it is actively thinking about) when it is within 60 feet of you. This effect lasts for 1 minute.",
                                                    "During that time, you can use your action to end this effect and cast the suggestion spell on the creature without expending a spell slot. The target automatically fails its saving throw against the spell."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Channel Divinity: Read Thoughts",
                                                    Description = "Knowledge Domain feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainLife,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Blessed Healer",
                                                Description = new List<string>
                                                {
                                                    "Beginning at 6th level, when you cast a spell of 1st level or higher that restores hit points to a creature other than you, you regain hit points equal to 2 + the spell's level."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainLight,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Improved Flare",
                                                Description = new List<string>
                                                {
                                                    "Starting at 6th level, you can also use your Warding Flare feature when a creature that you can see within 30 feet of you attacks a creature other than you."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainNature,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Dampen Elements",
                                                Description = new List<string>
                                                {
                                                    "Starting at 6th level, when you or a creature within 30 feet of you takes acid, cold, fire, lightning, or thunder damage, you can use your reaction to grant resistance to the creature against that instance of the damage."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Dampen Elements",
                                                    Description = "Nature Domain feature",
                                                    Type = ActionTypesEnum.Reaction
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainTempest,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Thunderbolt Strike",
                                                Description = new List<string>
                                                {
                                                    "At 6th level, when you deal lightning damage to a Large or smaller creature, you can also push it up to 10 feet away from you."
                                                },
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainTrickery,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: Cloak of Shadows",
                                                Description = new List<string>
                                                {
                                                    "Starting at 6th level, as an action, you become invisible until the end of your next turn. You become visible if you attack or cast a spell."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Channel Divinity: Cloak of Shadows",
                                                    Description = "Trickery Domain feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainWar,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Channel Divinity: War God's Blessing",
                                                Description = new List<string>
                                                {
                                                    "At 6th level, when a creature within 30 feet of you makes an attack roll, you can use your reaction to grant that creature a +10 bonus to the roll, using your Channel Divinity. You make this choice after you see the roll, but before the DM says whether the attack hits or misses."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Channel Divinity: War God's Blessing",
                                                    Description = "War Domain feature",
                                                    Type = ActionTypesEnum.Reaction
                                                }
                                            }
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
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 4,
                                _1 = 4,
                                _2 = 3,
                                _3 = 2,
                                _4 = 1
                            },
                            Variants = new Dictionary<ClassEnum, LevelModel>
                            {
                                {
                                    ClassEnum.DomainArcana,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _4 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.ArcaneEye,
                                                SpellsEnum.LeomundsSecretChest
                                            },
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainDeath,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _4 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Blight,
                                                SpellsEnum.DeathWard
                                            },
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainForge,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _4 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Fabricate,
                                                SpellsEnum.WallOfFire,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainGrave,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _4 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.Blight,
                                                SpellsEnum.DeathWard,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainKnowledge,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _4 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.ArcaneEye,
                                                SpellsEnum.Confusion,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainLife,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _4 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.DeathWard,
                                                SpellsEnum.GuardianOfFaith,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainLight,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _4 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.GuardianOfFaith,
                                                SpellsEnum.WallOfFire,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainNature,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _4 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.DominateBeast,
                                                SpellsEnum.GraspingVine,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainTempest,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _4 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.ControlWater,
                                                SpellsEnum.IceStorm,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainTrickery,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _4 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.DimensionDoor,
                                                SpellsEnum.Polymorph,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainWar,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.FreedomOfMovement,
                                                SpellsEnum.Stoneskin,
                                            }
                                        }
                                    }
                                },
                            }
                        }
                    },
                    {
                        8,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 4,
                                _1 = 4,
                                _2 = 3,
                                _3 = 2,
                                _4 = 2
                            },
                            Variants = new Dictionary<ClassEnum, LevelModel>
                            {
                                {
                                    ClassEnum.DomainArcana,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Potent Spellcasting",
                                                Description = new List<string>
                                                {
                                                    "Starting at 8th level, you add your Wisdom modifier to the damage you deal with any cleric cantrip."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainDeath,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Divine Strike",
                                                Description = new List<string>
                                                {
                                                    "At 8th level, once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 necrotic damage to the target. When you reach 14th level, the extra damage increases to 2d8."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainForge,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Divine Strike",
                                                Description = new List<string>
                                                {
                                                    "At 8th level, once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 fire damage to the target. When you reach 14th level, the extra damage increases to 2d8."
                                                }
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainGrave,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Potent Spellcasting",
                                                Description = new List<string>
                                                {
                                                    "Starting at 8th level, you add your Wisdom modifier to the damage you deal with any cleric cantrip."
                                                },
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainKnowledge,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Potent Spellcasting",
                                                Description = new List<string>
                                                {
                                                    "Starting at 8th level, you add your Wisdom modifier to the damage you deal with any cleric cantrip."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainLife,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Divine Strike",
                                                Description = new List<string>
                                                {
                                                    "At 8th level, once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 radiant damage to the target. When you reach 14th level, the extra damage increases to 2d8."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainLight,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Potent Spellcasting",
                                                Description = new List<string>
                                                {
                                                    "Starting at 8th level, you add your Wisdom modifier to the damage you deal with any cleric cantrip."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainNature,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Divine Strike",
                                                Description = new List<string>
                                                {
                                                    "At 8th level, once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 cold, fire, or lightning damage (your choice) to the target. When you reach 14th level, the extra damage increases to 2d8."
                                                },                                           },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainTempest,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Divine Strike",
                                                Description = new List<string>
                                                {
                                                    "At 8th level, once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 thunder damage to the target. When you reach 14th level, the extra damage increases to 2d8."
                                                },
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainTrickery,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Divine Strike",
                                                Description = new List<string>
                                                {
                                                    "At 8th level, once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 poison damage to the target. When you reach 14th level, the extra damage increases to 2d8."
                                                },
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainWar,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Divine Strike",
                                                Description = new List<string>
                                                {
                                                    "At 8th level, once on each of your turns when you hit a creature with a weapon attack, you can cause the attack to deal an extra 1d8 damage of the same type dealt by the weapon to the target. When you reach 14th level, the extra damage increases to 2d8."
                                                },
                                            }
                                        },
                                    }
                                },
                            }
                        }
                    },
                    {
                        9,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 4,
                                _1 = 4,
                                _2 = 3,
                                _3 = 3,
                                _4 = 3,
                                _5 = 1
                            },
                            Variants = new Dictionary<ClassEnum, LevelModel>
                            {
                                {
                                    ClassEnum.DomainArcana,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _5 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.PlanarBinding,
                                                SpellsEnum.TeleportationCircle
                                            },
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainDeath,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _5 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.AntilifeShell,
                                                SpellsEnum.Cloudkill
                                            },
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainForge,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _5 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.AnimateObject,
                                                SpellsEnum.Creation,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainGrave,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _5 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.AntilifeShell,
                                                SpellsEnum.RaiseDead,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainKnowledge,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _5 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.LegendLore,
                                                SpellsEnum.Scrying,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainLife,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.MassCureWounds,
                                                SpellsEnum.RaiseDead,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainLight,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _5 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.FlameStrike,
                                                SpellsEnum.Scrying,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainNature,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _5 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.InsectPlague,
                                                SpellsEnum.TreeStride,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainTempest,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _1 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.DestructiveWave,
                                                SpellsEnum.InsectPlague
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainTrickery,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _5 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.DominateBeast,
                                                SpellsEnum.ModifyMemory,
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainWar,
                                    new LevelModel
                                    {
                                        Spells = new SpellsModel {
                                            _5 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.FlameStrike,
                                                SpellsEnum.HoldMonster,
                                            }
                                        }
                                    }
                                },
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
                                    Name = "Divine Intervention",
                                    Description = new List<string>
                                    {
                                        "Beginning at 10th level, you can call on your deity to intervene on your behalf as an action. Describe the assistance you seek, and roll percentile dice. If you roll a number equal to or lower than your cleric level, your deity intervenes. The DM chooses the nature of the intervention.",
                                        "If your deity intervenes, you can't use this feature again for 7 days. Otherwise, you can use it again after you finish a long rest.",
                                        "At 20th level, your call for intervention succeeds automatically, no roll required."
                                    },
                                    Action = new ActionModel
                                    {
                                        Name = "Divine Intervention",
                                        Description = "Cleric feature",
                                        Type = ActionTypesEnum.Option
                                    }
                                },
                            },
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 5,
                                _1 = 4,
                                _2 = 3,
                                _3 = 3,
                                _4 = 3,
                                _5 = 2
                            },
                        }
                    },
                    {
                        11,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 5,
                                _1 = 4,
                                _2 = 3,
                                _3 = 3,
                                _4 = 3,
                                _5 = 2,
                                _6 = 1
                            },
                        }
                    },
                    {
                        13,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 5,
                                _1 = 4,
                                _2 = 3,
                                _3 = 3,
                                _4 = 3,
                                _5 = 2,
                                _6 = 1,
                                _7 = 1
                            },
                        }
                    },
                    {
                        15,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 5,
                                _1 = 4,
                                _2 = 3,
                                _3 = 3,
                                _4 = 3,
                                _5 = 2,
                                _6 = 1,
                                _7 = 1,
                                _8 = 1,
                            },
                        }
                    },
                    {
                        17,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 5,
                                _1 = 4,
                                _2 = 3,
                                _3 = 3,
                                _4 = 3,
                                _5 = 2,
                                _6 = 1,
                                _7 = 1,
                                _8 = 1,
                                _9 = 1
                            },
                            Variants = new Dictionary<ClassEnum, LevelModel>
                            {
                                {
                                    ClassEnum.DomainArcana,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Arcane Mastery",
                                                Description = new List<string>
                                                {
                                                    "At 17th level, you choose four spells from the wizard spell list, one from each of the following levels: 6th, 7th, 8th, and 9th. You add them to your list of domain spells. Like your other domain spells, they are always prepared and count as cleric spells for you."
                                                },
                                            },
                                        },
                                        Spells = new SpellsModel {
                                            _6 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.SpellWizard
                                            },
                                            _7 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.SpellWizard
                                            },
                                            _8 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.SpellWizard
                                            },
                                            _9 = new List<SpellsEnum>
                                            {
                                                SpellsEnum.SpellWizard
                                            }
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainDeath,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Improved Reaper",
                                                Description = new List<string>
                                                {
                                                    "Starting at 17th level, when you casts a necromancy spell of 1st through 5th-level that targets only one creature, the spell can instead target two creatures within range and within 5 feet of each other. If the spell consumes its material components, you must provide them for each target."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainForge,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Saint of Forge and Fire",
                                                Description = new List<string>
                                                {
                                                    "At 17th level, you gain the following benefits:",
                                                    "You gain immunity to fire damage.<br />While you're wearing heavy armor, you have resistance to bludgeoning, piercing, and slashing damage from nonmagical attacks."
                                                }
                                            }
                                        },
                                        Immunity = new List<DamageTypesEnum>
                                        {
                                            DamageTypesEnum.Fire
                                        }
                                    }
                                },
                                {
                                    ClassEnum.DomainGrave,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Keeper of Souls",
                                                Description = new List<string>
                                                {
                                                    "Starting at 17th level, when an enemy you can see dies within 60 feet of you, you or one creature of your choice that is within 60 feet of you regains hit points equal to the enemy's number of Hit Dice. You can use this feature only if you aren't incapacitated. Once you use it, you can't do so again until the start of your next turn."
                                                }
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainKnowledge,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Visions of the Past",
                                                Description = new List<string>
                                                {
                                                    "Starting at 17th level, you can spend at least 1 minute in meditation and prayer, then receive dreamlike, shadowy glimpses of recent events. You can meditate in this way for a number of minutes equal to your Wisdom score and must maintain concentration during that time, as if you were casting a spell.",
                                                    "Once you use this feature, you can't use it again until you finish a short or long rest.",
                                                    "<b>Object Reading:</b> Holding an object as you meditate, you can see visions of the object's previous owner. After meditating for 1 minute, you learn how the owner acquired and lost the object, as well as the most recent significant event involving the object and that owner. If the object was owned by another creature in the recent past (within a number of days equal to your Wisdom score), you can spend 1 additional minute for each owner to learn the same information about that creature.",
                                                    "<b>Area Reading:</b> As you meditate, you see visions of recent events in your immediate vicinity (a room, street, tunnel, clearing, or the like, up to a 50-foot cube), going back a number of days equal to your Wisdom score. For each minute you meditate, you learn about one significant event, beginning with the most recent. Significant events typically involve powerful emotions, such as battles and betrayals, marriages and murders, births and funerals. However, they might also include more mundane events that are nevertheless important in your current situation."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainLife,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Supreme Healing",
                                                Description = new List<string>
                                                {
                                                    "Starting at 17th level, when you would normally roll one or more dice to restore hit points with a spell, you instead use the highest number possible for each die. For example, instead of restoring 2d6 hit points to a creature, you restore 12."
                                                },
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainLight,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Corona of Light",
                                                Description = new List<string>
                                                {
                                                    "Starting at 17th level, you can use your action to activate an aura of sunlight that lasts for 1 minute or until you dismiss it using another action. You emit bright light in a 60-foot radius and dim light 30 feet beyond that. Your enemies in the bright light have disadvantage on saving throws against any spell that deals fire or radiant damage."
                                                },
                                                Action = new ActionModel
                                                {
                                                    Name = "Corona of Light",
                                                    Description = "Light Domain feature",
                                                    Type = ActionTypesEnum.Option
                                                }
                                            },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainNature,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Master of Nature",
                                                Description = new List<string>
                                                {
                                                    "At 17th level, while creatures are charmed by your Charm Animals and Plants feature, you can take a bonus action on your turn to verbally command what each of those creatures will do on its next turn."
                                                },                                           },
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainTempest,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Stormborn",
                                                Description = new List<string>
                                                {
                                                    "At 17th level, you have a flying speed equal to your current walking speed whenever you are not underground or indoors."
                                                },
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainTrickery,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Improved Duplicity",
                                                Description = new List<string>
                                                {
                                                    "At 17th level, you can create up to four duplicates of yourself, instead of one, when you use Invoke Duplicity. As a bonus action on your turn, you can move any number of them up to 30 feet, to a maximum range of 120 feet."
                                                },
                                            }
                                        },
                                    }
                                },
                                {
                                    ClassEnum.DomainWar,
                                    new LevelModel
                                    {
                                        Features = new List<FeaturesModel>
                                        {
                                            new FeaturesModel
                                            {
                                                Name = "Avatar of Battle",
                                                Description = new List<string>
                                                {
                                                    "At 17th level, you gain resistance to bludgeoning, piercing, and slashing damage from non-magical weapons."
                                                },
                                            }
                                        },
                                        Resistance = new List<DamageTypesEnum>
                                        {
                                            DamageTypesEnum.Bludgeoning,
                                            DamageTypesEnum.Piercing,
                                            DamageTypesEnum.Slashing
                                        },
                                    }
                                },
                            }
                        }
                    },
                    {
                        18,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 5,
                                _1 = 4,
                                _2 = 3,
                                _3 = 3,
                                _4 = 3,
                                _5 = 3,
                                _6 = 1,
                                _7 = 1,
                                _8 = 1,
                                _9 = 1
                            },
                        }
                    },
                    {
                        19,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 5,
                                _1 = 4,
                                _2 = 3,
                                _3 = 3,
                                _4 = 3,
                                _5 = 3,
                                _6 = 2,
                                _7 = 1,
                                _8 = 1,
                                _9 = 1
                            },
                        }
                    },
                    {
                        20,
                        new LevelModel
                        {
                            SpellSlots = new SpellSlotsModel
                            {
                                Cantrips = 5,
                                _1 = 4,
                                _2 = 3,
                                _3 = 3,
                                _4 = 3,
                                _5 = 3,
                                _6 = 2,
                                _7 = 2,
                                _8 = 1,
                                _9 = 1
                            },
                        }
                    },
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Druid.GetEnumText(),
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
                                    AbilityModifier = AbilitiesEnum.Wis,
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
                                Armor = new List<ArmorEnum>
                                {
                                    ArmorEnum.Light,
                                    ArmorEnum.Medium,
                                    ArmorEnum.Shield
                                },
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Int,
                                    AbilitiesEnum.Wis,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.Club,
                                    WeaponsEnum.Dagger,
                                    WeaponsEnum.Dart,
                                    WeaponsEnum.Javelin,
                                    WeaponsEnum.Mace,
                                    WeaponsEnum.Quarterstaff,
                                    WeaponsEnum.Scimitar,
                                    WeaponsEnum.Sickle,
                                    WeaponsEnum.Sling,
                                    WeaponsEnum.Spear,
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Fighter.GetEnumText(),
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
                                Armor = new List<ArmorEnum>
                                {
                                    ArmorEnum.Light,
                                    ArmorEnum.Medium,
                                    ArmorEnum.Heavy,
                                    ArmorEnum.Shield
                                },
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Str,
                                    AbilitiesEnum.Con,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.SimpleWeapon,
                                    WeaponsEnum.MartialWeapon
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Monk.GetEnumText(),
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
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Str,
                                    AbilitiesEnum.Dex,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.SimpleWeapon,
                                    WeaponsEnum.Shortsword,
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Paladin.GetEnumText(),
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
                                Armor = new List<ArmorEnum>
                                {
                                    ArmorEnum.Light,
                                    ArmorEnum.Medium,
                                    ArmorEnum.Heavy,
                                    ArmorEnum.Shield
                                },
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Wis,
                                    AbilitiesEnum.Cha,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.SimpleWeapon,
                                    WeaponsEnum.MartialWeapon
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Ranger.GetEnumText(),
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
                                Armor = new List<ArmorEnum>
                                {
                                    ArmorEnum.Light,
                                    ArmorEnum.Medium,
                                    ArmorEnum.Shield
                                },
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Str,
                                    AbilitiesEnum.Dex,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.SimpleWeapon,
                                    WeaponsEnum.MartialWeapon
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Rogue.GetEnumText(),
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
                                Armor = new List<ArmorEnum>
                                {
                                    ArmorEnum.Light,
                                },
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Dex,
                                    AbilitiesEnum.Int,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.SimpleWeapon,
                                    WeaponsEnum.Longsword,
                                    WeaponsEnum.Rapier,
                                    WeaponsEnum.Shortsword,
                                    WeaponsEnum.CrossbowHand
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Sorcerer.GetEnumText(),
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
                        Name = WeaponsEnum.Dagger.GetEnumText(),
                        Quantity = 2,
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Dagger
                    },
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Dart.GetEnumText(),
                        Quantity = 20,
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Dart
                    },
                    new EquipmentModel
                    {
                        Name = WeaponsEnum.Quarterstaff.GetEnumText(),
                        Type = EquipmentTypeEnum.Weapon,
                        Weapon = WeaponsEnum.Quarterstaff
                    },
                    new EquipmentModel
                    {
                        Name = ToolsEnum.drum.GetEnumText(),
                        Description = "A drum crafted from a bear's skull",
                        Type = EquipmentTypeEnum.Tool
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.HuntingTrap.GetEnumText(),
                        Type = EquipmentTypeEnum.Item
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.TravelersClothes.GetEnumText(),
                        Type = EquipmentTypeEnum.Item
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.ExlporersPack.GetEnumText(),
                        Type = EquipmentTypeEnum.Item
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.ComponentPouch.GetEnumText(),
                        Type = EquipmentTypeEnum.Item
                    },
                    new EquipmentModel
                    {
                        Name = ItemsEnum.BeltPouch.GetEnumText(),
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
                                    AbilityModifier = AbilitiesEnum.Cha,
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
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Con,
                                    AbilitiesEnum.Cha,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.Dagger,
                                    WeaponsEnum.Dart,
                                    WeaponsEnum.Sling,
                                    WeaponsEnum.Quarterstaff,
                                    WeaponsEnum.CrossbowLight
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Warlock.GetEnumText(),
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
                                    AbilityModifier = AbilitiesEnum.Cha,
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
                                Armor = new List<ArmorEnum>
                                {
                                    ArmorEnum.Light,
                                },
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Wis,
                                    AbilitiesEnum.Cha,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.SimpleWeapon,
                                }
                            },
                        }
                    }
                },
            },
            new ClassCard()
            {
                Name = ClassEnum.Wizard.GetEnumText(),
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
                                    AbilityModifier = AbilitiesEnum.Int,
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
                                SavingThrows = new List<AbilitiesEnum>
                                {
                                    AbilitiesEnum.Int,
                                    AbilitiesEnum.Wis,
                                },
                                Weapons = new List<WeaponsEnum>
                                {
                                    WeaponsEnum.Dagger,
                                    WeaponsEnum.Dart,
                                    WeaponsEnum.Sling,
                                    WeaponsEnum.Quarterstaff,
                                    WeaponsEnum.CrossbowLight
                                }
                            },
                        }
                    }
                },
            }
        };
    }
}
