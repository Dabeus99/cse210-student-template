using System.Diagnostics.Contracts;

class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool status = false) : base(name, description, points, status)
    {
    }
    public override void RecordEvent()
    {
    
    }

    public override string GetConsoleString()
    {
        
    }

    public override string GetFileSystemString()
    {
        
    }
}