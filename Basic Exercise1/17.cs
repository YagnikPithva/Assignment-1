using System;
class First
{
    static bool nagativePositive(int a,int b)
    {
        if( a < 0 && b > 0 || a > 0 && b < 0)
        {
            return true;       
        }        
        return false;
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