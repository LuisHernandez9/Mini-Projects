namespace Room_Runner
{
    internal class Death
    {
        //Random Death Message
        public static void Naturaldeathmsg(int type) 
        {
            switch(type)
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("You refuse to press the button. After hours of nothingness, your character decides to end the game...\n\nYYAAaaaawwwnnn...\r\n                       \\\r\n                          ____\r\n                         _ _)\\\\\r\n                        /<   c\r\n                        \\_)_/(_____\r\n                  |//_    ,/\\_/\\  '\\\r\n                   \\ )___/  \\$/     \\\r\n                    \\\\)  \\/  :    <  \\\r\n                    |/____|  |   /   /\r\n                          |  :  /__o/\r\n                          |__'__/(_|\r\n                                \\ )_\r\n                                /|\\\r\n");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
        }

        //Death from mob
        public static void Playerdeathmsg(int type) 
        {
            switch (type) 
            {
                case 0:
                    Console.Clear();
                    Console.WriteLine("As you tried to attack the beast, you slipped and broke your toe. You died...\n           ______\r\n        .-\"      \"-.\r\n       /            \\\r\n      |              |\r\n      |,  .-.  .-.  ,|\r\n      | )(__/  \\__)( |\r\n      |/     /\\     \\|\r\n      (_     ^^     _)\r\n       \\__|IIIIII|__/\r\n        | \\IIIIII/ |\r\n        \\          /\r\n         `--------`");
                    Console.ReadKey();
                    Console.Clear();
                    break;
            }
                
            
        }
    }
    
}
