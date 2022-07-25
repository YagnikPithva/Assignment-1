using System;
class First
{
    static void Main()
    {
        String s;
        Console.Write("Enter String : ");
        s = Console.ReadLine();
        s =  s.Insert(0, "Y");
        s = s.Insert(s.Length, "Y");
        Console.WriteLine("New String : "+s);
    }
}