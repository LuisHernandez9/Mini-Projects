namespace Room_Runner
{
    internal class ExitCommand
    {
        //Ends the Program
        public static void Exit() 
        {
            Console.Clear();
            Console.WriteLine("Till next time, traveller...\n _                \r\n| |               \r\n| |__  _   _  ___ \r\n| '_ \\| | | |/ _ \\\r\n| |_) | |_| |  __/\r\n|_.__/ \\__, |\\___|\r\n        __/ |     \r\n       |___/      ");
            Console.ReadKey();
            Environment.Exit(0);
        }
    }
}
