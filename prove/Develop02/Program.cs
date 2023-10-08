using System;

// Prompt List
List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord today?",
            "What was the strongest emotion I felt today?",
            "If I could do over one thing today, what would it be?"
        };



// creating an entry
Console.WriteLine("Welcome to your journaling program!");
Journal journal = new Journal();

bool Active = true;
while (Active == true)
{   
    Console.Write("\nWould you like to \n 1. Write. \n 2. Display. \n 3. Load. \n 4. Save. \n 5. Quit. \nResponse: ");
    int answer = int.Parse(Console.ReadLine());
    if (answer == 1) // Write
    {
        Random PromptGen = new Random();
        int PromptInt = PromptGen.Next(0, 5);

        Entry entry = new Entry();
        entry._prompt = prompts[PromptInt];
        entry._response = entry.getEntry(prompts[PromptInt]);
        entry._date = DateTime.Now.ToShortDateString();
        journal.JournalAdd(entry);
        continue;

    }
    else if (answer == 2) // Display
    {
        foreach (Entry entry in journal._journals)
        {
            Console.WriteLine($"\n{entry._date}\n{entry._prompt}\n{entry._response}\n");
        }
    }
    else if (answer == 3) // Load
    {
        Entry entry = new Entry();

        Console.WriteLine("What is the filename of your journal? ");
        string filename = Console.ReadLine() + ".txt";

        string[] lines = System.IO.File.ReadAllLines(filename);
        int i = 0;
        foreach(string line in lines)
        {
            if (line == "")
            {
                journal._journals.Add(entry);
                entry = new Entry();
            }
            else if (i == 0 | i % 5 == 0)
            {
                entry._date = line;
            }
            else if (i == 1 | (i - 1) % 5 == 0)
            {
                entry._prompt = line;
            }
            else if (i == 2 | (i - 2) % 5 == 0)
            {
                entry._response = line;
            }
            i += 1;
        }
    }
    else if (answer == 4) // Save
    {
        Console.WriteLine("What do you want to name your file (.txt)? " );
        string filename = Console.ReadLine() + ".txt";


        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach(Entry entry in journal._journals)
            {
                outputFile.WriteLine($"{entry._date}\n{entry._prompt}\n{entry._response}\n");
            }
            // You can add text to the file with the WriteLine method
            //outputFile.WriteLine("This will be the first line in the file.");

            // You can use the $ and include variables just like with Console.WriteLine
            // string color = "Blue";
            // outputFile.WriteLine($"My favorite color is {color}");
        }

    }
    else if (answer == 5) // Quit
    {
        Active = false;
        break;
    }
}
