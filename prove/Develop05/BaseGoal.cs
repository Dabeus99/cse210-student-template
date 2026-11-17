abstract class BaseGoal
{
    private string _name;

    private string _description;

    private int _points;

    private bool _status;

    public BaseGoal()
    {
        SetName();
        SetDescription();
        SetPoints();
        SetStatus();
    }

    virtual protected void SetName()
    {
        Console.Write("What is the name of your goal: ");
        _name = Console.ReadLine();
    }

    virtual protected void SetDescription()
    {
        Console.Write("What is the description of the goal: ");
        _description = Console.ReadLine();
    }

     virtual protected void SetPoints()
    {
        Console.Write("How many points should this goal be worth: ");
        _points = int.Parse(Console.ReadLine());
    }

    virtual protected void SetStatus()
    {
        Console.Write("Has the goal been completed? ");
        _status = bool.Parse(Console.ReadLine());
    }

    abstract public string GetConsoleString();

    abstract public void RecordEvent();


    abstract public string GetFileSystemString();
    

    public int GetPoints()
    {
        return _points; 
    }

    public void MarkComplete()
    {
        return _status;
    }

}