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

namespace UI
{
    public partial class ManagmentSales : Form
    {
        public ManagmentSales()
        {
            InitializeComponent();
        }
        private BlApi.IBl _bl = BlApi.Factory.Get();

        private void deletSaleButton_Click(object sender, EventArgs e)
        {
            Controls.Remove(inputProductId);
            Controls.Remove(productIdLabel);
            Controls.Remove(inputQuntity);
            Controls.Remove(qantityLabel);
            Controls.Remove(inputSalePrice);
            Controls.Remove(salePriceLabel);
            Controls.Remove(forAllClub);
            Controls.Remove(inputStartDate);
            Controls.Remove(startDateLabel);
            Controls.Remove(inputEndDate);
            Controls.Remove(endDateLabel);
            Controls.Remove(inputUpdateEndDate);
            Controls.Remove(updateEndSaleLabel);
            Controls.Remove(inputUpdateStartDate);
            Controls.Remove(updateStartDateLabel);
            Controls.Remove(inputUpdateQuntity);
            Controls.Remove(inputUpdateSalePrice);
            Controls.Remove(inputUpdateProductId);
            Controls.Remove(updateForAllClub);
            Controls.Remove(updateSalePriceLabel);
            Controls.Remove(updateQuntityLabel);
            Controls.Remove(updateProductIdLabel);
            Controls.Remove(buttonUpdateSale);
            Controls.Remove(buttonAddSale);

            Controls.Add(inputSaleId);
            Controls.Add(saleIdLabel);
        }

