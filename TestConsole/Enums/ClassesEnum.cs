using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Enums
{
    public enum ClassesEnum
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
