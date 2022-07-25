using System;

class First {
    static void Main() {
        int a; int b; 
        Console.Write("Input : ");
        a = Convert.ToInt32(Console.ReadLine());

        for (b = 1; b <= 10; b++)
        {
            Console.WriteLine(a + " " + b + " " + (a * b));
        }

    }
}