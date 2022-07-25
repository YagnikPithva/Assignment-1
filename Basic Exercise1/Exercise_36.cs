using System;

public class Code
{
    static void Main(string[] args)
    {
        int first_num, second_num, third_num;

        Console.Write("Enter First Number : ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        second_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Third Number : ");
        third_num = Convert.ToInt32(Console.ReadLine()); 
        
        Console.WriteLine("Largest Number : "+Math.Max(first_num, Math.Max(second_num, third_num)));
        Console.WriteLine("Lowest Number : "+Math.Min(first_num, Math.Min(second_num, third_num)));
    }
}