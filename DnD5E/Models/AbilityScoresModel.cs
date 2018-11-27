using System;
using System.ComponentModel.DataAnnotations;

namespace DnD5E.Models
{
    public class AbilityScoresModel
    {
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Cha { get; set; } = 8;
        public int ChaMod { get; set; }
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Con { get; set; } = 8;
        public int ConMod { get; set; }
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Dex { get; set; } = 8;
        public int DexMod { get; set; }
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Int { get; set; } = 8;
        public int IntMod { get; set; }
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Str { get; set; } = 8;
        public int StrMod { get; set; }
        [Range(1, 20, ErrorMessage = "Value must be between 1 and 20.")]
        public int Wis { get; set; } = 8;
        public int WisMod { get; set; }
    }
}
