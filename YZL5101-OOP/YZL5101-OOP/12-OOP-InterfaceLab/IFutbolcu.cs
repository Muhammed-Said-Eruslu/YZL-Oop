using System;

namespace _12_OOP_InterfaceLab;

public interface IFutbolcu
{
    public string AdıSoyadı { get; set; }
    public int FormaNumarası { get; set; }
    public int SutGucu { get; set; }
    public int PasGucu { get; set; }
    public int KosmaHızı { get; set; }
    public bool SakatMı { get; set; }
    void Kos();
    void SutCek();
    void PasVer();
}
