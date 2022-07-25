using System;

class First {
    static void Main() {
        int a; int b; int c;
        Console.Write("Input Num 1 : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Num 2 : ");
        b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Addition : " + a + b);
        Console.WriteLine("Multiplication : " + a * b);
        Console.WriteLine("Division : " + a / b);
        Console.WriteLine("Substraction : " + (a - b));
        Console.WriteLine("Mod : " + a % b);

    }
}