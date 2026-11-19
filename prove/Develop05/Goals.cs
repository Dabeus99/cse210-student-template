using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.Marshalling;

class Goals
{
    private List<BaseGoal> _goals = new List<BaseGoal>();

    private int _totalScore = 0;
    private string _fileName = "goal";



public void AddGoal()
{
    Console.WriteLine("The types of goals are:");
    Console.WriteLine("  1. Simple Goal");
    Console.WriteLine("  2. Eternal Goal");
    Console.WriteLine("  3. Checklist Goal");
    Console.Write("Which type of goal would you like to create? ");
    string choice = Console.ReadLine();


    if (choice == "1")
    {
        _goals.Add(new SimpleGoal());
    }
    else if (choice == "2")
    {
        //_goals.Add(new EternalGoal());
    }
    else if (choice == "3")
    {
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("What is the bonus for accomplishing it that many times? ");
        int bonus = int.Parse(Console.ReadLine());

        //_goals.Add(new CheckListGoal(name, description, points, target, bonus));
    }
    else
    {
        Console.WriteLine("Invalid choice.");
    }
}

    

public void LoadGoals()
    {
        
    }

public void SaveGoals()
    {
        using (StreamWriter outputFile = new StreamWriter(_fileName))
    {
        foreach(BaseGoal g in _goals)
            outputFile.WriteLine(g.GetFileSystemString());

    }
    } 
 

public void DisplayGoals()
    {
        foreach(BaseGoal goal in _goals)
        {
            Console.WriteLine(goal.GetConsoleString());
        }
    }

public void DisplayScore()
    {
        Console.WriteLine($"You have {_totalScore} points.");
    }

public void RecordEvent()
    {
        
    }

    

}