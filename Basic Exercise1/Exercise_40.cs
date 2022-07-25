using System;

public class Code
{

    static int sumOfArray(int[] arr)
    {
        int sum = 0;    
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        return sum;
    }

    static void Main(string[] args)
    {
        int[] given_arr = new int[] { 1, 2, 3, 4, 5 };
        Console.WriteLine("Sum Of Array is : {0}", sumOfArray(given_arr));
    }
}