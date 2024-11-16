using _16_OOP_Generic;

//PrintData<int> printData = new PrintData<int>();
//printData.Print(5);

//PrintData<double> printData1 = new PrintData<double>();
//printData1.Print(5);

//PrintData<string> printData2 = new PrintData<string>();
//printData2.Print("Hello");

//PrintData<DateTime> printData3 = new PrintData<DateTime>();
//printData3.Print(DateTime.Now);

PrintData<Person> printData4  = new PrintData<Person>();
printData4.Print(new Person());

PrintData<Memur> printData5 = new PrintData<Memur>();

KeyValuePair<double, string, string> pair = new KeyValuePair<double, string, string>();

pair.Name = "Said";
pair.BirthDate = DateTime.Now;
pair.ID = 1.0;
pair.Get("");
KeyValuePair<Guid, string, bool> pair2 = new KeyValuePair<Guid, string, bool>();
pair2.Name = "Said";
pair2.BirthDate = DateTime.Now;
pair2.ID = Guid.NewGuid();
pair2.Get(true);

EkranaYaz<string>("");
EkranaYaz<int>(10);
EkranaYaz<bool>(true);


static void EkranaYaz<T>(T data)
{
    Console.WriteLine(data);
}