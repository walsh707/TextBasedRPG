using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGame
{
    internal class Enemy
    {
        public int hp;
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
        hp = 100;
            wepdmg = 5;

    }
    public Enemy(string enemyName, int Enemyattack, int enemyHp)
        {
            name = enemyName;
            wepdmg = Enemyattack;
            hp = enemyHp;
        }

        public void attack()
        {
            Console.WriteLine("Kobolt Launches an attack");
        }


  }
}
