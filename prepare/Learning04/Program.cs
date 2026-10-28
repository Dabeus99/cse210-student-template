class Program
    {
        static void Main(string[] args)
    {

        WritingAssignment myWriting = new WritingAssignment("Mary Waters","European History", "The Causes of World War II");
        Console.WriteLine(myWriting.GetWritingInformation());

        Assignment myAssigment = new Assignment("Mary Waters","European History");
        Console.WriteLine(myAssigment.getSummary());
 
        MathAssignment myMathAssignment = new MathAssignment("Mary Waters","European History", "The Causes of World War II", "by: Mary Waters");
        Console.WriteLine(myMathAssignment.GetHomeworkList());

      
    }

        
 
    }
    