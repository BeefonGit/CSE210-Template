using System;

class Program
{
    static void Main(string[] args)
    {
        bool Play = true;
        while (Play == true)
        {
            Console.WriteLine("Menu Options: \n1. Breathing Activity\n2. Listing Activity\n3. Reflection Activity\n4. Quit\n");
            Console.Write("Which activity would you like to do? ");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                BreathingActivity activity = new();
                activity.Breath();
            }
            else if (choice == 2)
            {
                ListingActivity activity = new();
                activity.Listing();
            }
            else if (choice == 3)
            {
                ReflectionActivity activity = new();
                activity.Reflect();
            }
            else if (choice == 4)
            {
                Play = false;
            }
            else 
            {
                Console.WriteLine("Input not recognized, try again?");
            }
        }
    }
}