using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Models;

namespace TestConsole.Dictionaries.PHB
{
    public static class Skills
    {
        public static Dictionary<string, Skill> List = new Dictionary<string, Skill>()
        {
            {
                "acrobatics",
                new Skill
                {
                    Ability = "dexterity",
                    Description = "",
                    IsProficient = false,
                    Name = "Acrobatics"
                }
            },
            {
                "animalHandling",
                new Skill
                {
                    Ability = "wisdom",
                    Description = "",
                    IsProficient = false,
                    Name = "Animal Handling"
                }
            },
            {
                "arcana",
                new Skill
                {
                    Ability = "intelligence",
                    Description = "",
                    IsProficient = false,
                    Name = "Arcana"
                }
            },
            {
                "athletics",
                new Skill
                {
                    Ability = "strength",
                    Description = "",
                    IsProficient = false,
                    Name = "Athletics"
                }
            },
            {
                "deception",
                new Skill
                {
                    Ability = "charisma",
                    Description = "",
                    IsProficient = false,
                    Name = "Deception"
                }
            },
            {
                "history",
                new Skill
                {
                    Ability = "intelligence",
                    Description = "",
                    IsProficient = false,
                    Name = "History"
                }
            },
            {
                "insight",
                new Skill
                {
                    Ability = "wisdom",
                    Description = "",
                    IsProficient = false,
                    Name = "Insight"
                }
            },
            {
                "intimidation",
                new Skill
                {
                    Ability = "charisma",
                    Description = "",
                    IsProficient = false,
                    Name = "Intimidation"
                }
            },
            {
                "investigation",
                new Skill
                {
                    Ability = "intelligence",
                    Description = "",
                    IsProficient = false,
                    Name = "Investigation"
                }
            },
            {
                "medicine",
                new Skill
                {
                    Ability = "wisdom",
                    Description = "",
                    IsProficient = false,
                    Name = "Medicine"
                }
            },
            {
                "nature",
                new Skill
                {
                    Ability = "intelligence",
                    Description = "",
                    IsProficient = false,
                    Name = "Nature"
                }
            },
            {
                "perception",
                new Skill
                {
                    Ability = "wisdom",
                    Description = "",
                    IsProficient = false,
                    Name = "Perception"
                }
            },
            {
                "performance",
                new Skill
                {
                    Ability = "charisma",
                    Description = "",
                    IsProficient = false,
                    Name = "Performance"
                }
            },
            {
                "persuasion",
                new Skill
                {
                    Ability = "charisma",
                    Description = "",
                    IsProficient = false,
                    Name = "Persuasion"
                }
            },
            {
                "religion",
                new Skill
                {
                    Ability = "intelligence",
                    Description = "",
                    IsProficient = false,
                    Name = "Religion"
                }
            },
            {
                "sleightOfHand",
                new Skill
                {
                    Ability = "dexterity",
                    Description = "",
                    IsProficient = false,
                    Name = "Sleight of Hand"
                }
            },
            {
                "stealth",
                new Skill
                {
                    Ability = "dexterity",
                    Description = "",
                    IsProficient = false,
                    Name = "Stealth"
                }
            },
            {
                "survival",
                new Skill
                {
                    Ability = "wisdom",
                    Description = "",
                    IsProficient = false,
                    Name = "Survival"
                }
            }
        };
    }
}
