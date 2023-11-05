public class ReflectionActivity : Activity
{
    public void Reflect()
    {
        Console.Clear();
        Console.WriteLine("Welcome to the reflection activity!");
        Console.WriteLine("In this activity you will be asked to reflect on experiences that have shaped your recent life experience.");
        Console.WriteLine("For how many seconds do you want to participate in this activity?");
        int Seconds = int.Parse(Console.ReadLine());
        Dictionary<int, string> prompts = new Dictionary<int, string>();
        prompts[1] = "What is your most memorable moment today?";
        prompts[2] = "When did you feel respected recently?";
        prompts[3] = "When did you feel disrespected recently?";
        prompts[4] = "When did you feel offended recently?";
        List<string> questions = new List<string>
        {
            "Why was this experience meaningful to you?",
            "How did you feel about this during the experience?",
            "How did you feel about this in retrospect?",
            "What made this time stick out inside your head?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };
        Random number = new();
        int prompt = number.Next(1, 4);
        Console.Clear();
        Console.WriteLine(prompts[prompt]);
        Pause(20);
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(Seconds);
        while (end > DateTime.Now)
        {
            Random list_int = new();
            int list_prompt = list_int.Next(1, 7);
            Console.WriteLine($"\n{questions[list_prompt]}");
            Countdown(10);
        }
        Conclude();
    }
}