

class Program
{
    static void Main(string[] args)
    {
        List<BaseGoal> goals = new List<BaseGoal>();

        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();

        Console.Write("What is the name of your goal: ");
        string name = Console.ReadLine();
        
        Console.Write("How many points should this goal be worth: ");
        int points = int.Parse(Console.ReadLine());

        goals.Add(new SimpleGoal(name, description, points));

       
    }
}