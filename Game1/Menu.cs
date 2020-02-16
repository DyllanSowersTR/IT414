// Dyllan Sowers

using System;

namespace Game1
{
    class Menu
    {
        public static IWeapon SelectWeapon()
        {
            Console.WriteLine("Choose a weapon! Your options are Sword, Fire Staff, and Ice Staff.");

            Console.WriteLine("Would you like to use the Sword? (y/n)");
            string input = Console.ReadLine();
            if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                return new Sword();

            Console.WriteLine("Would you like to use the Fire Staff? (y/n)");
            input = Console.ReadLine();
            if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                return new FireStaff();

            Console.WriteLine("Would you like to use the Ice Staff? (y/n)");
            input = Console.ReadLine();
            if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
                return new IceStaff();

            Console.WriteLine("You really want to fight barehanded? (y/n)");
            input = Console.ReadLine();
            if (input.Equals("y", StringComparison.InvariantCultureIgnoreCase))
            {
                Console.WriteLine("How brave.");
                return new Fist();
            }

            Console.WriteLine("Then choose a weapon!\n\n");
            return null;
        }

        public static string SelectName()
        {
            Console.WriteLine("What is your name?");
            return Console.ReadLine();
        }

        public static int SelectLevel()
        {
            Console.WriteLine("What level do you want to fight on?");
            string input = Console.ReadLine();
            while (!int.TryParse(input, out _))
            {
                Console.WriteLine("Please enter an integer value only.");
                input = Console.ReadLine();
            }
            return int.Parse(input);
        }
    }
}
