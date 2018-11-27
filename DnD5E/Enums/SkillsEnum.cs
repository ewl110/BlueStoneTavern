using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5E.Enums
{
    public enum SkillsEnum
    {
        Acrobatics,
        Arcana,
        [Description("Animal Handling")]
        AnimalHandling,
        Athletics,
        Deception,
        History,
        Insight,
        Intimidation,
        Investigation,
        Medicine,
        Nature,
        Perception,
        Performance,
        Persuasion,
        Religion,
        [Description("Select Skill")]
        SelectSkill,
        [Description("Sleight of Hand")]
        SleightOfHand,
        Stealth,
        Survival
    }
}
