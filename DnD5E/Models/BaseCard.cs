using DnD5E.Enums;
using System.ComponentModel.DataAnnotations;

namespace DnD5E.Models
{
    public class BaseCard
    {
        public string Description { get; set; }
        public string Name { get; set; }

        [Range(1, 100)]
        public int Weight { get; set; } = (int)RarityEnum.Common;
    }
}
