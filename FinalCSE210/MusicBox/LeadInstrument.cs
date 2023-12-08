using NAudio.Wave;
using NAudio.Wave.SampleProviders;

public class LeadInstrument : Instrument
{    
    private Dictionary<string, List<string>> _chords = new Dictionary<string, List<string>>
    {
        {"C", new List<string>{"C3", "E3", "G3", "C4", "E4", "G4"}},
        {"D", new List<string>{"D3", "F3", "A3", "D4", "F4", "A4"}},
        {"E", new List<string>{"E3", "G3", "B3", "E4", "G4", "B4"}},
        {"F", new List<string>{"F3", "A3", "C3", "F4", "A4", "C4"}},
        {"G", new List<string>{"G3", "B3", "D3", "G4", "B4", "D4"}},
        {"A", new List<string>{"A3", "C3", "E3", "A4", "C4", "E4"}},
        {"B", new List<string>{"B3", "D3", "F3", "B4", "D4", "F4"}},
    };
    public Dictionary<string, List<string>> GetChords()
    {
        return _chords;
    }

    public override List<WaveStream> GenerateChord(string chord, Dictionary<string, List<string>> scale)
    {
        Random rnote1 = new Random();
        Random rnote2 = new Random();
        Random rnote3 = new Random();
        int note1 = rnote1.Next(0,3);
        int note2 = rnote2.Next(0,3);
        int note3 = rnote3.Next(0,3);
        List<WaveStream> notes = new List<WaveStream>{
        GetNote(scale[chord][note1]),
        GetNote(scale[chord][note2]), 
        GetNote(scale[chord][note3])
        };
        return notes;
    }    
}