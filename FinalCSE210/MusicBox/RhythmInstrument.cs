using NAudio.Wave;
using NAudio.Wave.SampleProviders;

public class RhythmInstrument : Instrument
{
    private Dictionary<string, List<string>> _chords = new Dictionary<string, List<string>>
    {
        {"C", new List<string>{"C3", "E3", "G3"}},
        {"D", new List<string>{"D3", "F3", "A4"}},
        {"E", new List<string>{"E3", "G3", "B4"}},
        {"F", new List<string>{"F2", "A3", "C3"}},
        {"G", new List<string>{"G2", "B3", "D3"}},
        {"A", new List<string>{"A3", "C3", "E3"}},
        {"B", new List<string>{"B3", "D3", "F3"}},
    };
    public Dictionary<string, List<string>> GetChords()
    {
        return _chords;
    }
    public override List<WaveStream> GenerateChord(string chord, Dictionary<string, List<string>> scale)
    {
        List<WaveStream> notes = new List<WaveStream>{
            GetNote(scale[chord][0]), GetNote(scale[chord][1]), GetNote(scale[chord][2])
        };
        return notes;
    }
}