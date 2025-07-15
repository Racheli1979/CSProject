using Dal;
using DalApi;

namespace Dal
{
    internal sealed class DalList : IDAL
    {
        private DalList()
        {
        }
        public ICustomer iCustomer => new CustomerImplementation();
        public IProduct iProduct => new ProductImplementation();
        public ISale iSale => new SaleImplementation();

        public static DalList Instance { get; } = new DalList();
    }
}
