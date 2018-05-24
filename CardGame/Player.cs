using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardGame
{
    class Player
    {
        private ArrayList playercards = new ArrayList();

        public Player(ArrayList cards)
        {
            this.playercards = cards;
        }

        public ArrayList GetCards()
        {
            return this.playercards;
        }
    }
}
