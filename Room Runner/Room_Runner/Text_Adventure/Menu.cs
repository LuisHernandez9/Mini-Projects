namespace Room_Runner
{
    internal class Menu
    {
        public static Player currentPlayer = new Player();
        
        //introduction
        public static string intro() 
        {
            Console.WriteLine("Please enter your name, unlucky traveler...");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("You awaken in a empty room. A quick look around the room reveals a door and your sword on the floor\nA monitor sits in the middle of the room\nTurn on the monitor?\nYes or No");
            string pick = Console.ReadLine();
            return pick;
        }
        
        //menu options
        public static void option()
        {
            Console.Clear();
            Console.WriteLine("    ____                           ____                             \r\n   / __ \\____  ____  ____ ___     / __ \\__  ______  ____  ___  _____\r\n  / /_/ / __ \\/ __ \\/ __ `__ \\   / /_/ / / / / __ \\/ __ \\/ _ \\/ ___/\r\n / _, _/ /_/ / /_/ / / / / / /  / _, _/ /_/ / / / / / / /  __/ /    \r\n/_/ |_|\\____/\\____/_/ /_/ /_/  /_/ |_|\\__,_/_/ /_/_/ /_/\\___/_/     \r\n                                                                   ");
            Console.WriteLine("Player Information\nName: " + currentPlayer.name + "\nHealth: " + currentPlayer.health + "\nPotion: " + currentPlayer.potion);
            Console.WriteLine("Objective: Escape\nWhat would you like to do?\n");
            Console.WriteLine("-----------------------");
            Console.WriteLine("(S)tart       (I)nfo");
            Console.WriteLine("(C)redits     (E)xit");
            Console.WriteLine("-----------------------");
            string choice=Console.ReadLine();
            
            //start game
            if (choice.ToLower()=="s"||choice.ToLower() == "start")  
            {
                StartCommand.Start();
            }
            
            //info about game
            else if(choice.ToLower() == "i" ||choice.ToLower() == "info") 
            {
                InfoCommand.Info();
                option();
            }
            
            //credits
            else if (choice.ToLower() == "c" || choice.ToLower() == "credit") 
            {
                CreditCommand.Credit();
                option();
            }
            
            //exit
            else if(choice.ToLower() == "e" || choice.ToLower() == "exit") 
            {
               ExitCommand.Exit();
            }
            
            //response checker
            else
            {
                Console.Clear();
                Console.WriteLine("Please enter a proper response!\r\n                               ...:=+@*-..         \r\n                      .:=%%%%#*+---+@+.+*%+        \r\n              ....  :+%*-.........=@*..::-%        \r\n             .+@@%%%@+............-=....=%+.       \r\n              ..*@=.:+*:.............=@%+.         \r\n            .:*%-..+#.............=%#+%:           \r\n           .=#-..............:=*%*-...+%.          \r\n          .*%:..........:*%@#*:.......-%.          \r\n        ..*#..........:%*.............+#.          \r\n        .#+..........=%-..............#+           \r\n       .#*...........=:..............-%.           \r\n       =%............................-#..          \r\n      .%=............................=%#%#+-:..    \r\n      =%.............................=# ..-=*%%-   \r\n    .:#+.............................=+      .*%.  \r\n   ..=@:.............................==      .#*   \r\n  .#%%@@%=...........................=+     .*#.   \r\n  .=@%+=::...........................=+    .#*.    \r\n    .*@*.............................-%...+@+.     \r\n    .++-#%+:.........................:%.-%*.       \r\n    .=+...-*%#=.......................%@%-.        \r\n    .-*......:+@*.....................#@=          \r\n     :#:.......:%+....................-@%=.        \r\n     .*-.....+%+:.....................:@==.        \r\n     .+#.....:.........................#=          \r\n      .%:..............................-#.         \r\n      .*#. .............................#-   \nPress any key to continue");
                Console.ReadKey();
                option();
            }
        }
        
    }
}
