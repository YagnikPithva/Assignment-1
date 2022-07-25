using System;

public class Code
{

    static bool arrayEqual(int[] arr1, int[] arr2)
    {
        if (arr1.Length > 0 || arr2.Length > 0)
        {
            if ((arr1[0] == arr2[0]) || (arr1[arr1.Length - 1] == arr2[arr2.Length - 1]))
            {
                return true;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int[] given_arr1 = new int[] { 25, 8, 4, 9, 5, 10, 30, 45, 57 };
        int[] given_arr2 = new int[] { 25, 1, 2, 3, 4, 5, 6, 7, 8, 45 };

        Console.WriteLine("Result : {0}", arrayEqual(given_arr1, given_arr2));
    }
}