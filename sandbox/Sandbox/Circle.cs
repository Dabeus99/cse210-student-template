class Circle
{
    public double _radius;

    public double GetArea()
    {
        return 3.14159 * _radius * _radius;

    }

}


// using System;
// using System.Configuration.Assemblies;
// using System.Runtime.CompilerServices;

// class Program
// {
//     static double AddNumbers(double x, int y)
//     {
//         return x + y;       


//     }

//     static string MyName()
//     {
//         return "Bod";
//     }

//     static void DisplayGreetining(string name)
//     {
//         System.Console.WriteLine($"Welcome {name}, its nice to meet you ");
//     }

//     static void Main(string[] args)
//     {
//         string myName = MyName();
//         DisplayGreetining(myName);
//         double total = AddNumbers(12.234, 20);
//         Console.WriteLine(total);
//     }
// }