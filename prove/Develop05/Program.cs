

class Program
{
    static void Main(string[] args)
    {
        List<BaseGoal> goals = new List<BaseGoal>();

     

        goals.Add(new SimpleGoal());

        foreach(BaseGoal bg in goals)
        {
            Console.WriteLine(bg.GetConsoleString());
        }
       
    }
}