using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;

namespace BlImplementation
{
    internal class CustomerImplementation : ICustomer
    {
        private DalApi.IDAL _dal = DalApi.Factory.Get;
        public int Create(BO.Customer customer)
        {
            return _dal.iCustomer.Create(BO.Tools.ConvertToDoCustomer(customer));
        }

        public void Delete(int id)
        {
            _dal.iCustomer.Delete(id);
        }

        public bool IfCustomerExist(int id)
        {
            try
            {
                Read(id);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public BO.Customer? Read(int id)
        {
            return BO.Tools.ConvertToBoCustomer(_dal.iCustomer.Read(id));
        }

        public List<BO.Customer> ReadAll()
        {
            return _dal.iCustomer.ReadAll().Select(cust => BO.Tools.ConvertToBoCustomer(cust)).ToList();
        }

        public List<BO.Customer> ReadAll(Func<BO.Customer, bool>? filter = null)
        {
            return _dal.iCustomer.ReadAll(cust => filter(BO.Tools.ConvertToBoCustomer(cust)))
            .Select(c => BO.Tools.ConvertToBoCustomer(c)).ToList();
        }

        public void Update(BO.Customer customer)
        {
            DO.Customer c = BO.Tools.ConvertToDoCustomer(customer);
            _dal.iCustomer.Update(c);
        }
    }
}
