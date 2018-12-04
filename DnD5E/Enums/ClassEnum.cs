using System.ComponentModel;

namespace DnD5E.Enums
{
    public enum ClassEnum
    {
        Barbarian,
        Berserker,
        Bard,
        Cleric,
        [Description("College of Lore")]
        CollegeOfLore,
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
