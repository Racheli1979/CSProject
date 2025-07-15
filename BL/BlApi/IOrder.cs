using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    /// <summary>
    /// מתודות לניהול הזמנה תוך כדי ביצועה וכן ביצוע ההזמנה הסופי
    /// </summary>
    /// <param name="AddProductToOrder">הוספת מוצר להזמנה</param>
    /// <param name="CalcTotalPriceForProduct">חישוב המחיר הסופי למוצר</param>
    /// <param name="CalcTotalPrice">חישוב המחיר הסופי להזמנה</param>
    /// <param name="DoOrder">ביצוע הזמנה</param>
    /// <param name="SearchSaleForProduct">עדכון המבצעים המתאימים למוצר בהזמנה</param>
    public interface IOrder
    {
        // מחזיר לי האם יש מבצע למוצר לדוגמא 3 ב - או פחות 5 שקל וכו
        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int qantityToOrder);
        public void CalcTotalPriceForProduct(BO.ProductInOrder product);
        public void CalcTotalPrice(BO.Order order);
        public void DoOrder(BO.Order order);
        public void SearchSaleForProduct(BO.ProductInOrder product, bool existingCustomer);
    }
}
