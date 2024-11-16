using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_OOP_Constructor
{
    internal class Car
    {
        // Consturctor (yapıcı metot) bir sınıfın istance'nın alındığı anda  calısacak metot
        // Main metoduna benzetilir.Genellikle bir sınfın özellıklerı / alanlarını nesne oluşturma esnasında calıştırmak için kullanılır
        // Default constructor eğer bir değişiklik yapılmıcaksa kullanılır.Kodun içinde gormesekte orada vardır

        //public Car() { } // default yapıcı metot


        public Car(string brand)  // ctor u cağırırken parametreye gore cağrılır 1 girdğim zaman bunu çağırır
        {
            Brand = brand;
        }
        public Car(string brand, string model) // 2 parametre girersem bunu
        {
            Brand = brand;
            Model = model;
        }

        public Car(string brand, string model,int engine) // 3 parametre girersem bunu çağırır   
        {
            Brand = brand;
            Model = model;
            Engine = engine;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int Engine { get; set; }
    }
}
