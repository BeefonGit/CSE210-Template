using System;

class Program
{
    static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
    static string PromptUserName()
    {
        Console.Write("What is your name: ");
        string username = Console.ReadLine();
        return username;
    }
    static int FavoriteNumber()
    {
        Console.Write("What is your favorite number: ");
        int username = int.Parse(Console.ReadLine());
        return username;
    }
    static int NumberSquared(int num)
    {
        return num * num;
    }
    static void DisplayResult(string username, int num)
    {
        Console.WriteLine($"{username}, your favorite number squared is {num}");
    }
    static void Main(string[] args)
    {
        DisplayWelcome();
        DisplayResult(PromptUserName(), NumberSquared(FavoriteNumber()));
    }
}
