using System;

class Code
{
    static void Main(string[] args)
    {
        string str;
        Console.Write("Input a string : ");
        str = Console.ReadLine();
        Console.WriteLine((str.Length < 6 && str.Equals("Hello")) || (str.StartsWith("Hello") && str[5] == ' '));
    }
}