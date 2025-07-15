
namespace Dal;
using DO;
using DalApi;
using System.Reflection;
using Tools;
using System.Security.Principal;

public class CustomerImplementation : ICustomer
{
    public int Create(Customer item)
    {
        if (DataSource.Customers.Contains(item))
            throw new NotImplementedException("This user is exist!");
        DataSource.Customers.Add(item);
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"create customer: {item}");
        return item._customerId;
    }

    public void Delete(int id)
    {
        Customer customer = DataSource.Customers.FirstOrDefault(c => c._customerId == id);
        if (customer != null)
        {
            DataSource.Customers.Remove(customer);
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"delete customer with identity: {id}");
        }
    }

    public Customer? Read(int id)
    {
        foreach (Customer item in DataSource.Customers)
        {
            if (item._customerId == id)
            {
                MethodBase m = MethodBase.GetCurrentMethod();
                LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"read customer with identity: {id}");
                return item;
            }
        }
        throw new Exception("Code not Found");
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"read filter customer");
        return DataSource.Customers.FirstOrDefault(c => filter(c));
    }

    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        MethodBase m = MethodBase.GetCurrentMethod();
        LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"read all customers");
        if (filter == null)
            return DataSource.Customers;
        return DataSource.Customers.Where(c => filter(c)).ToList();
    }

    public void Update(Customer item)
    {
        Customer c = DataSource.Customers.FirstOrDefault(c => c._customerId == item._customerId);
        if (c != null)
        {
            Delete(c._customerId);
            Create(item);
            MethodBase m = MethodBase.GetCurrentMethod();
            LogManager.WriteToLog(m.DeclaringType.FullName, m.Name, $"update customer: {item}");
            return;
        }
    }
}
