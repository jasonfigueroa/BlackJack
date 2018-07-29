using System;
using System.Collections.Generic;

namespace BlackJack
{
    public class Deck : IDeck
    {
        public int DeckCount { get; private set; }
        public List<Card> Cards { get; set; }
        public Deck()
        {
            Cards = BuildDeck();
            ShuffleCards();
        }

        public void ShuffleCards()
        {
            Random rng = new Random();  
            Card temp;
            int n = Cards.Count;
            while (n > 1)
            {
                n--;
                int randomValue = rng.Next(n + 1);
                temp = Cards[randomValue];
                Cards[randomValue] = Cards[n];
                Cards[n] = temp;
            }
        }

        public List<Card> BuildDeck()
        {
            List<Card> sortedDeck = new List<Card>();
            List<string> faceCards = new List<string> { "jack", "queen", "king" };
            List<string> suits = new List<string> { "spades", "diamonds", "hearts", "clubs" };
            Dictionary<string, int> ranksAndValues = new Dictionary<string, int>
            {
                {"two", 2},
                {"three", 3},
                {"four", 4},
                {"five", 5},
                {"six", 6},
                {"seven", 7},
                {"eight", 8},
                {"nine", 9},
                {"ten", 10},
                {"jack", 10},
                {"queen", 10},
                {"king", 10},
                {"ace", 11}
            };

            for (int i = 0; i < 4; i++)
            {
                foreach(KeyValuePair<string, int> rankAndValue in ranksAndValues)
                {
                    Card newCard = new Card()
                    {
                        Rank = rankAndValue.Key,
                        Value = rankAndValue.Value,
                        FaceCard = faceCards.Contains(rankAndValue.Key),
                        Ace = rankAndValue.Key == "ace",
                        Suit = suits[i]
                    };

                    sortedDeck.Add(newCard);
                }
            }
            return sortedDeck;
        }

        public Card DrawCard()
        {
            throw new System.NotImplementedException();
        }
    }
}