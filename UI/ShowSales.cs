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
    public partial class ShowSales : Form
    {
        public ShowSales()
        {
            InitializeComponent();
        }
        private BlApi.IBl _bl = BlApi.Factory.Get();

        private void buttonSalesList_Click(object sender, EventArgs e)
        {
            Controls.Remove(buttonSalesList);
            Controls.Add(listBoxSalesList);
            List<BO.Sale> l = _bl.Sale.ReadAll();
            foreach (var prod in l)
            {
                this.listBoxSalesList.Items.Add(prod.ToString());
            }
        }
    }
}
