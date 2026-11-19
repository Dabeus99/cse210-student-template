using System.Diagnostics.Contracts;

class SimpleGoal : BaseGoal
{
    public SimpleGoal(string name, string description, int points, bool status = false) : base(name, description, points, status)
    {
    }

    public SimpleGoal() : base()
    {
        
    }
    public override int RecordEvent()
    {
        MarkComplete();
            return GetPoints();
    }



    public override string GetFileSystemString()
    {
        return $"simple|{base.GetFileSystemString()}";
    }
}