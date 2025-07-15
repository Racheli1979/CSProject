using DO;
//using DalList;
using DalTest;
using System.Runtime.CompilerServices;
using DalApi;
using Dal;
using System.Reflection;
using Tools;

public class program
{
    private static IDAL s_dal = DalApi.Factory.Get;

    public static void Main(string[] args)
    {
        //DeleteOldDirrectories
        // נשאר לי להפעיל את הפונקציה של מחיקת תיקיות לוגים ישנות
        Intialization.initialize();

        try
        {
            int select1 = PrintMainMenu();
            int select2;
            while (select1 != 0)
            {
                switch (select1)
                {
                    case 1:
                        Console.WriteLine("Product");
                        ProductMenu();
                        break;
                    case 2:
                        Console.WriteLine("Sale");
                        SaleMenu();
                        break;
                    case 3:
                        Console.WriteLine("Customer");
                        CustomerMenu();
                        break;
                    default:
                        Console.WriteLine("Wrong selection. please select again.");
                        break;
                }
                select1 = PrintMainMenu();
            }
        }
        catch (Exception ex)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"eror: {ex.ToString()}");
            Console.WriteLine(ex.ToString());
        }
    }

    private static void ProductMenu()
    {
        int select;
        select = PrintSubMenu("Product");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddProduct();
                    break;
                case 2:
                    ReadProduct();
                    break;
                case 3:
                    ReadeAll(s_dal.iProduct.ReadAll());
                    break;
                case 4:
                    Update("Product");
                    break;
                case 5:
                    DeleteProduct();
                    break;
                default:
                    Console.WriteLine("Wrong selection. please select again.");
                    break;
            }
            select = PrintSubMenu("Product");
        }
    }

    private static Product AddProduct()
    {
        string name;
        Categories category;
        double price;
        int count;
        Console.WriteLine("Enter the name of product");
        name = Console.ReadLine();
        Console.WriteLine("Enter the category: between 0 to 4");
        int c;
        if (!int.TryParse(Console.ReadLine(), out c))
            category = 0;
        else
            category = (Categories)c;
        Console.WriteLine("Enter price");
        if (!double.TryParse(Console.ReadLine(), out price)) price = 10;
        Console.WriteLine("Enter count in stock");
        if (!int.TryParse(Console.ReadLine(), out count)) count = 0;

        Product p = new Product(0, name, category, price, count);
        int code = s_dal.iProduct.Create(p);
        p = p with { _productId = code };

        Console.WriteLine("Product created successfully");
        Console.WriteLine(p);
        return p;
    }

    private static void ReadProduct()
    {
        try
        {
            Console.WriteLine("Enter Code");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine(s_dal.iProduct.Read(code));
        }
        catch (Exception ex)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"eror: {ex.ToString()}");
            Console.WriteLine(ex.Message);
        }
    }

    private static void DeleteProduct()
    {
        try
        {
            Console.WriteLine("Enter code");
            int code = int.Parse(Console.ReadLine());
            s_dal.iProduct.Delete(code);
            Console.WriteLine("Delete successfully");
        }
        catch (Exception e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"eror: {e.ToString()}");
            Console.WriteLine((e.Message));
        }
    }

    private static void SaleMenu()
    {
        int select;
        select = PrintSubMenu("Sale");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddSale();
                    break;
                case 2:
                    ReadSale();
                    break;
                case 3:
                    ReadeAll(s_dal.iSale.ReadAll());
                    break;
                case 4:
                    Update("Sale");
                    break;
                case 5:
                    DeleteSale();
                    break;
                default:
                    Console.WriteLine("Wrong selection. please select again.");
                    break;
            }
            select = PrintSubMenu("Sale");
        }
    }

    private static Sale AddSale()
    {
        int productId;
        int quantity;
        double salePrice;
        bool forAllCusts;
        DateTime startSale;
        DateTime endSale;

        Console.WriteLine("Enter the code of the product");
        if (!int.TryParse(Console.ReadLine(), out productId)) productId = 100;
        Console.WriteLine("Enter the quantity of sale that need buy");
        if (!int.TryParse(Console.ReadLine(), out quantity)) quantity = 1;
        Console.WriteLine("Enter price");
        if (!double.TryParse(Console.ReadLine(), out salePrice)) salePrice = 10;
        Console.WriteLine("only to club?");
        if (!bool.TryParse(Console.ReadLine(), out forAllCusts)) forAllCusts = false;
        Console.WriteLine("Enter date of start");
        if (!DateTime.TryParse(Console.ReadLine(), out startSale)) startSale = DateTime.Now;
        Console.WriteLine("Enter date of finish");
        if (!DateTime.TryParse(Console.ReadLine(), out endSale)) endSale = DateTime.Now;

        Sale s = new Sale(0, productId, quantity, salePrice, forAllCusts, startSale, endSale);
        int code = s_dal.iSale.Create(s);
        s = s with { _saleId = code };

        Console.WriteLine("Sale create successfully");
        Console.WriteLine(s);
        return s;
    }

    private static void ReadSale()
    {
        try
        {
            Console.WriteLine("Enter Code");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine(s_dal.iSale.Read(code));
        }
        catch (Exception ex)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"eror: {ex.ToString()}");
            Console.WriteLine(ex.Message);
        }
    }

    private static void DeleteSale()
    {
        try
        {
            Console.WriteLine("Enter code");
            int code = int.Parse(Console.ReadLine());
            s_dal.iSale.Delete(code);
            Console.WriteLine("Delete successfully");
        }
        catch (Exception e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"eror: {e.ToString()}");
            Console.WriteLine((e.Message));
        }
    }

    private static void CustomerMenu()
    {
        int select;
        select = PrintSubMenu("Customer");
        while (select != 0)
        {
            switch (select)
            {
                case 1:
                    AddCustomer();
                    break;
                case 2:
                    ReadCustomer();
                    break;
                case 3:
                    ReadeAll(s_dal.iCustomer.ReadAll());
                    break;
                case 4:
                    Update("Customer");
                    break;
                case 5:
                    DeleteCustomer();
                    break;
                default:
                    Console.WriteLine("Wrong selection. please select again.");
                    break;
            }
            select = PrintSubMenu("Customer");
        }
    }

    private static Customer AddCustomer()
    {
        int customerId;
        string name;
        string address;
        string phone;

        Console.WriteLine("Enter id of the customer");
        if (!int.TryParse(Console.ReadLine(), out customerId)) ;
        Console.WriteLine("Enter name of customer");
        name = Console.ReadLine();
        Console.WriteLine("Enter address");
        address = Console.ReadLine();
        Console.WriteLine("Enter phone");
        phone = Console.ReadLine();

        Customer c = new Customer(customerId, name, address, phone);

        Console.WriteLine("Customer created successfully");
        Console.WriteLine(c);

        return c;
    }

    private static void ReadCustomer()
    {
        try
        {
            Console.WriteLine("Enter id of customer");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine(s_dal.iCustomer.Read(code));
        }
        catch (Exception ex)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"eror: {ex.ToString()}");
            Console.WriteLine(ex.Message);
        }
    }

    private static void DeleteCustomer()
    {
        try
        {
            Console.WriteLine("Enter id of customer");
            int code = int.Parse(Console.ReadLine());
            s_dal.iCustomer.Delete(code);
            Console.WriteLine("Delete successfully");
        }
        catch (Exception e)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"eror: {e.ToString()}");
            Console.WriteLine((e.Message));
        }
    }

    private static void ReadeAll<T>(List<T> list)
    {
        foreach (var item in list)
        {
            Console.WriteLine(item);
        }
    }

    private static void Update(string s)
    {
        try
        {
            Console.WriteLine("Enter code to update");
            int code = int.Parse(Console.ReadLine());
            if (s == "Product")
            {
                Product p1 = s_dal.iProduct.Read(code);
                Product p2 = AddProduct();
                s_dal.iProduct.Update(p2);
                int code2 = (int)p1._productId;
                s_dal.iProduct.Delete(code2);
            }
            if (s == "Customer")
            {
                Customer c1 = s_dal.iCustomer.Read(code);
                Customer c2 = AddCustomer();
                Customer c3 = c2 with { _customerId = c1._customerId };
                s_dal.iCustomer.Update(c3);
                int code2 = (int)c3._customerId;
                s_dal.iCustomer.Delete(code2);
            }
            if (s == "Sale")
            {
                Sale s1 = s_dal.iSale.Read(code);
                Sale s2 = AddSale();
                Sale s3 = s2 with { _saleId = s1._saleId };
                s_dal.iSale.Update(s3);
                int code2 = (int)s3._saleId;
                s_dal.iSale.Delete(code2);
            }
        }
        catch (Exception ex)
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"eror: {ex.ToString()}");
            Console.WriteLine();
        }
    }

    public static int PrintMainMenu()
    {
        Console.WriteLine("For Products press 1");
        Console.WriteLine("For Sales press 2");
        Console.WriteLine("For Customers press 3");
        Console.WriteLine("For exit press 0");
        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }

    public static int PrintSubMenu(string item)
    {
        Console.WriteLine($"To add {item} press 1");
        Console.WriteLine($"To read one {item} press 2");
        Console.WriteLine($"To read all {item}s press 3");
        Console.WriteLine($"To update {item} press 4");
        Console.WriteLine($"To delete {item} press 5");
        Console.WriteLine($"To exit press 0");
        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }

    //private static void WriteLog()
    //{
    //    Console.WriteLine("enter text to log");
    //    string text = Console.ReadLine();
    //    MethodBase m = MethodBase.GetCurrentMethod();
    //    LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, text);
    //}
}
