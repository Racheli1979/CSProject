using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DalTest;

namespace BlTest
{
    internal class Program
    {
        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        static void Main(string[] args)
        {
            Intialization.initialize();
            try
            {
                int select = 0;
                Console.WriteLine("enter id of customer or -1 to exit");
                if (!int.TryParse(Console.ReadLine(), out select)) select = 0;
                while (select != -1)
                {
                    BO.Order order = new BO.Order();
                    order.ProductsList = new List<BO.ProductInOrder>();
                    AddProduct(select, order);
                    Console.WriteLine("enter id of customer or -1 to exit");
                    if (!int.TryParse(Console.ReadLine(), out select)) select = 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private static void AddProduct(int select, BO.Order order)
        {
            try
            {
                int select2 = 0;
                Console.WriteLine("to add product enter 0 or -1 to exit");
                if (!int.TryParse(Console.ReadLine(), out select2)) select2 = 0;
                while (select2 == 0)
                {
                    int id;
                    int quantity;
                    Console.WriteLine("enter id of product");
                    if (!int.TryParse(Console.ReadLine(), out id)) id = 100;
                    Console.WriteLine("enter quentity");
                    if (!int.TryParse(Console.ReadLine(), out quantity)) quantity = 1;

                    List<BO.SaleInProduct> listSale;
                    if (s_bl.Customer.IfCustomerExist(select))
                    {
                        order.IfPreferredCustomer = true;
                        listSale = s_bl.Order.AddProductToOrder(order, id, quantity);
                    }
                    else
                    {
                        order.IfPreferredCustomer = false;
                        listSale = s_bl.Order.AddProductToOrder(order, id, quantity);
                    }
                    foreach (BO.SaleInProduct sale in listSale)
                    {
                        Console.WriteLine("sale:");
                        Console.WriteLine(sale.ToString());
                    }
                    Console.WriteLine($"Final amount for the order so far:{order.FinalPrice}");

                    Console.WriteLine("to add product enter 0");
                    if (!int.TryParse(Console.ReadLine(), out select2)) select2 = 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

    }
}
