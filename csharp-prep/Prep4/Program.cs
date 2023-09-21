using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        bool play = true;
        while (play == true)
        {
            Console.Write("Enter number: ");
            int num = int.Parse(Console.ReadLine());
            if (num == 0)
            {
                play = false;
                break;
            }
            numbers.Add(num);
        }
        Console.WriteLine(numbers);
        int sum = 0;
        foreach(int num in numbers)
        {
            sum += num;
        }
        float avg = sum / numbers.Count;
        int largest = -999;
        foreach(int num in numbers)
        {
            if (largest < num)
            {
                largest = num;
            }
        }
        int smallest = 999999999;
        foreach(int num in numbers)
        {
            if (smallest > num)
            {
                smallest = num;
            }
        }
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {avg}");
        Console.WriteLine($"Largest: {largest}");
        Console.WriteLine($"Smallest: {smallest}");        
        numbers.Sort();
        Console.WriteLine("Sorted List: ");
        foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }

    }
}