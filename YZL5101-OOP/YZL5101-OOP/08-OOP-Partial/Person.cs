using System;

namespace _08_OOP_Partial;

public class Person
{
    public int ID { get; set; }
    public string Name { get; set; }

    public Person(int id, string name)
    {
        ID = id;
        Name = name;
    }
    void Display()
    {
        Console.WriteLine("Ekrana Yaz");
    }
}
