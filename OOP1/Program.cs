using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };
            //iki türlüde de yazabiliriz product1 deki gibi ve product2 gibi


            //Case sensitive=küçük büyük harfe duyarlı olması demek
            //Pascal Case  //Camel Case
            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.ProductName);





            productManager.Topla2(3, 6);

            int toplamSonucu = productManager.Topla(3, 6);

            Console.WriteLine(toplamSonucu * 2);

        }
    }
}
