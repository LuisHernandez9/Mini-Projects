using Room_Runners;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Room_Runner
{
    internal class Location
    {
        static Random rand = new Random();
        public static void Setlocation(int place)
        {
            //location selector
            switch (place) 
            {
                case 0:                  
                    Console.WriteLine("Welcome to\n _     ____  _     ____  _____   ____  _____   _____  _     _  _____ _     _____ ____ \r\n/ \\ /|/  _ \\/ \\ /\\/ ___\\/  __/  /  _ \\/    /  /__ __\\/ \\ /|/ \\/  __// \\ |\\/  __// ___\\\r\n| |_||| / \\|| | |||    \\|  \\    | / \\||  __\\    / \\  | |_||| ||  \\  | | //|  \\  |    \\\r\n| | ||| \\_/|| \\_/|\\___ ||  /_   | \\_/|| |       | |  | | ||| ||  /_ | \\// |  /_ \\___ |\r\n\\_/ \\|\\____/\\____/\\____/\\____\\  \\____/\\_/       \\_/  \\_/ \\|\\_/\\____\\\\__/  \\____\\\\____/\r\n                                                                                     ");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    HouseT();
                    break;
                case 1:
                    Console.Clear();
                    Console.WriteLine("Welcome to\n       _..._                                                                     \r\n    .-'_..._''.                                                                  \r\n  .' .'      '.\\                     _________   _...._                          \r\n / .'                 .-.          .-\\        |.'      '-.                       \r\n. '             .-,.--.\\ \\        / / \\        .'```'.    '.     .|              \r\n| |             |  .-. |\\ \\      / /   \\      |       \\     \\  .' |_             \r\n| |             | |  | | \\ \\    / /     |     |        |    |.'     |       _    \r\n. '             | |  | |  \\ \\  / /      |      \\      /    .'--.  .-'     .' |   \r\n \\ '.          .| |  '-    \\ `  /       |     |\\`'-.-'   .'    |  |      .   | / \r\n  '. `._____.-'/| |         \\  /        |     | '-....-'`      |  |    .'.'| |// \r\n    `-.______ / | |         / /        .'     '.               |  '.'.'.'.-'  /  \r\n             `  |_|     |`-' /       '-----------'             |   / .'   \\_.'   \r\n                         '..'                                  `'-'              ");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Crypt();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Welcome tp\n  ▄      ▄   ██▄   ▄███▄   █▄▄▄▄  ▄ ▄   ████▄ █▄▄▄▄ █     ██▄   \r\n   █      █  █  █  █▀   ▀  █  ▄▀ █   █  █   █ █  ▄▀ █     █  █  \r\n█   █ ██   █ █   █ ██▄▄    █▀▀▌ █ ▄   █ █   █ █▀▀▌  █     █   █ \r\n█   █ █ █  █ █  █  █▄   ▄▀ █  █ █  █  █ ▀████ █  █  ███▄  █  █  \r\n█▄ ▄█ █  █ █ ███▀  ▀███▀     █   █ █ █          █       ▀ ███▀  \r\n ▀▀▀  █   ██                ▀     ▀ ▀          ▀                \r\n                                                                ");
                    Console.WriteLine("The end is near, traveller...");
                    Console.ReadKey();
                    Underground();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("This is\n       _            _       _    _               _            _             _         \r\n      /\\ \\         / /\\    / /\\ /\\ \\            /\\ \\         /\\ \\     _    /\\ \\       \r\n      \\_\\ \\       / / /   / / //  \\ \\          /  \\ \\       /  \\ \\   /\\_\\ /  \\ \\____  \r\n      /\\__ \\     / /_/   / / // /\\ \\ \\        / /\\ \\ \\     / /\\ \\ \\_/ / // /\\ \\_____\\ \r\n     / /_ \\ \\   / /\\ \\__/ / // / /\\ \\_\\      / / /\\ \\_\\   / / /\\ \\___/ // / /\\/___  / \r\n    / / /\\ \\ \\ / /\\ \\___\\/ // /_/_ \\/_/     / /_/_ \\/_/  / / /  \\/____// / /   / / /  \r\n   / / /  \\/_// / /\\/___/ // /____/\\       / /____/\\    / / /    / / // / /   / / /   \r\n  / / /      / / /   / / // /\\____\\/      / /\\____\\/   / / /    / / // / /   / / /    \r\n / / /      / / /   / / // / /______     / / /______  / / /    / / / \\ \\ \\__/ / /     \r\n/_/ /      / / /   / / // / /_______\\   / / /_______\\/ / /    / / /   \\ \\___\\/ /      \r\n\\_\\/       \\/_/    \\/_/ \\/__________/   \\/__________/\\/_/     \\/_/     \\/_____/       \r\n                                                                                      ");
                    Console.WriteLine("Finally, a worthy opponent for me...");
                    Console.ReadKey();
                    Boss();
                    break;
            }
        }

        //House of Thieves
        public static void HouseT()
        {
            Console.Clear ();
            while (Program.currentPlayer.kill != 3)
            {
                Console.Clear();
                Console.WriteLine("            __________\r\n           |  __  __  |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |  __  __()|\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |__________|");
                Console.WriteLine("Pick a door...");
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("There's only one door innit. Just press any key.");
                Console.WriteLine("------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Encounter.Fight(0);
            }
            Console.Clear();
            Console.WriteLine("You have cleared this area.\nPress any key to move to the next area.");
            Console.WriteLine();
            Enemy.Sherlock();
            Program.currentPlayer.level = 1;
            Setlocation(Program.currentPlayer.level);

        }

        //Crpyt event generator
        public static int CryptGen()
        {
            var list = new List<int> { 1, 2, 3, 4 };
            int index = rand.Next(list.Count);
            return list[index];
        }

        //The Crypt
        public static void Crypt()
        {
            Console.Clear();
            while (Program.currentPlayer.kill != 8) 
            {
                Console.Clear();
                Console.WriteLine("            __________\r\n           |  __  __  |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |  __  __()|\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |__________|");
                Console.WriteLine("            __________\r\n           |  __  __  |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |  __  __()|\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |__________|");
                Console.WriteLine("Pick a door...");
                Console.WriteLine("-----------------");
                Console.WriteLine("|(T)op  (B)ottom|");
                Console.WriteLine("-----------------");
                string temp=Console.ReadLine();
                if (temp.ToLower() == "t" || temp.ToLower() == "top" || temp.ToLower() == "b" || temp.ToLower()== "bottom")
                {
                    Console.Clear();
                    Encounter.Fight(CryptGen());
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a proper response!\r\n                               ...:=+@*-..         \r\n                      .:=%%%%#*+---+@+.+*%+        \r\n              ....  :+%*-.........=@*..::-%        \r\n             .+@@%%%@+............-=....=%+.       \r\n              ..*@=.:+*:.............=@%+.         \r\n            .:*%-..+#.............=%#+%:           \r\n           .=#-..............:=*%*-...+%.          \r\n          .*%:..........:*%@#*:.......-%.          \r\n        ..*#..........:%*.............+#.          \r\n        .#+..........=%-..............#+           \r\n       .#*...........=:..............-%.           \r\n       =%............................-#..          \r\n      .%=............................=%#%#+-:..    \r\n      =%.............................=# ..-=*%%-   \r\n    .:#+.............................=+      .*%.  \r\n   ..=@:.............................==      .#*   \r\n  .#%%@@%=...........................=+     .*#.   \r\n  .=@%+=::...........................=+    .#*.    \r\n    .*@*.............................-%...+@+.     \r\n    .++-#%+:.........................:%.-%*.       \r\n    .=+...-*%#=.......................%@%-.        \r\n    .-*......:+@*.....................#@=          \r\n     :#:.......:%+....................-@%=.        \r\n     .*-.....+%+:.....................:@==.        \r\n     .+#.....:.........................#=          \r\n      .%:..............................-#.         \r\n      .*#. .............................#-   \nPress any key to continue");
                    Console.ReadKey();
                    Crypt();
                }
            }
            Console.Clear();
            Console.WriteLine("You have cleared this area.\nPress any key to move to the next area.");
            Program.currentPlayer.level += 1;
            Setlocation(Program.currentPlayer.level);
        }

        //Underground event generator
        public static int UnderGen()
        {
            var list = new List<int> {3,4,5,6,7,10};
            int index = rand.Next(list.Count);
            return list[index];
        }

        //Undergound
        public static void Underground() 
        {
            Console.Clear();
            while (Program.currentPlayer.kill != 13) 
            {
                Console.Clear();
                Console.WriteLine("            __________\r\n           |  __  __  |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |  __  __()|\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |__________|");
                Console.WriteLine("            __________\r\n           |  __  __  |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |  __  __()|\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |__________|");
                Console.WriteLine("            __________\r\n           |  __  __  |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |  __  __()|\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |  ||  | |\r\n           | |__||__| |\r\n           |__________|");
                Console.WriteLine("Pick a door...");
                Console.WriteLine("-----------------");
                Console.WriteLine("|(T)op  (M)iddle|");
                Console.WriteLine("|   (B)ottom    |");
                Console.WriteLine("-----------------");
                string temp=Console.ReadLine();
                if (temp.ToLower() == "t" || temp.ToLower() == "top"||temp.ToLower() == "m" || temp.ToLower() == "middle" || temp.ToLower() == "b" || temp.ToLower() == "bottom") 
                {
                    Console.Clear();
                    Encounter.Fight(UnderGen());
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Please enter a proper response!\r\n                               ...:=+@*-..         \r\n                      .:=%%%%#*+---+@+.+*%+        \r\n              ....  :+%*-.........=@*..::-%        \r\n             .+@@%%%@+............-=....=%+.       \r\n              ..*@=.:+*:.............=@%+.         \r\n            .:*%-..+#.............=%#+%:           \r\n           .=#-..............:=*%*-...+%.          \r\n          .*%:..........:*%@#*:.......-%.          \r\n        ..*#..........:%*.............+#.          \r\n        .#+..........=%-..............#+           \r\n       .#*...........=:..............-%.           \r\n       =%............................-#..          \r\n      .%=............................=%#%#+-:..    \r\n      =%.............................=# ..-=*%%-   \r\n    .:#+.............................=+      .*%.  \r\n   ..=@:.............................==      .#*   \r\n  .#%%@@%=...........................=+     .*#.   \r\n  .=@%+=::...........................=+    .#*.    \r\n    .*@*.............................-%...+@+.     \r\n    .++-#%+:.........................:%.-%*.       \r\n    .=+...-*%#=.......................%@%-.        \r\n    .-*......:+@*.....................#@=          \r\n     :#:.......:%+....................-@%=.        \r\n     .*-.....+%+:.....................:@==.        \r\n     .+#.....:.........................#=          \r\n      .%:..............................-#.         \r\n      .*#. .............................#-   \nPress any key to continue");
                    Console.ReadKey();
                    Underground();
                }
            }
            Console.Clear();
            Console.WriteLine("You have cleared this area.\nPress any key to move to the next area.");
            Program.currentPlayer.level += 1;
            Setlocation(Program.currentPlayer.level);
        }
        
        //Boss Fight
        public static void Boss() 
        {
            Console.Clear();
            Console.WriteLine("You feel a heavy aura behind the final door");
            Console.WriteLine("      ______\r\n   ,-' ;  ! `-.\r\n  / :  !  :  . \\\r\n |_ ;   __:  ;  |\r\n )| .  :)(.  !  |\r\n |\"    (##)  _  |\r\n |  :  ;`'  (_) (\r\n |  :  :  .     |\r\n )_ !  ,  ;  ;  |\r\n || .  .  :  :  |\r\n |\" .  |  :  .  |\r\n |mt-2_;----.___|");
            Console.WriteLine("Would you like to check your stats before the fight?\nYes or No");
            string temp = Console.ReadLine();
            if (temp.ToLower() == "yes" || temp.ToLower() == "y")
            {
                Console.WriteLine("Your stats are:\n" +
                    "Health: " + Program.currentPlayer.health +
                    "\nPotions: " + Program.currentPlayer.potion +
                    "\nPower: " + Program.currentPlayer.weapondamage+
                    "\n\nPress any key to continue...");
                Console.ReadKey();
                Boss();
            }
            else 
            {
                Console.WriteLine("So be it. Best of luck traveller...");
            }
            while (Program.currentPlayer.kill != 14) 
            {
                Console.Clear();
                Console.WriteLine("      ______\r\n   ,-' ;  ! `-.\r\n  / :  !  :  . \\\r\n |_ ;   __:  ;  |\r\n )| .  :)(.  !  |\r\n |\"    (##)  _  |\r\n |  :  ;`'  (_) (\r\n |  :  :  .     |\r\n )_ !  ,  ;  ;  |\r\n || .  .  :  :  |\r\n |\" .  |  :  .  |\r\n |mt-2_;----.___|\r\n");
                Console.WriteLine("Open the door?");
                Console.WriteLine("-----------------");
                Console.WriteLine("|(Y)es     (Y)es|");
                Console.WriteLine("-----------------");
                string tempi = Console.ReadLine();
                if (tempi.ToLower() == "y" || tempi.ToLower() == "yes" )
                {
                    Console.Clear();
                    Console.WriteLine("As you approach the door, you notice and pick up 3 potions from the ground.\nYou brace yourself for hell..\n\nPress any key to continue...");
                    Console.ReadKey();
                    Encounter.Fight(8);
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("There is no running now...\n\nPress any key to continue");
                    Console.ReadKey();
                    Boss();
                }
            }
            Console.Clear();
            Console.WriteLine("You have bested me. I grant you freedom from this dungeon...");
            Console.WriteLine(" ______________\r\n|\\ ___________ /|\r\n| |  /|,| |   | |\r\n| | |,x,| |   | |\r\n| | |,x,' |   | |\r\n| | |,x   ,   | |\r\n| | |/    |   | |\r\n| |    /] ,   | |\r\n| |   [/ ()   | |\r\n| |       |   | |\r\n| |       |   | |\r\n| |       |   | |\r\n| |      ,'   | |\r\n| |   ,'      | |\r\n|_|,'_________|_|    ");
            Console.WriteLine("Enjoy it while you still can...\n\n");
            Console.ReadKey();
            ExitCommand.Exit();
        }

        //Gym Event
        public static void Gym() 
        {
            Console.Clear();
            int temp= rand.Next(1,5);
            if (Program.currentPlayer.weapondamage != 12) 
            {
                Console.WriteLine("You stumbled upon a gym. You worked out and increased your damage by " + temp);
                Program.currentPlayer.weapondamage += temp;
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("You stumbled upon a gym. However, you already maxed your strength out.\nYou decide to move on...\n\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        //Campfire Event
        public static void Campfire() 
        {
            int temp=rand.Next(1,3);
            if (Program.currentPlayer.health != 50)
            {
                Console.WriteLine("You stumble upon a campfire. You decide to stay a while to regain your health.\nAs you prepare to leave, you pick up "+temp+" potion/s.");
                Program.currentPlayer.potion += temp;
                Program.currentPlayer.health = 50;
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("You stumble upon a campfire. However, you seem to not be tired and decided to move on...");
                Console.ReadKey();
            }
        }
    }
}
