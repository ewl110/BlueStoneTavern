using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole.Enums.Languages
{
    public enum Exotic
    {
        Abyssal,
        Aarakocra,
        Celestial,
        [Description("Deep Speech")]
        DeepSpeech,
        Draconic,
        Gith,
        Infernal,
        Primordial,
        Sylvan,
        Undercommon
    }
}
