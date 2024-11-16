using _12_OOP_InterfaceLab;

Futbolcu futbolcu = new Futbolcu()
{

};
Kaleci kaleci = new Kaleci();

Futbolcu forvet = new Futbolcu();

List<IFutbolcu> takım = new List<IFutbolcu>();
takım.Add(forvet);
takım.Add(kaleci);


foreach (IFutbolcu oyuncu in takım)
{
    oyuncu.PasVer();
    oyuncu.SutCek();
}

