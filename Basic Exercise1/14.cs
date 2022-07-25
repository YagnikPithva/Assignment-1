using System;

class First {
    static void Main() {
        int a; int b;
        Console.Write("Enter Celcious To Convert In Feranhit & Kelvin : ");
        a = Convert.ToInt32(Console.ReadLine());
        b = a;
        Console.WriteLine("Feranhit : " + ((a * 1.8) + 32));
        Console.WriteLine("Kelvin : " + (b+273.75));
        
    }
}