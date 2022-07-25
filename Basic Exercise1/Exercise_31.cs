using System;

class Code
{
    static bool checkNum(int num)
    {
        if (num%3 == 0 || num%7 == 0 )
        {
            return true;
        }
        else
        {
            return false;
        }    
    }
    static void Main(string[] args)
    {
        int number;
        Console.Write("Input a Number : ");
        number = Convert.ToInt32(Console.ReadLine());
        
        if(number > 0)
        {
            Console.WriteLine(checkNum(number)); 
        }
        else
        {
            Console.WriteLine("You Input Number is Negative !");
        }
    }
}