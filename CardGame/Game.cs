using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardGame
{
    class Game
    {
        string[] cards = new string[] { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
        string[] suit = new string[] { "Spades", "CLubs", "Diamonds", "Hearts" };
        ArrayList Table = new ArrayList();

        Random random = new Random();

        public ArrayList GetUniqueCards()
        {
            ArrayList temp = new ArrayList();
            while (true)
            {
                int cardgen = random.Next(0, cards.Length);
                int suitgen = random.Next(0, suit.Length);

                string s = cards[cardgen] + " " + suit[suitgen];

                if (!Table.Contains(s))
                {
                    Table.Add(s);
                    temp.Add(s);
                }

                if (temp.Count == 5) break;
            }

            //for (int i = 0; i < Table.Count; i++)
            //{
            //    Console.WriteLine(Table[i]);
            //}

            return temp;
        }

        public int GetValue(ArrayList playercards)
        {
            int total = 0;

            for(int i = 0; i < playercards.Count; i++)
            {
                string val = playercards[i].ToString().Split(' ')[0];

                if (val.Equals("Ace") || val.Equals("Jack") || val.Equals("Queen") || val.Equals("King"))
                {
                    total += 10;
                } else total += Int32.Parse(val);
            }   

            return total;
        }
    }
}
