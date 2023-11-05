public class ListingActivity : Activity
{
    public void Listing()
    {
        List<string> prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        Console.Clear();
        Console.WriteLine("For how many seconds do you want to list?");
        int Seconds = int.Parse(Console.ReadLine());
        Console.WriteLine("Get ready!");
        Countdown(5);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(Seconds);
        int count = 0;
        while (end > DateTime.Now)
        {
            Console.Write(">");
            Console.ReadLine();
            count += 1;
        }
        Console.WriteLine($"You listed {count} items! \nGood Job!");
        Conclude();
    }
}