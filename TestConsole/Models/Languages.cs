using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class Languages
    {
        Language[] LanguageList { get; set; }
    }

    public class Language : Base
    {
        public LanguageTypes Type { get; set; }
    }
}
