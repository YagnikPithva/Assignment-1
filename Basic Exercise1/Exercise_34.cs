using System;

class Code
{
    static void Main(string[] args)
    {
        int number_1, number_2;

        Console.Write("Enter First Number : ");
        number_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        number_2 = Convert.ToInt32(Console.ReadLine());

        if((number_1>-10 && number_1<10) && (number_2 > -10 && number_2 < 10))
        {
            Console.WriteLine(true);
        }
    }
}