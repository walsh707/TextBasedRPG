using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGame
{
    internal class Enemy
    {
        public int Hp;
        public string name;
        public int wepdmg;


        // getter and setter
        public string Enemyname
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



        public Enemy()
        {
            name = "Koblot";
            Hp = 50;
            wepdmg = 5;

        }
        public Enemy(string enemyName, int enemyHp, int Enemyattack)
        {
            name = enemyName;
            wepdmg = Enemyattack;
            Hp = enemyHp;
        }

        public void attack()
        {
            Console.WriteLine("The Enemy strikes at you");
            Console.WriteLine("You take" + " " + wepdmg + " " + "damage");
        }


    }
}