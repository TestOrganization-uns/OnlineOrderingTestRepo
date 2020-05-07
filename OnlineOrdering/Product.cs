using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineOrdering
{
    public class Product
    {
        public int productId;

        public double value;

        public Product()
        {

        }

        public Product(int productId, double value)
        {
            this.productId = productId;
            this.value = value;
        }
    }
}
