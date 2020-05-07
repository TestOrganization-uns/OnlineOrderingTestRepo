using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering.Util
{
    public class Order
    {
        //Jedinstveni identifikator porudzbine - ID
        public int OrderId { get; set; }

        //Lista proizvoda koju porudzbina sadrzi
        public List<Product> Products { get; set; }

        //Ukupna cena porudzbine
        //Cenu porudzbine racunati uz pomoc metode CalculateOrder koju je neophodno implementirati
        public double OrderPrice { get; set; }

        public Order()
        {

        }

        public Order(int orderId, List<Product> products)
        {
            OrderId = orderId;
            Products = products;
        }
    }
}
