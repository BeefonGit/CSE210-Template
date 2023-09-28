using System.Threading.Tasks.Dataflow;

public class resume 
{    
    public string _name;
    public List<job> _jobs = new List<job>();
    public void Display() {
        Console.WriteLine(_name);
        foreach (job j in _jobs) {
            Console.WriteLine($"{j._jobTitle} ({j._company} {j._startYear}-{j._startYear})");
    }}
}