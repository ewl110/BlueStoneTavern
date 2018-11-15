using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Enums
{
    public enum ToolTypes
    {
        [Description("Artisan's Tools")]
        artisansTools,
        [Description("Disguise Kit")]
        disguiseKit,
        [Description("Forgery Kit")]
        forgeryKit,
        [Description("Gaming Kit")]
        gaming,
        [Description("Herbalism Kit")]
        herbalismKit,
        [Description("Musical Instrument")]
        musicalInstrument,
        [Description("Navigator's Tools")]
        navigatorsTools,
        [Description("Poisoner's Kit")]
        poisonersKit,
        [Description("Thieves' Tools")]
        thievesTools
    }
}
