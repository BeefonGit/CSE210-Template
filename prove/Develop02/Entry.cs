using System;
public class Entry {
    public string _prompt {get; set;}
    public string _date { get; set;}
    public string _response { get; set;}

    public string getEntry(string prompt) {
        Random PromptGen = new Random();
        int PromptInt = PromptGen.Next(0, 5);
        Console.WriteLine(prompt);
        string current_entry = Console.ReadLine();
        return current_entry;
    }
}

