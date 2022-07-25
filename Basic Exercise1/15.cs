using System;

class First {
    static void Main() {
        String a;
        Console.Write("Enter String : ");
        a = Console.ReadLine();
        Console.WriteLine(a.Remove(3,1));
        Console.WriteLine(a.Remove(10,1));
    }
}