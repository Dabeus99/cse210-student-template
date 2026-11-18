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


    abstract public string GetConsoleString();
    abstract public void RecordEvent();
    abstract public string GetFileSystemString();

   
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