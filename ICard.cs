namespace BlackJack
{
    public interface ICard
    {
        string Rank { get; set; }
        int Value { get; set; }
        bool FaceCard { get; set; }
        bool Ace { get; set; }
        string Suit { get; set; }
    }
}