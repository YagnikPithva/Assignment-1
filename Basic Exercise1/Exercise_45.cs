using System;

public class Code
{

    static bool checkOdd(int[] arr1)
    {
        for (int i = 0; i < arr1.Length; i++)
        {
            if (arr1[i]%2 == 0)
            {
                return true;
            }
        }

        return false;
    }

    static void Main(string[] args)
    {
        int[] given_arr1 = new int[] { 1, 3, 2, 7, 9};

        Console.WriteLine("Contains Odd Number : " + checkOdd(given_arr1));
    }
}