using System;

public class Code
{

    static int largeValue(int[] arr1)
    {
        if (arr1[0] > arr1[arr1.Length - 1])
        {
            return arr1[0];
        }
        else
        {
            return arr1[arr1.Length - 1];
        }
    }

    static void Main(string[] args)
    {
        int[] given_arr1 = new int[] { 1, 2, 3, 4 };

        Console.WriteLine("Larger Value between first and last values of the said array : {0}", largeValue(given_arr1));
    }
}