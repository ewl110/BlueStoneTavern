using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5E.Enums
{
    public enum RaceEnum
    {
        [Description("Dragonborn (Black)")]
        dragonbornBlack,
        [Description("Dragonborn (Blue)")]
        dragonbornBlue,
        [Description("Dragonborn (Bronze)")]
        dragonbornBronze,
        [Description("Dragonborn (Copper)")]
        dragonbornCopper,
        [Description("Dragonborn (Gold)")]
        dragonbornGold,
        [Description("Dragonborn (Green)")]
        dragonbornGreen,
        [Description("Dragonborn (Red)")]
        dragonbornRed,
        [Description("Dragonborn (Silver)")]
        dragonbornSilver,
        [Description("Dragonborn (White)")]
        dragonbornWhite,
        [Description("Duergar")]
        dwarfGray,
        [Description("Dwarf (Hill)")]
        dwarfHill,
        [Description("Dwarf (Mountain)")]
        dwarfMountain,
        [Description("Drow")]
        elfDark,
        [Description("Elf (High)")]
        elfHigh,
        [Description("Elf (Wood)")]
        elfWood,
        [Description("Gnome")]
        gnome,
        [Description("Half Elf")]
        halfElf,
        [Description("Half Orc")]
        halfOrc,
        [Description("Halfling")]
        halfling,
        [Description("Human (Standard)")]
        humanStandard,
        [Description("Human (Variant)")]
        humanVariant,
        [Description("Tiefling")]
        tiefling
    }
}
