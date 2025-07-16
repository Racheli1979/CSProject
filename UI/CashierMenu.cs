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
    public partial class CashierMenu : Form
    {
        public CashierMenu()
        {
            InitializeComponent();
        }
        private BlApi.IBl _bl = BlApi.Factory.Get();

        private void buttonProductsList_Click(object sender, EventArgs e)
        {
            ShowProducts sp = new ShowProducts();
            sp.ShowDialog();
        }

        private void buttonCustomersList_Click(object sender, EventArgs e)
        {
            ShowCustomers sc = new ShowCustomers();
            sc.ShowDialog();
        }

        private void buttonDoAccount_Click(object sender, EventArgs e)
        {
            Order o = new Order();
            o.ShowDialog();
        }

        private void addCustomerToClub_Click(object sender, EventArgs e)
        {
            Controls.Add(buttonAdd);
            Controls.Add(inputPhone);
            Controls.Add(inputAddress);
            Controls.Add(inputId);
            Controls.Add(inputName);
            Controls.Add(phoneLabel);
            Controls.Add(addressLabel);
            Controls.Add(nameLabel);
            Controls.Add(idLabel);
            Controls.Add(buttonCencel);
        }

        private void buttonCencel_Click(object sender, EventArgs e)
        {
            RemoveInputs((Control)sender);
        }

        private void RemoveInputs(Control sender)
        {
            Controls.Remove(buttonAdd);
            Controls.Remove(inputPhone);
            Controls.Remove(inputAddress);
            Controls.Remove(inputId);
            Controls.Remove(inputName);
            Controls.Remove(phoneLabel);
            Controls.Remove(addressLabel);
            Controls.Remove(nameLabel);
            Controls.Remove(idLabel);
            Controls.Remove(buttonCencel);
            this.Controls.Remove((Control)sender);

            inputId.Text = "";
            inputName.Text = "";
            inputAddress.Text = "";
            inputPhone.Text = "";
        }

        private void RemoveUpdateInputs(Control sender)
        {
            Controls.Remove(buttonUpdateAdd);
            Controls.Remove(inputUpdatePhone);
            Controls.Remove(inputUpdateAddress);
            Controls.Remove(inputUpdateId);
            Controls.Remove(inputUpdateName);
            Controls.Remove(updatePhoneLabel);
            Controls.Remove(updateAddressLabel);
            Controls.Remove(updateNameLabel);
            Controls.Remove(updateIdLabel);
            Controls.Remove(buttonUpdateCencel);
            this.Controls.Remove((Control)sender);

            inputUpdateId.Text = "";
            inputUpdateName.Text = "";
            inputUpdateAddress.Text = "";
            inputUpdatePhone.Text = "";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Customer customer = new BO.Customer
                {
                    CustomerId = int.Parse(inputId.Text),
                    CustomerName = inputName.Text,
                    Address = inputAddress.Text,
                    Phone = inputPhone.Text
                };
                _bl.Customer.Create(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RemoveInputs((Control)sender);
        }

        private void updateExsistCustomer_Click(object sender, EventArgs e)
        {
            Controls.Add(buttonUpdateAdd);
            Controls.Add(inputUpdatePhone);
            Controls.Add(inputUpdateAddress);
            Controls.Add(inputUpdateId);
            Controls.Add(inputUpdateName);
            Controls.Add(updatePhoneLabel);
            Controls.Add(updateAddressLabel);
            Controls.Add(updateNameLabel);
            Controls.Add(updateIdLabel);
            Controls.Add(buttonUpdateCencel);
        }

        private void buttonUpdateCencel_Click(object sender, EventArgs e)
        {
            RemoveUpdateInputs((Control)sender);
        }

        private void buttonUpdateAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Customer customer = new BO.Customer
                {
                    CustomerId = int.Parse(inputId.Text),
                    CustomerName = inputName.Text,
                    Address = inputAddress.Text,
                    Phone = inputPhone.Text
                };
                _bl.Customer.Update(customer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RemoveUpdateInputs((Control)sender);
        }
    }
}
