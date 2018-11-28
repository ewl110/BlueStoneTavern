using DnD5E.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5E.Characters
{
    public class Character
    {
        private Random rng = new Random();

        public readonly Guid id;

        private BackgroundCard charBackgroundCard;
        private ClassCard charClassCard;
        private ClassCard charSubClassCard;
        private RaceCard charRaceCard;
        private RaceCard charRaceVariantCard;

        private AbilityScoresModel abilityScores;
        private int age;
        private CharacterBackgroundModel charBackground;
        private string charClass;
        private string charRace;

        private int deathSavesFailed;
        private int deathSavesPassed;
        private int hitDice;
        private int hitDiceUsed;
        private int hitPointCurrent;
        private int hitPointMax;

        private List<string> immunity;
        private List<string> languages;
        private List<string> proficiencyArmor;
        private int proficiencyBonus;
        private List<string> proficiencySkills;
        private List<string> proficiencyTools;
        private List<string> proficiencyWeapons;
        private List<string> resistance;
        private int speed;

        private int level;

        public Guid Id {
            get
            {
                return this.id;
            }
        }

        //public AbilityScoresModel AbilityScores
        //{
        //    get
        //    {
        //        return this.abilityScores;
        //    }
        //    set
        //    {
        //        this.abilityScores = value;
        //    }
        //}
        //public int Age
        //{
        //    get
        //    {
        //        return this.age;
        //    }
        //    set
        //    {
        //        this.age = value;
        //    }
        //}
        //public string CharBackground
        //{
        //    get
        //    {
        //        return this.charBackground;
        //    }
        //    set
        //    {
        //        this.charBackground = value;
        //    }
        //}
        //public string CharClass
        //{
        //    get
        //    {
        //        return this.charClass;
        //    }
        //    set
        //    {
        //        this.charClass = value;
        //    }
        //}
        //public string CharRace
        //{
        //    get
        //    {
        //        return this.charRace;
        //    }
        //    set
        //    {
        //        this.charRace = value;
        //    }
        //}
        //public List<string> Languages;

        //public int Level {
        //    get
        //    {
        //        return this.level;
        //    }
        //    set
        //    {
        //        this.level = value;
        //    }
        //}

        public Character() : this(1) {}

        public Character(int level)
        {
            this.charBackgroundCard = Decks.BackgroundDeck.Cards.PullRandomCardFromDeck();
            this.charClassCard = Decks.ClassDeck.Cards.PullRandomCardFromDeck(true);
            this.charRaceCard = Decks.RaceDeck.Cards.PullRandomCardFromDeck(true);
            this.charRaceVariantCard = this.charRaceCard.Variants.PullRandomCardFromDeck(true);

            this.abilityScores = GetAbilityScores( this.charClassCard.AbilityScores, this.charRaceCard.AbilityScores, this.charRaceVariantCard.AbilityScores );
            this.age = rng.Next(this.charRaceCard.AgeRange.Min, this.charRaceCard.AgeRange.Max);
            this.charBackground = GetBackground();
            this.charClass = this.charClassCard.Name;
            this.charRace = this.charRaceVariantCard.Name;
            this.hitDice = this.charClassCard.HitDice;
            this.hitPointCurrent = this.hitPointMax = this.charClassCard.HitDice + this.abilityScores.ConMod;
            this.id = CreateGuid();
            this.languages = GetLanguages();
            this.level = level;
            this.proficiencyBonus = GetProficiencyBonus();
            this.proficiencySkills = GetSkills();
            this.speed = this.charRaceVariantCard.Speed != 30? this.charRaceVariantCard.Speed : this.charRaceCard.Speed;
        }

        private Guid CreateGuid()
        {
            Guid id = Guid.Empty;

            if (id == Guid.Empty)
            {
                id = Guid.NewGuid();
            }

            return id;
        }

        public CharacterCard CreateNewCharacter()
        {
            CharacterCard randomCharacter = new CharacterCard()
            {
                AbilityScores = this.abilityScores,
                Age = this.age,
                Background = this.charBackground,
                Class = this.charClass,
                HitPoints = new HitPointsModel
                {
                    HitDice = this.hitDice,
                    HitDiceAvailable = this.hitDice,
                    HitPointsCurrent = this.hitPointCurrent,
                    HitPointsMax = this.hitPointMax,
                },
                Id = this.id,
                Languages = this.languages,
                Level = this.level,
                PassivePerception = GetPassivePerception(),
                ProficiencyBonus = this.proficiencyBonus,
                ProficiencySkills = this.proficiencySkills,
                Race = this.charRace,
                Size = this.charRaceCard.Size,
                Speed = this.speed
            };

            return randomCharacter;
        }

        private AbilityScoresModel GetAbilityScores(AbilityScoresModel classAS, AbilityScoresModel raceAS, AbilityScoresModel raceVariantAS)
        {
            int Str = classAS.Str + raceAS.Str + raceVariantAS.Str;
            int Dex = classAS.Dex + raceAS.Dex + raceVariantAS.Dex;
            int Con = classAS.Con + raceAS.Con + raceVariantAS.Con;
            int Int = classAS.Int + raceAS.Int + raceVariantAS.Int;
            int Wis = classAS.Wis + raceAS.Wis + raceVariantAS.Wis;
            int Cha = classAS.Cha + raceAS.Cha + raceVariantAS.Cha;

            AbilityScoresModel newAbilityScores = new AbilityScoresModel()
            {
                Str = Str,
                StrMod = GetAbilityScoreModifier(Str),
                Dex = Dex,
                DexMod = GetAbilityScoreModifier(Dex),
                Con = Con,
                ConMod = GetAbilityScoreModifier(Con),
                Int = Int,
                IntMod = GetAbilityScoreModifier(Int),
                Wis = Wis,
                WisMod = GetAbilityScoreModifier(Wis),
                Cha = Cha,
                ChaMod = GetAbilityScoreModifier(Cha),
            };

            return newAbilityScores;
        }

        private int GetAbilityScoreModifier(int abilityScore)
        {
            int abilityScoreModifier = (abilityScore - 10 ) / 2;

            if (abilityScore % 2 != 0)
            {
                abilityScoreModifier = ((abilityScore - 1) - 10) / 2;
            }

            return abilityScoreModifier;
        }

        private CharacterBackgroundModel GetBackground()
        {
            CharacterBackgroundModel background = new CharacterBackgroundModel {
                Bond = this.charBackgroundCard.Bond.PickRandomItemFromArray(),
                Description = this.charBackgroundCard.Description,
                Feature = new CharacterFeatureModel
                {
                    Description = this.charBackgroundCard.Feature.Description,
                    Name = this.charBackgroundCard.Feature.Name
                },
                Flaw = this.charBackgroundCard.Flaw.PickRandomItemFromArray(),
                Ideal = this.charBackgroundCard.Ideal.PickRandomItemFromArray(),
                Name = this.charBackgroundCard.Name,
                Personality = this.charBackgroundCard.Personality.PickRandomItemFromArray()
        };

            return background;
        }

        private List<string> GetLanguages() {
            List<string> languages = new List<string>(){ };

            if (this.charBackgroundCard.Languages != null)
            {
                foreach (var item in this.charBackgroundCard.Languages)
                {
                    languages.Add(item);
                }
            }

            if (this.charRaceCard.Languages != null)
            {
                foreach (var item in this.charRaceCard.Languages)
                {
                    languages.Add(item);
                }
            }

            if (this.charRaceVariantCard.Languages != null)
            {
                foreach (var item in this.charRaceVariantCard.Languages)
                {
                    languages.Add(item);
                }
            }

            return languages;
        }

        private int GetPassivePerception() {
            int passivePerception = 10 + this.abilityScores.WisMod;

            if ( string.Join(",", this.proficiencySkills).Contains("Perception") )
            {
                passivePerception += this.proficiencyBonus;
            }

            return passivePerception;
        }

        private int GetSkillModifier(string skill) {
            int skillModifier = this.proficiencyBonus;

            switch (skill)
            {
                case "Acrobatics":
                case "Sleight of Hand":
                case "Stealth":
                    skillModifier += this.abilityScores.DexMod;
                    break;
                case "Arcana":
                case "History":
                case "Investigation":
                case "Nature":
                case "Religion":
                    skillModifier += this.abilityScores.IntMod;
                    break;
                case "Animal Handling":
                case "Insight":
                case "Medicine":
                case "Perception":
                case "Survival":
                    skillModifier += this.abilityScores.WisMod;
                    break;
                case "Athletics":
                    skillModifier += this.abilityScores.StrMod;
                    break;
                case "Deception":
                case "Intimidation":
                case "Performance":
                case "Persuasion":
                    skillModifier += this.abilityScores.ChaMod;
                    break;
            }

            return skillModifier;
        }

        private int GetProficiencyBonus()
        {
            int level = this.level;
            int proficiencyBonus = 2;

            if (level > 4)
            {
                proficiencyBonus = 3;
            }

            if (level > 8)  
            {
                proficiencyBonus = 4;
            }

            if (level > 12)
            {
                proficiencyBonus = 5;
            }

            if (level > 16)
            {
                proficiencyBonus = 6;
            }

            return proficiencyBonus;
        }

        private List<string> GetSkills() {
            int skillModifier = 0;
            List<string> skills = new List<string>() { };

            if (this.charBackgroundCard.Proficiencies != null && this.charBackgroundCard.Proficiencies.Skills != null)
            {
                foreach (var item in this.charBackgroundCard.Proficiencies.Skills)
                {
                    skillModifier = GetSkillModifier(item);
                    skills.Add($"{item} +{skillModifier}");
                }
            }

            if (this.charRaceCard.Proficiencies != null && this.charRaceCard.Proficiencies.Skills != null)
            {
                foreach (var item in this.charRaceCard.Proficiencies.Skills)
                {
                    skillModifier = GetSkillModifier(item);
                    skills.Add($"{item} +{skillModifier}");
                }
            }

            if (this.charRaceVariantCard.Proficiencies != null && this.charRaceVariantCard.Proficiencies.Skills != null)
            {
                foreach (var item in this.charRaceVariantCard.Proficiencies.Skills)
                {
                    skillModifier = GetSkillModifier(item);
                    skills.Add($"{item} +{skillModifier}");
                }
            }

            return skills;
        }
    }
}
