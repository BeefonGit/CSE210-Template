using System;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static void Main(string[] args)
    {
        // Shove this whole thing into a while loop until quit is over!!!!!!
        using TextFieldParser parser = new TextFieldParser(@"lds-scriptures.csv");
        parser.TextFieldType = FieldType.Delimited;
        parser.SetDelimiters(",");

        Console.WriteLine("Welcome to your Doctrinal Mastery Program!");
        Console.WriteLine("What book will you be using?\n (Enter {Q} to quit)");
        string book = Console.ReadLine();
        Console.WriteLine($"Which chapter of {book}? ");
        string chapter = Console.ReadLine();
        Console.WriteLine($"Starting on which verse in {book} chapter {chapter}? ");
        string verse1 = Console.ReadLine();
        Console.WriteLine("What verse will this scripture end on? (For one verse enter the same one)");
        string verse2 = Console.ReadLine();
        Reference reference = new Reference();
        Scripture scripture = new Scripture();
        List<Word> text = new List<Word>();
        while (!parser.EndOfData)
            {
                //Processing row
                string[] fields = parser.ReadFields();
                for (int i = 0; i < fields.Length; i++)
                {   
                    if (i == 0) {
                        continue;
                    }
                    else if (book == fields[5] && chapter == fields[14] && int.Parse(verse1) <= int.Parse(fields[15]) && int.Parse(verse2) >= int.Parse(fields[15])) {
                        // Sets the reference
                        reference.SetBook(book);
                        reference.SetChapter(int.Parse(chapter));
                        reference.SetBeginningVerse(int.Parse(verse1));
                        reference.SetEndVerse(int.Parse(verse2));

                        // String Splits the text for our classes, then assigns them to our list of words
                        string[] words = fields[16].Split(' ');
                        foreach (string w in words) {
                            Word word = new Word();
                            word.SetText(w);
                            word.SetLength(w);
                            text.Add(word);
                        }
                        break;
                    }
                    
                }
            }
        scripture.SetText(text);
        if (scripture != null)
        {
            Scripture covered = new();
            covered.SetText(scripture.GetText());
            bool play = true;
            while(play){
                Console.Clear();
                Console.WriteLine($"{reference.GetBook()} {reference.GetChapter()}:{reference.GetBeginningVerse()}-{reference.GetEndVerse()}");
                covered.Display();
                Console.WriteLine("\n");
                string entry = Console.ReadLine();
                if (entry == "") {
                    string cov_display = covered.Cover();
                    List<string> cov_list = cov_display.Split(" ").ToList();
                    List<Word> cov_wlist = new();
                    foreach(string str in cov_list) {
                        Word w = new Word();
                        w.SetText(str);
                        w.SetLength(str);
                        cov_wlist.Add(w);
                    }
                    covered = new Scripture();
                    covered.SetText(cov_wlist);
                } 
                else if (entry == "quit" || entry == "Quit" || entry == "QUIT") {
                    play = false;
                }
            }
        }
        else
        {
            Console.WriteLine("Scripture not found.");
        }
                
            
    }
}
