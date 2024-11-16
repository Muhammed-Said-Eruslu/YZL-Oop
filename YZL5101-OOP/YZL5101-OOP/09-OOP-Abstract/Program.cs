// Abstract Class'lar sadece base class olarak davranamasını (Yani instance çıkartılmamasını)
// istediğmiz durumlarda kullanılır

/*

Abstract Metotlar (Abstrat meototlar tanımlanırken asağıdakı kurallara dıkkat edilmelidir)

- Abstract bir metot privte olarak tanımlanamaz.cunku privete metotlar miras alınan
sınıflarda implement edilemezler bu da abstract yapısına ters düşer
- Abstarct metotlar sadece abstrack sınıfların içinde tanımlanabilirler
- Abstract metotlar virtual olarak tanımlanamazlar. Her abstract class virtual'dır
- Abstract static olarak tanımlanamazlar

*/

namespace _09_OOP_AbstractClass // bir namespacein altında birden fazla class tanımlaya bilirim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //YeniClass yeniClass = new YeniClass(); abstract class yada
            // ınterface nın nesnesi olusturlamaz
            // abstarct bır sınıfın nesnesi olusturalamaz
            // abstarct olmıyan bir sınıfın ıcıne abstarct metot tanımlayamayız
            // abstarct bir sınıfın boddysını yazmayız
            // bir sınıf abstarct bir sınıftan mıras alıyorsa onu override etmek zorundayız

        }
        public abstract class YeniClass
        {
            public string mesaj = "Merhaba Dünya";
            public string Mesaj { get; set; }
            // Abstract class'ın en onemlı özelliği içersinde abstract olan veya olmıyan metotlar barındıra bilir
            // Abstract bir metodun kalıtım alan sınıf içersinde impelemnt edilmesi zorunludur

            public void MesajYaz()
            {
                Console.WriteLine(mesaj);
            }
            public abstract void MesajYazAbstract(); // Abstract metodun boddy'si olmaz

        }
        // YeniClass : Base Class
        // SınıfA : Derived Class
        public class SınıfA : YeniClass // base classında kı metodu override etmek zorunda yoksa hata alır
        {
            public override void MesajYazAbstract() // override etiiğim için hata kalktı
            {
                Console.WriteLine("Merhaba Sınıf A");
            }
        }
        public class SınıfB : YeniClass
        {
            public override void MesajYazAbstract()
            {
                Console.WriteLine("Merhaba Sınıf B");
            }
        }
    }

}
