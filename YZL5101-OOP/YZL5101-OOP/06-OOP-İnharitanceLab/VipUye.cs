using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_İnharitanceLab
{
    internal class VipUye : Üye
    {
        public double boy;

        public VipUye()
        {
            Console.WriteLine("Parametresiz VIP Ana Yapıcı");
        }
        public VipUye(int ıd, string ad, DateTime tarih, int aylık) : base(ıd, ad, tarih)
        {
            Console.WriteLine("4 Prametreli VIP Üye Ana Yapıcı Metot");
            aylıkUcret = aylık;
        }
        public override int AidatHesapla()
        {
            return base.AidatHesapla() + (aylıkUcret * 12) + 500;
        }
    }
}
