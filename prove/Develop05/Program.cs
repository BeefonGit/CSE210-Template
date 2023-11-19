using System;
using System.Reflection;

class Program
{
    static void Main(string[] args)
    {
        
        
        List<Goal> goals = new();
        Console.WriteLine("Welcome to your Eternal Quest!");
//
        CharacterGenerator GenerateCharacter = new CharacterGenerator();
        CharacterLevel level = new CharacterLevel();
        l
        ReturnCharacterLevel(score)
        Console.WriteLine(GenerateCharacter.GenerateCharacter(CharacterLevel ));

        Console.WriteLine("Here is your character, level him up by completing tasks");
        
        
//        
        Console.WriteLine("Menu\n1. Display Checklist\n2. Display Score\n3. Complete Goal\n4. Create New Goal\n5. Quit");
        string Input = Console.ReadLine();
        while (true)
        {


            if (Input == "1")
            {
                int iteration = 0;
                foreach (Goal goal in goals)
                {
                    iteration += 1;
                    string check = " ";
                    if (goal.GetCompleted() == true)
                    {
                        check = "X";
                    }
                    Console.WriteLine($"{iteration}. {goal.GetGoalName}: [{check}]");
                }
                Console.Write("Press ENTER to continue");
                string entry = Console.ReadLine();
            }
            else if (Input == "2")
            {
                int Score = 0;
                foreach (Goal goal in goals)
                {
                    Score += goal.GetTotalPoints();
                }
                Console.WriteLine(Score);
            }
            else if (Input == "3")
            {
                Console.Clear();
                Console.WriteLine("Which goal would you like to complete? ");
                int iteration = 0;
                foreach (Goal goal in goals)
                {
                    iteration += 1;
                    if (goal.GetCompleted() == false)
                    {
                        Console.WriteLine($"{iteration}. {goal.GetGoalName}: [{goal.GetGoalPoints}]");
                    }
                }
                int choice = int.Parse(Console.ReadLine());
                goals[choice -1].Complete();
            }
            else if (Input == "4")
            {
                Console.Clear();
                Console.WriteLine("What type of goal are you creating?\n1. Simple one time goal\n2. Goal to be completed after a certain number of times\n3. Goal to do forever more\n4. Go back\n");
                string Input2 = Console.ReadLine();
                if (Input2 == "1")
                {
                    // Create Simple Goal
                    SimpleGoal simpleGoal = new();
                    Console.Write("What do you want to call your goal: ");
                    string name = Console.ReadLine();
                    simpleGoal.SetGoalName(name);
                    Console.Write("Describe what your goal is: ");
                    string description = Console.ReadLine();
                    simpleGoal.SetGoalDescription(description);
                    Console.Write("How many points is your goal worth (int): ");
                    int points = int.Parse(Console.ReadLine());
                    goals.Add(simpleGoal);
                }
                else if (Input2 == "2")
                {
                    // Create FiniteGoal
                    FiniteGoal finiteGoal = new();
                    Console.Write("What do you want to call your goal: ");
                    string name = Console.ReadLine();
                    finiteGoal.SetGoalName(name);
                    Console.Write("Describe what your goal is: ");
                    string description = Console.ReadLine();
                    finiteGoal.SetGoalDescription(description);
                    Console.Write("How many points is your goal worth (int): ");
                    int points = int.Parse(Console.ReadLine());
                    finiteGoal.SetGoalPoints(points);
                    Console.Write("How many times do you want to repeat this goal: ");
                    int repeats = int.Parse(Console.ReadLine());
                    finiteGoal.SetRepeats(repeats);
                    goals.Add(finiteGoal);

                }
                else if (Input2 == "3")
                {
                    // Create EternalGoal
                    EternalGoal eternalGoal = new();
                    Console.Write("What do you want to call your goal: ");
                    string name = Console.ReadLine();
                    eternalGoal.SetGoalName(name);
                    Console.Write("Describe what your goal is: ");
                    string description = Console.ReadLine();
                    eternalGoal.SetGoalDescription(description);
                    Console.Write("How many points is your goal worth (int): ");
                    int points = int.Parse(Console.ReadLine());
                    eternalGoal.SetGoalPoints(points);
                }
                else if (Input2 == "4")
                {
                    continue;
                }

            }
            else if (Input == "5")
            {
                break;
            }
        }
    }
}