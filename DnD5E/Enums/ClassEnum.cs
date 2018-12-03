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
        Paladin,
        Ranger,
        Rogue,
        Sorcerer,
        [Description("Totem Warrior")]
        TotemWarrior,
        Warlock,
        Wizard
    }
}
