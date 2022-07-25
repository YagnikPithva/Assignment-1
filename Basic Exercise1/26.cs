using System;

class Program26{
    static void Main() 
    {
        String s;
        Console.Write("Enter String = ");
        s = Console.ReadLine();

        String[] a = s.Split(' ');
        Console.WriteLine("REVERSE OF STRING  ");
        for(int i = a.Length-1 ; i >= 0 ; i--)   
        {
            Console.Write(a[i]+" ");
        }
        Console.WriteLine();
    }
}