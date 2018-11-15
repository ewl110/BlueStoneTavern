using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Characters
{
    public abstract class Character
    {
        public readonly Guid id;

        // General Stats
        private string alignment;
        private int age;
        private int[] abilityScores;
        private List<CharacterClasses> classes = new List<CharacterClasses>();
        private List<string> feats = new List<string>();
        private List<string> languages = new List<string>();
        private int level;
        private string name;
        private int proficiencyBonus;
        private string race;
        private Sizes size;
        private List<Skills> skills = new List<Skills>();
        private int speed;

        // Ability Scores
        private int charisma;
        private int constitution;
        private int dexterity;
        private int intelligence;
        private int strength;
        private int wisdom;

        // Health
        private int deathSavesFailed;
        private int deathSavesPassed;
        private int hitDiceUsed;
        private int hitPointCurrent;
        private int hitPointMax;

        public string Alignmnet
        {
            get
            {
                return this.alignment;
            }
            set
            {
                this.alignment = value;
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
        public int[] AbilityScores { get; set; }
        public List<CharacterClasses> Classes {
            get
            {
                return this.classes;
            }
            set
            {
                foreach (var item in value)
                {
                    if (!this.classes.Contains(item))
                    {
                        this.classes.Add(item);
                    }
                }
            }
        }
        public List<string> Feats {
            get
            {
                return this.feats;
            }
            set
            {
                foreach (var item in value)
                {
                    if (!this.feats.Contains(item))
                    {
                        this.feats.Add(item);
                    }
                }
            }
        }
        public int HitPoints { get; set; }
        public Guid Id
        {
            get
            {
                return this.id;
            }
        }
        public List<string> Languages {
            get
            {
                return this.languages;
            }
            set
            {
                foreach (var item in value)
                {
                    if (!this.languages.Contains(item))
                    {
                        this.languages.Add(item);
                    }
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                this.level = value;
            }
        }
        public string Name
        {
            get
            {
                return this.race;
            }
            set
            {
                this.race = value;
            }
        }
        public int ProficiencyBonus
        {
            get
            {
                return this.proficiencyBonus;
            }
            set
            {
                this.proficiencyBonus = value;
            }
        }
        public string Race {
            get
            {
                return this.race;
            }
            set
            {
                this.race = value;
            }
        }
        public Sizes Size
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }
        public List<Skills> Skills {
            get
            {
                return this.skills;
            }
            set
            {
                foreach (var item in value)
                {
                    if (!this.skills.Contains(item))
                    {
                        this.skills.Add(item);
                    }
                }
            }
        }
        public int Speed
        {
            get
            {
                return this.speed;
            }
            set
            {
                this.speed = value;
            }
        }

        public Character() : this("Human", CharacterClasses.Fighter) { }

        public Character(string charRace, CharacterClasses charClass)
        {
            //var races = Dictionaries.PHB.Races.Core();
            //this.classes = new List<CharacterClasses>(){ charClass };
            //this.race = charRace;
        }

        public Guid createGuid()
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
