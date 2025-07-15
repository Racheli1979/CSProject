using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlApi;

namespace BlImplementation
{
    internal class ProductImplementation : IProduct
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

        public List<BO.SaleInProduct> PromotionsInEffect(int productId, bool favorite)
        {
            return _dal.iSale.ReadAll(sale => productId == sale._saleId && (favorite == true || sale._forAllCusts == false) && DateTime.Now >= sale._startSale && DateTime.Now <= sale._endSale)
                .Select(s => new BO.SaleInProduct()
                {
                    SaleId = s._saleId,
                    ForAllCustomers = s._forAllCusts,
                    Price = s._salePrice,
                    QuantityToSale = s._amount,
                }).ToList();
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
