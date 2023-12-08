// See https://aka.ms/new-console-template for more information
using System;
using System.Xml;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

class Program{static void Main(string[] args)
{
    Console.Clear();
    Console.WriteLine("I hope that you enjoy my music box.\nDespite its simple melodies, it is the product of an estimated 25-30 hours of work and a 50 dollar purchase in order to obtain audio samples (Didn't know how stingy people were about audio lol). \nThis is easily the most complicated thing I have programmed. \nI am very proud of this and hope that you will be as well.");
    Drums drums = new();
    drums.SetBass("Drums/Bass.mp3");
    drums.SetHihat("Drums/Hat.mp3");
    drums.SetSnare("Drums/Snare.wav");
    Dictionary<string, string> NoteFiles = new();
    NoteFiles["A2"] = "Xylophone/XYA2.wav";
    NoteFiles["A3"] = "Xylophone/XYA3.wav";
    NoteFiles["A4"] = "Xylophone/XYA4.wav";
    NoteFiles["B3"] = "Xylophone/XYB3.wav";
    NoteFiles["B4"] = "Xylophone/XYB4.wav";
    NoteFiles["C3"] = "Xylophone/XYC3.wav";
    NoteFiles["C4"] = "Xylophone/XYC4.wav";
    NoteFiles["D3"] = "Xylophone/XYD3.wav";
    NoteFiles["D4"] = "Xylophone/XYD4.wav";
    NoteFiles["E2"] = "Xylophone/XYE3.wav";
    NoteFiles["E3"] = "Xylophone/XYE3.wav";
    NoteFiles["E4"] = "Xylophone/XYE4.wav";
    NoteFiles["F2"] = "Xylophone/XYF3.wav";
    NoteFiles["F3"] = "Xylophone/XYF3.wav";
    NoteFiles["F4"] = "Xylophone/XYF4.wav";
    NoteFiles["G2"] = "Xylophone/XYG2.wav";
    NoteFiles["G3"] = "Xylophone/XYG3.wav";
    NoteFiles["G4"] = "Xylophone/XYG4.wav";
    Dictionary<string, WaveStream> NoteStream = new();
    foreach(var kvp in NoteFiles)
    {
        string Key = kvp.Key;
        string Value = kvp.Value;

        using WaveStream reader = new MediaFoundationReader(kvp.Value);
        NoteStream[Key] = reader;

    }
    LeadInstrument xylophone = new();
    RhythmInstrument xylophone1 = new();
    xylophone.SetNotes(NoteStream);
    xylophone1.SetNotes(NoteStream);
    Progression progression = new();
    Song song = new();
    song.SetSong(song.CreateSong(progression.GetProgression(), progression.GetScale(), xylophone1, xylophone, drums));
    Thread.Sleep(8000);
    Console.Clear();
    Console.WriteLine("Enjoy!");
    Thread.Sleep(2500);
    Console.Clear();
    Console.WriteLine("Playing...");
    song.PlaySong(song.GetSong());
    Console.Clear();
    Console.WriteLine("Thank you for listening :)");
    Thread.Sleep(5000);
    Console.Clear();
}}