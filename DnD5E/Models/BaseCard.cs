using System.ComponentModel.DataAnnotations;

namespace DnD5E.Models
{
    public class BaseCard
    {
        public string Description { get; set; }
        public string Name { get; set; }

        /*
         * Weights by Rarity:
         * Common: 100
         * Uncommon: 45
         * Rare: 25
         * Very Rare: 10
         * Legendary: 1
        */

        [Range(1, 100)]
        public int Weight { get; set; } = 1;
    }
}
