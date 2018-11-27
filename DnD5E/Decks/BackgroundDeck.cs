using DnD5E.Enums;
using DnD5E.Models;
using System.Collections.Generic;
using System.ComponentModel;

namespace DnD5E.Decks
{
    public static class BackgroundDeck
    {
        public static List<BackgroundCard> Cards = new List<BackgroundCard>()
        {
            new BackgroundCard()
            {
                Name = "Acolyte",
                Description = "You have spent your life in the service of a temple to a specific god or pantheon of gods. You act as an intermediary between the realm of the holy and the mortal world, performing sacred rites and offering sacrifices in order to conduct worshipers into the presence of the divine. You are not necessarily a cleric — performing sacred rites is not the same thing as channeling divine power.",
                Feature = "<p><b>Shelter of the Faithful:/b> As an acolyte, you command the respect of those who share your faith, and you can perform the religious ceremonies of your deity. You and your adventuring companions can expect to receive free healing and care at a temple, shrine, or other established presence of your faith, though you must provide any material components needed for spells. Those who share your religion will support you (but only you) at a modest lifestyle.<p><p>You might also have ties to a specific temple dedicated to your chosen deity or pantheon, and you have a residence there. This could be the temple where you used to serve, if you remain on good terms with it, or a temple where you have found a new home. While near your temple, you can call upon the priests for assistance, provided the assistance you ask for is not hazardous and you remain in good standing with your temple.</p>",
                Proficiencies = new ProficiencyModel
                {
                    Skills = new string[]{
                        SkillsEnum.Insight.ToString(),
                        SkillsEnum.Religion.ToString()
                    }
                },
                Bond = new string[]{
                    "I would die to recover an ancient relic of my faith that was lost long ago.",
                    "I will someday get revenge on the corrupt temple hierarchy who branded me a heretic.",
                    "I owe my life to the priest who took me in when my parents died.",
                    "Everything I do is for the common people.",
                    "I will do anything to protect the temple where I served.",
                    "I seek to preserve a sacred text that my enemies consider heretical and seek to destroy."
                },
                Flaw = new string[]{
                    "I judge others harshly, and myself even more severely.",
                    "I put too much trust in those who wield power within my temple's hierarchy.",
                    "My piety sometimes leads me to blindly trust those that profess faith in my god.",
                    "I am inflexible in my thinking.",
                    "I am suspicious of strangers and expect the worst of them.",
                    "Once I pick a goal, I become obsessed with it to the detriment of everything else in my life."
                },
                Ideal = new string[]{
                    "Tradition. The ancient traditions of worship and sacrifice must be preserved and upheld. (Lawful)",
                    "Charity. I always try to help those in need, no matter what the personal cost. (Good)",
                    "Change. We must help bring about the changes the gods are constantly working in the world. (Chaotic)",
                    "Power. I hope to one day rise to the top of my faith's religious hierarchy. (Lawful)",
                    "Faith. I trust that my deity will guide my actions, I have faith that if I work hard, things will go well. (Lawful)",
                    "Aspiration. I seek to prove myself worthy of my god's favor by matching my actions against his or her teachings. (Any)"
                },
                Personality = new string[]{
                    "I idolize a particular hero of my faith, and constantly refer to that person's deeds and example.",
                    "I can find common ground between the fiercest enemies, empathizing with them and always working toward peace.",
                    "I see omens in every event and action. The gods try to speak to us, we just need to listen",
                    "Nothing can shake my optimistic attitude.",
                    "I quote (or misquote) sacred texts and proverbs in almost every situation.",
                    "I am tolerant (or intolerant) of other faiths and respect (or condemn) the worship of other gods.",
                    "I've enjoyed fine food, drink, and high society among my temple's elite. Rough living grates on me.",
                    "I've spent so long in the temple that I have little practical experience dealing with people in the outside world.",
                },
                Languages = new string[] {
                    LanguagesEnum.SelectLanguage.GetAttributeOfType<DescriptionAttribute>().Description,
                    LanguagesEnum.SelectLanguage.GetAttributeOfType<DescriptionAttribute>().Description
                },
                Equipment = new string[]{
                    "A holy symbol (a gift to you when you entered the priesthood)",
                    "a prayer book or prayer wheel",
                    "5 sticks of incense, vestments",
                    "a set of common clothes",
                    "a belt pouch"
                },
                Money = new MoneyModel
                {
                    Gp = 15
                }
            },
            new BackgroundCard()
            {
                Name = "Charlatan",
                Description = "You have always had a way with people. You know what makes them tick, you can tease out their hearts' desires after a few minutes of conversation, and with a few leading questions you can read them like they were children's books. It's a useful talent, and one that you're perfectly willing to use for your advantage. You know what people want and you deliver, or rather, you promise to deliver. Common sense should steer people away from things that sound too good to be true, but common sense seems to be in short supply when you're around. The bottle of pink-colored liquid will surely cure that unseemly rash, this ointment — nothing more than a bit of fat with a sprinkle of silver dust — can restore youth and vigor, and there's a bridge in the city that just happens to be for sale. These marvels sound implausible, but you make them sound like the real deal.",
                Feature = "<p><b>False Identity:</b> You have created a second identity that includes documentation, established acquaintances, and disguises that allow you to assume that persona. Additionally, you can forge documents including official papers and personal letters, as long as you have seen an example of the kind of document or the handwriting you are trying to copy.</p>",
                Proficiencies = new ProficiencyModel
                {
                    Skills = new string[]{
                        SkillsEnum.Deception.ToString(),
                        SkillsEnum.SleightOfHand.GetAttributeOfType<DescriptionAttribute>().Description
                    },
                    Tools = new string[]{
                        ToolsEnum.disguiseKit.GetAttributeOfType<DescriptionAttribute>().Description,
                        ToolsEnum.forgeryKit.GetAttributeOfType<DescriptionAttribute>().Description
                    }
                },
                Ideal = new string[]{
                    "Independence. I am a free spirit — no one tells me what to do. (Chaotic)",
                    "Fairness. I never target people who can't afford to lose a few coins. (Lawful)",
                    "Charity. I distribute the money I acquire to the people who really need it. (Good)",
                    "Creativity. I never run the same con twice. (Chaotic)",
                    "Friendship. Material goods come and go. Bonds of friendship last forever. (Good)",
                    "Aspiration. I'm determined to make something of myself. (Any)"
                },
                Bond = new string[]{
                    "I fleeced the wrong person and must work to ensure that this individual never crosses paths with me or those I care about.",
                    "I owe everything to my mentor — a horrible person who's probably rotting in jail somewhere.",
                    "Somewhere out there, I have a child who doesn't know me. I'm making the world better for him or her.",
                    "I come from a noble family, and one day I'll reclaim my lands and title from those who stole them from me.",
                    "A powerful person killed someone I love. Some day soon, I'll have my revenge.",
                    "I swindled and ruined a person who didn't deserve it. I seek to atone for my misdeeds but might never be able to forgive myself."
                },
                Flaw = new string[]{
                    "I can't resist a pretty face.",
                    "I'm always in debt. I spend my ill-gotten gains on decadent luxuries faster than I bring them in.",
                    "I'm convinced that no one could ever fool me the way I fool others.",
                    "I'm too greedy for my own good. I can't resist taking a risk if there's money involved.",
                    "I can't resist swindling people who are more powerful than me.",
                    "I hate to admit it and will hate myself for it, but I'll run and preserve my own hide if the going gets tough."
                },
                Personality = new string[]{
                    "I fall in and out of love easily, and am always pursuing someone.",
                    "I have a joke for every occasion, especially occasions where humor is inappropriate.",
                    "Flattery is my preferred trick for getting what I want.",
                    "I'm a born gambler who can't resist taking a risk for a potential payoff.",
                    "I lie about almost everything, even when there's no good reason to.",
                    "Sarcasm and insults are my weapons of choice.",
                    "I keep multiple holy symbols on me and invoke whatever deity might come in useful at any given moment.",
                    "I pocket anything I see that might have some value.",
                },
                Equipment = new string[]{
                    "A set of fine clothes",
                    "a disguise kit, tools of the con of your choice (ten stoppered bottles filled with colored liquid",
                    "a set of weighted dice",
                    "a deck of marked cards or a signet ring of an imaginary duke),",
                    "a belt pouch"
                },
                Money = new MoneyModel
                {
                    Gp = 15
                }
            },
            new BackgroundCard()
            {
                Name = "Criminal",
                Description = "You are an experienced criminal with a history of breaking the law. You have spent a lot of time among other criminals and still have contacts within the criminal underworld. You’re far closer than most people to the world of murder, theft, and violence that pervades the underbelly of civilization, and you have survived up to this point by flouting the rules and regulations of society.",
                Feature = "<p><b>Criminal Contact:</b> You have a reliable and trustworthy contact who acts as your liaison to a network of other criminals. You know how to get messages to and from your contact, even over great distances; specifically, you know the local messengers, corrupt caravan masters, and seedy sailors who can deliver messages for you.</p>",
                Proficiencies = new ProficiencyModel
                {
                    Skills = new string[]{
                        SkillsEnum.Deception.ToString(),
                        SkillsEnum.Stealth.ToString()
                    },
                    Tools = new string[]{
                        ToolsEnum.selectGameSet.GetAttributeOfType<DescriptionAttribute>().Description,
                        ToolsEnum.thievesTools.GetAttributeOfType<DescriptionAttribute>().Description
                    }
                },
                Ideal = new string[]{
                    "Honor. I don't steal from others in the trade. (Lawful)",
                    "Freedom. Chains are meant to be broken, as are those who would forge them. (Chaotic)",
                    "Charity. I steal from the wealthy so that I can help people in need. (Good)",
                    "Greed. I will do whatever it takes to become wealthy. (Evil)",
                    "People. I'm loyal to my friends, not to any ideals, and everyone else can take a trip down the Styx for all I care. (Neutral)",
                    "Redemption. There's a spark of good in everyone. (Good)"
                },
                Bond = new string[]{
                    "I'm trying to pay off an old debt I owe to a generous benefactor.",
                    "My ill-gotten gains go to support my family.",
                    "Something important was taken from me, and I aim to steal it back.",
                    "I will become the greatest thief that ever lived.",
                    "I'm guilty of a terrible crime. I hope I can redeem myself for it.",
                    "Someone I loved died because of a mistake I made. That will never happen again."
                },
                Flaw = new string[]{
                    "When I see something valuable, I can't think about anything but how to steal it.",
                    "When faced with a choice between money and my friends, I usually choose the money.",
                    "If there's a plan, I'll forget it. If I don't forget it, I'll ignore it.",
                    "I have a \"tell\" that reveals when I'm lying.",
                    "I turn tail and run when things look bad.",
                    "An innocent person is in prison for a crime that I committed. I'm okay with that."
                },
                Personality = new string[]{
                    "I always have a plan for what to do when things go wrong.",
                    "I am always calm, no matter what the situation. I never raise my voice or let my emotions control me.",
                    "The first things to do in a new place is note the locations of everything valuable — or where such things could be hidden.",
                    "I would rather make a new friend than a new enemy.",
                    "I am incredibly slow to trust. Those who seem the fairest often have the most to hide.",
                    "I don't pay attention to the risks in a situation. Never tell me the odds.",
                    "The best way to get me to do something is to tell me I can't do it.",
                    "I blow up at the slightest insult.",
                },
                Equipment = new string[]{
                    "A crowbar",
                    "a set of dark common clothes including a hood",
                    "a belt pouch"
                },
                Money = new MoneyModel
                {
                    Gp = 15
                }
            },
            new BackgroundCard()
            {
                Name = "Entertainer",
                Description = "You thrive in front of an audience. You know how to entrance them, entertain them, and even inspire them. Your poetics can stir the hearts of those who hear you, awakening grief or joy, laughter or anger. Your music raises their spirits or captures their sorrow. Your dance steps captivate, your humor cuts to the quick. Whatever techniques you use, your art is your life.",
                Feature = "<p><b>By Popular Demand:</b> You can always find a place to perform, usually in an inn or tavern but possibly with a circus, at a theater, or even in a noble's court. At such a place, you receive free lodging and food of a modest or comfortable standard (depending on the quality of the establishment), as long as you perform each night. In addition, your performance makes you something of a local figure. When strangers recognize you in a town where you have performed, they typically take a liking to you.</p>",
                Proficiencies = new ProficiencyModel
                {
                    Skills = new string[]{
                        SkillsEnum.Acrobatics.ToString(),
                        SkillsEnum.Performance.ToString()
                    },
                    Tools = new string[]{
                        ToolsEnum.disguiseKit.GetAttributeOfType<DescriptionAttribute>().Description,
                        ToolsEnum.selectInstrument.GetAttributeOfType<DescriptionAttribute>().Description
                    }
                },
                Ideal = new string[]{
                    "Beauty. When I perform, I make the world better than it was. (Good)",
                    "Tradition. The stories, legends, and songs of the past must never be forgotten, for they teach us who we are. (Lawful)",
                    "Creativity. The world is in need of new ideas and bold action. (Chaotic)",
                    "Greed. I'm only in it for the money and fame. (Evil)",
                    "People. I like seeing the smiles on people's faces when I perform. That's all that matters. (Neutral)",
                    "Honesty. Art should reflect the soul; it should come from within and reveal who we really are. (Any)"
                },
                Bond = new string[]{
                    "My instrument is my most treasured possession, and it reminds me of someone I love.",
                    "Someone stole my precious instrument, and someday I'll get it back.",
                    "I want to be famous, whatever it takes.",
                    "I idolize a hero of the old tales and measure my deeds against that person's.",
                    "I will do anything to prove myself superior to my hated rival.",
                    "I would do anything for the other members of my old troupe."
                },
                Flaw = new string[]{
                    "I'll do anything to win fame and renown.",
                    "I'm a sucker for a pretty face.",
                    "A scandal prevents me from ever going home again. That kind of trouble seems to follow me around.",
                    "I once satirized a noble who still wants my head. It was a mistake that I will likely repeat.",
                    "I have trouble keeping my true feelings hidden. My sharp tongue lands me in trouble.",
                    "Despite my best efforts, I am unreliable to my friends."
                },
                Personality = new string[]{
                    "I know a story relevant to almost every situation.",
                    "Whenever I come to a new place, I collect local rumors and spread gossip.",
                    "I'm a hopeless romantic, always searching for that \"special someone.\"",
                    "Nobody stays angry at me or around me for long, since I can defuse any amount of tension.",
                    "I love a good insult, even one directed at me.",
                    "I get bitter if I'm not the center of attention.",
                    "I'll settle for nothing less than perfection.",
                    "I change my mood or my mind as quickly as I change key in a song.",
                },
                Equipment = new string[]{
                    "A musical instrument (one of your choice)",
                    "the favor of an admirer (love letter, lock of hair, or trinket)",
                    "a costume, ",
                    "a belt pouch"
                },
                Money = new MoneyModel
                {
                    Gp = 15
                }
            },
            new BackgroundCard()
            {
                Name = "Outlander",
                Description = "You grew up in the wilds, far from civilization and the comforts of town and technology. You’ve witnessed the migration of herds larger than forests, survived weather more extreme than any city-dweller could comprehend, and enjoyed the solitude of being the only thinking creature for miles in any direction. The wilds are in your blood, whether you were a nomad, an explorer, a recluse, a hunter-gatherer, or even a marauder. Even in places where you don’t know the specific features of the terrain, you know the ways of the wild.",
                Feature = "<p><b>Wanderer:/b> You have an excellent memory for maps and geography, and you can always recall the general layout of terrain, settlements, and other features around you. In addition, you can find food and fresh water for yourself and up to five other people each day, provided that the land offers berries, small game, water, and so forth.</p>",
                Proficiencies = new ProficiencyModel
                {
                    Skills = new string[]{
                        SkillsEnum.Athletics.ToString(),
                        SkillsEnum.Survival.ToString()
                    },
                    Tools = new string[]{
                        ToolsEnum.selectInstrument.GetAttributeOfType<DescriptionAttribute>().Description
                    }
                },
                Bond = new string[]{
                    "My family, clan, or tribe is the most important thing in my life, even when they are far from me.",
                    "An injury to the unspoiled wilderness of my home is an injury to me.",
                    "I will bring terrible wrath down on the evildoers who destroyed my homeland.",
                    "I am the last of my tribe, and it is up to me to ensure their names enter legend.",
                    "I suffer awful visions of a coming disaster and will do anything to prevent it.",
                    "It is my duty to provide children to sustain my tribe."
                },
                Flaw = new string[]{
                    "I am too enamored of ale, wine, and other intoxicants.",
                    "There's no room for caution in a life lived to the fullest.",
                    "I remember every insult I've received and nurse a silent resentment toward anyone who's ever wronged me.",
                    "I am slow to trust members of other races, tribes, and societies.",
                    "Violence is my answer to almost any challenge.",
                    "Don't expect me to save those who can't save themselves. It is nature's way that the strong thrive and the weak perish."
                },
                Ideal = new string[]{
                    "Change. Life is like the seasons, in constant change, and we must change with it. (Chaotic)",
                    "Greater Good. It is each person's responsibility to make the most happiness for the whole tribe. (Good)",
                    "Honor. If I dishonor myself, I dishonor my whole clan. (Lawful)",
                    "Might. The strongest are meant to rule. (Evil)",
                    "Nature. The natural world is more important than all the constructs of civilization. (Neutral)",
                    "Glory. I must earn glory in battle, for myself and my clan. (Any)"
                },
                Personality = new string[]{
                    "I'm driven by a wanderlust that led me away from home.",
                    "I watch over my friends as if they were a litter of newborn pups.",
                    "I once ran twenty-five miles without stopping to warn to my clan of an approaching orc horde. I'd do it again if I had to.",
                    "I have a lesson for every situation, drawn from observing nature.",
                    "I place no stock in wealthy or well-mannered folk. Money and manners won't save you from a hungry owlbear.",
                    "I'm always picking things up, absently fiddling with them, and sometimes accidentally breaking them.",
                    "I feel far more comfortable around animals than people.",
                    "I was, in fact, raised by wolves.",
                },
                Languages = new string[] {
                    LanguagesEnum.SelectLanguage.GetAttributeOfType<DescriptionAttribute>().Description
                },
                Equipment = new string[]{
                    "A staff",
                    "a hunting trap",
                    "a trophy from an animal you killed",
                    "a set of traveler’s clothes",
                    "a belt pouch"
                },
                Money = new MoneyModel
                {
                    Gp = 10
                }
            },
        };
    }
}
