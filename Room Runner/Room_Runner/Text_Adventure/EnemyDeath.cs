using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Room_Runners
{
    internal class EnemyDeath
    {
        //enemy death messages
        public static void Enemymsg(int choice)
        {
            if (choice == 0) 
            {
                Console.WriteLine("         />_________________________________\r\n[########[]_________________________________>\r\n         \\>\nYou have slain the beast!\n\nPress any key to continue...");
                Console.ReadKey();
                
            }
            else if (choice == 1)
            {
                Console.WriteLine("         />_________________________________\r\n[########[]_________________________________>\r\n         \\>\nYou have won this battle!\n\nPress any key to continue...");
                Console.ReadKey();
            }
            else if (choice == 2)
            {
                Console.WriteLine("         />_________________________________\r\n[########[]_________________________________>\r\n         \\>\nYou have triumphed over your foe!\n\nPress any key to continue...");
                Console.ReadKey();
            }
            else 
            {   
                Console.WriteLine("   .------\\ /------.\r\n   |       -       |\r\n   |               |\r\n   |               |\r\n   |               |\r\n_______________________\r\n===========.===========\r\n  / ~~~~~     ~~~~~ \\\r\n /|     |     |\\\r\n W   ---  / \\  ---   W\r\n \\.      |o o|      ./\r\n  |                 |\r\n  \\    #########    /\r\n   \\  ## ----- ##  /\r\n    \\##         ##/\r\n     \\_____v_____/\nYou have bested me...\n\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
