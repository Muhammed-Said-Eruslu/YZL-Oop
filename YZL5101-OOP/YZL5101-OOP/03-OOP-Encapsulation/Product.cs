using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_OOP_Encapsulation
{
    internal class Product
    {
        // fields
        private int id;
        private string name;
        private int stock;
        private double price;
        private bool status;

        // ctor
        public Product()
        {

        }
        public Product(int id, string name, int stock)
        {
            this.id = id; // bu sayfada bu filed var dışardan gelen parametredeki id ye atıyorum
            this.name = name;
            this.stock = stock;
            StockControl(stock);
        }
        // Property

        public string ID
        {
            get
            {
                return "BLG-" + id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            private set
            {
                name = value.ToUpper();
            }
        }
        public int Stock
        {
            get
            {
                return stock;
            }
            set
            {
                if (value >= 0)
                {
                    stock = value;
                }
                else
                {
                    throw new Exception("Stock Sıfırdan Küçük Olamaz");
                }
            }
        }
        public double Price
        {
            get
            {
                return price * 1.2;
            }
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
                else
                {
                    throw new Exception("Fiyat sıfırdan küçük olamaz");
                }
            }
        }
        public bool Status
        {
            get
            {
                return status;
            }
           private set
            {
                status = value;
            }
        }
        // only write
        public string Desctiption { private get; set; }

       public string GetProduct()
        {
            return $"Ürün No: {id} Adı: {name} Fiyat: {Price} (KDV DAHİL STOCK) Stock: {stock} Satıla Bilir mi {status}";
        }
        public void SellProduct(int quantity)
        {
            Stock = Stock - quantity;

            StockControl(stock);

            Console.WriteLine($"İstenilen Miktar: {Price} \nToplam Fiyat:{quantity * Price} \n------------------\nKalan Stock: {Stock}");
        }

        private void StockControl(int stock)
        {
            status = stock > 0;
        }
    }
}
