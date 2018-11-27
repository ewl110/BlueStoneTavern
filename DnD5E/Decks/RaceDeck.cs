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
                Languages = new string[]
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
                        Features = new string[]
                        {
                            "<p><b>Draconic Ancestry (Black):</b> You have an acid breath weapon and resistance to acid damage.</p>",
                            "<p><b>Breath weapon:</b> You can use your action to exhale acid in a 5 ft. by 30 ft. line. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.</p>"
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
                        Features = new string[]
                        {
                            "<p><b>Draconic Ancestry (Blue):</b> You have a lightning breath weapon and resistance to lightning damage.</p>",
                            "<p><b>Breath weapon:</b> You can use your action to exhale lightning in a 5 ft. by 30 ft. line. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.</p>"
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
                        Features = new string[]
                        {
                            "<p><b>Draconic Ancestry (Brass):</b> You have a fire breath weapon and resistance to fire damage.</p>",
                            "<p><b>Breath weapon:</b> You can use your action to exhale fire in a 5 ft. by 30 ft. line. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.</p>"
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
                        Features = new string[]
                        {
                            "<p><b>Draconic Ancestry (Bronze):</b> You have a lightning breath weapon and resistance to lightning damage.</p>",
                            "<p><b>Breath weapon:</b> You can use your action to exhale lightning in a 5 ft. by 30 ft. line. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.</p>"
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
                        Features = new string[]
                        {
                            "<p><b>Draconic Ancestry (Copper):</b> You have an acid breath weapon and resistance to acid damage.</p>",
                            "<p><b>Breath weapon:</b> You can use your action to exhale acid in a 5 ft. by 30 ft. line. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.</p>"
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
                        Features = new string[]
                        {
                            "<p><b>Draconic Ancestry (Gold):</b> You have a fire breath weapon and resistance to fire damage.</p>",
                            "<p><b>Breath weapon:</b> You can use your action to exhale fire in a 15 ft. cone. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.</p>"
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
                        Features = new string[]
                        {
                            "<p><b>Draconic Ancestry (Green):</b> You have a poison breath weapon and resistance to poison damage.</p>",
                            "<p><b>Breath weapon:</b> You can use your action to exhale fire in a 15 ft. cone. Each creature in the affected area must make a CON saving throw (DC = 8 + CON modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.</p>"
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
                        Features = new string[]
                        {
                            "<p><b>Draconic Ancestry (Red):</b> You have a fire breath weapon and resistance to fire damage.</p>",
                            "<p><b>Breath weapon:</b> You can use your action to exhale fire in a 15 ft. cone. Each creature in the affected area must make a DEX saving throw (DC = 8 + DEX modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.</p>"
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
                        Features = new string[]
                        {
                            "<p><b>Draconic Ancestry (Silver):</b> You have a cold breath weapon and resistance to cold damage.</p>",
                            "<p><b>Breath weapon:</b> You can use your action to exhale fire in a 15 ft. cone. Each creature in the affected area must make a CON saving throw (DC = 8 + CON modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.</p>"
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
                        Features = new string[]
                        {
                            "<p><b>Draconic Ancestry (White):</b> You have a cold breath weapon and resistance to cold damage.</p>",
                            "<p><b>Breath weapon:</b> You can use your action to exhale fire in a 15 ft. cone. Each creature in the affected area must make a CON saving throw (DC = 8 + CON modifier + proficiency bonus). A creature takes 2d6 damage on a failed save, and half as much damage on a successful one. The damage increase to 3d6 at 6th level, 4d6 at 11th, and 5d6 at 16th level. After using your breath weapon, you cannot use it again until you complete a short or long rest.</p>"
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
                Features = new string[]
                {
                    "<p><b>Speed:</b> Your speed is not reduced by wearing heavy armor.</p>",
                    "<p><b>Darkvision:</b> Accustomed to life underground, you have superior vision in dark and dim conditions. You can see in dim light within 60 feet of you as if it were bright light, and in darkness as if it were dim light. You can't discern color in darkness, only shades of gray.</p>",
                    "<p><b>Dwarven Resilience:</b> You have advantage on saving throws against poison, and you have resistance against poison damage.</p>",
                    "<p><b>Dwarven Combat Training:</b> You have proficiency with the battleaxe, handaxe, throwing hammer, and warhammer.</p>",
                    "<p><b>Stonecunning:</b> Whenever you make an INT (History) check related to the origin of stonework, you are considered proficient in the History skill and add double your proficiency bonus to the check, instead of your normal proficiency bonus.</p>"
                },
                Languages = new string[]
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
                        Features = new string[]
                        {
                            "<p><b>Superior Darkvision:</b> Your darkvision has a radius of 120 feet.</p>",
                            "<p><b>Duergar Resilience:</b> You have advantage on saving throws against illusions and against being charmed or paralyzed.</p>",
                            "<p><b>Duergar Magic:</b> When you reach 3rd level, you can cast the enlarge/reduce spell on yourself once with this trait, using only the spell's enlarge option. When you reach 5th level, you can cast the invisibility spell on yourself once with this trait. You don't need material components for either spell, and you can't cast them while you're in direct sunlight, although sunlight has no effect on them once cast. You regain the ability to cast these spells with this trait when you finish a long rest. Intelligence is your spellcasting ability for these spells.</p>",
                            "<p><b>Sunlight Sensitivity:</b> You have disadvantage on attack rolls and on WIS (Perception) checks that rely on sight when you, the target of your attack, or whatever you are trying to perceive is in direct sunlight.</p>"
                        },
                        Languages = new string[]
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
                        Features = new string[]
                        {
                            "<p><b>Dwarven Toughness:</b> Your hit point maximum increases by 1, and it increases by 1 every time you gain a level.</p>"
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
                        Features = new string[]
                        {
                            "<p><b>Dwarven Armor Training:</b> You have proficiency with light and medium armor.</p>"
                        },
                        Name = "Mountain Dwarf",
                        Weight = (int)RarityEnum.Common
                    },
                },
                Weight = (int)RarityEnum.Common
            },
            new RaceCard()
            {
                Name = "Elf",
                Speed = 35,
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Gnome",
                Speed = 25,
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Halfling",
                Speed = 25,
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Human",
                Weight = 100
            }
        };
    }
}
