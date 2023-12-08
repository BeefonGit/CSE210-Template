using NAudio.Wave;
public class Song
{
    private List<Bar> _song = new();
    public void SetSong(List<Bar> bars)
    {
        _song = bars;
    }
    public List<Bar> GetSong()
    {
        return _song;
    }
    public void PlaySounds(List<WaveStream> sounds)
    {
        List<WaveOutEvent> waveOuts = new List<WaveOutEvent>();

        foreach (var sound in sounds)
        {
            WaveOutEvent waveOut = new WaveOutEvent();
            var waveProvider = sound;
            waveOut.Init(waveProvider);
            waveOuts.Add(waveOut);
        }
        foreach(WaveOutEvent waveOut in waveOuts)
        {
            waveOut.Play();
        }

        foreach (WaveOutEvent waveOut in waveOuts)
        {
            while (waveOut.PlaybackState == PlaybackState.Playing)
            {
                Thread.Sleep(10);
            }
            waveOut.Dispose();
        }
        foreach(WaveStream sound in sounds)
        {
            sound.Position = 0;
        }
    }    

    public List<Bar> CreateSong(List<string> progression, Dictionary<string, string> scale, RhythmInstrument rhythmInstrument, LeadInstrument leadInstrument, Drums drums)
    {
        List<Bar> song = new();
        for(int i = 0;i < 1; i++)
        {
            Bar bar = new();
            bar.SetBar(bar.CreateVerse(progression, scale, rhythmInstrument, leadInstrument, drums));
            song.Add(bar);
        }
        return song;
    }
    public void PlaySong(List<Bar> song) // Turbo nesting basically goes -> Song<Bar<steps<step>>>>
    {
        foreach(Bar bar in song)
        {
            foreach(List<List<WaveStream>> steps in bar.GetBar())
            {
                foreach(List<WaveStream> step in steps)
                {
                    PlaySounds(step);
                }
            }
        }
    }
}