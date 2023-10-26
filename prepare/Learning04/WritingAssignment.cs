public class WritingAssignment : Assignment{
    private string _text;
    public void GetWritingInformation()
    {
        Console.WriteLine($"{_text}");
    }
    public void SetText(string text)
    {
        _text = text;
    }
    public string GetText() 
    {
        return _text;
    }
}