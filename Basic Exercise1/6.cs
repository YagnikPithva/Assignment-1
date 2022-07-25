using System;

class First {
    static void Main() {
        int a; int b; int c;
        Console.Write("Input Num 1 : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Num 2 : ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Num 3 : ");
        c = Convert.ToInt32(Console.ReadLine());
        a = b * c;

        Console.WriteLine("Multiplication : "+a);

    }
}