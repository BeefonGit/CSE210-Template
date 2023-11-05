public class Activity
{
    private string _type;
    public string GetType()
    {
        return _type;
    }
    public void SetType(string type)
    {
        _type = type;
    }
    public void Pause(int bar) 
    {
        List<string> loading = new();
        for (int i = 0; i < bar; i++)
        {
            loading.Add("--");
        }

        int CurrentPosition = Console.CursorTop;

        foreach (string dash in loading)
        {
            Console.Write(dash);
        }        

        Console.SetCursorPosition(0, CurrentPosition);

        int Xpos = 2;
        for (int i = 0; i < loading.Count; i++) 
        {
            Console.SetCursorPosition(Xpos, CurrentPosition);
            Xpos += 2;
            Console.Write("\b\b");
            Console.Write("==");
            Thread.Sleep(500);
        }
    } 

    public void Countdown(int seconds)
    {   
        while (seconds != 0)
        {
            Console.Write(seconds);
            Thread.Sleep(1000);
            Console.SetCursorPosition(0, Console.CursorTop); 
            Console.Write(new string(' ', Console.WindowWidth - 1));
            Console.SetCursorPosition(0, Console.CursorTop);;
            seconds -= 1;
        }
        Console.Write("0");
        Thread.Sleep(1000);
        Console.Write("\b ");
    }
    public void Conclude()
    {
        Console.Clear();
        Console.WriteLine("Thank you for participating in this activity!");
        Pause(8);
        Console.Clear();
    }
}