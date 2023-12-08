using NAudio.Wave;
using NAudio.Wave.SampleProviders;

public class Drums
{
    private WaveStream _bass;
    public void SetBass(string note_file)
    {
        using WaveStream reader = new MediaFoundationReader(note_file);
        _bass = reader;
    }
    public WaveStream GetBass()
    {
        return _bass;
    }
    private WaveStream _hihat;
    public void SetHihat(string note_file)
    {
        using WaveStream reader = new MediaFoundationReader(note_file);
        _hihat = reader;
    }
    public WaveStream GetHihat()
    {
        return _hihat;
    }
    private WaveStream _snare;
    public void SetSnare(string note_file)
    {
        using WaveStream reader = new MediaFoundationReader(note_file);
        _snare = reader;
    }
    public WaveStream GetSnare()
    {
        return _snare;
    }
}