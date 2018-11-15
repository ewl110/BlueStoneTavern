using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TestConsole.Enums;
using TestConsole.Models;

namespace TestConsole.Dictionaries.PHB
{
    public static class Languages
    {
        public static Dictionary<string, Language> List = new Dictionary<string, Language>()
        {
            {
                "abyssal",
                new Language
                {
                    Name = "Abyssal",
                    Ref = References.PHB,
                    Type = LanguageTypes.Exotic
                }
            },
            {
                "arakocra",
                new Language
                {
                    Name = "Arakocra",
                    Ref = References.VGtM,
                    Type = LanguageTypes.Exotic
                }
            },
            {
                "celestial",
                new Language
                {
                    Name = "Celestial",
                    Ref = References.PHB,
                    Type = LanguageTypes.Exotic
                }
            },
            {
                "common",
                new Language
                {
                    Name = "Common",
                    Ref = References.PHB,
                    Type = LanguageTypes.Common
                }
            },
            {
                "deepSpeech",
                new Language
                {
                    Name = "Deep Speech",
                    Ref = References.PHB,
                    Type = LanguageTypes.Exotic
                }
            },
            {
                "draconic",
                new Language
                {
                    Name = "Draconic",
                    Ref = References.PHB,
                    Type = LanguageTypes.Exotic
                }
            },
            {
                "druidic",
                new Language
                {
                    Name = "Druidic",
                    Ref = References.PHB,
                    Type = LanguageTypes.Class
                }
            },
            {
                "dwarvish",
                new Language
                {
                    Name = "Dwarvish",
                    Ref = References.PHB,
                    Type = LanguageTypes.Common
                }
            },
            {
                "elvish",
                new Language
                {
                    Name = "Elvish",
                    Ref = References.PHB,
                    Type = LanguageTypes.Common
                }
            },
            {
                "giant",
                new Language
                {
                    Name = "Giant",
                    Ref = References.PHB,
                    Type = LanguageTypes.Common
                }
            },
            {
                "gith",
                new Language
                {
                    Name = "Gith",
                    Ref = References.MToF,
                    Type = LanguageTypes.Exotic
                }
            },
            {
                "gnomish",
                new Language
                {
                    Name = "Gnomish",
                    Ref = References.PHB,
                    Type = LanguageTypes.Common
                }
            },
            {
                "goblin",
                new Language
                {
                    Name = "Goblin",
                    Ref = References.PHB,
                    Type = LanguageTypes.Common
                }
            },
            {
                "halfling",
                new Language
                {
                    Name = "Halfling",
                    Ref = References.PHB,
                    Type = LanguageTypes.Common
                }
            },
            {
                "infernal",
                new Language
                {
                    Name = "Infernal",
                    Ref = References.PHB,
                    Type = LanguageTypes.Exotic
                }
            },
            {
                "orc",
                new Language
                {
                    Name = "Orc",
                    Ref = References.PHB,
                    Type = LanguageTypes.Common
                }
            },
            {
                "primordial",
                new Language
                {
                    Name = "Primordial",
                    Ref = References.PHB,
                    Type = LanguageTypes.Exotic
                }
            },
            {
                "sylvan",
                new Language
                {
                    Name = "Sylvan",
                    Ref = References.PHB,
                    Type = LanguageTypes.Exotic
                }
            },
            {
                "thievesCant",
                new Language
                {
                    Name = "Thieves' Cant",
                    Ref = References.PHB,
                    Type = LanguageTypes.Class
                }
            },
            {
                "undercommon",
                new Language
                {
                    Name = "Undercommon",
                    Ref = References.PHB,
                    Type = LanguageTypes.Exotic
                }
            },
        };
    }
}
