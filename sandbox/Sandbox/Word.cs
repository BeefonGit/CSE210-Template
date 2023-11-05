public class Word{
    private string _text;
    private int _length;
    public string GetText() {
        return _text;
    }    
    public int GetLength() {
        return _length;
    }
    public void SetText(string text) {
        _text = text;
    }
    public void SetLength(string text) {
        _length = text.Length;
    }
}