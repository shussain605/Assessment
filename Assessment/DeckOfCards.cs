using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public static class DeckOfCards
    {
        public static List<string> CardsDeck = new List<string>();

        static DeckOfCards()
        {
            string[] suites = { "Hearts", "Clubs", "Spades", "Diamonds" };
            string[] cards = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

            //Populate Deck with 52 cards
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 13; j++)
                {
                    CardsDeck.Add(suites[i] + " - " + cards[j]);
                }
            }
        }
    }
}