        private void inputSaleId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                try
                {
                    int id = int.Parse(inputSaleId.Text);
                    _bl.Sale.Delete(id);
                    inputSaleId.Text = string.Empty;

                    Controls.Remove(inputSaleId);
                    Controls.Remove(saleIdLabel);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void addSale_Click(object sender, EventArgs e)
        {
            Controls.Remove(inputUpdateEndDate);
            Controls.Remove(updateEndSaleLabel);
            Controls.Remove(inputUpdateStartDate);
            Controls.Remove(updateStartDateLabel);
            Controls.Remove(inputUpdateQuntity);
            Controls.Remove(inputUpdateSalePrice);
            Controls.Remove(inputUpdateProductId);
            Controls.Remove(updateForAllClub);
            Controls.Remove(updateSalePriceLabel);
            Controls.Remove(updateQuntityLabel);
            Controls.Remove(updateProductIdLabel);
            Controls.Remove(buttonUpdateSale);
            Controls.Remove(inputSaleId);
            Controls.Remove(saleIdLabel);

            Controls.Add(inputProductId);
            Controls.Add(productIdLabel);
            Controls.Add(inputQuntity);
            Controls.Add(qantityLabel);
            Controls.Add(inputSalePrice);
            Controls.Add(salePriceLabel);
            Controls.Add(forAllClub);
            Controls.Add(inputStartDate);
            Controls.Add(startDateLabel);
            Controls.Add(inputEndDate);
            Controls.Add(endDateLabel);
            Controls.Add(buttonAddSale);
        }

        private void buttonAddSale_Click(object sender, EventArgs e)
        {
            try
            {
                int idProduct = int.Parse(inputProductId.Text);
                int qantity = int.Parse(inputQuntity.Text);
                double salePrice = double.Parse(inputSalePrice.Text);
                bool forClub = forAllClub.Checked;
                DateTime startDate = inputStartDate.Value;
                DateTime endDate = inputEndDate.Value;

                BO.Sale newSale = new BO.Sale
                {
                    ProductId = idProduct,
                    Amount = qantity,
                    SalePrice = salePrice,
                    ForAllCustomers = forClub,
                    StartSale = startDate,
                    EndSale = endDate
                };

                _bl.Sale.Create(newSale);

                inputProductId.Text = string.Empty;
                inputQuntity.Text = string.Empty;
                inputSalePrice.Text = string.Empty;
                forAllClub.Checked = false;
                inputStartDate.Value = DateTime.Now;
                inputEndDate.Value = DateTime.Now;

                Controls.Remove(inputProductId);
                Controls.Remove(productIdLabel);
                Controls.Remove(inputQuntity);
                Controls.Remove(qantityLabel);
                Controls.Remove(inputSalePrice);
                Controls.Remove(salePriceLabel);
                Controls.Remove(forAllClub);
                Controls.Remove(inputStartDate);
                Controls.Remove(startDateLabel);
                Controls.Remove(inputEndDate);
                Controls.Remove(endDateLabel);
                Controls.Remove(buttonAddSale);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void updateSale_Click(object sender, EventArgs e)
        {
            Controls.Remove(inputSaleId);
            Controls.Remove(saleIdLabel);
            Controls.Remove(inputProductId);
            Controls.Remove(productIdLabel);
            Controls.Remove(inputQuntity);
            Controls.Remove(qantityLabel);
            Controls.Remove(inputSalePrice);
            Controls.Remove(salePriceLabel);
            Controls.Remove(forAllClub);
            Controls.Remove(inputStartDate);
            Controls.Remove(startDateLabel);
            Controls.Remove(inputEndDate);
            Controls.Remove(endDateLabel);
            Controls.Remove(buttonAddSale);

            Controls.Add(inputUpdateEndDate);
            Controls.Add(updateEndSaleLabel);
            Controls.Add(inputUpdateStartDate);
            Controls.Add(updateStartDateLabel);
            Controls.Add(inputUpdateQuntity);
            Controls.Add(inputUpdateSalePrice);
            Controls.Add(inputUpdateProductId);
            Controls.Add(updateForAllClub);
            Controls.Add(updateSalePriceLabel);
            Controls.Add(updateQuntityLabel);
            Controls.Add(updateProductIdLabel); ;
            Controls.Add(buttonUpdateSale);
        }

        private void buttonUpdateSale_Click(object sender, EventArgs e)
        {
            try
            {
                int updateIdProduct = int.Parse(inputUpdateProductId.Text);
                int updateQantity = int.Parse(inputUpdateQuntity.Text);
                double updateSalePrice = double.Parse(inputUpdateSalePrice.Text);
                bool updateForClub = updateForAllClub.Checked;
                DateTime updateStartDate = inputUpdateStartDate.Value;
                DateTime updaetEndDate = inputUpdateEndDate.Value;

                BO.Sale newSale = new BO.Sale
                {
                    ProductId = updateIdProduct,
                    Amount = updateQantity,
                    SalePrice = updateSalePrice,
                    ForAllCustomers = updateForClub,
                    StartSale = updateStartDate,
                    EndSale = updaetEndDate
                };

                _bl.Sale.Create(newSale);

                inputUpdateProductId.Text = string.Empty;
                inputUpdateQuntity.Text = string.Empty;
                inputUpdateSalePrice.Text = string.Empty;
                updateForAllClub.Checked = false;
                inputUpdateStartDate.Value = DateTime.Now;
                inputUpdateEndDate.Value = DateTime.Now;

                Controls.Remove(inputUpdateEndDate);
                Controls.Remove(updateEndSaleLabel);
                Controls.Remove(inputUpdateStartDate);
                Controls.Remove(updateStartDateLabel);
                Controls.Remove(inputUpdateQuntity);
                Controls.Remove(inputUpdateSalePrice);
                Controls.Remove(inputUpdateProductId);
                Controls.Remove(updateForAllClub);
                Controls.Remove(updateSalePriceLabel);
                Controls.Remove(updateQuntityLabel);
                Controls.Remove(updateProductIdLabel);
                Controls.Remove(buttonUpdateSale);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void salesList_Click(object sender, EventArgs e)
        {
            ShowSales ss = new ShowSales();
            ss.ShowDialog();
        }
    }
}