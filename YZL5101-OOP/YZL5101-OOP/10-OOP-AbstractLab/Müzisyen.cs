using System;

namespace _10_OOP_AbstractLab;

public class Müzisyen
{
    public string Adı { get; set; }
    public string SoyAdı { get; set; }
    public MüzikAleti müzikAleti { get; set; }
    public IList<MüzikAleti> müzikAletis { get; set; } // ILıst belirli türdeki öğeleri saklamak ıcın kullanıır
    // listten temel farkı budur
}
