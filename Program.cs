namespace Stacks_DeBord_Joshua
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Card[] MyCardsArray = new Card[] //creates a stack list with aces, queens, aces, diamonds and hearts in it
            {
                new Card("Ace", "Spades"),
                new Card("Jack", "Clubs"),
                new Card("Queen", "Diamonds"),
                new Card("Queen", "Diamonds"),
                new Card("10", "Hearts"),
                new Card("2", "Diamonds"),
                new Card("6", "Spades"),
                new Card("9", "Clubs"),
                new Card("Acell", "Diamonds"),
            };

            Stack<Card> startingDeck = new(MyCardsArray);

            Console.WriteLine("Cards in Deck:");//sends to the console "cards in deck:"
            foreach (Card card in startingDeck)//for eacb card in the deck, sends that amount with wach card in it to the console
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

            Console.WriteLine($"Cards in the stack: {startingDeck.Count}");//sends to the console the amount of cards in the stack

            List<Card> myHand = new(); //creates a new stacks list
            {
                new Card("jack", "Diamonds");
                new Card("8", "Hearts");
                new Card("3", "Diamonds";
            }

            Console.WriteLine("Got any 8s?");//sends to the console "got any 8s?
            if (startingDeck.Count > 0)
            {
                myHand.Add(startingDeck.Pop());
            }

            Console.WriteLine($"Cards in the stack: {startingDeck.Count}"); //sends to the console

            startingDeck.Push(myHand[0]);
            myHand.RemoveAt(0);

            Console.WriteLine("Cards in Deck:");
            foreach (Card card in startingDeck)
            {
                Console.WriteLine($"The {card.Number} of {card.Suit}!");
            }

        }
    }
}