using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// רשומה למבצע של מוצר
    /// </summary>
    /// <param name="SaleId">מס' מזהה של המבצע</param>
    /// <param name="QuantityToSale">כמות למבצע</param>
    /// <param name="Price">מחיר</param>
    /// <param name="ForAllCustomers">מיועד לכל הלקוחות?</param>
    public class SaleInProduct
    {
        public int SaleId { get; set; }
        public int QuantityToSale { get; set; }
        public double Price { get; set; }
        public bool ForAllCustomers { get; set; }

        public override string ToString() => this.ToStringProperty();
    }
}
