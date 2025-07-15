using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;

namespace BlImplementation
{
    internal class SaleImplementation : ISale
    {
        private DalApi.IDAL _dal = DalApi.Factory.Get;
        public int Create(BO.Sale sale)
        {
            return _dal.iSale.Create(BO.Tools.ConvertToDoSale(sale));
        }

        public void Delete(int id)
        {
            _dal.iSale.Delete(id);
        }

        public BO.Sale? Read(int id)
        {
            return BO.Tools.ConvertToBoSale(_dal.iSale.Read(id));
        }

        public List<BO.Sale> ReadAll()
        {
            return _dal.iSale.ReadAll().Select(sale => BO.Tools.ConvertToBoSale(sale)).ToList();
        }

        public List<BO.Sale> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            return _dal.iSale.ReadAll(sale => filter(BO.Tools.ConvertToBoSale(sale)))
            .Select(s => BO.Tools.ConvertToBoSale(s)).ToList();
        }

        public void Update(BO.Sale sale)
        {
            DO.Sale s = BO.Tools.ConvertToDoSale(sale);
            _dal.iSale.Update(s);
        }
    }
}
