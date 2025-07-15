using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IProduct
    {
        public int Create(BO.Product product);
        public BO.Product? Read(int id);
        public List<BO.Product> ReadAll();
        public List<BO.Product> ReadAll(Func<BO.Product, bool>? filter = null);
        public void Update(BO.Product product);
        public void Delete(int id);
        //מחזירה רשימת מבצעים שבתוקף למוצר לפי קוד מוצר והאם לקוח מועדף
        public List<BO.SaleInProduct> PromotionsInEffect(int productId, bool favorite);
    }
}
