using System;

class Program28
{
    public static void Main()
    {
        String hex;
        Console.Write("Enter A Hexa Value = ");
        hex = Console.ReadLine();
        int i = Convert.ToInt32(hex, 16);
        Console.WriteLine("HexaDecimal Value of {0} is = {1}",hex,i);
    }
}