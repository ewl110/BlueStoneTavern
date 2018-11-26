using DnD5E.Models;
using System.Collections.Generic;

namespace DnD5E.Decks
{
    public static class ClassDeck
    {
        public static List<ClassCard> Cards = new List<ClassCard>() {
            new ClassCard()
            {
                HitDice = 12,
                Name = "Barbarian"
            },
            new ClassCard()
            {
                HitDice = 8,
                Name = "Bard"
            },
            new ClassCard()
            {
                HitDice = 8,
                Name = "Cleric"
            },
            new ClassCard()
            {
                HitDice = 8,
                Name = "Druid"
            },
            new ClassCard()
            {
                HitDice = 10,
                Name = "Fighter"
            },
            new ClassCard()
            {
                HitDice = 8,
                Name = "Monk"
            },
            new ClassCard()
            {
                HitDice = 8,
                Name = "Paladin"
            },
            new ClassCard()
            {
                HitDice = 10,
                Name = "Ranger"
            },
            new ClassCard()
            {
                HitDice = 8,
                Name = "Rogue"
            },
            new ClassCard()
            {
                HitDice = 6,
                Name = "Sorceror"
            },
            new ClassCard()
            {
                HitDice = 8,
                Name = "Warlock"
            },
            new ClassCard()
            {
                HitDice = 6,
                Name = "Wizard"
            }
        };
    }
}
