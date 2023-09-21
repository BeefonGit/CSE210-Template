using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1, 101); 
        bool play = true;
        while (play == true)
        {
            Console.WriteLine("What is your guess?");
            int guess = int.Parse(Console.ReadLine());
            if (guess == number)
            {
                Console.WriteLine("Good Guess!");
                play = false;
            } 
            else if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        } 

    }
}