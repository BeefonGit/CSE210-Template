using System.Runtime.CompilerServices;

public class BreathingActivity : Activity
{
    public void Breath()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the Breathing Activity!");
        Console.WriteLine("In this activity you will be asked to breath in and out at a controlled rate. \nThis will help you to feel more calm, and in a more present state of mind.\n");
        Pause(7);
        Console.WriteLine("\nFor how many seconds would you like to participate in this exercise? ");
        int Seconds = int.Parse(Console.ReadLine());
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(Seconds);
        while (end > DateTime.Now)
        {
            Console.WriteLine("\nNow breath in...");
            Countdown(6);
            Console.WriteLine("\nNow breath out...");
            Countdown(6);
        }
        Conclude();
    }
}