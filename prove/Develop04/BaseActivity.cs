using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

class BaseActivity
{
    private string _activityName;
    private string _description;
    private int _activityDuration;
    private DateTime _endTime;


    public BaseActivity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
    
    }




public void Display()
    {
        
    }

public void Timer()
    {
        _endTime = DateTime.Now.AddSeconds(_activityDuration);
    }
        protected bool HasTimerExpired()
    {
        return DateTime.Now >= _endTime;
    }

    

protected void StartActivity()
    {
        Console.Clear();

        Console.WriteLine($"Welcome to the {_activityName}.");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How many seconds would you like to practice? ");

        while (!int.TryParse(Console.ReadLine(), out _activityDuration)
        || _activityDuration <= 0)
{
    Console.Write("Please enter a whole number greater than zero: ");
}

        DisplaySpinner("Get ready...", 4);
    }

protected void DisplayEnding()
    {
        RunCountDown("Well done!", 3);

        Console.WriteLine(
            $"You completed {_activityDuration} seconds of the {_activityName}. ");

            RunCountDown("Returning to the menu...", 3);
    }

protected void RunCountDown(string message, int seconds)
    {
        Console.WriteLine(message);

        for (int i = seconds; i > 0; i--)
        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
        }
    }

protected void DisplaySpinner(string message, int seconds)
    {
        Console.Write(message);

        DateTime endTime = DateTime.Now.AddSeconds(seconds);

        while (DateTime.Now < endTime)
        {
            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b");

            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b");

            Console.Write("+");
            Thread.Sleep(500);
            Console.Write("\b");

        }

        Console.Write(" ");
        Console.WriteLine();
    }


}