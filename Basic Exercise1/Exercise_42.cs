using System;

public class Code
{

    static int[] rotateArray(int[] arr1)
    {
        int temp = arr1[0];

        for (int i = 0; i < arr1.Length - 1; i++)
        {
            arr1[i] = arr1[i + 1];
        }

        arr1[arr1.Length - 1] = temp;
        return arr1;
    }

    static void show(int[] arr)
    {
        Console.Write("Array : "); 
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+" ");
        }

        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        int[] given_arr1 = new int[] { 1, 2, 3, 4 };

        rotateArray(given_arr1);
        show(given_arr1);
    }
}