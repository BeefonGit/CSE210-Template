using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2023;
        Job job2 = new Job();
        job2._jobTitle = "Exploder";
        job2._company = "Tenacious D";
        job2._startYear = 2005;
        job2._endYear = 2009;
        Resume allison = new Resume();
        allison._name = "Allison Rose";
        allison._jobs.Add(job1);
        allison._jobs.Add(job2);
        allison.Display();
    }
}