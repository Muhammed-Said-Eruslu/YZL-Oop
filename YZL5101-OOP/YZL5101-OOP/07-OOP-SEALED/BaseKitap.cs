using System;

namespace _07_OOP_SEALED;

public class BaseKitap
{
    public int Id { get; set; } // bu bir prop
    public DateTime CreatedDate { get; set; }
    public DateTime UpdateDate { get; set; }
    public DateTime DEletedDate { get; set; }

    public virtual void GetLog() // virtual olarak işaretlediğim zaman
    // ezilmesine yani override edilmesine izin veririm
    // alt sınıf bunu override ederek değiştire bilir
    {
        Console.WriteLine("Log Kayıt Başladı");
    }
    public virtual void GetUser()
    {
        Console.WriteLine("Kullanıcı Bilgileri Getiriliyor");
    }
}
