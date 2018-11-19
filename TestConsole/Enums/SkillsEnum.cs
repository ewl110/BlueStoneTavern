using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Enums
{
    public enum SkillsEnum
    {
        [Description("Acrobatics")]
        acrobatics,
        [Description("Arcana")]
        arcana,
        [Description("Animal Handling")]
        animalHandling,
        [Description("Athletics")]
        athletics,
        [Description("Deception")]
        deception,
        [Description("History")]
        history,
        [Description("Insight")]
        insight,
        [Description("Intimidation")]
        intimitdation,
        [Description("Investigation")]
        investigation,
        [Description("Medicine")]
        medicine,
        [Description("Nature")]
        nature,
        [Description("Perception")]
        perception,
        [Description("Performance")]
        performance,
        [Description("Persuasion")]
        persuasion,
        [Description("Religion")]
        religion,
        [Description("Sleight of Hand")]
        sleightOfHand,
        [Description("Stealth")]
        stealth,
        [Description("Survival")]
        survival
    }
}
