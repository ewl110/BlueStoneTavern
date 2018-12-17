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

        // Class specific features
        private int bardicInspiration;
        private int combatDice;
        private int kiPoints;
        private int rage;
        private int rageDamage;
        private int sneakAttack;

        private List<ActionModel> actionAttack;
        private List<ActionModel> actionBonus;
        private List<ActionModel> actionOption;
        private List<ActionModel> actionReaction;
        private List<ActionModel> actionList = new List<ActionModel>() { };
        private int attack = 1;
        private string classDescription;
        private List<FeaturesModel> classFeatures = new List<FeaturesModel>() { };
        private CharacterClassModel charClassPrimary;
        private string equipment;
        private HitPointsModel hitPoints;
        private List<string> immunity;
        private int passivePerception;
        private List<string> proficiencyArmor;
        private int proficiencyBonus;
        private List<string> proficiencyLanguages;
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

        public static int GetRandomLevel() {
            Random rng2 = new Random();
            return rng2.Next(1, 20);
        }

        public Character() : this(GetRandomLevel()) {}

        public Character(int level) : this(level, Decks.ClassDeck.Cards.PullRandomCardFromDeck(true).Name) {}

        public Character(int level, string characterClass) : this(level, characterClass, Decks.RaceDeck.Cards.PullRandomCardFromDeck(true).Name) {}

        public Character(int level, string characterClass, string characterRace)
        {
            this.actionAttack = new List<ActionModel> { };
            this.actionBonus = new List<ActionModel> { };
            this.actionOption = new List<ActionModel> { };
            this.actionReaction = new List<ActionModel> { };

            // Get required character data
            this.charBackgroundCard = Decks.BackgroundDeck.Cards.PullRandomCardFromDeck();
            this.charClassCard = Decks.ClassDeck.Cards.Find(x => x.Name == characterClass);
            this.charFactionCard = Decks.FactionDeck.Cards.PullRandomCardFromDeck();
            this.charRaceCard = Decks.RaceDeck.Cards.Find(x => x.Name == characterRace);
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
            this.proficiencyBonus = GetProficiencyBonus();
            this.raceTraits = GetRaceTraits();
            this.resistance = GetResistances();
            this.speed = this.charRaceVariantCard.Speed != 30 ? this.charRaceVariantCard.Speed : this.charRaceCard.Speed;

            GetEquipment();
            GetClassFeatures();
            CalculateHitPoints();
            GetProficiencies();
            GetActions();
        }

        private void AddSpellCastingFeatures(FeaturesModel feature, string className)
        {
            int abilityMod = 0;

            // Reset the description list
            FeaturesModel newFeature = new FeaturesModel {
                Name = feature.Name,
                Description = new List<string>{}
            };

            foreach (var item in feature.Description)
            {
                newFeature.Description.Add(item);
            }

            switch (feature.AbilityModifier)
            {
                case AbilitiesEnum.Cha:
                    abilityMod = this.abilityScores.ChaMod;
                    break;
                case AbilitiesEnum.Int:
                    abilityMod = this.abilityScores.IntMod;
                    break;
                case AbilitiesEnum.Wis:
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

        private string ConvertIntToNumberString(int number) {
            string numberString = "zero";

            switch (number)
            {
                case 1:
                    numberString = "one";
                    break;
                case 2:
                    numberString = "two";
                    break;
                case 3:
                    numberString = "three";
                    break;
                case 4:
                    numberString = "four";
                    break;
                case 5:
                    numberString = "five";
                    break;
                case 6:
                    numberString = "six";
                    break;
                case 7:
                    numberString = "seven";
                    break;
                case 8:
                    numberString = "eight";
                    break;
                case 9:
                    numberString = "nine";
                    break;
                case 100:
                    numberString = "unlimited";
                    break;
            }

            return numberString;
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
                Languages = this.proficiencyLanguages,
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
                Size = this.charRaceCard.Size.GetEnumText(),
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
                weaponDamageModifier = $" - {weaponDamage * -1} ";
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

        private int GetAbilityScoreIncrease(int abilityScore, int availableScoreIncrease)
        {
            int newAbilityScore = abilityScore;

            if (availableScoreIncrease > 0)
            {
                if (abilityScore + 2 <= 20)
                {
                    newAbilityScore = abilityScore + 2;
                }
                else if (abilityScore + 1 <= 20)
                {
                    newAbilityScore = abilityScore + 1;
                }
            }

            return newAbilityScore;
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

        private void GetActions()
        {
            if (this.actionList.Count > 0)
            {
                foreach (var action in this.actionList)
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

                                        if (weapon.Range != null && WeaponsEnum.Dart.ToString() != weapon.Name)
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
                            if (action.Name == "Rage")
                            {
                                action.Description = $"{action.Description} ({ConvertIntToNumberString(this.rage)} uses per long rests, +{this.rageDamage} damage)";
                            }

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
            }
        }

        private List<string> GetArmorProficiency(ProficiencyModel proficiencies)
        {
            List<string> armorProficiency = new List<string>() { };

            if (proficiencies.Armor != null)
            {
                foreach (var item in proficiencies.Armor)
                {
                    string text = item.GetEnumText();

                    if (this.charClassCard.Name == ClassEnum.Druid.GetEnumText())
                    {
                        armorProficiency.Add($"{text} (nonmetal)");
                    }
                    else
                    {
                        armorProficiency.Add(text);
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
                                            switch (item.Name)
                                            {
                                                case "ASI":
                                                    UpdateAbilityScores(charClass.Name);
                                                    break;
                                                case "Combat Superiority":
                                                    break;
                                                case "Rage":
                                                    if (this.charClass[c.Name].Features.Any(x => x.Name == "Rage"))
                                                    {
                                                        return;
                                                    }
                                                    break;
                                                case "Sneak Attack":
                                                    break;
                                                case "Spellcasting":
                                                    AddSpellCastingFeatures(item, c.Name);
                                                    break;
                                                default:
                                                    this.charClass[c.Name].Features.Add(item);

                                                    if (item.Name == "Extra Attack")
                                                    {
                                                        this.attack++;
                                                    }
                                                    break;
                                            }

                                            if (item.Action != null)
                                            {
                                                this.actionList.Add(item.Action);
                                            }
                                        }
                                    }
                                }

                                // No variant is set and the SetVariant flag is present, choose a random variant
                                ClassEnum classVariant = ClassEnum.None;
                                if (c.Levels[i].SetVariant && charClass.Variant == null)
                                {
                                    ClassEnum[] variantsList = this.charClassCard.Levels[i].Variants.Keys.ToArray();
                                    classVariant = variantsList.PickRandomItemFromArray();
                                    charClass.Variant = classVariant.GetEnumText();
                                }
                                else if (charClass.Variant != null)
                                {
                                    Enum.TryParse(charClass.Variant, out ClassEnum cv);
                                    classVariant = EnumUtil.GetValueFromDescription<ClassEnum>(charClass.Variant);
                                    //classVariant = cv;
                                }

                                // Check if class variant exists
                                if (classVariant != ClassEnum.None)
                                {
                                    //Enum.TryParse(charClass.Variant, out ClassEnum classVariant);

                                    // If class variant is found add the relevant features
                                    if (
                                        this.charClassCard.Levels[i].Variants != null && 
                                        this.charClassCard.Levels[i].Variants.ContainsKey(classVariant) && 
                                        this.charClassCard.Levels[i].Variants[classVariant].Features != null
                                    )
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
                                                this.actionList.Add(item.Action);
                                            }
                                        }
                                    }
                                }

                                // Set class specific features
                                if (c.Levels[i].BardicInspiration != 0)
                                {
                                    this.bardicInspiration = c.Levels[i].BardicInspiration;
                                }

                                if (c.Levels[i].CombatDice != 0)
                                {
                                    this.combatDice = c.Levels[i].CombatDice;
                                }

                                if (c.Levels[i].KiPoints != 0)
                                {
                                    this.kiPoints = c.Levels[i].KiPoints;
                                }

                                if (c.Levels[i].Rage != 0)
                                {
                                    this.rage = c.Levels[i].Rage;
                                }

                                if (c.Levels[i].RageDamage != 0)
                                {
                                    this.rageDamage = c.Levels[i].RageDamage;
                                }

                                if (c.Levels[i].SneakAttack != 0)
                                {
                                    this.sneakAttack = c.Levels[i].SneakAttack;
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
                            Weapon = item.Weapon
                        };

                        this.actionList.Add(action);
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
                    immunity.Add(item.GetEnumText());
                }
            }

            if (this.charRaceVariantCard.Immunity != null)
            {
                foreach (var item in this.charRaceVariantCard.Immunity)
                {
                    immunity.Add(item.GetEnumText());
                }
            }

            return immunity;
        }

        private List<string> GetLanguageProficiency(ProficiencyModel proficiencies)
        {
            List<string> languages = new List<string>() { };

            if (proficiencies.Skills != null)
            {
                foreach (var item in proficiencies.Skills)
                {
                    languages.Add(item.GetEnumText());
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
            this.proficiencyLanguages = new List<string>() { };
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
                        this.proficiencyLanguages = this.proficiencyArmor.Union(GetLanguageProficiency(proficiencies)).ToList();
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
                                this.proficiencyLanguages = this.proficiencyArmor.Union(GetLanguageProficiency(proficiencies)).ToList();
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
                this.proficiencyLanguages = this.proficiencyArmor.Union(GetLanguageProficiency(proficiencies)).ToList();
                this.proficiencySavingThrows = this.proficiencySavingThrows.Union(GetSavingThrowProficiency(proficiencies)).ToList();
                this.proficiencySkills = this.proficiencySkills.Union(GetSkillProficiency(proficiencies)).ToList();
                this.proficiencyTools = this.proficiencyTools.Union(GetToolProficiency(proficiencies)).ToList();
                this.proficiencyWeapons = this.proficiencyWeapons.Union(GetWeaponProficiency(proficiencies)).ToList();
            }

            if (this.charRaceCard.Proficiencies != null)
            {
                var proficiencies = this.charRaceCard.Proficiencies;

                this.proficiencyArmor = this.proficiencyArmor.Union(GetArmorProficiency(proficiencies)).ToList();
                this.proficiencyLanguages = this.proficiencyArmor.Union(GetLanguageProficiency(proficiencies)).ToList();
                this.proficiencySavingThrows = this.proficiencySavingThrows.Union(GetSavingThrowProficiency(proficiencies)).ToList();
                this.proficiencySkills = this.proficiencySkills.Union(GetSkillProficiency(proficiencies)).ToList();
                this.proficiencyTools = this.proficiencyTools.Union(GetToolProficiency(proficiencies)).ToList();
                this.proficiencyWeapons = this.proficiencyWeapons.Union(GetWeaponProficiency(proficiencies)).ToList();
            }

            if (this.charRaceVariantCard.Proficiencies != null)
            {
                var proficiencies = this.charRaceVariantCard.Proficiencies;

                this.proficiencyArmor = this.proficiencyArmor.Union(GetArmorProficiency(proficiencies)).ToList();
                this.proficiencyLanguages = this.proficiencyArmor.Union(GetLanguageProficiency(proficiencies)).ToList();
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
                        this.actionList.Add(item.Action);
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
                        this.actionList.Add(item.Action);
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
                    resistance.Add(item.GetEnumText());
                }
            }

            if (this.charRaceVariantCard.Resistance != null)
            {
                foreach (var item in this.charRaceVariantCard.Resistance)
                {
                    resistance.Add(item.GetEnumText());
                }
            }

            return resistance;
        }

        private int GetSavingThrowModifier(AbilitiesEnum ability)
        {
            int abilityModifier = this.proficiencyBonus;

            switch (ability)
            {
                case AbilitiesEnum.Cha:
                    abilityModifier += this.abilityScores.ChaMod;
                    break;
                case AbilitiesEnum.Con:
                    abilityModifier += this.abilityScores.ConMod;
                    break;
                case AbilitiesEnum.Dex:
                    abilityModifier += this.abilityScores.DexMod;
                    break;
                case AbilitiesEnum.Int:
                    abilityModifier += this.abilityScores.IntMod;
                    break;
                case AbilitiesEnum.Str:
                    abilityModifier += this.abilityScores.StrMod;
                    break;
                case AbilitiesEnum.Wis:
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

        private int GetSkillModifier(SkillsEnum skill) {
            int skillModifier = this.proficiencyBonus;

            switch (skill)
            {
                case SkillsEnum.Acrobatics:
                case SkillsEnum.SleightOfHand:
                case SkillsEnum.Stealth:
                    skillModifier += this.abilityScores.DexMod;
                    break;
                case SkillsEnum.Arcana:
                case SkillsEnum.History:
                case SkillsEnum.Investigation:
                case SkillsEnum.Nature:
                case SkillsEnum.Religion:
                    skillModifier += this.abilityScores.IntMod;
                    break;
                case SkillsEnum.AnimalHandling:
                case SkillsEnum.Insight:
                case SkillsEnum.Medicine:
                case SkillsEnum.Perception:
                case SkillsEnum.Survival:
                    skillModifier += this.abilityScores.WisMod;
                    break;
                case SkillsEnum.Athletics:
                    skillModifier += this.abilityScores.StrMod;
                    break;
                case SkillsEnum.Deception:
                case SkillsEnum.Intimidation:
                case SkillsEnum.Performance:
                case SkillsEnum.Persuasion:
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
                    tools.Add(item.GetEnumText());
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
                    weapons.Add(item.GetEnumText());
                }
            }

            return weapons;
        }

        private void UpdateAbilityScores(string charClass) {
            ClassCard selectedClass = Decks.ClassDeck.Cards.Find(x => x.Name == charClass);
            int abilityScore = 0;
            int availableScoreIncrease = 2;

            foreach (var ability in selectedClass.ASI)
            {
                switch (ability)
                {
                    case AbilitiesEnum.Cha:
                        if (this.abilityScores.Cha < 20)
                        {
                            abilityScore = GetAbilityScoreIncrease(this.abilityScores.Cha, availableScoreIncrease);
                            availableScoreIncrease = this.abilityScores.Cha - abilityScore - availableScoreIncrease;

                            this.abilityScores.Cha = abilityScore;
                            this.abilityScores.ChaMod = GetAbilityScoreModifier(abilityScore);
                        }
                        break;
                    case AbilitiesEnum.Con:
                        if (this.abilityScores.Con < 20)
                        {
                            abilityScore = GetAbilityScoreIncrease(this.abilityScores.Con, availableScoreIncrease);
                            availableScoreIncrease = abilityScore - this.abilityScores.Con - availableScoreIncrease;

                            this.abilityScores.Con = abilityScore;
                            this.abilityScores.ConMod = GetAbilityScoreModifier(abilityScore);
                        }
                        break;
                    case AbilitiesEnum.Dex:
                        if (this.abilityScores.Dex < 20)
                        {
                            abilityScore = GetAbilityScoreIncrease(this.abilityScores.Dex, availableScoreIncrease);
                            availableScoreIncrease = this.abilityScores.Dex - abilityScore - availableScoreIncrease;

                            this.abilityScores.Dex = abilityScore;
                            this.abilityScores.DexMod = GetAbilityScoreModifier(abilityScore);
                        }
                        break;
                    case AbilitiesEnum.Int:
                        if (this.abilityScores.Int < 20)
                        {
                            abilityScore = GetAbilityScoreIncrease(this.abilityScores.Int, availableScoreIncrease);
                            availableScoreIncrease = this.abilityScores.Int - abilityScore - availableScoreIncrease;

                            this.abilityScores.Int = abilityScore;
                            this.abilityScores.IntMod = GetAbilityScoreModifier(abilityScore);
                        }
                        break;
                    case AbilitiesEnum.Str:
                        if (this.abilityScores.Str < 20)
                        {
                            abilityScore = GetAbilityScoreIncrease(this.abilityScores.Str, availableScoreIncrease);
                            availableScoreIncrease = this.abilityScores.Str - abilityScore - availableScoreIncrease;

                            this.abilityScores.Str = abilityScore;
                            this.abilityScores.StrMod = GetAbilityScoreModifier(abilityScore);
                        }
                        break;
                    case AbilitiesEnum.Wis:
                        if (this.abilityScores.Wis < 20)
                        {
                            abilityScore = GetAbilityScoreIncrease(this.abilityScores.Wis, availableScoreIncrease);
                            availableScoreIncrease = this.abilityScores.Wis - abilityScore - availableScoreIncrease;

                            this.abilityScores.Wis = abilityScore;
                            this.abilityScores.WisMod = GetAbilityScoreModifier(abilityScore);
                        }
                        break;
                    default:
                        break;
                }

                availableScoreIncrease = availableScoreIncrease <= 0 ? 0 : availableScoreIncrease;
            }
        }
    }
}
