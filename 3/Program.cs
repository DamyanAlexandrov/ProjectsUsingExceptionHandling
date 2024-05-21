namespace lab_ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> validCards = new List<Card>();

            string[] cardsToCreate = Console.ReadLine().Split(", ");

            foreach (string item in cardsToCreate)
            {
                string[] validFaces = new[] 
                { 
                    "A", "K", "Q", "J", "2", "3", "4", "5", "6", "7", "8", "9", "10"
                };

                Dictionary<string, string> validSuites = new Dictionary<string, string>()
                {
                    { "S", "\u2660" },
                    { "H", "\u2665" },
                    { "D", "\u2666" },
                    { "C", "\u2663" }
                };


                string[] cardElements = item.Split(" ");
                string face = cardElements[0];
                string suite = cardElements[1];

                try
                {
                    if (!validFaces.Contains(face) || !validSuites.ContainsKey(suite))
                    {
                        throw new Exception("Invalid card!");
                    }

                    Card card = new Card();

                    card.Face = face;
                    card.Suit = validSuites[suite];
                    validCards.Add(card);
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine(String.Join(" ", validCards));

        }
    }
    public class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }

        public override string ToString()
        {
            return $"[{this.Face}{this.Suit}]";
        }
    }
}
