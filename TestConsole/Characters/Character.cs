using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;
using TestConsole.Models;

namespace TestConsole.Characters
{
    public class Character
    {
        public readonly Guid id;

        // General Stats
        private string alignment;
        private int age;
        private int[] abilityScores;
        private List<ClassesEnum> classes = new List<ClassesEnum>();
        private List<string> feats = new List<string>();
        private List<string> features = new List<string>();
        private List<string> languages = new List<string>();
        private int level;
        private string name;
        private int proficiencyBonus;
        private RacesEnum race;
        private List<string> savingThrows = new List<string>();
        private SizesEnum size;
        private List<string> skills = new List<string>();
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
        private int hitDice;
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
        public List<ClassesEnum> Classes {
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
        public List<string> Features
        {
            get
            {
                return this.features;
            }
            set
            {
                foreach (var item in value)
                {
                    if (!this.features.Contains(item))
                    {
                        this.features.Add(item);
                    }
                }
            }
        }
        public int HitDice
        {
            get
            {
                return this.hitDice;
            }
            set
            {
                this.hitDice = value;
            }
        }
        public int HitPointCurrent
        {
            get
            {
                return this.hitPointCurrent;
            }
            set
            {
                this.hitPointCurrent = value;
            }
        }
        public int HitPointMax
        {
            get
            {
                return this.hitPointMax;
            }
            set
            {
                this.hitPointMax = value;
            }
        }
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
                return this.name;
            }
            set
            {
                this.name = value;
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
        public RacesEnum Race {
            get
            {
                return this.race;
            }
            set
            {
                this.race = value;
            }
        }
        public List<string> SavingThrows
        {
            get
            {
                return this.savingThrows;
            }
            set
            {
                foreach (var item in value)
                {
                    if (!this.savingThrows.Contains(item))
                    {
                        this.savingThrows.Add(item);
                    }
                }
            }
        }
        public SizesEnum Size
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
        public List<string> Skills {
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

        public Character() : this(RacesEnum.humanVariant, ClassesEnum.barbarian) { }

        public Character(RacesEnum charRace, ClassesEnum charClass)
        {
            ClassModel charClassDefaults = Dictionaries.ClassDictionary.List[charClass.ToString()];
            RaceModel charRaceDefaults = Dictionaries.RacesDictionary.List[charRace.ToString()];
            var languages = Dictionaries.PHB.LanguagesDictionary.List;
            var commonLanguages = languages.Where(l => l.Value.Type == LanguageTypesEnum.Common).ToDictionary(i => i.Key, i => i.Value);
            var skills = Dictionaries.PHB.Skills.List;
            Random rng = new Random();

            //var parentClasses = Dictionaries.ClassDictionary.List.Where(c => c.Value.ParentClass == null).ToDictionary(i => i.Key, i => i.Value);

            this.classes.Add(charClass);
            this.feats = new List<string>() { };
            this.hitDice = charClassDefaults.HitDice;
            this.hitPointCurrent = charClassDefaults.HitDice;
            this.hitPointMax = charClassDefaults.HitDice;
            this.languages = new List<string>() { };
            this.level = 1;
            this.name = "Huumon";
            this.race = charRace;
            this.size = charRaceDefaults.Size;
            this.skills = new List<string>() { };
            this.speed = charRaceDefaults.Speed;

            if (charRaceDefaults.Feats != null)
            {
                foreach (string feat in charRaceDefaults.Feats)
                {
                    this.feats.Add(feat);
                }
            }

            if (charRaceDefaults.Languages != null)
            {
                foreach (string item in charRaceDefaults.Languages)
                {
                    string lang = item;

                    //if (lang == "selectLanguage")
                    //{
                    //    while (this.Languages.Contains(lang) || lang == "selectLanguage")
                    //    {
                    //        lang = commonLanguages.Keys.ToArray()[rng.Next(0, commonLanguages.Count)];
                    //    }
                    //}

                    this.languages.Add(lang);
                }
            }

            if (charClassDefaults.SavingThrows != null)
            {
                foreach (var ability in charClassDefaults.SavingThrows.ToArray())
                {
                    this.savingThrows.Add(ability.ToString());
                }
            }

            if (charRaceDefaults.Skills != null)
            {
                foreach (string skill in charRaceDefaults.Skills)
                {
                    this.skills.Add(skill);
                }
            }

            if (charClass.ToString() == "barbarian")
            {
                var barbarian = Dictionaries.PHB.Classes.Barbarian.Levels[1];
                this.proficiencyBonus = barbarian.ProficiencyBonus;

                foreach (var feature in barbarian.Features)
                {
                    this.features.Add(feature);
                }
            }

            switch (charRace)
            {
                case RacesEnum.dragonbornBlack:
                    break;
                case RacesEnum.dragonbornBlue:
                    break;
                case RacesEnum.dragonbornBronze:
                    break;
                case RacesEnum.dragonbornCopper:
                    break;
                case RacesEnum.dragonbornGold:
                    break;
                case RacesEnum.dragonbornGreen:
                    break;
                case RacesEnum.dragonbornRed:
                    break;
                case RacesEnum.dragonbornSilver:
                    break;
                case RacesEnum.dragonbornWhite:
                    break;
                case RacesEnum.dwarfGray:
                    break;
                case RacesEnum.dwarfHill:
                    break;
                case RacesEnum.dwarfMountain:
                    break;
                case RacesEnum.elfDark:
                    break;
                case RacesEnum.elfHigh:
                    break;
                case RacesEnum.elfWood:
                    break;
                case RacesEnum.gnome:
                    break;
                case RacesEnum.halfElf:
                    break;
                case RacesEnum.halfOrc:
                    break;
                case RacesEnum.halfling:
                    break;
                case RacesEnum.humanStandard:
                    break;
                case RacesEnum.humanVariant:
                    break;
                case RacesEnum.tiefling:
                    break;
                default:
                    break;
            }
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
