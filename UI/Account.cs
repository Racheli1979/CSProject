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
        private BlApi.IBl _bl = BlApi.Factory.Get();
        Order order;
        public Account()
        {
            InitializeComponent();
            order = new Order();
        }

        private void buttonProductsList_Click(object sender, EventArgs e)
        {
            ShowProducts sp = new ShowProducts();
            sp.ShowDialog();
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            BO.ProductOrder p = _bl.Order.


        }

        private void buttonEndAccount_Click(object sender, EventArgs e)
        {

        }
    }
}
