using System;
public class Journal {
    public string _name;
    public List<Entry> _journals = new List<Entry>();
    public void JournalAdd(Entry entry)
    {
        _journals.Add(entry);
    }
}
