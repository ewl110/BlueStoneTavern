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
                        Weight = 45
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
                        Weight = 45
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
                        Weight = 100
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
                        Weight = 100
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
                        Weight = 100
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
                        Weight = 100
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
                        Weight = 45
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
                        Weight = 45
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
                        Weight = 100
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
                        Weight = 45
                    },
                },
                Weight = 45
            },
            new RaceCard()
            {
                Name = "Dwarf",
                Weight = 100
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
