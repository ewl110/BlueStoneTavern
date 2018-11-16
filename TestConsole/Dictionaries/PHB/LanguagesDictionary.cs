using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestConsole.Enums;
using TestConsole.Models;

namespace TestConsole.Dictionaries.PHB
{
    public static class LanguagesDictionary
    {
        public static Dictionary<string, LanguageModel> List = new Dictionary<string, LanguageModel>()
        {
            {
                "abyssal",
                new LanguageModel
                {
                    Name = "Abyssal",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Exotic
                }
            },
            {
                "arakocra",
                new LanguageModel
                {
                    Name = "Arakocra",
                    Ref = ReferencesEnum.VGtM,
                    Type = LanguageTypesEnum.Exotic
                }
            },
            {
                "celestial",
                new LanguageModel
                {
                    Name = "Celestial",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Exotic
                }
            },
            {
                "common",
                new LanguageModel
                {
                    Name = "Common",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Common
                }
            },
            {
                "deepSpeech",
                new LanguageModel
                {
                    Name = "Deep Speech",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Exotic
                }
            },
            {
                "draconic",
                new LanguageModel
                {
                    Name = "Draconic",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Exotic
                }
            },
            {
                "druidic",
                new LanguageModel
                {
                    Name = "Druidic",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Class
                }
            },
            {
                "dwarvish",
                new LanguageModel
                {
                    Name = "Dwarvish",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Common
                }
            },
            {
                "elvish",
                new LanguageModel
                {
                    Name = "Elvish",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Common
                }
            },
            {
                "giant",
                new LanguageModel
                {
                    Name = "Giant",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Common
                }
            },
            {
                "gith",
                new LanguageModel
                {
                    Name = "Gith",
                    Ref = ReferencesEnum.MToF,
                    Type = LanguageTypesEnum.Exotic
                }
            },
            {
                "gnomish",
                new LanguageModel
                {
                    Name = "Gnomish",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Common
                }
            },
            {
                "goblin",
                new LanguageModel
                {
                    Name = "Goblin",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Common
                }
            },
            {
                "halfling",
                new LanguageModel
                {
                    Name = "Halfling",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Common
                }
            },
            {
                "infernal",
                new LanguageModel
                {
                    Name = "Infernal",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Exotic
                }
            },
            {
                "orc",
                new LanguageModel
                {
                    Name = "Orc",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Common
                }
            },
            {
                "primordial",
                new LanguageModel
                {
                    Name = "Primordial",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Exotic
                }
            },
            {
                "selectLanguage",
                new LanguageModel
                {
                    Name = "Select Language",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Common
                }
            },
            {
                "sylvan",
                new LanguageModel
                {
                    Name = "Sylvan",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Exotic
                }
            },
            {
                "thievesCant",
                new LanguageModel
                {
                    Name = "Thieves' Cant",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Class
                }
            },
            {
                "undercommon",
                new LanguageModel
                {
                    Name = "Undercommon",
                    Ref = ReferencesEnum.PHB,
                    Type = LanguageTypesEnum.Exotic
                }
            },
        };
    }
}
