using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    class DrawCards
    {
        public static void DisplayShuffleCards()
        {
            Operations.Shuffle();
            foreach (string card in DeckOfCards.CardsDeck)
            {
                Console.WriteLine(card);
            }

            GetUserResponse();
        }

        public static void DisplayUnshuffledCards()
        {
            foreach(string card in DeckOfCards.CardsDeck)
            {
                Console.WriteLine(card);
            }

            GetUserResponse();
        }

        public static void DisplaySingleRandomCard()
        {
            char userResponse = 'a';
            int counter = 0;

            while (userResponse != 'Q')
            {
                Console.WriteLine("Press Q to end, any other key to draw next ...");
                userResponse = Console.ReadKey(true).KeyChar;
                userResponse = char.ToUpper(userResponse);

                if (userResponse == 'Q')
                {
                    break;
                }

                counter += 1;
                Console.WriteLine(counter.ToString() + " -- " + Operations.DealOneCard());
            }
        }

        public static void GetUserResponse()
        {
            Console.WriteLine("Press any key to close ...");
            Console.ReadKey();
        }
    }
}
