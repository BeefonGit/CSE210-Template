using System;
public class Reference{
    private string _book;
    private int _chapter;
    private int _beginningVerse;
    private int _endVerse;

    private Scripture _scripture;

    public string GetBook() {
        return _book;
    }
    public int GetChapter() {
        return _chapter;
    }
    public int GetBeginningVerse() {
        return _beginningVerse;
    }
    public int GetEndVerse() {
        return _endVerse;
    }
    public Scripture GetScripture() {
        return _scripture;
    }
    public void SetBook(string book) {
        _book = book;
    }
    public void SetChapter(int chapter) {
        _chapter = chapter;
    }
    public void SetBeginningVerse(int VerseStart) {
         _beginningVerse = VerseStart;
    }
    public void SetEndVerse(int VerseEnd) {
        _endVerse = VerseEnd;
    }
    public void SetScripture(Scripture scripture) {
        _scripture = scripture;
    }

}