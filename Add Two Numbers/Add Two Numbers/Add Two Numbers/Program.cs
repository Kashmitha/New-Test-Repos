using System;
class Add
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number One: ");
        int Num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter Number Two: ");
        int Num2 = int.Parse(Console.ReadLine());

        int sum = Num1 + Num2;
        Console.WriteLine("Sum of {0} and {1} is = {2}",Num1,Num2,sum);
    }
}
