using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_OOP_LAB
{
    internal class Ütü
    {
        private Guid _id; //  Guid 16 karakterlık sayı rakam olusturur
        private string _name;
        private bool _kazanlıMı;
        private int _derece;
        private int _suOranı;
        private DateTime _garanti;

        public Ütü(string name, bool kazanlıMı)
        {
            _name = name;
            _id = Guid.NewGuid();
            _kazanlıMı = kazanlıMı;
            _derece = 20;
        }


        public DateTime Garanti
        {
            get { return _garanti; }
            private set { _garanti = value; } // swetin private olmasının sebebi dışardan değer atamasını yapılmasını istemediğimiz için
        }

        public int SuOranı
        {
            get { return _suOranı; }
            set
            {
                if (value < 0 && value > 1000)
                {
                    _suOranı = value;
                }
                else
                {
                    Console.WriteLine("Su oranı 0 dan küçük 1000 den büyük olamaz");
                }
            }
        }


        public int Derece
        {
            get { return _derece; }
            set
            {
                if (value > 0 && value < 100)
                {
                    _suOranı = value;
                }
                else
                {
                    Console.WriteLine("0 ile 100 arasında derece veriniz");
                }
            }
        }


        public bool KazanlıMı
        {
            get { return _kazanlıMı; }
            set { _kazanlıMı = value; }
        }



        public string Name
        {
            get { return _name; }
            private set { _name = value; }
        }

        public Guid ID
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
            }
        }
        public bool Isın()
        {
            Derece += 10;
            SuOranı -= 100;

            int sıcaklık = SuKontrol();
            SonDurum();

            //if (sıcaklık < 10)
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}

            return !(sıcaklık < 10);
        }

        private void SonDurum()
        {
            Console.WriteLine($"Isı: {Derece} Su: {SuOranı}");
        }


        private int SuKontrol()
        {
            if (SuOranı < 300 && SuOranı > 100)
            {
                Console.WriteLine("Dıkkat et su azalıyor");
            }
            else if (SuOranı <= 100)
            {
                Console.WriteLine("Su bitti makine kendini kapattı");
                Derece = 5;

            }
            return Derece;
        }
        public void GenelBilgiGöster()
        {
            Console.WriteLine($"Id: {ID} Markası: {Name} Kazanlı Mı {KazanlıMı} Garanti : {Garanti}");
        }
    }
}

