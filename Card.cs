namespace BlackJack
{
    public class Card : ICard
    {
        public string Rank { get; set; }
        public int Value { get; set; }
        public bool FaceCard { get; set; }
        public bool Ace { get; set; }
        public string Suit { get; set; }
    }
}