using System;

class First {
    static void Main() {
        int a; int b; int c; int d;
        Console.Write("Input 1: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input 2: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input 3: ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input 4: ");
        d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Average : " + (a + b + c + d) / 4);
    }
}