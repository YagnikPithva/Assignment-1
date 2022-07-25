using System;

class First {
    static void Main() {
        int a;
        Console.Write("Enter Number: ");
        a = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < 5; i++) {
            for (int j = 0; j < 5; j++) {
                if (i == 0 || j == 0 || i == 4 || j == 4)
                {
                    Console.Write(a);
                }
                else {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}