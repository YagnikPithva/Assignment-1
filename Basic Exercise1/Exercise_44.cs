using System;

public class Code
{

    static void createArray(int[] arr1, int[] arr2, int[] arr3)
    {
        int[] newArr;
        if (arr1.Length > 0 || arr2.Length > 0 || arr3.Length > 0)
        {
            newArr = new int[] { arr1[1], arr2[1], arr3[1] };

            show(newArr);
        }
    }

    static void show(int[] arr)
    {
        Console.Write("New Created Array is : ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+ " ");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] given_arr1 = new int[] { 1, 2, 5 };
        int[] given_arr2 = new int[] { 0, 3, 8 };
        int[] given_arr3 = new int[] { -1, 0, 2 };

        createArray(given_arr1, given_arr2, given_arr3);
    }
}