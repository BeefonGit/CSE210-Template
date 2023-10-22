public class Scripture{
    private List<Word> _text = new List<Word>(); 
    public string Cover() {
        Random randomGenerator = new Random();
        List<string> covered = new List<string>();
        List<int> coveredNums = new List<int>();
        while (coveredNums.Count < 3) {
            int number = randomGenerator.Next(0, _text.Count); 
            if (!coveredNums.Contains(number)) {
                coveredNums.Add(number);
            }
        }
        int index = 0;
        foreach(Word w in _text){
            List<string> cov_word_list = new List<string>();
            if (coveredNums.Contains(index)) {
                for (int i2 = 0; i2 < w.GetLength(); i2++) {
                    cov_word_list.Add("-");
                }
                string cov_word = string.Join("", cov_word_list);
                covered.Add(cov_word);
                index += 1;
            }
            else {
                covered.Add(w.GetText());
            }
        }
    return string.Join(" ", covered);

    }
    
    public void Display() {
        foreach(Word w in _text) {
            Console.Write($"{w.GetText()} ");
        }
    }
    public void SetText(List<Word> sentence) {
        _text = sentence;
    }
    public List<Word> GetText() {
        return _text;
    }
    public string GetTextAsString() {
        List<string> ret_string = new List<string>();
        foreach(Word w in _text) {
            ret_string.Add(w.GetText());
        }
        return string.Join(" ", ret_string);
    }
}