using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// רשומה לפרטי הזמנה
    /// </summary>
    /// <param name="IfPreferredCustomer">האם לקוח מועדף? </param>
    /// <param name="ProductsList">רשימת המוצרים בהזמנה </param>
    /// <param name="FinalPrice">המחיר הסופי לתשלום</param>
    public class Order
    {
        public bool IfPreferredCustomer { get; set; }
        public List<ProductInOrder> ProductsList { get; set; }
        public double FinalPrice { get; set; }

        public override string ToString() => this.ToStringProperty();
    }
}
