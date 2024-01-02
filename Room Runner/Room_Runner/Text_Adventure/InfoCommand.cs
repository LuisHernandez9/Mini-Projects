namespace Room_Runner
{
    internal class InfoCommand
    {
        //Game info
        public static void Info() 
        {
            Console.Clear();
            Console.WriteLine("Room Runner is a strategy text-based adventure game created with the purpose of learning\n" +
            "and practicing concepts of C#. It was created as a practice for C# in preparation for the NASA MINDS competition.\n\nGame Concepts:\n" +
            "- There are 3 levels total with different enemies and event each level. Choose wisely and defeat all enemies to proceed.\n" +
            "- Attack allows the player to deal damage to the enemy, however, the enemy will counterattack.\n" +
            "- Defend allows the player to lessen the damage recieved, however, it also reduces damage dealt by half.\n" +
            "- Run allows a player to run away from an enemy and recover some health, however, a failed run attempt will deal the player a small amount of damage.\n" +
            "- Potion allows a player to heal 25 points of health.\n" +
            "- Different levels offer different chances to encounter rooms that can aid the player in their journey\n\n" +
            "Press any key to return");
            Console.ReadKey();
        }
    }
}
