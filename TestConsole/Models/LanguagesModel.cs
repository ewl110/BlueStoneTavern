using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class LanguagesModel
    {
        LanguageModel[] List { get; set; }
    }

    public class LanguageModel : Base
    {
        public LanguageTypesEnum Type { get; set; }
    }
}
