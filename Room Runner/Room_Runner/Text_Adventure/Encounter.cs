using Room_Runners;

namespace Room_Runner
{
    internal class Encounter
    {
        static Random rand=new Random();

        //Encounter Picker
        public static void Fight(int boop)
        {
            switch (boop)
            {
                case (0):
                    Enemy.ChooseEnemy(0);
                    break;
                case (1):
                    Enemy.ChooseEnemy(1);
                    break;
                case (2):
                    Enemy.ChooseEnemy(2);
                    break;
                case (3):
                    Enemy.ChooseEnemy(3);
                    break;
                case (4):
                    Enemy.ChooseEnemy(4);
                    break;
                case (5):
                    Enemy.ChooseEnemy(5);
                    break;
                case (6):
                    Enemy.ChooseEnemy(6);
                    break;
                case (7):
                    Enemy.ChooseEnemy(7);
                    break;
                case (8):
                    Enemy.ChooseEnemy(8);
                    break;
                case (10):
                    Enemy.ChooseEnemy(10);
                    break;
            }
        }

        //Combat Commands
        public static void SetEnemy (string name, int power, int health)
        {
            string n = name;
            int p = power;
            int h = health;
            while(h>0) 
            {
                Console.Clear();

                //Enemy image generator
                switch (n) 
                {
                    case "Common Thief":
                        EnemyASCII.EnemyProfile(0);
                        break;
                    case "Wriggly Worm":
                        EnemyASCII.EnemyProfile(1);
                        break;
                    case "Dishonored":
                        EnemyASCII.EnemyProfile(2);
                        break;
                    case "Executioner":
                        EnemyASCII.EnemyProfile(5);
                        break;
                    case "Evil Mage":
                        EnemyASCII.EnemyProfile(6);
                        break;
                    case "Skully":
                        EnemyASCII.EnemyProfile(7);
                        break;
                    case "Wrecker":
                        EnemyASCII.EnemyProfile(8);
                        break;
                    case "Sherlock":
                        EnemyASCII.EnemyProfile(9);
                        break;
                }
                
                Console.WriteLine("\n");
                Console.WriteLine(n);
                Console.WriteLine("Health: "+h+"  Power: "+p);
                Console.WriteLine("---------------------");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("|  (R)un   (P)otion |");
                Console.WriteLine("---------------------");
                Console.WriteLine("Potions: "+Program.currentPlayer.potion+"\nHealth: "+Program.currentPlayer.health);
                string move= Console.ReadLine();

                //attack
                if (move.ToLower() == "a" || move.ToLower() == "attack") 
                {
                    int damage = p;
                    int attack = rand.Next(0, Program.currentPlayer.weapondamage+1);
                    if (attack == 0) 
                    {
                        Console.WriteLine("You missed your attack!\nThe beast does not and hits you for "+p+" damage.");
                    }
                    else
                    {
                        Console.WriteLine("You attacked the filthy beast and deal " + attack + " damage!\nThe beast counters and hits you for " + p + " damage.");
                    }
                    h -= attack;
                    Program.currentPlayer.health -= damage;
                    
                    //death
                    if (Program.currentPlayer.health == 0 || Program.currentPlayer.health < 0)
                    {
                        var list = new List<int> { 0 };
                        int index = rand.Next(list.Count);
                        Death.Playerdeathmsg(list[index]);
                        Program.Start();
                    }

                }
                
                //defend
                else if (move.ToLower() == "d" || move.ToLower() == "defend") 
                {
                    int damage = p/4;
                    int attack = rand.Next(0, Program.currentPlayer.weapondamage+1)/2;
                    Console.WriteLine("You brace for the "+n+"\'s attack\nYou recieve "+damage+" damage and deflect back "+attack+" to the "+n);
                    h -= attack;
                    Program.currentPlayer.health -= damage;

                    //death
                    if (Program.currentPlayer.health == 0 || Program.currentPlayer.health < 0)
                    {
                        var list = new List<int> { 0 };
                        int index = rand.Next(list.Count);
                        Death.Playerdeathmsg(list[index]);
                        Program.Start();
                    }
                }
                
                //run
                else if (move.ToLower() == "r" || move.ToLower() == "run")
                {
                    if (rand.Next(0, 3) != 0)  
                    {
                        Console.WriteLine("You were able to run away from the "+n+" successsully.\n" +
                            "Your recovered 5 points of health");
                        Console.ReadKey();
                        if (Program.currentPlayer.level == 0)
                        {
                            Location.HouseT();
                        }
                        else if (Program.currentPlayer.level == 1)
                        {
                            Location.Crypt();
                        }
                        else
                        {
                            Location.Underground();
                        }
                    }
                    else 
                    {
                        Console.WriteLine("You tripped trying to escape and the " + n + " caught up to you.");
                        int damage = p / 4;
                        Console.WriteLine("You recieve " + damage + " points of damage.");
                        Program.currentPlayer.health -= damage;
                        Console.ReadKey();
                    }
                }
                
                //potion
                else if (move.ToLower() == "p" || move.ToLower() == "potion") 
                {
                    if (Program.currentPlayer.potion != 0) 
                    {
                        if(Program.currentPlayer.health > 25 & Program.currentPlayer.health !=50) 
                        {
                            int q = 50-Program.currentPlayer.health;
                            Program.currentPlayer.health += q;
                            Console.WriteLine("You recovered " + q + " points of health.");
                            Program.currentPlayer.potion -= 1;
                        }
                        else if (Program.currentPlayer.health == 50) 
                        {
                            Console.WriteLine("You have maximum health");
                        }
                        else 
                        {
                            Program.currentPlayer.health += 25;
                            Console.WriteLine("You recovered 25 points of health.");
                            Program.currentPlayer.potion -= 1;
                        }
                    }
                    else 
                    {
                        Console.WriteLine("You do not have any potions left.");
                    }
                    Console.ReadKey();
                }
                Console.ReadKey();
            }
            Console.Clear();
            Program.currentPlayer.kill+=1;
            int temp=rand.Next(0,3);
            Room_Runners.EnemyDeath.Enemymsg(temp);
        }
    }
}
