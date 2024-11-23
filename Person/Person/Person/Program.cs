using System;
class Person
{
    int age;
    public string name;
    
    public void sayHi()
    {
        Console.WriteLine("Hi");
    }
    public static void Main(string[] args)
    {
        Person p = new Person();
        p.sayHi();
        p.name = "Kashmitha";
        Console.WriteLine(p.name);
    }

}