using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGame
{
    internal class Player
    {
        public int Hp;
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
            name = "playername";
            Hp = 100;
            wepdmg = 10;

        }
        public Player(string PlayerName, int PlayerHp, int Playerattack)
        {
            name = PlayerName;
            wepdmg = Playerattack;
            Hp = PlayerHp;
        }

        public void attack()
        {
            Console.WriteLine("You strike at the enemy");
            Console.WriteLine("You do" + " " + wepdmg + " " + "damage");      
        }

    }
}