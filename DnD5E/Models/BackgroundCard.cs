﻿namespace DnD5E.Models
{
    public class BackgroundCard : BaseCard
    {
        public string[] Bond { get; set; }
        public string[] Equipment { get; set; }
        public string Feature { get; set; }
        public string[] Flaw { get; set; }
        public string[] Ideal { get; set; }
        public string[] Languages { get; set; }
        public MoneyModel Money { get; set; }
        public string[] Personality { get; set; }
        public ProficiencyModel Proficiencies { get; set; }
    }
}

public class MoneyModel
{
    public int Cp { get; set; }
    public int Gp { get; set; }
    public int Sp { get; set; }
    public int Pp { get; set; }
}