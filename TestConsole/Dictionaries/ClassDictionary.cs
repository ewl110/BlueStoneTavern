using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;
using TestConsole.Models;

namespace TestConsole.Dictionaries
{
    class ClassDictionary
    {
        public static Dictionary<string, ClassModel> List = new Dictionary<string, ClassModel>()
        {
            {
                "barbarian",
                new ClassModel {
                    HitDice = 12,
                    IsCaster = false,
                    Name = "Barbarian",
                    SavingThrows = new AbilitiesEnum[]{
                        AbilitiesEnum.constitution,
                        AbilitiesEnum.strength
                    }
                }
            },
            {
                "berserker",
                new ClassModel {
                    Name = "Berserker",
                    ParentClass = ClassesEnum.barbarian
                }
            },
            {
                "totemWarrior",
                new ClassModel {
                    Name = "Totem Warrior",
                    ParentClass = ClassesEnum.barbarian
                }
            }
        };
    }
}
