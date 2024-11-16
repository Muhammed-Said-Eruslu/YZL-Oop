using _03_OOP_Encapsulation;

Product product = new Product();


/*product.Desctiption = "Kurşun Kalem";
product.Price = 100;
Console.WriteLine(product.GetProduct());*/

Product product1 = new Product(35, "Kalem Kırmızı", 100);
product1.Desctiption = "kurşun Kalem";
product1.Price = 110;

Product product4 = new Product(36, "Defter", 50);
product1.Desctiption = "defter";
product1.Price = 50;
Product product5 = new Product(37, "Çanta", 100);
product1.Desctiption = "çanta";
product1.Price = 300;
Product product6 = new Product(38, "Resim Defteri", 100);
product1.Desctiption = "resim defteri";
product1.Price = 110;
Product product7 = new Product(39, "Test Kitabı", 100);
product1.Desctiption = "test kitabı";
product1.Price = 85;
Product product8 = new Product(40, "silgi", 100);
product1.Desctiption = "kurşun Kalem";
product1.Price = 10;

// Ürünler Listsesi

List<Product> products = new List<Product>();

products.Add(product1);
products.Add(product);
products.Add(product4);
products.Add(product5);
products.Add(product6);
products.Add(product7);
products.Add(product8);

int num = 0;

foreach (Product item in products)
{
    Console.WriteLine($" No: {num} Adı:{item.Name} Fiyatı:{item.Price}");
    num++;
}
Console.WriteLine("Satın almak istediğiniz ürünün numarsını giriniz");
int order = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Alacağın Ürün :");
Console.WriteLine(products[order].GetProduct());

Console.WriteLine("Kaç adet almak ıstıyorsun");

int quantity = Convert.ToInt32(Console.ReadLine());

products[order].SellProduct(quantity);
Console.WriteLine("Ürünün son durumu");
Console.WriteLine(products[order].GetProduct());