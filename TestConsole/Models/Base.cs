using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestConsole.Enums;

namespace TestConsole.Models
{
    public class Base
    {
        public string Description { get; set; }
        public string Name { get; set; }
        public References Ref { get; set; }
    }
}
