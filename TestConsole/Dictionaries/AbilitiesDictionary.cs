using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Models;

namespace TestConsole.Dictionaries
{
    public static class AbilitiesDictionary
    {
        public static Dictionary<string, Ability> List = new Dictionary<string, Ability>()
        {

            {
                "strength",
                new Ability
                {
                    AbilityScore = 10,
                    Description = "",
                    HasSavingThrow = false,
                    Name = "Strength"
                }
            },
            {
                "dexterity",
                new Ability
                {
                    AbilityScore = 10,
                    Description = "",
                    HasSavingThrow = false,
                    Name = "Dexterity"
                }
            },
            {
                "constitution",
                new Ability
                {
                    AbilityScore = 10,
                    Description = "",
                    HasSavingThrow = false,
                    Name = "Constitution"
                }
            },
            {
                "intelligence",
                new Ability
                {
                    AbilityScore = 10,
                    Description = "",
                    HasSavingThrow = false,
                    Name = "Intelligence"
                }
            },
            {
                "wisdom",
                new Ability
                {
                    AbilityScore = 10,
                    Description = "",
                    HasSavingThrow = false,
                    Name = "Wisdom"
                }
            },
            {
                "charisma",
                new Ability
                {
                    AbilityScore = 10,
                    Description = "",
                    HasSavingThrow = false,
                    Name = "Charisma"
                }
            }
        };
    }
}
