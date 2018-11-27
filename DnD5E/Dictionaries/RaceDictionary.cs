using DnD5E.Enums;
using DnD5E.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace DnD5E.Dictionaries
{
    public class RaceDictionary
    {
        public static Dictionary<string, RaceModel> List = new Dictionary<string, RaceModel>()
        {
            {
                RaceEnum.human.ToString(),
                new RaceModel
                {
                    Archetype = RaceEnum.human.ToString(),
                    Key = RaceEnum.human.ToString(),
                    Languages = new List<string>() {
                        LanguagesEnum.Common.ToString(),
                        LanguagesEnum.SelectLanguage.ToString() },
                    Name = RaceEnum.human.GetAttributeOfType<DescriptionAttribute>().Description,
                    Size = SizeEnum.medium,
                    Speed = 30
                }
            },
            {
                RaceEnum.humanStandard.ToString(),
                new RaceModel
                {
                    Archetype = RaceEnum.human.ToString(),
                    Asi = "1,1,1,1,1,1",
                    Key = RaceEnum.humanStandard.ToString(),
                    Name = RaceEnum.humanStandard.GetAttributeOfType<DescriptionAttribute>().Description,
                }
            },
            {
                RaceEnum.humanVariant.ToString(),
                new RaceModel
                {
                    Archetype = RaceEnum.human.ToString(),
                    Asi = "0,0,0,0,0,0",
                    Feats = new List<string>() { "selectFeat" },
                    Key = RaceEnum.humanVariant.ToString(),
                    Name = RaceEnum.humanVariant.GetAttributeOfType<DescriptionAttribute>().Description,
                    Skills = new List<string>() { SkillsEnum.SelectSkill.ToString() }
                }
            }
        };
    }
}
