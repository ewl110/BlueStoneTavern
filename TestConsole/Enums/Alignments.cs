using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Enums
{
    public enum Alignments
    {
        [Description("Lawful Good")]
        LawfulGood,
        [Description("Neutral Good")]
        NeutralGood,
        [Description("Chaotic Good")]
        ChaoticGood,
        [Description("Lawful Neutral")]
        LawfulBeutral,
        [Description("True Neutral")]
        TrueNeutral,
        [Description("Chaotic Neutral")]
        ChaoticNeutral,
        [Description("Lawful Evil")]
        LawfulEvil,
        [Description("Neutral Evil")]
        NeutralEvil,
        [Description("Chaotic Evil")]
        ChaoticEvil
    }
}
