using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";  //gerçek hayatta Textbox dan gelen veri alınır tbx.Text olur
            product1.UnitPrice = 500;
            product1.UnitStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            //PascalCase    //camelCase
            //case sensitive  -- büyük küçük harf duyarlı
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);



            /*
            productManager.Topla2(3, 8);
            int IslemSonucu = productManager.Topla(3, 8);
            Console.WriteLine(IslemSonucu*2);
            */


        }
    }
}
