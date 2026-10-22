

// class Program
// {


// static void Main(string[] args)
//     {
//         Circle myCircle = new Circle();

//         myCircle._radius = 10;

//         double area = myCircle.GetArea();
        
//         Console.WriteLine(area);
//     }
// }



class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("type in a number? ");
        int top = int.Parse(Console.ReadLine());

        Console.WriteLine("type in a number? ");
        int bottom = int.Parse(Console.ReadLine());

        Fraction one = new Fraction(top, bottom);
        
        
        
        Console.WriteLine($"{one.displayFraction()}");
        Console.WriteLine($"{one.displayDecimal()}");
    }
}