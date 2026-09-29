using System;
using System.Security.Cryptography;


class Program
{
     static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        bool keep_playing = true;

         while (keep_playing)
        {
        int magic_number = randomGenerator.Next(1, 101);
        int guess = -1;
        int count = 0;
    
       
            while (guess != magic_number)
            {  Console.WriteLine("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            count++;

            if (guess < magic_number) {
                    Console.WriteLine("Higher ");
                }
                else if (guess > magic_number) 
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it! ");
                }
            }
    
        
      
                Console.WriteLine($"Your number is: {magic_number} the number of guesses is: {count}");
        
                Console.WriteLine("Would you like to keep playing? ");
                string response = Console.ReadLine();
                keep_playing = (response.ToLower() == "yes"); //I grabbed ToLower() from stack overflow to prvent issues//
        }
    }

}