using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering.Util
{
    public class Product
    {
        //Jedinstveni identifikator proizvoda - ID
        public int ProductId { get; set; }

        //Naziv proizvoda (artikla)
        public string ProductName { get; set; }

        //Kolekcija kojoj proizvod pripada:
        //      1 - proizvod pripada kolekciji Jesen - Zima
        //      2 - proizvod pripada kolekciji Prolece - Leto
        //Ukoliko proizvod ima neku drugu oznaku za kolekciju (razlicitu od 1 ili 2), smatra se kao nevalidan u sistemu
        public int Collection { get; set; }

        //Cena proizvoda iskazana u dinarskoj vrednosti
        public double ProductPrice { get; set; }

        public Product()
        {

        }

        public Product(int productId, string productName, int collection, int productPrice)
        {
            ProductId = productId;
            ProductName = productName;
            Collection = collection;
            ProductPrice = productPrice;
        }
    }
}
