/* 
    ısı ayarı
    marka 
    fiyat
    garantiTarihi
    garantisiVarMı
    BuharlıMı
    üretimTarihi
    suHaznesi
    Güç
    KazanlıMı
    Renk
    Model
    Stok
    Seri Numarası
     */

using _04_OOP_LAB;

Ütü tefal = new Ütü("Tefal-34A",true);

// new Utu(); // Default constructor ezıldı kullanamayız

tefal.SuOranı = 6000;
tefal.Derece = 20;

for(int i = 0; i < 10; i++)
{
    Thread.Sleep(2000); // döngüyü 2 saniye bekletir

    if(!tefal.Isın())
    {
        break;
    }
}

