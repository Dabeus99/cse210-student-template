using System.Diagnostics.Contracts;

abstract class BaseGoal
{
    private string _name;
    private string _description;
    private int _points;
    private bool _status;

    public BaseGoal(string name, string description, int points, bool status = false)
    {
        _name = name;
        _description = description;
        _points = points;
        _status = status; 
    }

public BaseGoal()
    {
           Console.Write("What is the name of your goal? ");
        _name = Console.ReadLine();

        Console.Write("What is the description? ");
        _description = Console.ReadLine();
        
        Console.Write("How many points should this goal be worth? ");
        _points = int.Parse(Console.ReadLine());
    }

    public virtual string GetConsoleString()
    {
        string checkbox = _status ? "[X]" : "[ ]";
        return $"{checkbox} {_name} {_description} {_points} {_status}";
    }
    abstract public int RecordEvent();
    public virtual string GetFileSystemString()
    {
        return $"{_name}|{_description}|{_points}|{_status}";
    }
 
   public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }
   
   public int GetPoints()
    {
        return _points;
    }

    public bool IsComplete()
    {
        return _status;
    }

    public void MarkComplete()
    {
        _status = true;
    }

  
    

    

}