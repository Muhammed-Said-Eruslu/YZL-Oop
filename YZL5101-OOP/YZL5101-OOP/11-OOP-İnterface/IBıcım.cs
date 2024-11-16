using System;

namespace _11_OOP_İnterface;

// Interface(arayüz): Bir alt sınıf bir interface'i miras aldığında bu ınterface 
// uygulanmak zorundadır
// Interface bir sözleşmenin maddeleri gibi düşünülebilir
// Kalıtım alan taraf bu sözleşmenin tüm maddelerini uygulamak zorundadır
// Bir sınıf birden fazla ınterface'den kalıtım alabilir
// struct,class,enum,ınterface : Namespace'in içinde bulunur
// Publlic private,protected,internal,protected internal : Class'ta yada öğelerinde bulunur
// static class,abstract class,sealed class,partial class
public interface IBıcım
{
    public int Numaram { get; set; }
    void InterfaceMetot();

    internal void foo()
    {
        Console.WriteLine("Hello");
    }
}
