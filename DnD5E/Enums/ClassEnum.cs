using System.ComponentModel;

namespace DnD5E.Enums
{
    public enum ClassEnum
    {
        Barbarian,
        Berserker,
        Bard,
        Cleric,
        [Description("College of Glamour")]
        CollegeOfGlamour,
        [Description("College of Lore")]
        CollegeOfLore,
        [Description("College of Swords")]
        CollegeOfSwords,
        [Description("College of Valor")]
        CollegeOfValor,
        [Description("College of Whispers")]
        CollegeOfWhispers,
        [Description("Arcana Domain")]
        DomainArcana,
        [Description("Death Domain")]
        DomainDeath,
        [Description("Forge Domain")]
        DomainForge,
        [Description("Grave Domain")]
        DomainGrave,
        [Description("Knowledge Domain")]
        DomainKnowledge,
        [Description("Life Domain")]
        DomainLife,
        [Description("Light Domain")]
        DomainLight,
        [Description("Nature Domain")]
        DomainNature,
        [Description("Tempest Domain")]
        DomainTempest,
        [Description("Trickery Domain")]
        DomainTrickery,
        [Description("War Domain")]
        DomainWar,
        Druid,
        Fighter,
        Monk,
        None,
        Paladin,
        [Description("Path of the Ancestral Guardian")]
        PathOfTheAncestralGuardian,
        [Description("Path of the Battlerager")]
        PathOfTheBattlerager,
        [Description("Path of the Berserker")]
        PathOfTheBerserker,
        [Description("Path of the Storm Herald")]
        PathOfTheStormHerald,
        [Description("Path of the Totem Warrior")]
        PathOfTheTotemWarrior,
        [Description("Path of the Zealot")]
        PathOfTheZealot,
        Ranger,
        Rogue,
        Sorcerer,
        [Description("Totem Warrior")]
        TotemWarrior,
        Warlock,
        Wizard
    }
}
