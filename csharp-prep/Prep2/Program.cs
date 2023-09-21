using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage? ");
        string grade_input = Console.ReadLine();
        int grade = int.Parse(grade_input);
        if (grade >= 90)
        {
            string letter_g = "A";
            Console.WriteLine($"Your grade is {letter_g}");
        }
        else if (grade >= 80 && grade < 90)
        {
            string letter_g = "B";
            Console.WriteLine($"Your grade is {letter_g}");
        }
        else if (grade >= 70 && grade < 80)
        {
            string letter_g = "C";
            Console.WriteLine($"Your grade is {letter_g}");
        }
        else if (grade >= 60 && grade < 70)
        {
            string letter_g = "B";
            Console.WriteLine($"Your grade is {letter_g}");
        }
        else if (grade < 60)
        {
            string letter_g = "F"; 
            Console.WriteLine($"Your grade is {letter_g}");
        }
    }
}