using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Product(int _productId, string _productName, Categories _category, double _price, int _quantity)
    {
        public Product() : this(0, null, Categories.ספרי_קודש, 0.0, 0)
        {

        }
    }
}
