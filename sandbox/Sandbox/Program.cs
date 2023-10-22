using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture = new();
        string[] x = "In the beginning God created the heaven and the earth.".Split(" ");
        List<Word> words = new();
        foreach(string word in x) {
            Word w = new();
            w.SetText(word);
            w.SetLength(word);
            words.Add(w);
        }
        scripture.SetText(words);
        scripture.Display();
        Console.WriteLine(scripture.Cover());

    }
}