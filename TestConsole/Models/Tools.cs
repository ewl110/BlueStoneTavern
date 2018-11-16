using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class Tools
    {
        public Tool[] List { get; set; }
    }

    public class Tool : Base
    {
        public Cost Cost { get; set; }
        public ToolTypesEnum Type { get; set; }
        public double Weight { get; set; }
    }
}
