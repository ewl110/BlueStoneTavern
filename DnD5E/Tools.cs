using DnD5E.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DnD5E
{
    public static class Tools
    {
        static Random rng = new Random();

        public static TItem PickRandomItemFromArray<TItem>(this TItem[] array)
        {
            return array[rng.Next(array.Count())];
        }

        public static TCard PullRandomCardFromDeck<TCard>(this List<TCard> deck, bool weighted = false) where TCard : BaseCard
        {
            int randomNumber = rng.Next(deck.Count);
            int totalWeight = 0;

            if (weighted)
            {
                foreach (var card in deck)
                {
                    totalWeight += card.Weight;
                }

                randomNumber = rng.Next(1, totalWeight);

                foreach (var card in deck)
                {
                    randomNumber -= card.Weight;

                    if (randomNumber <= 0)
                    {
                        return card;
                    }
                }
            }

            return deck[randomNumber];
        }
    }
}
