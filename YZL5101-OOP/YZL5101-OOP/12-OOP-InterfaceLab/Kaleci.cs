using System;

namespace _12_OOP_InterfaceLab;

public class Kaleci : IFutbolcu, IKaleci
{
    public string AdıSoyadı { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int FormaNumarası { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int SutGucu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PasGucu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int KosmaHızı { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool SakatMı { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int Degaj { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Kos()
    {
        throw new NotImplementedException();
    }

    public void PasVer()
    {
        throw new NotImplementedException();
    }

    public void SutCek()
    {
        Console.WriteLine("Kaleci Şut Çekiyor");
    }

    public void TopKurtar()
    {
        throw new NotImplementedException();
    }
}
