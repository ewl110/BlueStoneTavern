using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;
using TestConsole.Models;

namespace TestConsole.Dictionaries
{
    public static class BackgroundDictionary
    {
        public static Dictionary<string, BackgroundModel> List = new Dictionary<string, BackgroundModel>()
        {
            {
                "acolyte",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){
                        LanguagesEnum.selectLanguage,
                        LanguagesEnum.selectLanguage
                    },
                    Name = "Acolyte",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.insight,
                        SkillsEnum.religion
                    },
                    Tools = new List<ToolsEnum>(){ }
                }
            },
            {
                "charlatan",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){ },
                    Name = "Charlatan",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.deception,
                        SkillsEnum.sleightOfHand
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.disguiseKit,
                        ToolsEnum.forgeryKit
                    }
                }
            },
            {
                "criminal",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){ },
                    Name = "Criminal",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.deception,
                        SkillsEnum.stealth
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.gamingSet,
                        ToolsEnum.thievesTools
                    }
                }
            },
            {
                "entertainer",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){ },
                    Name = "Entertainer",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.acrobatics,
                        SkillsEnum.performance
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.disguiseKit,
                        ToolsEnum.musicalInstrument
                    }
                }
            },
            {
                "folkHero",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){ },
                    Name = "Folk Hero",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.animalHandling,
                        SkillsEnum.survival
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.artisansTools,
                        ToolsEnum.vehiclesLand
                    }
                }
            },
            {
                "guildArtisan",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){
                        LanguagesEnum.selectLanguage
                    },
                    Name = "Guild Artisan",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.insight,
                        SkillsEnum.persuasion
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.artisansTools
                    }
                }
            },
            {
                "guildMerchant",
                new BackgroundModel
                { 
                    Languages = new List<LanguagesEnum>(){
                        LanguagesEnum.selectLanguage
                    },
                    Name = "Guild Merchant",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.insight,
                        SkillsEnum.persuasion
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.navigatorsTools
                    }
                }
            },
            {
                "hermit",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){
                        LanguagesEnum.selectLanguage
                    },
                    Name = "Hermit",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.medicine,
                        SkillsEnum.religion
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.herbalismKit
                    }
                }
            },
            {
                "noble",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){
                        LanguagesEnum.selectLanguage
                    },
                    Name = "Noble",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.history,
                        SkillsEnum.persuasion
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.gamingSet
                    }
                }
            },
            {
                "outlander",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){
                        LanguagesEnum.selectLanguage
                    },
                    Name = "Outlander",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.athletics,
                        SkillsEnum.survival
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.musicalInstrument
                    }
                }
            },
            {
                "pirate",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){ },
                    Name = "Pirate",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.athletics,
                        SkillsEnum.perception
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.navigatorsTools,
                        ToolsEnum.vehiclesWater
                    }
                }
            },
            {
                "knight",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){
                        LanguagesEnum.selectLanguage
                    },
                    Name = "Knight",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.history,
                        SkillsEnum.persuasion
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.gamingSet
                    }
                }
            },
            {
                "sage",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){
                        LanguagesEnum.selectLanguage,
                        LanguagesEnum.selectLanguage
                    },
                    Name = "Sage",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.arcana,
                        SkillsEnum.history
                    },
                    Tools = new List<ToolsEnum>(){ }
                }
            },
            {
                "sailor",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){ },
                    Name = "Sailor",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.athletics,
                        SkillsEnum.perception
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.navigatorsTools,
                        ToolsEnum.vehiclesWater
                    }
                }
            },
            {
                "soldier",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){ },
                    Name = "Soldier",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.athletics,
                        SkillsEnum.intimitdation
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.gamingSet,
                        ToolsEnum.vehiclesLand
                    }
                }
            },
            {
                "spy",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){ },
                    Name = "Spy",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.deception,
                        SkillsEnum.stealth
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.gamingSet,
                        ToolsEnum.thievesTools
                    }
                }
            },
            {
                "urchin",
                new BackgroundModel
                {
                    Languages = new List<LanguagesEnum>(){ },
                    Name = "Urchin",
                    Skills = new List<SkillsEnum>(){
                        SkillsEnum.sleightOfHand,
                        SkillsEnum.stealth
                    },
                    Tools = new List<ToolsEnum>(){
                        ToolsEnum.disguiseKit,
                        ToolsEnum.thievesTools
                    }
                }
            }
        };
    }
}