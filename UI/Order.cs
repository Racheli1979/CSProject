using BlApi;
using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Order : Form
    {
        static readonly BlApi.IBl _bl = BlApi.Factory.Get();
        public Order()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (int.TryParse(customerIdTextBox.Text, out id))
                {
                    if (ifPreferredCheckBox.Checked)
                    {
                        BO.Customer c = _bl.Customer.Read(id);

                        textHelloLabel.Text = $"Hello club member {c.CustomerName}";

                    }
                    else
                        textHelloLabel.Text = $"hello new ----- {customerIdTextBox.Text}";

                }
                ifPreferredCheckBox.Enabled = false;
                customerIdTextBox.Enabled = false;
                sendButton.Enabled = false;
                orderButton.Enabled = true;

            }
            catch (DalExceptionIdDoesNotExistInTheList ex)
            {
                textHelloLabel.Text = $"hello new {customerIdTextBox.Text}";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void orderButton_Click(object sender, EventArgs e)
        {
            Account a = new Account(ifPreferredCheckBox.Checked);
            a.ShowDialog();
        }
    }
}
