using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using BO;

namespace UI
{
    public partial class Account : Form
    {
        static readonly BlApi.IBl _bl = BlApi.Factory.Get();
        private BO.Order order;
        List<BO.SaleInProduct> list;
        public Account(bool isClub)
        {
            InitializeComponent();
            order = new BO.Order(isClub);
            list = new List<BO.SaleInProduct>();
        }

        private void buttonProductsList_Click(object sender, EventArgs e)
        {
            ShowProducts sp = new ShowProducts();
            sp.ShowDialog();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            int id, amount;
            if (int.TryParse(inputProductId.Text, out id) && int.TryParse(inputQuantity.Value.ToString(), out amount))
            {
                // הוספת המוצר להזמנה ולקבלת רשימת המבצעים
                list = _bl.Order.AddProductToOrder(order, id, amount);

                // עדכון רשימת המבצעים למוצר
                var productInOrder = order.ProductsList.Find(p => p.IdProduct == id);
                if (productInOrder != null)
                {
                    productInOrder.SalesList = _bl.Order.SearchSaleForProduct(id, order.IfPreferredCustomer, productInOrder.OrderQuantity);
                    _bl.Order.CalcTotalPriceForProduct(productInOrder);
                }

                // עדכון ה-UI
                listBox1.DataSource = order.ProductsList.SelectMany(p => p.ToString().Split("\n")).ToList();
                endAccountLabel.Text = $"סכום כולל לתשלום: {order.FinalPrice.ToString()} ש\"ח";
            }
            inputProductId.Text = "";
            inputQuantity.Value = 1;
        }

        private void buttonRemoveProduct_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(inputRemoveProductId.Text, out id))
            {
                ProductInOrder p = order.ProductsList.Find(p => p.IdProduct == id);
                order.ProductsList.Remove(p);
                listBox1.DataSource = null;
                listBox1.DataSource = order.ProductsList.SelectMany(p => p.ToString().Split("\n")).ToList();
                _bl.Order.CalcTotalPrice(order);
                endAccountLabel.Text = $"סכום כולל לתשלום: {order.FinalPrice.ToString()} ש\"ח";

            }
            inputRemoveProductId.Text = "";
        }

        private void buttonEndAccount_Click(object sender, EventArgs e)
        {
            MessageBox.Show($" התשלום בוצע בהצלחה!! \n" +
                "תודה שקניתם אצלנו!" + order.FinalPrice.ToString());
            this.Close();
        }
    }
}
