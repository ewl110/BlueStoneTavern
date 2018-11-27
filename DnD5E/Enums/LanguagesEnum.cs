using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5E.Enums
{
    public enum LanguagesEnum
    {
        Abyssal,
        Arakocra,
        Celestial,
        Common,
        [Description("Deep Speech")]
        DeepSpeech,
        Draconic,
        Druidic,
        Dwarvish,
        Elvish,
        Giant,
        Gith,
        Gnomish,
        Goblin,
        Halfling,
        Infernal,
        Orc,
        Primordial,
        [Description("Select Language")]
        SelectLanguage,
        Sylvan,
        [Description("Thieves' Cant")]
        ThievesCant,
        Undercommon
    }
}
