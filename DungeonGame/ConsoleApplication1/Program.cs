using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGame
{
    internal class Player
    {
        public int hp;
        public string name;
        public int wepdmg;



        // getter and setter
        public string Playername
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }



        public Player()
        {
            name = "Jason";
            hp = 100;
            wepdmg = 5;

        }
        public Player(string PlayerName, int Playerattack, int PlayerHp)
        {
            name = PlayerName;
            wepdmg = Playerattack;
            hp = PlayerHp;
        }

        public void attack()
        {
            Console.WriteLine("You strike back");
        }


    }
}
