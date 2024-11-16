using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_İnharitanceLab
{
    internal class Üye
    {
        private int uyeID; // field 
        private string uyeAdi;
        private DateTime uyeTarıhı;
        protected  int aylıkUcret;

        public Üye() // yapıcı metot bunu tanımlamasam bile default halınde var 
        {
            Console.WriteLine("Parametresiz Ana Yapıcı");
        }
        public Üye(int uyeID,string uyeAdı,DateTime uyelıkTarıhı) // parametreli yapıcı metot
        {
            Console.WriteLine("3 Parametreli Ana Yapıcı");
            this.uyeID = uyeID; // private olan fieldıma gelen parametreyi atadım
            this.uyeAdi = uyeAdı; // this bu demek bu sınıfın uyeAdi olan field uyeAdı olan parametreden gelen değer  yani uyeAdi buna ulaşamam ama parametre alarak ulaşmasını sağlarım
            this.uyeTarıhı = uyelıkTarıhı;
        }
        public override string ToString() // override etmezsen ekrana yazmaz namespace yazar ekrana
        {
            return $"\nÜye Adı: {uyeAdi} \nÜye ID {uyeID}\nÜye Kayıt Tarihi {uyeTarıhı}\nAylık Ücret:{aylıkUcret}";
        }
        public virtual int AidatHesapla()
        {
            return 1000;
        }
    }
}
