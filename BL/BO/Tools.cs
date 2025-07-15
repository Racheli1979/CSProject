using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;

namespace BO;
internal static class Tools
{
    public static BO.Product ConvertToBoProduct(DO.Product product)
    {
        BO.Product p = new BO.Product()
        {
            ProductId = product._productId,
            ProductName = product._productName,
            Category = (BO.Categories)product._category,
            Price = product._price,
            QuantityInStock = product._quantity
        };
        return p;
    }

    public static DO.Product ConvertToDoProduct(BO.Product product)
    {
        DO.Product p = new DO.Product()
        {
            _productId = product.ProductId,
            _productName = product.ProductName,
            _category = (DO.Categories)product.Category,
            _price = product.Price,
            _quantity = product.QuantityInStock
        };
        return p;
    }
    public static BO.Customer ConvertToBoCustomer(DO.Customer customer)
    {
        BO.Customer c = new BO.Customer()
        {
            CustomerId = customer._customerId,
            CustomerName = customer._customerName,
            Address = customer._address,
            Phone = customer._phone
        };
        return c;
    }

    public static DO.Customer ConvertToDoCustomer(BO.Customer customer)
    {
        DO.Customer c = new DO.Customer()
        {
            _customerId = customer.CustomerId,
            _customerName = customer.CustomerName,
            _address = customer.Address,
            _phone = customer.Phone
        };
        return c;
    }

    public static BO.Sale ConvertToBoSale(DO.Sale sale)
    {
        BO.Sale s = new BO.Sale()
        {
            SaleId = sale._saleId,
            ProductId = sale._productId,
            Amount = sale._amount,
            SalePrice = sale._salePrice,
            ForAllCustomers = sale._forAllCusts,
            StartSale = sale._startSale,
            EndSale = sale._endSale
        };
        return s;
    }

    public static DO.Sale ConvertToDoSale(BO.Sale sale)
    {
        DO.Sale s = new DO.Sale()
        {
            _saleId = sale.SaleId,
            _productId = sale.ProductId,
            _amount = sale.Amount,
            _salePrice = sale.SalePrice,
            _forAllCusts = sale.ForAllCustomers,
            _startSale = sale.StartSale,
            _endSale = sale.EndSale
        };
        return s;
    }

    public static string ToStringProperty<T>(this T obj)
    {
        StringBuilder sb = new StringBuilder();
        Type t = obj.GetType();
        foreach (PropertyInfo prop in t.GetProperties())
        {
            sb.AppendLine($"{prop.Name} = {prop.GetValue(obj)}");
        }
        return sb.ToString();
    }

  /* public static void UpdateStock(BO.Product product, int qantityToOrder, int select)
    {
        if(select == 1)
        {
            product._quantity += 
        }
    }*/
}
