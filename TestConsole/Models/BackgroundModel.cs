using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class BackgroundModel : Base
    {
        public List<LanguagesEnum> Languages { get; set; }
        public List<SkillsEnum> Skills { get; set; }
        public List<ToolsEnum> Tools { get; set; }
    }
}
