using System;

public class Code
{
    static int nearestTo20(int fnum, int snum)
    {
        if(fnum == snum)
        {
            return 0;
        }
        else
        {
            if((20 - fnum)>((20 - snum)))
            {
                return snum;
            }
            else
            {
                return fnum;
            }
        }
    }
    static void Main(string[] args)
    {
        int first_num, second_num;

        Console.Write("Enter First Number : ");
        first_num = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Second Number : ");
        second_num = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Nearest Number to 20(if 0 than both number are same) : {0}", nearestTo20(first_num, second_num));
    }
}