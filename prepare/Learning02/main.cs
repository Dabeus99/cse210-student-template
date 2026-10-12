using System;

class Program
{
    static void Main(string[] args)
    {
        Job Job1 = new Job();
        Console.WriteLine("What is your Companies name? ");
        Job1._company = Console.ReadLine();

        Console.WriteLine("What is your job title?");
        Job1._jobTitle = Console.ReadLine();

        Console.WriteLine("What year did you start? ");
        Job1._startYear = int.Parse(Console.ReadLine());

        Console.WriteLine("What year did you end? ");
        Job1._endYear = int.Parse(Console.ReadLine());

        Resume Resume1 = new Resume();
        Console.WriteLine("What is your name? ");
        Resume1._name = Console.ReadLine();

            Resume1._jobs.Add(Job1);
            Resume1.Display();




    }
}
