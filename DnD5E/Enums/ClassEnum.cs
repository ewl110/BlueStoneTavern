using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5E.Enums
{
    public enum ClassEnum
    {
        [Description("Barbarian")]
        barbarian,
        [Description("Bard")]
        bard,
        [Description("Cleric")]
        cleric,
        [Description("Druid")]
        druid,
        [Description("Fighter")]
        fighter,
        [Description("Monk")]
        monk,
        [Description("Paladin")]
        paladin,
        [Description("Ranger")]
        ranger,
        [Description("Rogue")]
        rogue,
        [Description("Sorceror")]
        sorceror,
        [Description("Warlock")]
        warlock,
        [Description("Wizard")]
        wizard
    }
}
