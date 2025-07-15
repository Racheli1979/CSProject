using BlApi;
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

namespace UI
{
    public partial class ShowCustomers : Form
    {
        public ShowCustomers()
        {
            InitializeComponent();
        }
        private BlApi.IBl _bl = BlApi.Factory.Get();

        private void buttonCustomersList_Click(object sender, EventArgs e)
        {
            Controls.Remove(buttonCustomersList);
            Controls.Add(listBoxCustomersList);
            List<BO.Customer> l = _bl.Customer.ReadAll();
            foreach (var prod in l)
            {
                this.listBoxCustomersList.Items.Add(prod.ToString());
            }
        }
    }
}
