using DnD5E.Models;
using System.Collections.Generic;

namespace DnD5E.Decks
{
    public static class RaceDeck
    {
        public static List<RaceCard> Cards = new List<RaceCard>() {
            new RaceCard()
            {
                Name = "Hill Dwarf",
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Mountain Dwarf",
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Drow",
                Weight = 25
            },
            new RaceCard()
            {
                Name = "High Elf",
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Wood Elf",
                Speed = 35,
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Forest Gnome",
                Speed = 25,
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Rock Gnome",
                Speed = 25,
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Lightfoot Halfling",
                Speed = 25,
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Stout Halfling",
                Speed = 25,
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Human (Standard)",
                Weight = 100
            },
            new RaceCard()
            {
                Name = "Human (Variant)",
                Weight = 100
            },
        };
    }
}
