using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace CardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Game newGame = new Game();

            int max = 0;
            string playermax = " ";

            List<Player> playerList = new List<Player>();
            //ArrayList cards = new ArrayList(newGame.GetUniqueCards());

            Console.WriteLine("How many players? ");
            int currentplayer = Int32.Parse(Console.ReadLine());

            if (currentplayer > 10)
            {
                Console.WriteLine("The maximum players cannot exceed 10");
            }
            else
            {
                for (int playernumber = 0; playernumber < currentplayer; playernumber++)
                {
                    Player player = new Player(newGame.GetUniqueCards());
                    playerList.Add(player);

                    //for (int i = 0; i < cards.Count; i++)
                    //{
                    //    Console.WriteLine(cards[i]);
                    //}

                    //Console.WriteLine(newGame.GetValue(cards));

                    //foreach(string s in Table)
                    //{
                    //    Console.WriteLine(s);
                    //}
                }

                for (int i = 0; i < playerList.Count; i++)
                {
                    ArrayList cardlist = playerList[i].GetCards();
                    int sum = newGame.GetValue(cardlist);

                    Console.WriteLine("Player: " + (i + 1));
                    Console.WriteLine("SUM: " + sum);

                    if (sum > max)
                    {
                        max = sum;
                        playermax = (i + 1).ToString();
                    }

                    for (int j = 0; j < cardlist.Count; j++)
                    {
                        Console.WriteLine(cardlist[j]);
                    }
                    Console.WriteLine('\n');
                }

                Console.WriteLine("Player " + playermax + " had the higest value of cards");
            }
            Console.ReadKey();
        }

    }
}
