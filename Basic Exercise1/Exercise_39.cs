using System;

public class Code
{

    static bool checkappears(int[] arr, int value)
    {
        if (arr.Length>0)
        {
            if ((arr[0] == value) || (arr[arr.Length-1] == value))
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int number;
        int[] given_arr = new int[] {25, 8, 4, 9, 5, 10, 30, 45, 57};

        Console.Write("Enter Number You Want to Check : ");
        number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Result : {0}", checkappears(given_arr, number));
    }
}