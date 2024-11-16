using _06_OOP_İnharitanceLab;

NormalÜye normalÜye1 = new NormalÜye(1, "Fatih", new DateTime(2024, 5, 1), 5000);
NormalÜye normalÜye2 = new NormalÜye(2, "Zafer", new DateTime(2024, 9, 10), 6000);

VipUye vipUye1 = new VipUye(3, "Said", new DateTime(2024, 3, 10), 6000);
VipUye vipUye2 = new VipUye(4, "Muhammed", new DateTime(2024, 3, 9), 5000);
VipUye vipUye3 = new VipUye(5, "Said", new DateTime(2024, 3, 10), 5500);

List<Üye> list = new List<Üye>();

list.Add(normalÜye1);
list.Add(normalÜye2);
list.Add(vipUye1);
list.Add(vipUye2);
list.Add(vipUye3);

foreach (Üye uye in list)
{
    Console.WriteLine(uye.ToString()); // üyenin to sting metodu çalışcak 
    Console.WriteLine(uye.AidatHesapla());
}