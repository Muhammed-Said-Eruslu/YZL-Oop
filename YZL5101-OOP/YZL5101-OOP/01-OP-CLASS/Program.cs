using _01_OP_CLASS;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
          //  Person person = new Person(); // Nesne oluşturma

            /*said.Name = "Said";
            said.SurName = "Eruslu";
            said.Age = 19;
            said.Id = 1;

            Person muhammed = new Person();

            muhammed.Name = "Muhammed";
            muhammed.SurName = "Eruslu";
            muhammed.Age = 19;
            muhammed.Id = 2;

            Console.WriteLine($"{said.Name}  {said.SurName}");
            Console.WriteLine($"{muhammed.Name}  {muhammed.SurName}");
            */

            /* person.Name = "Said";
             person.Age = 19;*/

            //Person burhan = new Person() {Name = "Burhan", Surname = "Baltacı", Age = 30 };
            //Person irem = new Person() { Name = "İrem", Surname = "Akay", Age = 25 };
            //Person sude = new Person() { Name = "Sude", Surname = "Kılıç", Age = 24 };

            //List<Person> list = new List<Person>
            //{
            //    burhan,
            //    irem,
            //    sude,
            //};



            //person.Age = 19;
            //person.Name = "Muhammed Said";
            //person.Surname = "eruslu";
            //Console.WriteLine($"{person.Age}");
            //Console.WriteLine($"{person.Name}");
            //Console.WriteLine($"{person.Surname}");

            //foreach (Person person1 in list)
            //{
            //    Console.WriteLine($"{person1.Name} {person1.Surname} {person1.Age}");
            //}


            #region Örnek
            // Kullanıcı personeller tanımlayacak ve bu bilgiler list içinde tutulacak


            


            List<Person> list = new List<Person>();
           
            bool kontrol = true;
            while (kontrol)
            {
                Person person = new Person(); // dongu her dondukce yeni bir nesne olusturur

                Console.WriteLine("İsim giriniz:");
                person.Name = Console.ReadLine();

                Console.WriteLine("Soyad giriniz:");
                person.Surname = Console.ReadLine();

                Console.WriteLine("Yaş giriniz:");
                person.Age = int.Parse(Console.ReadLine());

                list.Add(person);

                foreach (var item in list)
                {
                   
                        Console.WriteLine($"Girilen İsim{item.Name} Girilen Soyad{item.Surname} Girilen Yaş{item.Age}");
                    
                }
                Console.WriteLine("Yeni bilgi eklemek ister misiniz? (Y/N)");
                string secim = Console.ReadLine();
                if(secim != "Y")
                {
                    kontrol = false;
                }
               
            }
          

           /* do
            {
                Person person = new Person();
                Console.WriteLine("Lütfen İsim Giriniz");
                person.Name = Console.ReadLine();
                Console.WriteLine("Lütfen Soyisim Giriniz");
                person.Surname = Console.ReadLine();
                Console.WriteLine("Lütfen Yaşınızı Giriniz");
                person.Age = int.Parse(Console.ReadLine());

                list.Add(person);
            }while(Console.ReadLine() != "X");

            foreach(Person person in list)
            {
                Console.WriteLine($"{person.Name} {person.Surname} {person.Age}");
            }*/





            #endregion
        }
    }
}