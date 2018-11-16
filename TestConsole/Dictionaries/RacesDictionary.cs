using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestConsole.Enums;
using TestConsole.Models;

namespace TestConsole.Dictionaries
{
    public static class RacesDictionary
    {
        public static Dictionary<string, RaceModel> List = new Dictionary<string, RaceModel>()
        {
            {
                "humanStandard", 
                new RaceModel
                {
                    Asi = "1,1,1,1,1,1",
                    Languages = new List<string>() { LanguagesEnum.common.ToString(), "selectLanguage" },
                    Size = SizesEnum.Medium,
                    Speed = 30
                }
            },
            {
                "humanVariant", 
                new RaceModel
                {
                    Asi = "0,0,0,0,0,0",
                    Feats = new List<string>() { "selectFeat" },
                    Languages = new List<string>() { LanguagesEnum.common.ToString(), "selectLanguage" },
                    Size = SizesEnum.Medium,
                    Skills = new List<string>() { "selectSkill" },
                    Speed = 30
                }
            }
        };
    }
}
