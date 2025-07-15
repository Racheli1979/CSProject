
using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal;

public class ProductImplementation : IProduct
{
    //public int Create(Product product)
    //{
    //if(DataSourse.Products.Contains(product))
    //throw new NotImplementedException("לא ניתן להוסיף מוצר קיים");
    //DataSourse.Products.Add(product);
    //return product._productId;
    //}

    public int Create(Product item)
    {
        Product p = item with { _productId = DataSource.Config.ProductCode };
        DataSource.Products.Add(p);
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"create product: {item}");
        return p._productId;
    }

    public void Delete(int id)
    {
        Product product = DataSource.Products.FirstOrDefault(p => p._productId == id);
        if (product != null)
        {
            DataSource.Products.Remove(product);
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"delete product with identity: {id}");
        }
    }

    public Product? Read(int id)
    {
        foreach (Product item in DataSource.Products)
        {
            if (item._productId == id)
            {
                MethodBase m = MethodBase.GetCurrentMethod();
                LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"read product with identity: {id}");
                return item;
            }
        }
        throw new Exception("Code not Found");
    }

    public Product? Read(Func<Product, bool> filter)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"read filter product");
        return DataSource.Products.FirstOrDefault(p => filter(p));
    }

    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"read all products");
        if (filter == null)
            return DataSource.Products;
        return DataSource.Products.Where(p => filter(p)).ToList();
    }

    public void Update(Product item)
    {
        Product p = DataSource.Products.FirstOrDefault(p => p._productName == item._productName);
        if (p != null)
        {
            Delete(p._productId);
            Create(item);
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"update product: {item}");
            return;
        }
    }

}
