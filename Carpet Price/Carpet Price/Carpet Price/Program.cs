using System;
class Carpet
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the length of room: ");
        int len = int.Parse(Console.ReadLine());
        Console.Write("Enter the width of room: ");
        int wid = int.Parse(Console.ReadLine());

        const int pricePerInch = 250;
        int totalPrice = pricePerInch * len * wid; 
        Console.WriteLine("Total price for room carpet is " + totalPrice);
    }
}