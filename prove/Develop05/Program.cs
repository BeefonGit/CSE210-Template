using System;

class Program
{
    static void Main(string[] args)
    {
        int Score = 0; 
        Console.WriteLine("Welcome to your Eternal Quest!");
        Console.WriteLine("Menu\n1. Display Checklist\n2. Display Score\n3. Complete Goal\n4. Create New Goal\n5. Quit");
        string Input = Console.ReadLine();
        while (true)
        {
            if (Input == "1")
            {

            }
            else if (Input == "2")
            {
                Console.WriteLine(Score);
            }
            else if (Input == "3")
            {

            }
            else if (Input == "4")
            {

            }
            else if (Input == "5")
            {
                break;
            }
        }
    }
}