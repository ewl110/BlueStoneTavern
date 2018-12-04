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
        private Dictionary<string, CharacterClassModel> charClass;
        private string charRace;

        private int deathSavesFailed;
        private int deathSavesPassed;

        private List<ActionModel> actionAttack;
        private List<ActionModel> actionBonus;
        private List<ActionModel> actionOption;
        private List<ActionModel> actionReaction;
        private int attack = 1;
        private string classDescription;
        private List<FeaturesModel> classFeatures = new List<FeaturesModel>() { };
        private CharacterClassModel charClassPrimary;
        private string equipment;
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

        public Character() : this(1) { }

        public Character(int level)
        {
            this.actionAttack = new List<ActionModel> { };
            this.actionBonus = new List<ActionModel> { };
            this.actionOption = new List<ActionModel> { };
            this.actionReaction = new List<ActionModel> { };

            // Get required character data
            this.charBackgroundCard = Decks.BackgroundDeck.Cards.PullRandomCardFromDeck();
            this.charClassCard = Decks.ClassDeck.Cards.PullRandomCardFromDeck(true);
            this.charFactionCard = Decks.FactionDeck.Cards.PullRandomCardFromDeck();
            this.charRaceCard = Decks.RaceDeck.Cards.PullRandomCardFromDeck(true);
            this.charRaceVariantCard = this.charRaceCard.Variants.PullRandomCardFromDeck(true);

            // Define classes and totalLevel
            this.charClass = new Dictionary<string, CharacterClassModel> {
                {
                    this.charClassCard.Name,
                    new CharacterClassModel()
                    {
                        Level = level,
                        Name = this.charClassCard.Name,
                    }
                }
            };

            //Test Multiclass
            //if (!this.charClass.ContainsKey(ClassEnum.Wizard.ToString()))
            //{
            //    this.charClass.Add(
            //        ClassEnum.Wizard.ToString(),
            //        new CharacterClassModel()
            //        {
            //            Level = 1,
            //            Name = ClassEnum.Wizard.ToString()
            //        }
            //    );
            //}

            this.totalLevel = GetTotalLevel();

            // Calculate modifiers
            this.abilityScores = GetAbilityScores(this.charClassCard.AbilityScores, this.charRaceCard.AbilityScores, this.charRaceVariantCard.AbilityScores);
            this.age = rng.Next(this.charRaceCard.AgeRange.Min, this.charRaceCard.AgeRange.Max);
            this.charBackground = GetBackground();
            this.charClassPrimary = GetPrimaryClass();
            this.id = CreateGuid();
            this.immunity = GetImmunities();
            this.languages = GetLanguages();
            this.proficiencyBonus = GetProficiencyBonus();
            this.raceTraits = GetRaceTraits();
            this.resistance = GetResistances();
            this.speed = this.charRaceVariantCard.Speed != 30 ? this.charRaceVariantCard.Speed : this.charRaceCard.Speed;

            GetEquipment();
            GetClassFeatures();
            CalculateHitPoints();
            GetProficiencies();
        }

        private void AddSpellCastingFeatures(FeaturesModel feature, string className)
        {
            int abilityMod = 0;

            // Reset the description list
            FeaturesModel newFeature = new FeaturesModel {
                Name = feature.Name,
                Description = new List<string>
                {
                    feature.Description[0]
                }
            };

            if (feature.Description.Count == 2)
            {
                newFeature.Description.Add(feature.Description[1]);
            }

            switch (feature.AbilityModifier)
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

            newFeature.Description.Add($"<b>Spell Save DC:</b> {(8 + abilityMod + GetProficiencyBonus()).ToString()}");
            newFeature.Description.Add($"<b>Spell Attack Modifier:</b> +{abilityMod + GetProficiencyBonus()}");

            this.charClass[className].Features.Add(newFeature);
        }

        private void CalculateHitPoints()
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
                ActionAttack = this.actionAttack,
                ActionBonus = this.actionBonus,
                ActionOption = this.actionOption,
                ActionReaction = this.actionReaction,
                Age = this.age,
                Attack = this.attack,
                Background = this.charBackground,
                Class = this.charClass,
                ClassDescription = this.charClassCard.Description,
                ClassFeatures = this.classFeatures,
                ClassPrimary = this.charClassPrimary,
                Equipment = this.equipment,
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

        private string FormatAbilityModifier(int abilityScore)
        {
            string abilityModifier = null;
            int addProficiencyBonus = abilityScore + this.proficiencyBonus;

            if (addProficiencyBonus >= 0)
            {
                abilityModifier = "+";
            }
            else
            {
                abilityModifier = "-";
            }

            return $"{abilityModifier}{addProficiencyBonus}";
        }

        private string FormatWeaponDamageModifier(int weaponDamage)
        {
            string weaponDamageModifier = null;

            if (weaponDamage > 0)
            {
                weaponDamageModifier = $" + {weaponDamage} ";
            }
            else if (weaponDamage < 0)
            {
                weaponDamageModifier = $" - {weaponDamage} ";
            }

            return weaponDamageModifier;

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
            int abilityScoreModifier = (abilityScore - 10) / 2;

            if (abilityScore % 2 != 0)
            {
                abilityScoreModifier = ((abilityScore - 1) - 10) / 2;
            }

            return abilityScoreModifier;
        }

        private void GetActions(ActionModel action)
        {
            switch (action.Type)
            {
                case ActionTypesEnum.Attack:
                    if (action.Weapon != WeaponsEnum.None)
                    {
                        List<string> propertiesList = new List<string>() { };

                        WeaponCard weapon = Dictionaries.WeaponDictionary.List[action.Weapon];

                        string weaponAttackType = "Melee";
                        int weaponDamageModifier = this.abilityScores.StrMod;
                        string weaponDamageType = weapon.Damage.DamageType.ToString().ToLower();
                        string weaponReach = "5";

                        if (weapon.IsRanged)
                        {
                            weaponAttackType = "Ranged";
                            weaponDamageModifier = this.abilityScores.DexMod;
                            weaponReach = $"{weapon.Range.Short}/{weapon.Range.Long}";
                        }

                        if (weapon.Properties != null)
                        {
                            if (weapon.Properties.Ammunition)
                            {
                                propertiesList.Add("Ammunition");
                            }

                            if (weapon.Properties.Finesse)
                            {
                                weaponDamageModifier = this.abilityScores.DexMod > this.abilityScores.StrMod ? this.abilityScores.DexMod : this.abilityScores.StrMod;
                                propertiesList.Add("Finesse");
                            }

                            if (weapon.Properties.Heavy)
                            {
                                propertiesList.Add("Heavy");
                            }

                            if (weapon.Properties.Light)
                            {
                                propertiesList.Add("Light");
                            }

                            if (weapon.Properties.Loading)
                            {
                                propertiesList.Add("Loading");
                            }

                            if (weapon.Properties.Reach)
                            {
                                propertiesList.Add("Reach");
                            }

                            if (weapon.Properties.Special)
                            {
                                propertiesList.Add("Special");
                            }

                            if (weapon.Properties.Thrown)
                            {
                                string thrownProperty = "Thrown";

                                if (weapon.Range != null && WeaponsEnum.Dart.ToString() != "Dart")
                                {
                                    thrownProperty += $" ({weapon.Range.Short}/{weapon.Range.Long} ft.)";
                                }

                                propertiesList.Add(thrownProperty);
                            }

                            if (weapon.Properties.TwoHanded)
                            {
                                propertiesList.Add("Two Handed");
                            }

                            if (weapon.Properties.Versatile)
                            {
                                propertiesList.Add($"Versatile ({weapon.Damage.NumberOfDice}d{weapon.Damage.Versatile}{FormatWeaponDamageModifier(weaponDamageModifier)} {weaponDamageType})");
                            }
                        }

                        action.Description = $"<i>{weaponAttackType} Weapon Attack:</i> {FormatAbilityModifier(weaponDamageModifier)} to hit, reach {weaponReach} ft., one target. " +
                            $"<i>Hit:</i> {weapon.Damage.NumberOfDice}d{weapon.Damage.Dice}{FormatWeaponDamageModifier(weaponDamageModifier)} {weaponDamageType} damage. ";

                        if (weapon.Properties != null)
                        {
                            action.Description += $"<i>Special:</i> " + string.Join(", ", propertiesList.ToArray());
                        }

                        action.Name = weapon.Name;

                        this.actionAttack.Add(action);
                    }
                    else
                    {
                        this.actionAttack.Add(action);
                    }
                    break;
                case ActionTypesEnum.Bonus:
                    this.actionBonus.Add(action);
                    break;
                case ActionTypesEnum.Option:
                    this.actionOption.Add(action);
                    break;
                case ActionTypesEnum.Reaction:
                    this.actionReaction.Add(action);
                    break;
            }
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
            // Loop through all the currently selected character classes
            foreach (CharacterClassModel charClass in this.charClass.Values)
            {
                // Find the mathching class in the ClassDeck
                foreach (ClassCard c in Decks.ClassDeck.Cards)
                {
                    if (charClass.Name == c.Name)
                    {
                        // Create empty feature list if one doesn't already exist
                        if (this.charClass[c.Name].Features == null)
                        {
                            this.charClass[c.Name].Features = new List<FeaturesModel> { };
                        }

                        for (int i = 1; i <= charClass.Level; i++)
                        {
                            if (c.Levels.ContainsKey(i))
                            {
                                if (c.Levels[i].Features != null)
                                {
                                    foreach (FeaturesModel item in c.Levels[i].Features)
                                    {
                                        if (this.charClass.ContainsKey(c.Name))
                                        {
                                            if (item.Name == "Spellcasting")
                                            {
                                                AddSpellCastingFeatures(item, c.Name);
                                            }
                                            else
                                            {
                                                this.charClass[c.Name].Features.Add(item);

                                                if (item.Name == "Extra Attack")
                                                {
                                                    this.attack++;
                                                }
                                            }

                                            if (item.Action != null)
                                            {
                                                GetActions(item.Action);
                                            }
                                        }
                                    }
                                }

                                // No variant is set and the SetVariant flag is present, choose a random variant
                                if (c.Levels[i].SetVariant && charClass.Variant == null)
                                {
                                    ClassEnum[] variantsList = this.charClassCard.Levels[i].Variants.Keys.ToArray();
                                    ClassEnum randomVariant = variantsList.PickRandomItemFromArray();
                                    charClass.Variant = randomVariant.ToString();
                                }

                                // Check if class variant exists
                                if (charClass.Variant != null)
                                {
                                    Enum.TryParse(charClass.Variant, out ClassEnum classVariant);

                                    // If class variant is found add the relevant features
                                    if (this.charClassCard.Levels[i].Variants != null && this.charClassCard.Levels[i].Variants.ContainsKey(classVariant) && this.charClassCard.Levels[i].Variants[classVariant].Features != null)
                                    {
                                        foreach (FeaturesModel item in this.charClassCard.Levels[i].Variants[classVariant].Features)
                                        {
                                            if (item.Name == "Spellcasting")
                                            {
                                                AddSpellCastingFeatures(item, c.Name);
                                            }
                                            else
                                            {
                                                this.charClass[c.Name].Features.Add(item);

                                                if (item.Name == "Extra Attack")
                                                {
                                                    this.attack++;
                                                }
                                            }

                                            if (item.Action != null)
                                            {
                                                GetActions(item.Action);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public void GetEquipment()
        {
            List<string> equipmentList = new List<string>() { };

            if (this.charClassCard.Equipment != null)
            {
                foreach (var item in this.charClassCard.Equipment)
                {
                    string itemText = item.Name;

                    if (item.Description != null)
                    {
                        itemText = item.Description;
                    }

                    if (item.Quantity > 1)
                    {
                        itemText += $" ({item.Quantity})";
                    }

                    equipmentList.Add(itemText);

                    if (item.Type == EquipmentTypeEnum.Weapon)
                    {
                        ActionModel action = new ActionModel
                        {
                            Type = ActionTypesEnum.Attack,
                            Weapon =item.Weapon
                        };

                        GetActions(action);
                    }
                }

                this.equipment = string.Join(", ", equipmentList.ToArray());
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
            List<string> languages = new List<string>() { };

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

            if (string.Join(",", this.proficiencySkills).Contains("Perception"))
            {
                passivePerception += this.proficiencyBonus;
            }

            this.passivePerception = passivePerception;
        }

        private CharacterClassModel GetPrimaryClass()
        {
            CharacterClassModel charClass = null;
            int level = 0;

            foreach (var c in this.charClass.Values)
            {
                if (c.Level > level)
                {
                    charClass = c;
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

            foreach (var c in this.charClass.Values)
            {
                for (int i = 1; i <= c.Level; i++)
                {
                    if (this.charClassCard.Levels.ContainsKey(i) && this.charClassCard.Levels[i].Proficiencies != null)
                    {
                        //ClassEnum classVariant = ClassEnum.None;
                        var proficiencies = this.charClassCard.Levels[i].Proficiencies;

                        this.proficiencyArmor = this.proficiencyArmor.Union(GetArmorProficiency(proficiencies)).ToList();
                        this.proficiencySavingThrows = this.proficiencySavingThrows.Union(GetSavingThrowProficiency(proficiencies)).ToList();
                        this.proficiencySkills = this.proficiencySkills.Union(GetSkillProficiency(proficiencies)).ToList();
                        this.proficiencyTools = this.proficiencyTools.Union(GetToolProficiency(proficiencies)).ToList();
                        this.proficiencyWeapons = this.proficiencyWeapons.Union(GetWeaponProficiency(proficiencies)).ToList();

                        if (c.Variant != null)
                        {
                            Enum.TryParse(c.Variant, out ClassEnum classVariant);

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

                    if (item.Action != null)
                    {
                        GetActions(item.Action);
                    }
                }
            }

            if (this.charRaceVariantCard.Features != null)
            {
                foreach (var item in this.charRaceVariantCard.Features)
                {
                    traits.Add(item);

                    if (item.Action != null)
                    {
                        GetActions(item.Action);
                    }
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

            foreach (var c in this.charClass.Values)
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
