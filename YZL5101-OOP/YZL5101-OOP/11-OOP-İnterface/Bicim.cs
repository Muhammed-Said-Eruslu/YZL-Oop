using System;

namespace _11_OOP_İnterface;

public class Bicim : IBıcım
{
    private int numaram;
    public int Numaram
    {
        get { return numaram; }
        set { numaram = value; }
    }


    public void InterfaceMetot() // Bu imzada ımplement etmem lazım ısmı değişmez
    {
        throw new NotImplementedException();
    }
}
