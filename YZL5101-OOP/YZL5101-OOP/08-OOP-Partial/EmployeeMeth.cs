using System;

namespace _08_OOP_Partial;

public partial class Employee
{
    public Employee(int id, string name)
    {
        ID = id; // bu ID propu burda tanımlı değil ama nasıl kullana bılıyorum
                 // cunku employee propun bir partıalı (parçası) olduğu için kullanabilirim
        Name = name;
    }
    public void Display()
    {
        Console.WriteLine("Ekrana Yaz");
    }
}
