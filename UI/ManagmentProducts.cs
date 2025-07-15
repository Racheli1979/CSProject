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
    public partial class ManagmentProducts : Form
    {
        public ManagmentProducts()
        {
            InitializeComponent();
        }
        private BlApi.IBl _bl = BlApi.Factory.Get();

        private void addProduct_Click(object sender, EventArgs e)
        {
            Controls.Remove(inputProductId);
            Controls.Remove(productIdLabel);
            Controls.Remove(inputUpdateQantity);
            Controls.Remove(inputUpdatePrice);
            Controls.Remove(inputUpdateName);
            Controls.Remove(updateQantityLabel);
            Controls.Remove(updatePriceLabel);
            Controls.Remove(updateCategoryLabel);
            Controls.Remove(updateNameLabel);
            Controls.Remove(buttonUpdateProduct);
            Controls.Remove(inputUpdateCategory);

            Controls.Add(inputQantity);
            Controls.Add(inputPrice);
            Controls.Add(inputProductName);
            Controls.Add(quantityLabel);
            Controls.Add(priceLabel);
            Controls.Add(categoryLabel);
            Controls.Add(productNameLabel);
            Controls.Add(buttonAddProduct);
            Controls.Add(inputCategory);
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                string name = inputProductName.Text;
                BO.Categories category = (BO.Categories)Enum.Parse(typeof(BO.Categories), inputCategory.SelectedItem.ToString());
                double price = double.Parse(inputPrice.Text);
                int quantity = int.Parse(inputQantity.Text);

                BO.Product newProduct = new BO.Product
                {
                    ProductName = name,
                    Category = category,
                    Price = price,
                    QuantityInStock = quantity
                };

                _bl.Product.Create(newProduct);

                inputProductName.Text = string.Empty;
                inputCategory.SelectedIndex = -1;
                inputPrice.Text = string.Empty;
                inputQantity.Text = string.Empty;

                Controls.Remove(inputQantity);
                Controls.Remove(inputPrice);
                Controls.Remove(inputProductName);
                Controls.Remove(quantityLabel);
                Controls.Remove(priceLabel);
                Controls.Remove(categoryLabel);
                Controls.Remove(productNameLabel);
                Controls.Remove(buttonAddProduct);
                Controls.Remove(inputCategory);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void inputProductId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int id = int.Parse(inputProductId.Text);
                    _bl.Product.Delete(id);
                    inputProductId.Text = string.Empty;

                    Controls.Remove(inputProductId);
                    Controls.Remove(productIdLabel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void deletProductButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(inputQantity);
            Controls.Remove(inputPrice);
            Controls.Remove(inputProductName);
            Controls.Remove(quantityLabel);
            Controls.Remove(priceLabel);
            Controls.Remove(categoryLabel);
            Controls.Remove(productNameLabel);
            Controls.Remove(buttonAddProduct);
            Controls.Remove(inputCategory);
            Controls.Remove(inputUpdateQantity);
            Controls.Remove(inputUpdatePrice);
            Controls.Remove(inputUpdateName);
            Controls.Remove(updateQantityLabel);
            Controls.Remove(updatePriceLabel);
            Controls.Remove(updateCategoryLabel);
            Controls.Remove(updateNameLabel);
            Controls.Remove(buttonUpdateProduct);
            Controls.Remove(inputUpdateCategory);


            Controls.Add(inputProductId);
            Controls.Add(productIdLabel);
        }

        private void updateProduct_Click(object sender, EventArgs e)
        {
            Controls.Remove(inputQantity);
            Controls.Remove(inputPrice);
            Controls.Remove(inputProductName);
            Controls.Remove(quantityLabel);
            Controls.Remove(priceLabel);
            Controls.Remove(categoryLabel);
            Controls.Remove(productNameLabel);
            Controls.Remove(buttonAddProduct);
            Controls.Remove(inputCategory);
            Controls.Remove(inputProductId);
            Controls.Remove(productIdLabel);


            Controls.Add(inputUpdateQantity);
            Controls.Add(inputUpdatePrice);
            Controls.Add(inputUpdateName);
            Controls.Add(updateQantityLabel);
            Controls.Add(updatePriceLabel);
            Controls.Add(updateCategoryLabel);
            Controls.Add(updateNameLabel);
            Controls.Add(buttonUpdateProduct);
            Controls.Add(inputUpdateCategory);
        }

        private void buttonUpdateProduct_Click(object sender, EventArgs e)
        {
            try
            {
                BO.Product  newProduct = new BO.Product
                {
                    ProductName = inputUpdateName.Text,
                    Category = (BO.Categories)Enum.Parse(typeof(BO.Categories), inputUpdateCategory.SelectedItem.ToString()),
                    Price = double.Parse(inputUpdatePrice.Text),
                    QuantityInStock = int.Parse(inputUpdateQantity.Text)
                };

                _bl.Product.Update(newProduct);

                inputUpdateName.Text = string.Empty;
                inputUpdateCategory.SelectedIndex = -1;
                inputUpdatePrice.Text = string.Empty;
                inputUpdateQantity.Text = string.Empty;

                Controls.Remove(inputUpdateQantity);
                Controls.Remove(inputUpdatePrice);
                Controls.Remove(inputUpdateName);
                Controls.Remove(updateQantityLabel);
                Controls.Remove(updatePriceLabel);
                Controls.Remove(updateCategoryLabel);
                Controls.Remove(updateNameLabel);
                Controls.Remove(buttonUpdateProduct);
                Controls.Remove(inputUpdateCategory);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void productsList_Click(object sender, EventArgs e)
        {
            ShowProducts sp = new ShowProducts();
            sp.ShowDialog();
        }
    }
}
