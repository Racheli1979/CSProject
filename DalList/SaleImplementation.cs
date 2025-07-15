
using DO;
using DalApi;
using System.Reflection;
using Tools;

namespace Dal;


public class SaleImplementation : ISale
{
    //public int Create(Sale item)
    //{
    //if(DataSourse.Sales.Contains(item))
    //throw new NotImplementedException("מבצע זה כבר קיים");
    //DataSourse.Sales.Add(item);
    //return item._saleId;
    //}

    public int Create(Sale item)
    {
        Sale s = item with { _saleId = DataSource.Config.SaleCode };
        DataSource.Sales.Add(s);
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"create sale: {item}");
        return s._saleId;
    }

    public void Delete(int id)
    {
        Sale sale = DataSource.Sales.FirstOrDefault(s => s._saleId == id);
        if (sale != null)
        {
            DataSource.Sales.Remove(sale);
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"delete sale with identity: {id}");
        }
    }

    public Sale? Read(int id)
    {
        foreach (Sale item in DataSource.Sales)
        {
            if (item._saleId == id)
            {
                MethodBase m = MethodBase.GetCurrentMethod();
                LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"read sale with identity: {id}");
                return item;
            }
        }
        throw new Exception("Code not Found");
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"read filter sale");
        return DataSource.Sales.FirstOrDefault(s => filter(s));
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"read all sales");
        if (filter == null)
            return DataSource.Sales;
        return DataSource.Sales.Where(s => filter(s)).ToList();
    }

    public void Update(Sale item)
    {
        Sale s = DataSource.Sales.FirstOrDefault(s => s._saleId == item._saleId);
        if (s != null)
        {
            Delete(s._saleId);
            Create(item);
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"update sale: {item}");
            return;
        }
    }
}
