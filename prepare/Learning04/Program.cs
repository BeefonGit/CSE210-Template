using System;

class Program
{
    static void Main(string[] args)
    {
        MathAssignment mathAssignment = new();
        mathAssignment.SetStudentName("Ethan");
        mathAssignment.SetTopic("Math");
        mathAssignment.SetTextbookSection("Section 7.6");
        mathAssignment.SetProblems("12-19");
        mathAssignment.GetSummary();
        mathAssignment.GetHomeWorkList();

        WritingAssignment writingAssignment = new();
        writingAssignment.SetStudentName("Ethan");
        writingAssignment.SetTopic("English");
        writingAssignment.GetSummary();
        writingAssignment.SetText("Big Jeremy's Escapade");
        writingAssignment.GetWritingInformation();
    }
}