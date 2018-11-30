using DnD5E.Enums;
using DnD5E.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnD5E.Characters
{
    public class Character
    {
        private Random rng = new Random();

        public readonly Guid id;

        private BackgroundCard charBackgroundCard;
        private ClassCard charClassCard;
        private FactionCard charFactionCard;
        private ClassCard charSubClassCard;
        private RaceCard charRaceCard;
        private RaceCard charRaceVariantCard;

        private AbilityScoresModel abilityScores;
        private int age;
        private CharacterBackgroundModel charBackground;
        private List<CharacterClassModel> charClass;
        private string charRace;

        private int deathSavesFailed;
        private int deathSavesPassed;

        private string classDescription;
        private List<FeaturesModel> classFeatures = new List<FeaturesModel>() { };
        private string charClassPrimary;
        private HitPointsModel hitPoints;
        private List<string> immunity;
        private List<string> languages;
        private int passivePerception;
        private List<string> proficiencyArmor;
        private int proficiencyBonus;
        private List<string> proficiencySavingThrows;
        private List<string> proficiencySkills;
        private List<string> proficiencyTools;
        private List<string> proficiencyWeapons;
        private List<FeaturesModel> raceTraits;
        private List<string> resistance;
        private int speed;
        private int totalLevel;

        public Guid Id {
            get
            {
                return this.id;
            }
        }

        public Character() : this(1) {}

        public Character(int level)
        {
            // Get required character data
            this.charBackgroundCard = Decks.BackgroundDeck.Cards.PullRandomCardFromDeck();
            this.charClassCard = Decks.ClassDeck.Cards.PullRandomCardFromDeck(true);
            this.charFactionCard = Decks.FactionDeck.Cards.PullRandomCardFromDeck();
            this.charRaceCard = Decks.RaceDeck.Cards.PullRandomCardFromDeck(true);
            this.charRaceVariantCard = this.charRaceCard.Variants.PullRandomCardFromDeck(true);

            // Define classes and totalLevel
            this.charClass = new List<CharacterClassModel> {
                new CharacterClassModel()
                    {
                        Level = level,
                        Name = this.charClassCard.Name,
                    }
                };
            this.totalLevel = GetTotalLevel();

            // Calculate modifiers
            this.abilityScores = GetAbilityScores( this.charClassCard.AbilityScores, this.charRaceCard.AbilityScores, this.charRaceVariantCard.AbilityScores );
            this.age = rng.Next(this.charRaceCard.AgeRange.Min, this.charRaceCard.AgeRange.Max);
            this.charBackground = GetBackground();
            this.charClassPrimary = GetPrimaryClass();
            this.id = CreateGuid();
            this.immunity = GetImmunities();
            this.languages = GetLanguages();
            this.proficiencyBonus = GetProficiencyBonus();
            this.raceTraits = GetRaceTraits();
            this.resistance = GetResistances();
            this.speed = this.charRaceVariantCard.Speed != 30? this.charRaceVariantCard.Speed : this.charRaceCard.Speed;

            GetClassFeatures();
            CalculateitPoints();
            GetProficiencies();
        }

        private void AddSpellCastingFeatures(string abilityModifier)
        {
            int abilityMod = 0;

            switch (abilityModifier)
            {
                case "Cha":
                    abilityMod = this.abilityScores.ChaMod;
                    break;
                case "Int":
                    abilityMod = this.abilityScores.IntMod;
                    break;
                case "Wis":
                    abilityMod = this.abilityScores.WisMod;
                    break;
            }

            this.classFeatures.Add(new FeaturesModel
            {
                Name = "Spell Save DC",
                Description = new string[] {
                    (8 + abilityMod + GetProficiencyBonus()).ToString()
                },
            });

            this.classFeatures.Add(new FeaturesModel
            {
                Name = "Spell Attack Modifier",
                Description = new string[] {
                    $"+{abilityMod + GetProficiencyBonus()}"
                },
            });
        }

        private void CalculateitPoints()
        {
            int hitDice = this.charClassCard.HitDice;
            int hitPointsMax = (hitDice + this.abilityScores.ConMod) + ((totalLevel - 1) * ((hitDice / 2) + 1 + this.abilityScores.ConMod));
            this.hitPoints = new HitPointsModel
            {
                HitDice = hitDice,
                HitDiceAvailable = this.totalLevel,
                HitPointsCurrent = hitPointsMax,
                HitPointsMax = hitPointsMax,
            };
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
                ClassDescription = this.charClassCard.Description,
                ClassFeatures = this.classFeatures,
                ClassPrimary = this.charClassPrimary,
                Faction = this.charFactionCard,
                HitPoints = this.hitPoints,
                Id = this.id,
                Immunity = this.immunity,
                Languages = this.languages,
                PassivePerception = this.passivePerception,
                ProficiencyArmor = this.proficiencyArmor,
                ProficiencyBonus = this.proficiencyBonus,
                ProficiencySavingThrows = this.proficiencySavingThrows,
                ProficiencySkills = this.proficiencySkills,
                ProficiencyTools = this.proficiencyTools,
                ProficiencyWeapons = this.proficiencyWeapons,
                Race = this.charRaceVariantCard.Name,
                RaceTraits = this.raceTraits,
                Resistance = this.resistance,
                Size = this.charRaceCard.Size,
                Speed = this.speed,
                TotalLevel = this.totalLevel,
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

        private List<string> GetArmorProficiency(ProficiencyModel proficiencies)
        {
            List<string> armorProficiency = new List<string>() { };

            if (proficiencies.Armor != null)
            {
                foreach (var item in proficiencies.Armor)
                {
                    if (this.charClassCard.Name == ClassEnum.Druid.ToString())
                    {
                        armorProficiency.Add($"{item} (nonmetal)");
                    }
                    else
                    {
                        armorProficiency.Add(item);
                    }
                }
            }

            return armorProficiency;
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

        private void GetClassFeatures()
        {
            List<FeaturesModel> features = new List<FeaturesModel>() { };

            // Loop through all the currently selected character classes
            foreach (var charClass in this.charClass)
            {
                // Find the mathching class in the ClassDeck
                foreach (ClassCard c in Decks.ClassDeck.Cards)
                {
                    if (charClass.Name == c.Name)
                    {
                        for (int i = 1; i <= charClass.Level; i++)
                        {
                            string classVariant = "";

                            if (c.Levels.ContainsKey(i))
                            {
                                if (c.Levels[i].Features != null)
                                {
                                    foreach (FeaturesModel item in this.charClassCard.Levels[i].Features)
                                    {
                                        this.classFeatures.Add(item);

                                        if (item.Name == "Spellcasting")
                                        {
                                            AddSpellCastingFeatures(item.AbilityModifier);
                                        }
                                    }
                                }

                                // Check if class variant exists
                                if (charClass.Variant != null)
                                {
                                    classVariant = charClass.Variant;
                                }

                                // If class variant is found add the relevant features
                                if (this.charClassCard.Levels[i].Variants != null && this.charClassCard.Levels[i].Variants.ContainsKey(classVariant) && this.charClassCard.Levels[i].Variants[classVariant].Features != null)
                                {
                                    foreach (FeaturesModel item in this.charClassCard.Levels[i].Variants[classVariant].Features)
                                    {
                                        this.classFeatures.Add(item);

                                        if (item.Name == "Spellcasting")
                                        {
                                            AddSpellCastingFeatures(item.AbilityModifier);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private List<string> GetImmunities()
        {
            List<string> immunity = new List<string>() { };

            if (this.charRaceCard.Immunity != null)
            {
                foreach (var item in this.charRaceCard.Immunity)
                {
                    immunity.Add(item);
                }
            }

            if (this.charRaceVariantCard.Immunity != null)
            {
                foreach (var item in this.charRaceVariantCard.Immunity)
                {
                    immunity.Add(item);
                }
            }

            return immunity;
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

        private void GetPassivePerception() {
            int passivePerception = 10 + this.abilityScores.WisMod;

            if ( string.Join(",", this.proficiencySkills).Contains("Perception") )
            {
                passivePerception += this.proficiencyBonus;
            }

            this.passivePerception = passivePerception;
        }

        private string GetPrimaryClass()
        {
            string charClass = "";
            int level = 0;

            foreach (var c in this.charClass)
            {
                if ( c.Level > level )
                {
                    charClass = c.Name;
                    level = c.Level;
                }
            }

            return charClass;
        }

        private void GetProficiencies()
        {
            this.proficiencyArmor = new List<string>() { };
            this.proficiencySavingThrows = new List<string>() { };
            this.proficiencySkills = new List<string>() { };
            this.proficiencyTools = new List<string>() { };
            this.proficiencyWeapons = new List<string>() { };

            foreach (var c in this.charClass)
            {
                for (int i = 1; i <= c.Level; i++)
                {
                    if (this.charClassCard.Levels.ContainsKey(i) && this.charClassCard.Levels[i].Proficiencies != null)
                    {
                        string classVariant = "";
                        var proficiencies = this.charClassCard.Levels[i].Proficiencies;

                        this.proficiencyArmor = this.proficiencyArmor.Union(GetArmorProficiency(proficiencies)).ToList();
                        this.proficiencySavingThrows = this.proficiencySavingThrows.Union(GetSavingThrowProficiency(proficiencies)).ToList();
                        this.proficiencySkills = this.proficiencySkills.Union(GetSkillProficiency(proficiencies)).ToList();
                        this.proficiencyTools = this.proficiencyTools.Union(GetToolProficiency(proficiencies)).ToList();
                        this.proficiencyWeapons = this.proficiencyWeapons.Union(GetWeaponProficiency(proficiencies)).ToList();

                        if (c.Variant != null)
                        {
                            classVariant = c.Variant;
                        }

                        if (this.charClassCard.Levels[i].Variants != null && this.charClassCard.Levels[i].Variants.ContainsKey(classVariant) && this.charClassCard.Levels[i].Variants[classVariant].Proficiencies != null)
                        {
                            var proficienciesVariant = this.charClassCard.Levels[i].Variants[classVariant].Proficiencies;

                            this.proficiencyArmor = this.proficiencyArmor.Union(GetArmorProficiency(proficienciesVariant)).ToList();
                            this.proficiencySavingThrows = this.proficiencySavingThrows.Union(GetSavingThrowProficiency(proficienciesVariant)).ToList();
                            this.proficiencySkills = this.proficiencySkills.Union(GetSkillProficiency(proficienciesVariant)).ToList();
                            this.proficiencyTools = this.proficiencyTools.Union(GetToolProficiency(proficienciesVariant)).ToList();
                            this.proficiencyWeapons = this.proficiencyWeapons.Union(GetWeaponProficiency(proficienciesVariant)).ToList();
                        }
                    }
                }
            }

            if (this.charBackgroundCard.Proficiencies != null)
            {
                var proficiencies = this.charBackgroundCard.Proficiencies;

                this.proficiencyArmor = this.proficiencyArmor.Union(GetArmorProficiency(proficiencies)).ToList();
                this.proficiencySavingThrows = this.proficiencySavingThrows.Union(GetSavingThrowProficiency(proficiencies)).ToList();
                this.proficiencySkills = this.proficiencySkills.Union(GetSkillProficiency(proficiencies)).ToList();
                this.proficiencyTools = this.proficiencyTools.Union(GetToolProficiency(proficiencies)).ToList();
                this.proficiencyWeapons = this.proficiencyWeapons.Union(GetWeaponProficiency(proficiencies)).ToList();
            }

            if (this.charRaceCard.Proficiencies != null)
            {
                var proficiencies = this.charRaceCard.Proficiencies;

                this.proficiencyArmor = this.proficiencyArmor.Union(GetArmorProficiency(proficiencies)).ToList();
                this.proficiencySavingThrows = this.proficiencySavingThrows.Union(GetSavingThrowProficiency(proficiencies)).ToList();
                this.proficiencySkills = this.proficiencySkills.Union(GetSkillProficiency(proficiencies)).ToList();
                this.proficiencyTools = this.proficiencyTools.Union(GetToolProficiency(proficiencies)).ToList();
                this.proficiencyWeapons = this.proficiencyWeapons.Union(GetWeaponProficiency(proficiencies)).ToList();
            }

            if (this.charRaceVariantCard.Proficiencies != null)
            {
                var proficiencies = this.charRaceVariantCard.Proficiencies;

                this.proficiencyArmor = this.proficiencyArmor.Union(GetArmorProficiency(proficiencies)).ToList();
                this.proficiencySavingThrows = this.proficiencySavingThrows.Union(GetSavingThrowProficiency(proficiencies)).ToList();
                this.proficiencySkills = this.proficiencySkills.Union(GetSkillProficiency(proficiencies)).ToList();
                this.proficiencyTools = this.proficiencyTools.Union(GetToolProficiency(proficiencies)).ToList();
                this.proficiencyWeapons = this.proficiencyWeapons.Union(GetWeaponProficiency(proficiencies)).ToList();
            }

            GetPassivePerception();
        }

        private int GetProficiencyBonus()
        {
            int level = this.totalLevel;
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

        private List<FeaturesModel> GetRaceTraits()
        {
            List<FeaturesModel> traits = new List<FeaturesModel>() { };

            if (this.charRaceCard.Features != null)
            {
                foreach (var item in this.charRaceCard.Features)
                {
                    traits.Add(item);
                }
            }

            if (this.charRaceVariantCard.Features != null)
            {
                foreach (var item in this.charRaceVariantCard.Features)
                {
                    traits.Add(item);
                }
            }

            return traits;
        }

        private List<string> GetResistances()
        {
            List<string> resistance = new List<string>() { };

            if (this.charRaceCard.Resistance != null)
            {
                foreach (var item in this.charRaceCard.Resistance)
                {
                    resistance.Add(item);
                }
            }

            if (this.charRaceVariantCard.Resistance != null)
            {
                foreach (var item in this.charRaceVariantCard.Resistance)
                {
                    resistance.Add(item);
                }
            }

            return resistance;
        }

        private int GetSavingThrowModifier(string ability)
        {
            int abilityModifier = this.proficiencyBonus;

            switch (ability)
            {
                case "Cha":
                    abilityModifier += this.abilityScores.ChaMod;
                    break;
                case "Con":
                    abilityModifier += this.abilityScores.ConMod;
                    break;
                case "Dex":
                    abilityModifier += this.abilityScores.DexMod;
                    break;
                case "Int":
                    abilityModifier += this.abilityScores.IntMod;
                    break;
                case "Str":
                    abilityModifier += this.abilityScores.StrMod;
                    break;
                case "Wis":
                    abilityModifier += this.abilityScores.WisMod;
                    break;
            }

            return abilityModifier;
        }

        private List<string> GetSavingThrowProficiency(ProficiencyModel proficiencies)
        {
            List<string> savingThrowProficiency = new List<string>() { };

            if (proficiencies.SavingThrows != null)
            {
                foreach (var item in proficiencies.SavingThrows)
                {
                    int savingThrowMod = GetSavingThrowModifier(item);
                    savingThrowProficiency.Add($"{item} +{savingThrowMod}");
                }
            }
        
            return savingThrowProficiency;
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

        private List<string> GetSkillProficiency(ProficiencyModel proficiencies) {
            int skillModifier = 0;
            List<string> skills = new List<string>() { };

            if (proficiencies.Skills != null)
            {
                foreach (var item in proficiencies.Skills)
                {
                    skillModifier = GetSkillModifier(item);
                    skills.Add($"{item} +{skillModifier}");
                }
            }

            return skills;
        }

        private List<string> GetToolProficiency(ProficiencyModel proficiencies)
        {
            List<string> tools = new List<string>() { };

            if (proficiencies.Tools != null)
            {
                foreach (var item in proficiencies.Tools)
                {
                    tools.Add(item);
                }
            }

            return tools;
        }

        private int GetTotalLevel()
        {
            int totalLevel = 0;

            foreach (var c in this.charClass)
            {
                totalLevel += c.Level;
            }

            return totalLevel;
        }

        private List<string> GetWeaponProficiency(ProficiencyModel proficiencies)
        {
            List<string> weapons = new List<string>() { };

            if (proficiencies.Weapons != null)
            {
                foreach (var item in proficiencies.Weapons)
                {
                    weapons.Add(item);
                }
            }

            return weapons;
        }
    }
}
