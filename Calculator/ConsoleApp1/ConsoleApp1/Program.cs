using System;
class Calc
{
    public static void Main(string[] args)
    {
        string name = "Kashmitha Madushan";

        string sub1 = "Science";
        string sub2 = "Maths";
        string sub3 = "ICT";

        int sub1Grade = 4; 
        int sub2Grade = 3;
        int sub3Grade = 3;

        int sub1Credit = 3;
        int sub2Credit = 3;
        int sub3Credit = 4;

        int totalSub1Grade = sub1Grade * sub1Credit;
        int totalSub2Grade = sub2Grade * sub2Credit;
        int totalSub3Grade = sub3Grade * sub3Credit;

        int totalGrade = totalSub1Grade + totalSub2Grade +totalSub3Grade;
        int totalCredit = sub1Credit + sub2Credit + sub3Credit;

        decimal GPA = (decimal)totalGrade / totalCredit;

        Console.WriteLine(name);
        Console.WriteLine(sub1);
        Console.WriteLine(sub2);
        Console.WriteLine(sub3);
        Console.WriteLine(GPA);

    }
}