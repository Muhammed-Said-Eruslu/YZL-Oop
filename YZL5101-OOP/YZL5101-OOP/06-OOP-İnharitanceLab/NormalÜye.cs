using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_OOP_İnharitanceLab
{
    internal class NormalÜye : Üye
    {
        public string kılo;
        public NormalÜye()
        {
            Console.WriteLine("Parametresiz Normal Üye Ana Yapıcı");
        }
        public NormalÜye(int ıd, string ad, DateTime tarih, int aylık) : base(ıd, ad, tarih)
        {
            Console.WriteLine("4 Parametreli Normal Üye Ana Yapıcı");
            aylıkUcret = aylık;

        }
        public override int AidatHesapla()
        {
            return base.AidatHesapla() + aylıkUcret * 12;
        }
    }
}
