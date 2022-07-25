using System;

class First {
    static void Main() {
        int a; int b; int temp;
        Console.Write("Num 1 : ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Num 2 : ");
        b = Convert.ToInt32(Console.ReadLine());
        temp = a;
        a = b;
        b = temp;
        Console.WriteLine("After Swapping...");
        Console.WriteLine("Num 1 : " + a);
        Console.WriteLine("Num 2 : " + b);

    }
}