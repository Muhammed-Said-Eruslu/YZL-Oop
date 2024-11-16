using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_OOP_StaticLab
{
    public static class InventoryManagerLab
    {
        public static List<Product> products = new List<Product>();

        public static void AppProduct()
        {
            foreach (Product product in products)
            {
                product.DisplayProductInfo();
            }
        }
    }
}
