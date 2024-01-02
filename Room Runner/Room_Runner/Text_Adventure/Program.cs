namespace Room_Runner
{
    class Program
    {
        static Random rand = new Random();
        public static Player currentPlayer= new Player();
        static void Main(string[] args)
        {
            Start();
        }

        //Starts the program
        public static void Start()
        {
            string pick=Menu.intro();
            if (pick.ToLower() != "yes")
            {
                Death.Naturaldeathmsg(0);
                Start();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("The screen boots up...\n" +
                    "    _______________\r\n    |,----------.  |\\\r\n    ||           |=| |\r\n    ||          || | |\r\n    ||       . _o| | | __\r\n    |`-----------' |/ /~/\r\n     ~~~~~~~~~~~~~~~ / /\r\n                     ~~\nPress any key to read the screen");
                Console.ReadLine();
            }
            Menu.option();
            Console.Clear();
            Console.ReadKey();
        }
    }

}