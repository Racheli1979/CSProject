using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using BO;

namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDAL _dal = DalApi.Factory.Get;

        /// <summary>
        /// הוספת מוצר להזמנה
        /// </summary>
        /// <param name="order">הזמנה שרוצים להוסיף אליה מוצר</param>
        /// <param name="productId">קוד מוצר שרוצים להוסיף</param>
        /// <param name="quantity">כמות מהמוצר שרוצים להוסיף</param>
        /// <returns>מחזירים את רשימת המבצעים שמומשו למוצר זה</returns>
        /// <exception cref="BLNoQuantityInStock">שגיאה אם אין מספיק כמות במלאי</exception>
        public List<SaleInProduct> AddProductToOrder(Order order, int productId, int qantityToOrder)
        {
            DO.Product product = _dal.iProduct.Read(productId);
            BO.ProductInOrder p = null;
            if (order.ProductsList != null)
                p = order.ProductsList.FirstOrDefault(p => p.IdProduct == product._productId);
            if (p == null)
            {
                if (qantityToOrder <= product._quantity)
                {
                    p = new BO.ProductInOrder();
                    p.IdProduct = product._productId;
                    p.NameOfProduct = product._productName;
                    p.BasePriceOfProduct = product._price;
                    p.OrderQuantity = qantityToOrder;
                    order.ProductsList.Add(p);
                }
                else
                {
                    throw new BO.BLNoQuantityInStock("no quantity in stock");
                }
            }
            else
            {
                if (qantityToOrder + p.OrderQuantity <= product._quantity)
                {
                    order.ProductsList.Remove(p);
                    p.OrderQuantity += qantityToOrder;
                    order.ProductsList.Add(p);    
                }
                else
                {
                    throw new BO.BLNoQuantityInStock("no quantity in stock");
                }
            }
            SearchSaleForProduct(p, order.IfPreferredCustomer);
            CalcTotalPriceForProduct(p);
            CalcTotalPrice(order);
            return p.SalesList;
        }

        /// <summary>
        /// חישוב הסכום הסופי לתשלום להזמנה
        /// </summary>
        /// <param name="order">ההזמנה שרוצים לחשב את הסכום</param>
        public void CalcTotalPrice(Order order)
        {
            order.FinalPrice = (from p in order.ProductsList
                                select p.FinalPriceOfProduct).Sum();
        }

        /// <summary>
        /// חישוב המחיר לתשלום עבור מוצר בהזמנה, כולל מימוש מבצעים
        /// </summary>
        /// <param name="product">המוצר שרוצים לחשב את המחיר</param>
        public void CalcTotalPriceForProduct(ProductInOrder product)
        {
            if (product.SalesList == null)
            {
                DO.Product p = _dal.iProduct.Read(product.IdProduct);
                double sum = p._price;
                product.FinalPriceOfProduct = (sum * product.OrderQuantity);
            }
            else
            {
                int count = product.OrderQuantity;
                List<BO.SaleInProduct> UsedSalesList = new();
                foreach (BO.SaleInProduct sale in product.SalesList)
                {
                    if (count < sale.QuantityToSale)
                        continue;
                    else
                    {
                         int howMany = (int)count/sale.QuantityToSale;
                         product.FinalPriceOfProduct += (howMany * sale.Price);
                         count = count - howMany;
                         UsedSalesList.Add(sale);
                        if (count == 0)
                            break;
                    }
                }
                product.FinalPriceOfProduct += (product.BasePriceOfProduct * count);
                product.SalesList = UsedSalesList;
            }
        }

        /// <summary>
        /// DALעבור כל מוצר בהזמנה, מייצרים בקשת עדכון ל 
        ///  כדי להוריד ממלאי המוצר את הכמות שבהזמנה
        /// </summary>
        /// <param name="order">ההזמנה שרוצים לעדכן</param>
        public void DoOrder(Order order)
        {
            foreach (BO.ProductInOrder p in order.ProductsList)
            {
                DO.Product product = _dal.iProduct.Read(p.IdProduct);
                _dal.iProduct.Update(product with { _quantity = product._quantity - p.OrderQuantity });
            }
        }

        /// <summary>
        /// עדכון המבצעים המתאימים למוצר בהזמנה
        /// </summary>
        /// <param name="product">מוצר בהזמנה</param>
        /// <param name="existingCustomer">האם ההזמנה היא ללקוח קיים</param>
        public void SearchSaleForProduct(ProductInOrder product, bool existingCustomer)
        {
            product.SalesList = _dal.iSale.ReadAll(
                sale => product.IdProduct == sale._productId
                && (existingCustomer == true || (existingCustomer == false && sale._forAllCusts == true))
                && DateTime.Now >= sale._startSale && DateTime.Now <= sale._endSale
                && product.OrderQuantity >= sale._amount)
            .Select(s => new BO.SaleInProduct()
            {
                SaleId = s._saleId,
                ForAllCustomers = s._forAllCusts,
                Price = s._salePrice,
                QuantityToSale = s._amount,
            }).ToList();
            product.SalesList.OrderBy(s => s.Price / s.QuantityToSale);
        }
    }
}
