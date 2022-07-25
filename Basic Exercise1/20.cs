using System;
class First
{
    static bool nagativePositive(double a,double b)
    {
        if (a == 20 || b == 20 || a+b == 20)
        {
            return true;
        }
        return false;
    }
    static void Main()
    {
        double i; int j;
        Console.Write("Enter Num1 : ");
        i = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Num2 : ");
        j = Convert.ToInt32(Console.ReadLine());
     
        Console.WriteLine("Is there no. OR Sum of No. 20 ? = "+nagativePositive(i,j));
    }
}