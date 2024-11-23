using System;
class minToHour
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the minutes amount: ");
        int minutes = int.Parse(Console.ReadLine());

        int hour = (int)minutes / 60;
        int leftMins = (int)minutes % 60;

        Console.WriteLine("{0} minutes equal to {1} hour and {2} minutes",minutes,hour, leftMins);
    }
}