using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DO
{
    public record Sale(int _saleId, int _productId, int _amount, double _salePrice, bool _forAllCusts, DateTime _startSale, DateTime _endSale)
    {
        public Sale() : this(0, 0, 0, 0.0, false, new DateTime(), new DateTime())
        {

        }
    }
}
