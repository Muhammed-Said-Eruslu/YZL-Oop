using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Generic yapılar belirle bir tipe bağlı olmak yerine hergangi bir veri tipiyle çalısabilen sınıfların, interfacelerin,metotların fieldların oluşturulmasını izin verir

// Generic yapılar farklı türlerdeki verilerle çalışabilen kod oluşturmamız gerektiğinde kullanışlıdır
/* 
 Constraint: generic yapılarda tipleri sınırlandırmak için üç anahtar kelıme kullanılır calss,struct ve BaseClass
Class: sadece refarns tiplerin kabul edilmesini güvence altına alır
Struct : sadece value tiplerin kabul edilmesini guvence altına alır
BaseClass : sadece belirli bir temel sınıftan türetilmesini güvence altına alır
 
 */

namespace _16_OOP_Generic
{
    internal class PrintData<T> where T : Person // sadece Persondan değer alabılırm yada person sınıdfından türeyneleri alırım
    {
        public T ID { get; set; }
     public void Print(T data)
        {
            Console.WriteLine("Data"+data);
        }
        public T ValueGet(T data) // metotun parametre geri donuş tipi olarak kulalnabılırım
        {
            return data;
        }
    }
}
