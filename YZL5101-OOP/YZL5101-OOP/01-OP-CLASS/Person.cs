using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_OP_CLASS
{
    // Basitçe tanımlamak gerekirse Class(sınıf), nesneleri oluşturmak için kullanılan şablonlardır
    // Sınıf - Class
    // Nesne - Object
    internal class Person
    {
        // Üyeler
        // Temel olarak Constructor (Yapıcı metotlar), Fields (Alanlar), Properties (Özellikler)
        // Constructor (Yapıcı Metot)
        // Fields (Alanlar)
        // Methods (Metotlar)
        // Event, Delegate ve Struct

        // Default Constructor Method
        // Person () {}

        // public int Id;

        // public string Name; // internal aynı namespace içindeyse ulaşa bilirim

        // public string SurName; // protected türetildiği zaman kullanılır

        //  public int Age;

        //  private double Salary;

        // Fields 
        private string _name; // alt tre varsa fielddır
        private int _age;
        private string _SurName;

        // Properties 

        //public string Name { get; set; } // gete ve sete erişim belirleyicisi verile bilir getı kaldırırsan hata alıtsın


        #region II.Yontem

        public int Age
        { 
            get
            {
                return _age;
            }
            set
            {
                
                if(value >= 18)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Kullanıcının Yaşı 18'den Küçük Olamaz");
                }
            }
        }
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        public string Surname
        {
            get
            {
                return _SurName;
            }
            set
            {
                _SurName = value.ToUpper();
            }
        }

        #endregion



    }
}