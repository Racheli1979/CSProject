using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface ICustomer
    {
        public int Create(BO.Customer customer);
        public BO.Customer? Read(int id);
        public List<BO.Customer> ReadAll();
        public List<BO.Customer> ReadAll(Func<BO.Customer, bool>? filter = null);
        public void Update(BO.Customer customer);
        public void Delete(int id);
        public bool IfCustomerExist(int id);
    }
}
