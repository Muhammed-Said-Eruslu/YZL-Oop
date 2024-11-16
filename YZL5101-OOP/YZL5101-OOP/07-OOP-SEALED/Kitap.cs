using System;

namespace _07_OOP_SEALED;

// Türüyen Sınıf: Derived Class
// Kitap sınıfı mühürlendi artık kimse ondan miras alamaz.TÜretilemez
public sealed class Kitap : BaseKitap
{
    public string KitapAdı { get; set; }
    public string KitapTÜrü { get; set; }
    public string ISBNO { get; set; }
    public string YazarAdı { get; set; }

    public override void GetLog() // burda override edılıyor nedeni atası
    // yani base vırtual olarak işaretlei değiştirmesine izin verdi
    // değiştirip değiştirmemek bu sınıfa kaldı
    {
        Console.WriteLine("Kitap Class'ından kayıt getiriliyor");
    }
    public override void GetUser()
    {
        Console.WriteLine("Kitap Class'ından Kullanıcı Getiriliyor");
    }
}
