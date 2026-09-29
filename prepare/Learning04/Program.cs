using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
    List<int> nums = new List<int>();
    int userNumber = -1;

    Console.WriteLine("Enter a list of numbers, type 0 when finished. ");


    while (userNumber != 0)
        {
            Console.Write("Enter number: ");
            userNumber = int.Parse(Console.ReadLine());

            if (userNumber !=0)
            {
                nums.Add(userNumber);
            }
        }
        
    int sum = 0;
    foreach (int num in nums)
    {
            sum += num;
    }
    Console.WriteLine($"The sum is: {sum}");

    float average = ((float)sum) / nums.Count;
    Console.WriteLine($"The average is: {average}");

    int max = nums[0];
    foreach (int num in nums)
        {
            if (num > max)
            {
                max = num;
            }
        }
Console.WriteLine($"The largest number is: {max}");
}
}



  