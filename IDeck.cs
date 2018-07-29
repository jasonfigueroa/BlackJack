using System.Collections.Generic;

namespace BlackJack
{
    public interface IDeck
    {
        List<Card> Cards { get; set; }
        Card DrawCard();
        List<Card> BuildDeck();
        void ShuffleCards();
    }
}