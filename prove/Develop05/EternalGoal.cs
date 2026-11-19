using System.Diagnostics.Contracts;

class EternalGoal : BaseGoal
{
    public EternalGoal(string name, string description, int points) : base(name, description, points)
    {
    }

    public override int RecordEvent()
    {
            return GetPoints();
    }

    public override string GetConsoleString()
    {
        return $"[ ] {GetName()} ({GetDescription()})";
    }

    public override string GetFileSystemString()
    {
        return $"eternal|{base.GetFileSystemString()}";

    }

    

}