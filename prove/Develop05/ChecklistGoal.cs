class CheckListGoal: BaseGoal
{

    private int _numberOfCompletions;
    private int _maxGoal;
    private int _bonusPoint;

    public CheckListGoal(string name, string description, int points, int maxGoal, int bonusPoint, int numberOfCompletions = 0)
        : base(name, description, points)
    {
        _numberOfCompletions = numberOfCompletions;
        _maxGoal = maxGoal;
        _bonusPoint = bonusPoint;
    }
    
    public override void RecordEvent()
    {
        _numberOfCompletions++;
        if(_numberOfCompletions >= _maxGoal)
        {
            MarkComplete();
        }
        
    }

    public override string GetConsoleString()
    {
        return "";
    }

    public override string GetFileSystemString()
    {
        return "";
    }
}