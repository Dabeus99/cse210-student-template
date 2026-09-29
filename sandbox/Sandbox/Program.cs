// // using System;

// // class Program
// // {
// //     static void Main(string[] args)
// //     {
// //         bool done = false;

// //         while (! done)
// //         {
// //             Console.Write("Are we done (y/n)? ");
// //             done = Console.ReadLine() == "y";
// //         }
// //     }
// // }






// //  bool done;

// //         do
// //         {
// //            Console.Write("Are we done (y/n)? ");
// //            done = Console.ReadLine().ToLower() == "y";
// //         } while (! done);


// // for(int i = 100000; i > 0; i-=10000)
// //             {
// //                 Console.WriteLine(i);
// //             }


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

using System;
using System.Collections.Generic;


class Program
{


static void Main(string[] args)
    {
        Circle myCircle = new Circle();

        myCircle._radius = 10;

        double area = myCircle.GetArea();
        
        Console.WriteLine(area);
    }
}