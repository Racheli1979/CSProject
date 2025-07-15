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
    public partial class ShowProducts : Form
    {
        public ShowProducts()
        {
            InitializeComponent();
        }
        private BlApi.IBl _bl = BlApi.Factory.Get();

        private void buttonProductsList_Click(object sender, EventArgs e)
        {
            Controls.Remove(buttonProductsList);
            Controls.Add(listBoxProductsList);
            List<BO.Product> l = _bl.Product.ReadAll();
            foreach (var prod in l)
            {
                this.listBoxProductsList.Items.Add(prod.ToString());
            }
        }
    }
}
