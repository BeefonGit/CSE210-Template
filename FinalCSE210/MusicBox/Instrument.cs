using NAudio.Wave;
using NAudio.Wave.SampleProviders;

public class Instrument
{
    private Dictionary<string, WaveStream> _notes = new Dictionary<string, WaveStream>(); 
    public void SetNotes(Dictionary<string, WaveStream> notes)
    {
        _notes = notes;
    }
    // public void SetNote()
    public Dictionary<string, WaveStream> GetNotes()
    {
        return _notes;
    }
    public WaveStream GetNote(string index)
    {
        return _notes[index];
    }
}