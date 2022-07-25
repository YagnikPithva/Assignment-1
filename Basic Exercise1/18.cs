using System;
class First
{
    static int nagativePositive(int a,int b)
    {
        if (a == b)
        {
            return a * 3;
        }
        else 
        {
            return a + b;
        }
    }
    static void Main()
    {
        int i; int j;
        Console.Write("Enter Num1 : ");
        i = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Num2 : ");
        j = Convert.ToInt32(Console.ReadLine());
     
        Console.WriteLine("One is negative and one is positive : "+nagativePositive(i,j));
    }
}