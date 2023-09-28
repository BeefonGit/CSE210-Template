using System;

class Program
{
    static void Main(string[] args)
    {
        job job1 = new job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2023;
        job job2 = new job();
        job2._jobTitle = "Exploder";
        job2._company = "Tenacious D";
        job2._startYear = 2005;
        job2._endYear = 2009;
        resume allison = new resume();
        allison._name = "Allison Rose";
        allison._jobs.Add(job1);
        allison._jobs.Add(job2);
        allison.Display();
    }
}