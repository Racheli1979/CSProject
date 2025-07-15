using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// רשומה לפרטי מוצר
    /// </summary>
    /// <param name="ProductId">מספר מזהה</params>
    /// <param name="ProductName">שם מוצר</params>
    /// <param name="Category">קטגוריה</params>
    /// <param name="Price">מחיר</params>
    /// <param name="QuantityInStock">כמות במלאי</params>
    /// <param name="SalesList">רשימת מבצעים למוצר</params>
    public class Product
    {
        public int ProductId { get; init; }
        public string ProductName { get; set; }
        public BO.Categories Category { get; set; }
        public double Price { get; set; }
        public int QuantityInStock { get; set; }
        public BO.SaleInProduct SalesList { get; set; }

        public override string ToString() => this.ToStringProperty();
    }
}
