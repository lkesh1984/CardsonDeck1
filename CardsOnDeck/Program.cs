using System;
using System.Collections.Generic;

namespace CardsOnDeck
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());

            for (int i = 0; i < T; i++)
            {
                int N = int.Parse(Console.ReadLine());
                List<int> cards = new List<int>();

                for (int j = 1; j <= N; j++)
                {
                    cards.Add(j);
                }

                PlayGame(cards);
                int topcard = cards[0];

                Console.WriteLine(topcard);
            }
        }

        static void PlayGame(List<int> cards)
        {
            while (cards.Count > 2)
            {
                // throw the top card
                cards.RemoveAt(0);

                // move the top card in the bottom
                int card = cards[0];
                cards.RemoveAt(0);
                cards.Insert(cards.Count, card);
            }

            // move the top card in the bottom
            int card1 = cards[0];
            cards.RemoveAt(0);
            cards.Insert(cards.Count, card1);
        }
    }
}
