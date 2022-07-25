using System;

class First {
    static void Main() {
        int a; int b; int c; 
        Console.Write("Input 1: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input 2: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input 3: ");
        c = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("(A + B)*C : " + (a + b) * c);
        Console.WriteLine("(A * B)+(B * C) : " + ((a * b) + (b * c)));
    }
}