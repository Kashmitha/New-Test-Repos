//Find factorial using for loop
/*using System;
public class Factorial
{
    public static void Main(string[] args)
    {
        int factorial = 1;
        string x = Console.ReadLine();
        int factNum = Convert.ToInt32(x);

        for (int i = 1; i <= factNum; i++)
        {
            factorial *= i;
        }
        Console.WriteLine(factorial);
    }
}*/

//find factorial using while loop
/*using System;
class Factorial
{
    static void Main(string[] args)
    {
        int factorial = 1;
        string x = Console.ReadLine();
        int num = Convert.ToInt32(x);

        int i = 1;

        while(i <= num)
        {
            factorial *= i;
            i++;
        }
        Console.WriteLine($"Factorial of {num} is {factorial}");
    }
}*/

//find factorial using do-while loop
using System;
