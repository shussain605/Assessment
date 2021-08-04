using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment
{
    public static class Operations
    {
        private static List<int> UsedIndexes = new List<int>();
        private static int DrawCount { get; set; } = 0;

        public static void Shuffle()
        {
            //Empty Used Indexes list as DealOneCard method might have filled it
            UsedIndexes.Clear();

            //Temp list to hold shuffled deck
            List<string> shuffledDeck = new List<string>();

            //Shuffle deck in new list 'shuffledDeck'
            for (int i = 0; i < 52; i++)
            {
                int nextRandomIndex = GetNextRandomIndex(UsedIndexes);
                UsedIndexes.Add(nextRandomIndex);
                shuffledDeck.Add(DeckOfCards.CardsDeck[nextRandomIndex]);
            }

            //Clone Deck using shuffledDeck
            for (int i = 0; i < 52; i++)
            {
                DeckOfCards.CardsDeck[i] = shuffledDeck[i];
            }

            //Reset Used Indexes and Draw Count for DealOneCard method
            UsedIndexes.Clear();
            DrawCount = 0;
        }

        public static string DealOneCard()
        {
            //Shuffle only once when DrawCount value is 0
            if (DrawCount == 0)
            {
                Shuffle();
            }

            //return one card at a time, up to 52, and the return blank
            if (DrawCount < 52)
            {
                //Get next random index, update used indexes, and increment counter
                int nextRandomIndex = GetNextRandomIndex(UsedIndexes);
                UsedIndexes.Add(nextRandomIndex);
                DrawCount += 1;
                return DeckOfCards.CardsDeck[nextRandomIndex];
            }
            else
            {
                return "";
            }
        }

        private static int GetNextRandomIndex(List<int> usedIndexesList)
        {
            Random rnd = new Random();
            bool nextRandomIndexFound = true;
            int nextRandomIndex = 0;

            //Do not return a random index which is already used
            while (nextRandomIndexFound)
            {
                nextRandomIndex = rnd.Next(0, 52);
                if (!usedIndexesList.Contains(nextRandomIndex))
                {
                    break;
                }
            }

            return nextRandomIndex;
        }
    }
}
