using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Enums
{
    public enum Skills
    {
        Acrobatics,
        Arcana,
        [Description("Animal Handling")]
        AnimalHandling,
        Athletics,
        Deception,
        History,
        Insight,
        Intimitdation,
        Investigation,
        Medicine,
        Nature,
        Perception,
        Performance,
        Persuasion,
        Religion,
        [Description("Sleight of Hand")]
        SleightOfHand,
        Stealth,
        Survival
    }
}
