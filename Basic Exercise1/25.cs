using System;
class First {
    static void Main() {
        int num;
        Console.Write("Enter Num : ");
        num = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine("Sum Of Given Numbers : "+sum);
    }
}