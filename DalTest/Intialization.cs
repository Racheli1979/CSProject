
using DO;
using DalApi;
using System.Runtime.Serialization;
using Microsoft.VisualBasic;

namespace DalTest;


public class Intialization
{
    private static IDAL? s_dal;
    private static List<int> productsCode = new List<int>();

    private static void createCustomers()
    {
        s_dal.iCustomer.Create(new Customer());
        /*s_dal.iCustomer.Create(new Customer(1, "Moshe", "Rabi Akiva 115", "0548457878"));
        s_dal.iCustomer.Create(new Customer(2, "Yehuda", "Netivot Amishpat 23", "0527614235"));
        s_dal.iCustomer.Create(new Customer(3, "Shlomo", "Rubin 43", "0556739721"));
        s_dal.iCustomer.Create(new Customer(4, "Eli", "Nechemya 60", "0534169865"));
        s_dal.iCustomer.Create(new Customer(5, "Nati", "Rabi Yehuda Anasi 19", "0548582535"));*/
    }

    private static void createProducts()
    {
        s_dal.iProduct.Create(new Product());
        /*productsCode.Add(s_dal.iProduct.Create(new Product(0, "Aish shelanu birushalim", Categories.History, 85.5, 15)));
        productsCode.Add(s_dal.iProduct.Create(new Product(0, "Yaldy yshay", Categories.Children, 15, 35)));
        productsCode.Add(s_dal.iProduct.Create(new Product(0, "Linur", Categories.Adult, 100, 6)));
        productsCode.Add(s_dal.iProduct.Create(new Product(0, "Mi sheyematzmetz rishon", Categories.Noar, 70, 3)));
        productsCode.Add(s_dal.iProduct.Create(new Product(0, "Chakimy deyehuday", Categories.Sipury_Tzadikim, 105, 10)));*/
    }

    private static void createSales()
    {
        s_dal.iSale.Create(new Sale());
        /*s_dal.iSale.Create(new Sale(0, productsCode[0], 3, 100, true, DateTime.Now, DateTime.Now.AddDays(10)));
        s_dal.iSale.Create(new Sale(0, productsCode[1], 10, 85, false, new DateTime(2024, 11, 04), new DateTime(2024, 11, 28)));
        s_dal.iSale.Create(new Sale(0, productsCode[2], 5, 90, true, new DateTime(2024, 01, 07), new DateTime(2024, 03, 07)));
        s_dal.iSale.Create(new Sale(0, productsCode[3], 35, 50, true, new DateTime(2024, 09, 25), new DateTime(2024, 10, 13)));
        s_dal.iSale.Create(new Sale(0, productsCode[4], 7, 45, false, new DateTime(2025, 01, 19), new DateTime(2024, 02, 19)));*/

    }
    public static void initialize()
    {
        s_dal = DalApi.Factory.Get;
        createCustomers();
        createProducts();
        createSales();
    }

}
