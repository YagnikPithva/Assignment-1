using System;

class Program27
{ 
    public static void Main()
    {
        var path = @"D:\YY\DEMO\DEMO.sln";
        long length = new System.IO.FileInfo(path).Length;
        System.Console.WriteLine("Lenghth Of files in Bytes = "+length);
    }
}