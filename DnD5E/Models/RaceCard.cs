using DnD5E.Enums;

namespace DnD5E.Models
{
    public class RaceCard : BaseCard
    {
        public SizeEnum Size { get; set; } = SizeEnum.medium;
        public int Speed { get; set; } = 30;
    }
}
