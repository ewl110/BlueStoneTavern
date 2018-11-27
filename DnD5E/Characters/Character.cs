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

        //private BackgroundCard charBackgroundCard;
        //private ClassCard charClassCard;
        //private ClassCard charSubClassCard;
        //public RaceCard charRaceCard;
        //private RaceCard charRaceVariantCard;

        private AbilityScoresModel abilityScores;
        private int age;
        private string charBackground;
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

        public AbilityScoresModel AbilityScores
        {
            get
            {
                return this.abilityScores;
            }
            set
            {
                this.abilityScores = value;
            }
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public string CharBackground
        {
            get
            {
                return this.charBackground;
            }
            set
            {
                this.charBackground = value;
            }
        }
        public string CharClass
        {
            get
            {
                return this.charClass;
            }
            set
            {
                this.charClass = value;
            }
        }
        public string CharRace
        {
            get
            {
                return this.charRace;
            }
            set
            {
                this.charRace = value;
            }
        }
        public List<string> Languages;

        public int Level {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }

        public Character() : this(1) {}

        public Character(int level)
        {
            var charBackgroundCard = Decks.BackgroundDeck.Cards.PullRandomCardFromDeck();
            var charClassCard = Decks.ClassDeck.Cards.PullRandomCardFromDeck(true);
            var charRaceCard = Decks.RaceDeck.Cards.PullRandomCardFromDeck(true);
            var charRaceVariantCard = charRaceCard.Variants.PullRandomCardFromDeck(true);

            this.abilityScores = GetAbilityScores( charClassCard.AbilityScores, charRaceCard.AbilityScores, charRaceVariantCard.AbilityScores );
            this.age = rng.Next(charRaceCard.AgeRange.Min, charRaceCard.AgeRange.Max);
            this.charBackground = charBackgroundCard.Name;
            this.charClass = charClassCard.Name;
            this.charRace = charRaceVariantCard.Name;
            this.hitDice = charClassCard.HitDice;
            this.hitPointCurrent = this.hitPointMax = charClassCard.HitDice + this.abilityScores.ConMod;
            this.id = CreateGuid();
            this.level = level;
            this.proficiencyBonus = 2;
            this.speed = charRaceVariantCard.Speed != 30? charRaceVariantCard.Speed : charRaceCard.Speed;
        }

        public Guid CreateGuid()
        {
            Guid id = Guid.Empty;

            if (id == Guid.Empty)
            {
                id = Guid.NewGuid();
            }

            return id;
        }

        public AbilityScoresModel GetAbilityScores(AbilityScoresModel classAS, AbilityScoresModel raceAS, AbilityScoresModel raceVariantAS)
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

        public int GetAbilityScoreModifier(int abilityScore)
        {
            int abilityScoreModifier = (abilityScore - 10 ) / 2;

            if (abilityScore % 2 != 0)
            {
                abilityScoreModifier = ((abilityScore - 1) - 10) / 2;
            }

            return abilityScoreModifier;
        }

        public CharacterCard GetNewCharacter()
        {
            CharacterCard randomCharacter = new CharacterCard()
            {
                AbilityScores = this.AbilityScores,
                Age = this.Age,
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
                Level = this.level,
                ProficiencyBonus = this.proficiencyBonus,
                Race = this.charRace,
                Speed = this.speed
            };

            return randomCharacter;
        }
    }
}
