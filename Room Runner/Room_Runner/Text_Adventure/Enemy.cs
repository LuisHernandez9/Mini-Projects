using Room_Runner;

namespace Room_Runners
{
    internal class Enemy
    {
        static Random rand = new Random();

        //Enemy picker
        public static void ChooseEnemy(int boop) 
        {
            switch (boop)
            {
                case 0:
                    Room_Runner.Encounter.SetEnemy("Common Thief", 3, 10);
                    break;
                case 1:
                    Room_Runner.Encounter.SetEnemy("Wriggly Worm", 5, 15);
                    break;
                case 2:
                    Room_Runner.Encounter.SetEnemy("Dishonored", 4, 20);
                    break;
                case 3:
                    Room_Runner.Location.Gym();
                    break;
                case 4:
                    Room_Runner.Location.Campfire();
                    break;
                case 5:
                    Room_Runner.Encounter.SetEnemy("Executioner", 10, 15);
                    break;
                case 6:
                    Room_Runner.Encounter.SetEnemy("Evil Mage", 8, 15);
                    break;
                case 7:
                    Room_Runner.Encounter.SetEnemy("Skully", 8, 20);
                    break;
                case 8:
                    Room_Runner.Encounter.SetEnemy("Wrecker", 20, 90);
                    break;
                case 9:
                    Room_Runner.Encounter.SetEnemy("Sherlock", 5, 9);
                    break;
                case 10:
                    Sherlock();
                    break;
            }
        }

        //Easter egg mob
        public static void Sherlock() 
        {
            Console.Clear();
            Console.WriteLine("As you move to the next area, you encounter a sleeping cat\n\n      |\\      _,,,---,,_\r\nZZZzz /,`.-'`'    -.  ;-;;,_\r\n     |,4-  ) )-,_. ,\\ (  `'-'\r\n    '---''(_/--'  `-'\\_)  ");
            Console.WriteLine("\nPet the cat?\nYes or No");
            string temp = Console.ReadLine();
            if (temp.ToLower() == "yes"||temp.ToLower()=="y") 
            {
                Console.Clear();
                Console.WriteLine("    |\\__/,|   (`\\\r\n  _.|o o  |_   ) )\r\n-(((---(((--------");
                Console.WriteLine("\nThe cat purred. It woke up and gave you a random buff.\nPress any key to continue.");
                Console.ReadKey();
                int timp = rand.Next(0, 2);
                if (timp == 0)
                {
                    if (Program.currentPlayer.weapondamage != 12)
                    {
                        Console.Clear();
                        Console.WriteLine("    |\\__/,|   (`\\\r\n  _.|o o  |_   ) )\r\n-(((---(((--------");
                        int qt = rand.Next(1, 3);
                        Console.WriteLine("\nThe cat increased your damage by " + qt);
                        Program.currentPlayer.weapondamage += qt;
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("      |\\      _,,,---,,_\r\nZZZzz /,`.-'`'    -.  ;-;;,_\r\n     |,4-  ) )-,_. ,\\ (  `'-'\r\n    '---''(_/--'  `-'\\_)  ");
                        Console.WriteLine("The cat just wished you goodluck and slept.");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("    |\\__/,|   (`\\\r\n  _.|o o  |_   ) )\r\n-(((---(((--------");
                    Console.WriteLine("\nThe cat gave you a potion");
                    Program.currentPlayer.health += 1;
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                }
            }
            else 
            {
                Console.WriteLine("The cat woke up crankly and decided to attack you");
                Console.ReadKey();
                Enemy.ChooseEnemy(9);
            }

        }
        
    }
}
