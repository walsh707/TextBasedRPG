using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int loop =1;
            string PlayerName;
            string choice;
            Enemy firstEnemy = new Enemy("Kobolt",50,5);
            Player PC = new Player("Jason",100,10);


            Console.WindowWidth = Console.LargestWindowWidth - 100;
            

            Console.WriteLine("          _______  _        _______  _______  _______  _______   _________ _______ ");
            Console.WriteLine("|\\     /|(  ____ \\( \\      (  ____ \\(  ___   (       )|  ____ \\  \\__   __/(  ___  )");
            Console.WriteLine("| )   ( || (    \\ | |      | (    \\ |       | () () ()|  (         (   )  | |   | |");
            Console.WriteLine("| | _ | || (__    | |      | |      | |   | || || || || (__         | |   | |   | |");
            Console.WriteLine("| |( )| ||  __)   | |      | |      | |   | || |(_)| ||  __)        | |   | |   | |");
            Console.WriteLine("| || || || (      | |      | |      | |   | || |   | || (           | |   | |   | |");
            Console.WriteLine("| () () || (____/\\| (____/\\| (____/\\| (___) || )   ( || (____/\\     | |   | (___) |");
            Console.WriteLine("(_______)(_______/(_______/(_______/(_______)|/     \\|(_______/     )_(   (_______)");
            Console.WriteLine(" ______            _        _______  _______  _______  _          _______  _______  _______  _______ ");
            Console.WriteLine("(  __  \\ |\\     /|( (    /|(  ____ \\(  ____ \\(  ___  )( (    /|  (  ____ \\(  ___  )(       )(  ____ \\");
            Console.WriteLine("| (  \\  )| )   ( ||  \\  ( || (    \\/| (    \\/| (   ) ||  \\  ( |  | (    \\/| (   ) || () () || (    \\/");
            Console.WriteLine("| |   ) || |   | ||   \\ | || |      | (__    | |   | ||   \\ | |  | |      | (___) || || || || (__    ");
            Console.WriteLine("| |   | || |   | || (\\ \\) || | ____ |  __)   | |   | || (\\ \\) |  | | ____ |  ___  || |(_)| ||  __)   ");
            Console.WriteLine("| |   ) || |   | || | \\   || | \\_  )| (      | |   | || | \\   |  | | \\_  )| (   ) || |   | || (      ");
            Console.WriteLine("| (__/  )| (___) || )  \\  || (___) || (____/\\| (___) || )  \\  |  | (___) || )   ( || )   ( || (____/\\");
            Console.WriteLine("(______/ (_______)|/    )_)(_______)(_______/(_______)|/    )_)  (_______)|/     \\||/     \\|(_______/");


            Console.WriteLine("PRESS ENTER TO CONTINUE");
            Console.ReadLine();

            while (loop != 0)
            {          
                Console.WriteLine("Press 1 to Start the Game");
                Console.WriteLine("Press 0 to Quit");
                string input = Console.ReadLine();
                Int32.TryParse(input, out loop);

                if (loop == 1)
                {
                    Console.WriteLine("Enter Your Name");
                    PlayerName = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Welcome hero  " + PlayerName);

                    Console.WriteLine("     /'");
                    Console.WriteLine("     ||");
                    Console.WriteLine("     ||");
                    Console.WriteLine("     ||      ____ ");
                    Console.WriteLine("     ||     ( ___\\");
                    Console.WriteLine("     ||     |:  \\\\");
                    Console.WriteLine("    ><><  ___)..:/_#__,");
                    Console.WriteLine("    (X|) (|+(____)+\\ _)");
                    Console.WriteLine("     o|_\\/>> + + + << \\");
                    Console.WriteLine("       \\./  XXXXXX.  (o_)_");
                    Console.WriteLine("           /+ + + |   \\:|");
                    Console.WriteLine("           /+ + + |   \\:|");
                    Console.WriteLine("         /+ +|+ /XX /   _--,");
                    Console.WriteLine("        \\+ + + /  |X");
                    Console.WriteLine("        /\\+ + /\\  |X");
                    Console.WriteLine("       +_+_+_( )o_)X");
                    Console.WriteLine("        (_o(  /__/ X");
                    Console.WriteLine("         \\_|  |_/  X");
                    Console.WriteLine("         \\_| >(_/ ");
                    Console.WriteLine("    ,////__o\\ /__////,");

                    Console.WriteLine("You have been given a quest to investigate a mine");
                    Console.WriteLine("It has been rumored to be harboring demon and is stopping iron production for the region");
                    Console.WriteLine("Upon completion of this task the Mayor of the town promises you a reward, Will you accept");
                    Console.WriteLine("Enter y or n to continue:");
                    choice = Console.ReadLine();
                    Console.Clear();

                    if (choice == "y" || choice == "Y")
                    {
                        Console.WriteLine("You journey to the entrance of the mine and find the Forman of the mine and ask him to allow you entrance");
                        Console.WriteLine("Forman: so you want to enter my mine. I'm sure you've heard all the trouble that's beeng going on in there."); 
                        Console.WriteLine("but if you want to risk your neck that's your choise");
                        Console.WriteLine("He waves a hand and the armored guards at the entrance move aside to let you pass");
                        Console.WriteLine("press enter to continue");
                        

                        Console.WriteLine(" _____________________________");
                        Console.WriteLine("/_____________________________\\");
                        Console.WriteLine("| |		           | |");
                        Console.WriteLine("| |		           | |");
                        Console.WriteLine("| |		           | |");
                        Console.WriteLine("| |		           | |");
                        Console.WriteLine("| |		           | |");
                        Console.WriteLine("| |		           | |");
                        Console.WriteLine("| |		           | |");
                        Console.WriteLine("| |		           | |");

                        choice = Console.ReadLine();
                        Console.Clear();



                        while (choice != "quit")
                        {

                            Console.WriteLine("              ______________");
                            Console.WriteLine("           ( |	           | )");
                            Console.WriteLine("          ( | #         @    | )");
                            Console.WriteLine("        ( | /                 | )");
                            Console.WriteLine("        ( |/   @              | )");
                            Console.WriteLine("       ( |                     | )");
                            Console.WriteLine("      ( |           @           | )");
                            Console.WriteLine("     ( |                         | )");
                            Console.WriteLine("    ( |                   @       | )");

                            Console.WriteLine("You enter the mine");
                            Console.WriteLine("As you travel in all you can hear are the sounds of dripping water and your own echoing footsteps");
                            Console.WriteLine("The path is dimly lit by tourches along the walls");
                            Console.WriteLine("A little farther in and you come too a crossroad spliting off to the left and right");
                            Console.WriteLine("Which way will you go (left/right)");
                            Console.WriteLine("Enter left or right to continue:");
                            choice = Console.ReadLine();
                            Console.Clear();

                            if (choice == "right")
                            {
                                Console.WriteLine("              ______________");
                                Console.WriteLine("           ( |	           | )");
                                Console.WriteLine("          ( | #              | )");
                                Console.WriteLine("        ( | /                 | )");
                                Console.WriteLine("        ( |/                  | )");
                                Console.WriteLine("       ( |   ^                  | )");
                                Console.WriteLine("      ( |    |                  | )");
                                Console.WriteLine("     ( |     |                   | )");
                                Console.WriteLine("    ( |      |     @---<          | )");

                                Console.WriteLine("You venture down the right tunnel");
                                Console.WriteLine("As you continue you come accross several shodows in the distance");
                                Console.WriteLine("As you get closer the you realize that the shadows are actually bodies of dead miners");
                                Console.WriteLine("As you bend down and check the bodies you notice claw and bite marks, and arrows and spear scattered around the area");
                                Console.WriteLine("You cautiously continue down untill you come were the two paths seem to rejoin");
                                Console.WriteLine("Will you keep going or will you search the other tunnel");
                                Console.WriteLine("Enter (explore or keep going) to continue:");
                                choice = Console.ReadLine();
                                Console.Clear();
                            }

                            else if (choice == "left")
                            {
                                Console.WriteLine("              ______________");
                                Console.WriteLine("           ( |	           | )");
                                Console.WriteLine("          ( | #              | )");
                                Console.WriteLine("        ( | /                 | )");
                                Console.WriteLine("        ( |/                  | )");
                                Console.WriteLine("       ( |                      | )");
                                Console.WriteLine("      ( |                       | )");
                                Console.WriteLine("     ( |                         | )");
                                Console.WriteLine("    ( |    >---@   @---<          | )");

                                Console.WriteLine("You venture down the left tunnel");
                                Console.WriteLine("As you continue through the tunnel you find dead bodies and hear echos of dripping water");
                                Console.WriteLine("You cautiously continue down untill you come were the two paths seem to rejoin");
                                Console.WriteLine("will you keep going or will you search the other tunnel");
                                Console.WriteLine("Enter (explore or keep going) to continue:");
                                choice = Console.ReadLine();
                                Console.Clear();
                            }


                            Console.WriteLine("              ______________");
                            Console.WriteLine("           ( |	           | )");
                            Console.WriteLine("          ( | #         @    | )");
                            Console.WriteLine("        ( | /                 | )");
                            Console.WriteLine("        ( |/   @              | )");
                            Console.WriteLine("       ( |                     | )");
                            Console.WriteLine("      ( |           @           | )");
                            Console.WriteLine("     ( |                         | )");
                            Console.WriteLine("    ( |                   @       | )");

                            if (choice == "explore")
                            {
                                Console.WriteLine("              ______________");
                                Console.WriteLine("           ( |	           | )");
                                Console.WriteLine("          ( | #              | )");
                                Console.WriteLine("        ( | /                 | )");
                                Console.WriteLine("        ( |/                  | )");
                                Console.WriteLine("       ( |   ^                  | )");
                                Console.WriteLine("      ( |    |                  | )");
                                Console.WriteLine("     ( |     |                   | )");
                                Console.WriteLine("    ( |      |     @---<          | )");
                                Console.WriteLine("You find much of the same broken weapon and dead corpses but you do find a few copper pieces on one of the miners");
                                Console.WriteLine("The only Path left is to Forge Ahead");
                            }
                            else if (choice == "keep going")
                            {
                                Console.WriteLine("You continue on your path, readying yourself as the echoes get louder");
                            }

                            choice = Console.ReadLine();
                            Console.WriteLine("press enter to continue");
                            Console.Clear();

                            Console.WriteLine("              ______________");
                            Console.WriteLine("           ( |	           | )");
                            Console.WriteLine("          ( | #         @    | )");
                            Console.WriteLine("        ( | /                 | )");
                            Console.WriteLine("        ( |/   @              | )");
                            Console.WriteLine("       ( |                     | )");
                            Console.WriteLine("      ( |           @           | )");
                            Console.WriteLine("     ( |                         | )");
                            Console.WriteLine("    ( |                   @       | )");

                            Console.WriteLine("As you urge yourself forward the air seem to becoming moldy");
                            Console.WriteLine("And the echoes are getting louder");
                            Console.WriteLine("As you go deeped you get closer and closer to the sounds");
                            Console.WriteLine("Froem what you can make out they sound like growls or a small dog");
                            Console.WriteLine("All of a sudden the sounds of the creature seems to stop and you left in the dark with only the dripping water and your footsteps");
                            Console.WriteLine("press enter to continue");
                            choice = Console.ReadLine();
                            
                            Console.WriteLine("After a few seconds you hear the sound of something running at you");
                            Console.WriteLine("A shadowy figure comes into view and lunges at you");
                            Console.WriteLine("You manage to narowly dodge it's first attack");
                            Console.WriteLine("You pull out your sword ready for battle");
                            Console.WriteLine("Do you stike first (y/n)");
                            choice = Console.ReadLine();
                            Console.Clear();

                            while (firstEnemy.Hp != 0)
                            {

                                Console.WriteLine("     (_(");
                                Console.WriteLine("    ('')");
                                Console.WriteLine("  _   \\ ) >,_.-- > ");
                                Console.WriteLine("  _>--w/((_ >,_.'");
                                Console.WriteLine("         / /");
                                Console.WriteLine("         / /     ");

                                if (choice == "y")
                                {
                                    PC.attack();
                                    Console.WriteLine("You slash at the enemy");
                                    firstEnemy.Hp = firstEnemy.Hp - PC.wepdmg;
                                    Console.WriteLine("The enemy health is " + firstEnemy.Hp);

                                    Console.WriteLine("The emeny is preparing to strike back");
                                    firstEnemy.attack();
                                    PC.Hp = PC.Hp - firstEnemy.wepdmg;
                                    Console.WriteLine("Your health is " + PC.Hp);
                                }
                                

                                else if (choice == "n")
                                {
                                    firstEnemy.attack();
                                    Console.WriteLine("You flinch from the enemy's attack");
                                    PC.Hp = PC.Hp - firstEnemy.wepdmg;
                                    Console.WriteLine("Your health is " + PC.Hp);

                                    Console.WriteLine("But you compose your self and prepare to strike back");
                                    Console.ReadLine();
                                    PC.attack();
                                    firstEnemy.Hp = firstEnemy.Hp - PC.wepdmg;
                                    Console.WriteLine("The enemy health is " + firstEnemy.Hp);
                                }

                                Console.WriteLine("The Fight Continues");
                                Console.WriteLine("Press enter to continue the attack");
                                Console.ReadLine();
                                Console.Clear();
                            }

                            Console.WriteLine("The Fight is Over");
                            Console.WriteLine("A few seconds passed and you take the time to catch your breath");
                            Console.WriteLine("press enter to continue");
                            choice = Console.ReadLine();
                            Console.WriteLine("You take a look at you fallen foe");
                            Console.WriteLine("Upon closer inspection you identify it as a kobolt");
                            Console.WriteLine("   .      .");
                            Console.WriteLine("   }\\    /{");
                            Console.WriteLine("   ) \\__/ (");
                            Console.WriteLine("   (*\\  /*) ");
                            Console.WriteLine("    \\    / ");
                            Console.WriteLine("     \\../");
                            Console.WriteLine("      VV ");

                            Console.WriteLine("You identify it as a kobotl");
                            Console.WriteLine("Lizard like creatures, resembling small dragons without wings");
                            Console.ReadLine();
                            Console.WriteLine("But they always travel in packs");
                            Console.WriteLine("Perhaps it was the last one left after the battle with the guards and miners");
                            Console.WriteLine("press enter to continue");
                            Console.ReadLine();

                            Console.WriteLine("You bring yourself together and continue");
                            Console.WriteLine("However on further inspection of the mine you do not find any other enimies");
                            Console.WriteLine("The only course left is to return to the mayor and tell him the mine is cleared");
                            Console.WriteLine("press enter to continue");
                            Console.ReadLine();
                            Console.Clear();

                            Console.WriteLine("    xxxxxxxxxxxxxxxxxx	             xxxxx");
                            Console.WriteLine("   xxxxxxxxxxxxxxxxxxxx		       xxxxxxxxx");
                            Console.WriteLine("  xxxxxxxxxxxxxxxxxx  xx           xxxxxxxxxxx");
                            Console.WriteLine(" xxxxxxxxxxxxxxxxxx    xx	      xxxxxxxxxxx");
                            Console.WriteLine("xxxxxxxxxxxxxxxxxx	   xx          xxxxxxxxx");
                            Console.WriteLine(" x               x      x	         xxxxx");
                            Console.WriteLine(" x               x      x	         xxxxx");
                            Console.WriteLine(" x	xx xx	    x  xxx x	           x");
                            Console.WriteLine(" x	            x  xxx x               x");
                            Console.WriteLine("xxxxxxxxxxxxxxxxxxxxxxxxxxx	           x");

                            Console.WriteLine("Upon return the Mayor is over joyed to hear that you have succeeded");
                            Console.WriteLine("He hands you a bag of coins and invites you to celebrate");
                            Console.WriteLine("press enter to continue");
                            Console.ReadLine();
                            
                            Console.WriteLine("As you drink and eat you can't but wonder how the Kobolts got into the mine in the first place");
                            Console.WriteLine("You can't shake the fealing of something ominus about to happen");
                            Console.WriteLine("press enter to continue");
                            Console.ReadLine();
                            Console.WriteLine("X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X");
                            Console.WriteLine("|                           ,,'``````````````',,                            |");
                            Console.WriteLine("X                        ,'`                   `',                          X");
                            Console.WriteLine("|                      ,'                         ',                        |");
                            Console.WriteLine("X                    ,'          ;       ;          ',                      X");
                            Console.WriteLine("|       (           ;             ;     ;             ;     (               |");
                            Console.WriteLine("X        )         ;              ;     ;              ;     )              X");
                            Console.WriteLine("|       (         ;                ;   ;                ;   (               |");
                            Console.WriteLine("X        )    ;   ;    ,,'```',,,   ; ;   ,,,'```',,    ;   ;               X");
                            Console.WriteLine("|       (    ; ',;   '`          `',   ,'`          `'   ;,' ;              |");
                            Console.WriteLine("X        )  ; ;`,`',  _--~~~~--__   ' '   __--~~~~--_  ,'`,'; ;     )       X");
                            Console.WriteLine("|       (    ; `,' ; :  /       \\~~-___-~~/       \\  : ; ',' ;     (        |");
                            Console.WriteLine("X  )     )   )',  ;   -_\\  o    /  '   '  \\    o  /_-   ;  ,'       )   (   X");
                            Console.WriteLine("| (     (   (   `;      ~-____--~'       '~--____-~      ;'  )     (     )  |");
                            Console.WriteLine("X  )     )   )   ;            ,`;,,,   ,,,;',            ;  (       )   (   X");
                            Console.WriteLine("| (     (   (  .  ;        ,'`  (__ '_' __)  `',        ;  . )     (     )  |");
                            Console.WriteLine("| (   , ,'|// / (/ ,;  '        _--~~-~~--_        '  ;, \\)    \\|', ,    )  |");
                            Console.WriteLine("X ,)  , \\/ \\|  \\,/  ;;       ,; |_| | |_| ;,       ;;  \\,//  |/ \\/ ,   ,   X");
                            Console.WriteLine("X#(,'  )  \\\\#\\ \\##/)#;     :  `\\/       \\/   :     ;#(\\##/ /#///  (  ',)# ,X");
                            Console.WriteLine("|| ) | \\ |/ /#/ |#( \\; ;     :               ;     ; ;/ )#| \\#\\ \\| / | ( |) |");
                            Console.WriteLine("X\\ |.\\ |\\_/#| /#),,`   ;     ;./\\_     _/\\.;     ;   `,,(#\\ |#\\_/| //.| / ,X");
                            Console.WriteLine("| \\_/# |#\\##/,,'`       ;     ~~--|~|~|--~~     ;       `',,\\##/#| #\\_// \\/|");
                            Console.WriteLine("X  ##/#  #,,'`            ;        ~~~~~        ;            `',,#  #\\##  //X");
                            Console.WriteLine("|####@,,'`                 `',               ,'`                 `',,@####| |");
                            Console.WriteLine("X#,,'`                        `',         ,'`                        `',,###X");
                            Console.WriteLine("|'                               ~~-----~~                               `' |");
                            Console.WriteLine("X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X-X");

                            Console.WriteLine("_________ _______    ______   _______    _______  _______  _       __________________ _                 _______  ______    ");
                            Console.WriteLine("\\__   __/(  ___  )  (  ___ \\ (  ____ \\  (  ____ \\(  ___  )( (    /|\\__   __/\\__   __/( (    /||\\     /|(  ____ \\(  __  \\   ");
                            Console.WriteLine("   ) (   | (   ) |  | (   ) )| (    \\/  | (    \\/| (   ) ||  \\  ( |   ) (      ) (   |  \\  ( || )   ( || (    \\/| (  \\  )  ");
                            Console.WriteLine("   | |   | |   | |  | (__/ / | (__      | |      | |   | ||   \\ | |   | |      | |   |   \\ | || |   | || (__    | |   ) |  ");
                            Console.WriteLine("   | |   | |   | |  |  __ (  |  __)     | |      | |   | || (\\ \\) |   | |      | |   | (\\ \\) || |   | ||  __)   | |   | |  ");
                            Console.WriteLine("   | |   | |   | |  | (  \\ \\ | (        | |      | |   | || | \\   |   | |      | |   | | \\   || |   | || (      | |   ) |  ");
                            Console.WriteLine("   | |   | (___) |  | )___) )| (____/\\  | (____/\\| (___) || )  \\  |   | |   ___) (___| )  \\  || (___) || (____/\\| (__/  )  ");
                            Console.WriteLine("   )_(   (_______)  |/ \\___/ (_______/  (_______/(_______)|/    )_)   )_(   \\_______/|/    )_)(_______)(_______/(______/   ");

                            Console.WriteLine("press enter to return to the main menu");
                            Console.ReadLine();
                            Console.Clear();
                            choice = "quit";




                        }
                    }



                    else if (choice == "n" || choice == "N")
                    {
                        Console.WriteLine("You return to town");
                        Console.WriteLine("press enter to continue");
                        Console.ReadLine();
                        Console.Clear();
                    }


                }
            }
        }
    }
}
