using NAudio.Wave;

public class Bar
{
    private List<List<List<WaveStream>>> _bar = new();
    public void SetBar(List<List<List<WaveStream>>> bar)
    {
        _bar = bar;
    }
    public List<List<List<WaveStream>>> GetBar()
    {
        return _bar;
    }
    public List<List<List<WaveStream>>> CreateVerse(List<string> progression, Dictionary<string, string> scale, RhythmInstrument rhythmInstrument, LeadInstrument leadInstrument, Drums drums)
    {
        List<List<List<WaveStream>>> verse = new();
        List<List<WaveStream>> steps = new();
        foreach(string chordsig in progression)
        {
            List<WaveStream> step1 = new();
            List<WaveStream> chord = rhythmInstrument.GenerateChord(scale[chordsig], rhythmInstrument.GetChords());
            foreach(WaveStream w in chord)
            {
                step1.Add(w);
            }
            step1.Add(drums.GetSnare());
            step1.Add(drums.GetBass());
            step1.Add(drums.GetHihat());
            steps.Add(step1);
            List<WaveStream> melody = leadInstrument.GenerateMelody(scale[chordsig], leadInstrument.GetChords());
            foreach(WaveStream note in melody)
            {
                List<WaveStream> step = new()
                {
                    note,
                    drums.GetHihat(),
                    drums.GetSnare()
                };
                steps.Add(step);
            }
            verse.Add(steps);
        }
        return verse;
    }
    public void PlayVerse()
    {

    }
}