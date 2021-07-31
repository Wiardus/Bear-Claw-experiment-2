using System;

namespace Bear_Claw_experiment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Character Creation Screen 
            Console.WriteLine("Welcome to Bear Claw!");
            Console.WriteLine("How do you want to name your new character?");
            var charName = Console.ReadLine();
            Console.WriteLine("Your character is called: " + charName);
            Console.WriteLine("The available classes are: Warrior, Wizard, Dark Wizard, Druid and Archer.");
            Console.WriteLine("What class is " + charName + "?");
            var charClass = Console.ReadLine();
            
            Console.WriteLine(charName + " is a " + charClass);
            switch (charClass)
            {
                case "Warrior":
                    Console.WriteLine("This means you excell at melee combat.");
                    break;
                case "Wizard":
                    Console.WriteLine("This means you excell at casting magical spells.");
                    break;
                case "Dark Wizard":
                    Console.WriteLine("This means you excell at using dark magic.");
                    break;
                case "Druid":
                    Console.WriteLine("This means you excell at connecting with nature and earth.");
                    break;
                case "Archer":
                    Console.WriteLine("This means you excell at ranged combat.");
                    break;
                default:
                    Console.WriteLine("That is not an available class.");
                    break;
            }

            int dummyHP = 100;
            int charDmg = 25;
            int xp = 0;
            int level = 1;

            Console.WriteLine("Start your journey by practicing your combat against a dummy.");
            void combat()
            {
                         
                Console.WriteLine("Press any key to start attacking");
                Console.ReadKey();
                dummyHP = dummyHP - charDmg;
                Console.Write("You attacked the dummy and the dummy's health points went down to: ");
                Console.WriteLine(dummyHP); 
                if (dummyHP <= 0)
                {
                    Console.WriteLine("You have succesfully defeated the dummy.");
                    xp += 100;
                }
            }

            if (xp >= 100)
            {
                level++;
                Console.WriteLine("You leveled up!");
            }

            while (dummyHP > 0)
            {
                combat();
            }


            // First attempt for the dummy combat system
            /* combat();
            int dummyHP = 100;
            int charDmg = 25;
            int remainingHp = dummyHP - charDmg;
            Console.Write("You attacked the dummy and the dummy's health points went down to: ");
            Console.WriteLine(remainingHp);
            combat();
            Console.Write("You attacked the dummy and the dummy's health points went down to: ");
            Console.WriteLine(remainingHp);
            combat();
            Console.Write("You attacked the dummy and the dummy's health points went down to: ");
            Console.WriteLine(remainingHp);
            combat();
            Console.Write("You attacked the dummy and the dummy's health points went down to: ");
            Console.WriteLine(remainingHp); */


            // feedback from stackoverflow to seperate presentation from logic
            /* class MyClass 
        {
            static int Combat(int remainingHp, int charDmg) // logic
            {
                return remainingHp -= charDmg;
            }

            static void PrintHealth(int remainingHp)
            {       // presentation
                Console.WriteLine("Press any key to start attacking");
                Console.ReadKey();
                Console.Write("You attacked the dummy and the dummy's health points went down to: ");
                Console.WriteLine(remainingHp);
            }

            static void Main()
            {
                int remainingHp = 100;
                int charDmg = 25;
                Console.WriteLine
                  ("Start your journey by practicing your combat against a dummy.");

                do
                {
                    remainingHp = Combat(remainingHp, charDmg);
                    PrintHealth(remainingHp);
                }
                while (remainingHp > 0);
            }
        } */

        }
    }
}
