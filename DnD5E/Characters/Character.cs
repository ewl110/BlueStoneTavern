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
        private List<string> proficiencySkills;
        private List<string> proficiencyTools;
        private List<string> proficiencyWeapons;
        private List<string> resistance;

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
            this.id = CreateGuid();
            this.level = level;
        }

        public AbilityScoresModel GetAbilityScores(AbilityScoresModel classAS, AbilityScoresModel raceAS, AbilityScoresModel raceVariantAS)
        {
            int Str = classAS.Str + raceAS.Str + raceVariantAS.Str;
            int Dex = classAS.Dex + raceAS.Dex + raceVariantAS.Dex;
            int Con = classAS.Dex + raceAS.Dex + raceVariantAS.Dex;
            int Int = classAS.Dex + raceAS.Dex + raceVariantAS.Dex;
            int Wis = classAS.Dex + raceAS.Dex + raceVariantAS.Dex;
            int Cha = classAS.Dex + raceAS.Dex + raceVariantAS.Dex;

            AbilityScoresModel newAbilityScores = new AbilityScoresModel()
            {
                Str = Str,
                StrMod = (Str - 10) / 2,
                Dex = Dex,
                DexMod = (Dex - 10) / 2,
                Con = Con,
                ConMod = (Con - 10) / 2,
                Int = Int,
                IntMod = (Int - 10) / 2,
                Wis = Wis,
                WisMod = (Wis - 10) / 2,
                Cha = Cha,
                ChaMod = (Cha - 10) / 2,
            };

            return newAbilityScores;
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
    }
}
