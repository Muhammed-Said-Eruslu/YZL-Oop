using System;

namespace _14_OOP_Static;

public static class Loger
{
    // static class
    // Eğer nesneye bağımlı işlemler gerçekleştirmıyorsanız amaç sadece
    // belirli bir duruma hizmet eden birden fazla öğeyi bir araya toplamak
    // ise static sınıf tercih edilebilir.Instance almadan tüm oğeleri
    // kullanılabilir
    // static sınıflar içlerinde sadece static uyeler barındırabilirler
    // kalıtım alamazlar
    // static classlar program başladığında depolanmaya başlar
    // ramin heap bolgesinde tutulur

    public static void Log(string message)
    {
        Console.WriteLine(message);
    }
}
