using DnD5E.Enums;
using DnD5E.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace DnD5E.Dictionaries
{
    public static class ClassDictionary
    {
        public static Dictionary<string, ClassModel> List = new Dictionary<string, ClassModel>()
        {
            {
                ClassEnum.barbarian.ToString(),
                new ClassModel {
                    HitDice = 12,
                    IsCaster = false,
                    Key = ClassEnum.barbarian.ToString(),
                    Name = ClassEnum.barbarian.GetAttributeOfType<DescriptionAttribute>().Description,
                    SavingThrows = new List<AbilitiesEnum>
                    {
                        AbilitiesEnum.Con,
                        AbilitiesEnum.Str
                    },
                    Skills = new ClassSkillsModel {
                        Available = new List<SkillsEnum>
                        {
                            SkillsEnum.AnimalHandling,
                            SkillsEnum.Athletics,
                            SkillsEnum.Intimidation,
                            SkillsEnum.Nature,
                            SkillsEnum.Perception,
                            SkillsEnum.Survival
                        },
                        Number = 2
                    }
                }
            },
            {
                ClassEnum.berserker.ToString(),
                new ClassModel {
                    Key = ClassEnum.berserker.ToString(),
                    Name = ClassEnum.berserker.GetAttributeOfType<DescriptionAttribute>().Description,
                    ParentClass = ClassEnum.barbarian
                }
            },
            {
                ClassEnum.totemWarrior.ToString(),
                new ClassModel {
                    Key = ClassEnum.totemWarrior.ToString(),
                    Name = ClassEnum.totemWarrior.GetAttributeOfType<DescriptionAttribute>().Description,
                    ParentClass = ClassEnum.barbarian
                }
            }
        };
    }
}
