using System;

class First {
    static void Main() {
        int a;
        Console.Write("Enter Number: ");
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(a + " " + a + " " + a + " " + a);
            Console.WriteLine(a + "" + a + "" + a + "" + a);
        }
    }
}