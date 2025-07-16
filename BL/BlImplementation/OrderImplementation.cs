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

        // הוספת מוצר להזמנה
        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int qantityToOrder)
        {
            try
            {
                DO.Product productInStock = _dal.iProduct.Read(productId);
                BO.ProductInOrder product;
                product = order.ProductsList.FirstOrDefault<BO.ProductInOrder>(p => p.IdProduct == productId);

                if (product == null)
                {
                    product = new BO.ProductInOrder(productId, productInStock._productName, productInStock._price, 0);
                    order.ProductsList.Add(product);
                }

                if (productInStock._quantity < qantityToOrder + product.OrderQuantity)
                {
                    throw new BO.BLExceptionNotEnoughInStock(product.NameOfProduct);
                }

                product.OrderQuantity += qantityToOrder;

                // עדכון המבצעים לאחר הוספת הכמות
                product.SalesList = SearchSaleForProduct(productId, order.IfPreferredCustomer, product.OrderQuantity);

                // חישוב המחיר לאחר עדכון המבצעים
                CalcTotalPriceForProduct(product);

                // חישוב הסכום הסופי להזמנה
                CalcTotalPrice(order);

                return product.SalesList;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        // חישוב הסכום הסופי לתשלום להזמנה
        public void CalcTotalPrice(BO.Order order)
        {
            try
            {
                order.FinalPrice = order.ProductsList.Sum(p => p.FinalPriceOfProduct);
            }
            catch
            {
                throw new Exception();
            }
        }

        // חישוב המחיר לתשלום עבור מוצר בהזמנה, כולל מימוש מבצעים
        public void CalcTotalPriceForProduct(BO.ProductInOrder productInOrder)
        {
            try
            {
                int count = productInOrder.OrderQuantity;
                double totalSum = 0;
                int max;
                List<BO.SaleInProduct> salesList = new List<BO.SaleInProduct>();
                foreach (BO.SaleInProduct sale in productInOrder.SalesList)
                {
                    if (count <= 0)
                        break;
                    if (sale.QuantityToSale <= count)
                    {
                        max = count / sale.QuantityToSale;
                        totalSum += max * sale.Price;
                        count -= max * sale.QuantityToSale; // עדכן את count בהתאם
                        salesList.Add(sale);
                    }

                }
                if (count > 0)
                {
                    totalSum += (productInOrder.BasePriceOfProduct * count);

                }
                productInOrder.SalesList = salesList;
                productInOrder.FinalPriceOfProduct = totalSum;
            }
            catch
            {
                throw;

            }
        }

        //  מקבלת כפרמטר הזמנה ולא מחזירה ערך
        public void DoOrder(Order order)
        {
            try
            {
                foreach (BO.ProductInOrder p in order.ProductsList)
                {
                    DO.Product product = _dal.iProduct.Read(p.IdProduct);
                    _dal.iProduct.Update(product with { _quantity = product._quantity - p.OrderQuantity });
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //עדכון המבצעים המתאימים למוצר בהזמנה
        public List<BO.SaleInProduct> SearchSaleForProduct(int productId, bool isClub, int amount)
        {

            try
            {
                List<DO.Sale> sales = _dal.iSale.ReadAll();
                sales = (from s in sales
                         where s._productId == productId
                         select s).ToList();
                if (!isClub)
                {
                    sales = sales.FindAll(s => !s._forAllCusts);
                }
                List<BO.SaleInProduct> list = (from s in sales
                                               where s._endSale >= DateTime.Now && s._startSale <= DateTime.Now && amount >= s._amount
                                               orderby s._salePrice / s._amount
                                               select new BO.SaleInProduct(s._saleId, s._amount, s._salePrice, s._forAllCusts)).ToList();

                return list;
            }
            catch
            {
                throw new Exception();
            }
        }
    }
}
