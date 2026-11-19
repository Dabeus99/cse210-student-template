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
    
    public override int RecordEvent()
    {

        if (IsComplete())
        {
            return 0;
        }

        _numberOfCompletions++;
        int earned = GetPoints();

        if (_numberOfCompletions >= _maxGoal)
        {
            MarkComplete();
            earned += _bonusPoint;
        }

        return earned;

    }

    public override string GetConsoleString()
    {
        string checkbox = IsComplete() ? "[X]" : "[ ]";
        return $"{checkbox} {GetName()} ({GetDescription()}) Complete {_numberOfCompletions}/{_maxGoal} times";
    }

    public override string GetFileSystemString()
    {
        return $"checklist|{base.GetFileSystemString()}|{_numberOfCompletions}|{_maxGoal}|{_bonusPoint}";
    }
}