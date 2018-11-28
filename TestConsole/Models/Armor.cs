using TestConsole.Enums;

namespace TestConsole.Models
{
    public class Armor : Base
    {
        public int ArmorClass { get; set; }
        public Cost Cost { get; set; }
        public bool Stealth { get; set; }
        public int Strength { get; set; }
        public ArmorTypesEnum Type { get; set; }
        public int Weight { get; set; }
    }
}
