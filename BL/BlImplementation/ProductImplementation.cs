using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;
using DalApi;

namespace BlImplementation
{
    internal class ProductImplementation : BlApi.IProduct
    {
        private DalApi.IDAL _dal = DalApi.Factory.Get;
        public int Create(BO.Product product)
        {
            return _dal.iProduct.Create(BO.Tools.ConvertToDoProduct(product));
        }

        public void Delete(int id)
        {
            _dal.iProduct.Delete(id);
        }

        public List<BO.SaleInProduct> PromotionsInEffect(int productId, bool isClub)
        {
            try
            {
                List<DO.Sale> sales = _dal.iSale.ReadAll();
                sales = (from s in sales
                         where s._productId == productId
                         select s).ToList();

                if (!isClub)
                {
                    sales = sales.FindAll(s => !s._forAllCusts);
                }
                List<BO.SaleInProduct> list = (from s in sales
                                               where s._endSale >= DateTime.Now && s._startSale <= DateTime.Now
                                               select new BO.SaleInProduct(s._saleId, s._amount, s._salePrice, s._forAllCusts)).ToList();

                return list;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public BO.Product? Read(int id)
        {
            return BO.Tools.ConvertToBoProduct(_dal.iProduct.Read(id));
        }

        public List<BO.Product> ReadAll()
        {
            return _dal.iProduct.ReadAll().Select(prod => BO.Tools.ConvertToBoProduct(prod)).ToList();
        }

        public List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            return _dal.iProduct.ReadAll(prod => filter(BO.Tools.ConvertToBoProduct(prod)))
            .Select(p => BO.Tools.ConvertToBoProduct(p)).ToList();
        }

        public void Update(BO.Product product)
        {
            DO.Product p = BO.Tools.ConvertToDoProduct(product);
            _dal.iProduct.Update(p);
        }
    }
}
