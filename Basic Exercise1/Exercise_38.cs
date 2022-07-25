using System;

public class Code
{

    static int count(int[] arr, int value)
    {
        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                count++;
            }
        }

        return count;
    }

    static void Main(string[] args)
    {
        int number;
        int[] given_arr = new int[] { 1, 2, 3, 1, 5, 6, 1, 2 };

        Console.Write("Enter Number You Want to Count : ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Number of {0} Present in the said array {1} Times.", number, count(given_arr, number));
    }
}