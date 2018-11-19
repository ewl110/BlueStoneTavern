using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace DnD5E.Enums
{

    public enum BackgroundEnum
    {
        [Description("Acolyte")]
        acolyte,
        [Description("Charlatan")]
        charlatan,
        [Description("Criminal")]
        criminal,
        [Description("Entertainer")]
        entertainer,
        [Description("Folk Hero")]
        folkHero,
        [Description("Guild Artisan")]
        guildArtisan,
        [Description("Guild Merchant")]
        guildMerchant,
        [Description("Hermit")]
        hermit,
        [Description("Knight")]
        knight,
        [Description("Noble")]
        noble,
        [Description("Outlander")]
        outlander,
        [Description("Pirate")]
        pirate,
        [Description("Sage")]
        sage,
        [Description("Sailor")]
        sailor,
        [Description("Soldier")]
        soldier,
        [Description("Spy")]
        spy,
        [Description("Urchin")]
        urchin
    }
}
