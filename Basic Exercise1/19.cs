using System;
class First
{
    static double nagativePositive(double a,double b)
    {
        if (a>b)
        {
            return a - b;
        }
        return 0;
    }
    static void Main()
    {
        double i; int j;
        Console.Write("Enter Num1 : ");
        i = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Num2 : ");
        j = Convert.ToInt32(Console.ReadLine());
     
        Console.WriteLine("Absolute Difference: "+nagativePositive(i,j));
    }
}