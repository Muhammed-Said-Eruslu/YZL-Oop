using System;

namespace _12_OOP_InterfaceLab;

public class Futbolcu : IFutbolcu
{
    public string AdıSoyadı { get; set; }
    public string FormaNumarası { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int SutGucu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int PasGucu { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public int KosmaHızı { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public bool SakatMı { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    int IFutbolcu.FormaNumarası { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public void Kos()
    {
        throw new NotImplementedException();
    }

    public void PasVer()
    {
        Console.WriteLine("Futbolcu Pas Veriyor");
    }

    public void SutCek()
    {
        if (SutGucu > 70)
        {
            Console.WriteLine("Gol Olur");
        }
        else
        {
            Console.WriteLine("Taç Olur");
        }
    }
}


