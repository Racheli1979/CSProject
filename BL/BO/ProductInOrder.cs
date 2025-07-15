using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// רשומה להכנסת מוצר להזמנה
    /// </summary>
    /// <param name="IdProduct">מס' מזהה של המוצר</param>
    /// <param name="NameOfProduct">שם מוצר</param>
    /// <param name="BasePriceOfProduct">מחיר בסיסי של מוצר</param>
    /// <param name="OrderQuantity">כמות מוצרים להזמנה</param>
    /// <param name="SalesList">רשימת מבצעים למוצר זה</param>
    /// <param name="FinalPriceOfProduct">מחיר סופי</param>
    public class ProductInOrder
    {
        public int IdProduct { get; set; }
        public string NameOfProduct { get; set; }
        public double BasePriceOfProduct { get; set; }
        public int OrderQuantity { get; set; }
        public List<BO.SaleInProduct> SalesList { get; set; }
        public double FinalPriceOfProduct { get; set; }

        public override string ToString() => this.ToStringProperty();
    }
}
