namespace DnD5E.Models
{
    public class BackgroundCard : BaseCard
    {
        public string[] Bond { get; set; }
        public string Faction { get; set; }
        public string Feature { get; set; }
        public string[] Flaw { get; set; }
        public string[] Ideal { get; set; }
        public string[] Personality { get; set; }
    }
}
