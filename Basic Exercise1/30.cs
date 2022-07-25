using System;

class Program30 { 
    static void Main()
    {
        String s;
        Console.Write("Enter String = ");
        s = Console.ReadLine();
        int len = s.Length-1;
        int len2 = s.Length-4;
        Console.WriteLine(s.Substring(len2, len));

        //for (int i = len; i >= len - 4; i--) {
        //}
    }
}