using System;

public class Code
{
    static void Main(string[] args)
    {
        string str = "PHP Tutorial";
        if(str.Substring(1, 2).Equals("HP"))
        {
            str = str.Remove(1, 2);
        }
        Console.WriteLine("String : "+ str);
    }
}