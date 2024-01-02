namespace Room_Runner
{
    internal class StartCommand
    {
        //start command
        public static void Start() 
        {
            Console.Clear();
            Console.WriteLine("Goodluck, traveller...");
            Console.ReadKey();
            Location.Setlocation(0);
        }
    }
}
