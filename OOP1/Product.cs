using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    //snippet prop yazınca altında nokta varsa hazır kodlar oluyor.
    //product=ürün demek
    class Product
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        //ürünün hangi kategoriye ait dahil olduğu ıd  
        public string ProductName { get; set; }
        //ürün ismi
        public double UnitPrice { get; set; }
        //ürünün birim fiyatı
        public int UnitsInStock { get; set; }
        //ürünün stok adedi
    }
}
