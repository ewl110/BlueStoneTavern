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
                ClassEnum.Barbarian.ToString(),
                new ClassModel {
                    HitDice = 12,
                    IsCaster = false,
                    Key = ClassEnum.Barbarian.ToString(),
                    Name = ClassEnum.Barbarian.GetAttributeOfType<DescriptionAttribute>().Description,
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
                ClassEnum.Berserker.ToString(),
                new ClassModel {
                    Key = ClassEnum.Berserker.ToString(),
                    Name = ClassEnum.Berserker.GetAttributeOfType<DescriptionAttribute>().Description,
                    ParentClass = ClassEnum.Barbarian
                }
            },
            {
                ClassEnum.TotemWarrior.ToString(),
                new ClassModel {
                    Key = ClassEnum.TotemWarrior.ToString(),
                    Name = ClassEnum.TotemWarrior.GetAttributeOfType<DescriptionAttribute>().Description,
                    ParentClass = ClassEnum.Barbarian
                }
            }
        };
    }
}
