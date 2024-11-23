using System;
class GPA
{
    public static void Main(string[] args)
    {
        string name = "Kashmitha Madushan";

        string sub1 = "Science";
        string sub2 = "Math";
        string sub3 = "ICT";

        int sub1Grade = 4;
        int sub2Grade = 4;
        int sub3Grade = 3;

        int sub1Credit = 2;
        int sub2Credit = 1;
        int sub3Credit = 4;

        int totalSub1Grade = sub1Grade * sub1Credit;
        int totalSub2Grade = sub2Grade * sub2Credit;
        int totalSub3Grade = sub3Grade * sub3Credit;

        int totalGrade = totalSub1Grade + totalSub2Grade + totalSub3Grade;
        int totalCredit = sub1Credit + sub2Credit + sub3Credit;

        decimal GPA = (decimal)totalGrade / totalCredit;
        //3.4285
        int leadDigit = (int)GPA;
        int firstTwoDigit = (int)(GPA * 1000) % 1000;  

        Console.WriteLine(name);
        Console.WriteLine($"Your GPA is: {leadDigit}.{firstTwoDigit}");

    }
}