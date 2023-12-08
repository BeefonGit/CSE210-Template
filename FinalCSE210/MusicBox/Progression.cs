public class Progression
{
    private Dictionary<string, string> _scale = new Dictionary<string, string>
    {
        {"I", "C"},
        {"ii", "D"},
        {"iii", "E"},
        {"IV", "F"},
        {"V", "G"},
        {"vi", "A"},
        {"vii*", "B"}
    };
    public Dictionary<string, string> GetScale()
    {
        return _scale;
    }
    private List<List<string>> _majorChordProgressions = new List<List<string>>
    {
        new List<string>{"I", "vi", "V", "I"},
        new List<string>{"I", "V", "vi", "IV"},
        new List<string>{"I", "IV", "V", "IV"},
        new List<string>{"I", "vi", "IV", "V"}
    };
    private List<List<string>> _minorChordProgressions = new List<List<string>>
    {
        new List<string>{"vi", "IV", "iii", "vi"},
        new List<string>{"vi", "iii", "IV", "ii"},
        new List<string>{"vi", "ii", "iii", "ii"},
        new List<string>{"vi", "IV", "ii", "iii"}
    };
    public List<string> GetProgression()
    {
        Random random = new Random();
        int Key = random.Next(1, 3);
        int Progression = random.Next(0, 4);
        List<string> prog = new();
        if (Key == 1)
        {
            prog = _majorChordProgressions[Progression];
        }
        else if (Key == 2)
        {
            prog = _minorChordProgressions[Progression];
        }
        return prog;
    }
}