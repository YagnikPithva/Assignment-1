using System;

class Program29
{
    static void show(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i] + " ");
        }
    }
    static void Main(string[] args)
    {
        int[] array_1 = new int[] { 1, 3, -5, 4 };
        int[] array_2 = new int[] { 1, 4, -5, -2 };

        int[] multiplied_arrray = new int[4];

        for (int i = 0; i < array_1.Length; i++)
        {
            multiplied_arrray[i] = array_1[i] * array_2[i];
        }

        show(multiplied_arrray);
    }
}
