using System;
class First
{
    static bool nagativePositive(int a)
    {
        if ( a - 100 <= 20 )
        {
            return true;
        }
        return false;
    }
    static void Main()
    {
        int i; 
        Console.Write("Enter Num1 : ");
        i = Convert.ToInt32(Console.ReadLine());
       
        Console.WriteLine(i+" - 100 <= 20 ? = "+nagativePositive(i));
    }
}