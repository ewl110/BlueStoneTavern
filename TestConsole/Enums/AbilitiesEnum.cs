using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Enums
{
    public enum AbilitiesEnum
    {
        [Description("Charisma")]
        charisma,
        [Description("Constitution")]
        constitution,
        [Description("Dexterity")]
        dexterity,
        [Description("Intelligence")]
        intelligence,
        [Description("Strength")]
        strength,
        [Description("Wisdom")]
        wisdom
    }
}
