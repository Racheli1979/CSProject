namespace UI
{
    partial class Account
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonAddProduct = new Button();
            inputProductId = new TextBox();
            productIdLabel = new Label();
            titleLabel = new Label();
            buttonProductsList = new Button();
            buttonEndAccount = new Button();
            endAccountLabel = new Label();
            buttonSeeMyProducts = new Button();
            quantityLabel = new Label();
            inputQuantity = new TextBox();
            SuspendLayout();
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.BackColor = SystemColors.ControlDark;
            buttonAddProduct.FlatAppearance.BorderColor = Color.White;
            buttonAddProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddProduct.ForeColor = Color.Maroon;
            buttonAddProduct.Location = new Point(346, 284);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(126, 44);
            buttonAddProduct.TabIndex = 7;
            buttonAddProduct.Text = "הוספת מוצר";
            buttonAddProduct.UseVisualStyleBackColor = false;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // inputProductId
            // 
            inputProductId.Location = new Point(323, 144);
            inputProductId.Name = "inputProductId";
            inputProductId.Size = new Size(168, 30);
            inputProductId.TabIndex = 8;
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productIdLabel.ForeColor = Color.Maroon;
            productIdLabel.Location = new Point(340, 103);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(141, 23);
            productIdLabel.TabIndex = 9;
            productIdLabel.Text = "הכנס מזהה מוצר";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.Maroon;
            titleLabel.Location = new Point(300, 28);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(210, 46);
            titleLabel.TabIndex = 10;
            titleLabel.Text = "ביצוע הזמנה";
            // 
            // buttonProductsList
            // 
            buttonProductsList.BackColor = SystemColors.ControlDark;
            buttonProductsList.FlatAppearance.BorderColor = Color.White;
            buttonProductsList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProductsList.ForeColor = Color.Maroon;
            buttonProductsList.Location = new Point(32, 336);
            buttonProductsList.Name = "buttonProductsList";
            buttonProductsList.Size = new Size(158, 86);
            buttonProductsList.TabIndex = 11;
            buttonProductsList.Text = "לראות את קטלוג המוצרים";
            buttonProductsList.UseVisualStyleBackColor = false;
            buttonProductsList.Click += buttonProductsList_Click;
            // 
            // buttonEndAccount
            // 
            buttonEndAccount.BackColor = SystemColors.ControlDark;
            buttonEndAccount.FlatAppearance.BorderColor = Color.White;
            buttonEndAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEndAccount.ForeColor = Color.Maroon;
            buttonEndAccount.Location = new Point(346, 394);
            buttonEndAccount.Name = "buttonEndAccount";
            buttonEndAccount.Size = new Size(126, 44);
            buttonEndAccount.TabIndex = 12;
            buttonEndAccount.Text = "סיום ותשלום";
            buttonEndAccount.UseVisualStyleBackColor = false;
            buttonEndAccount.Click += buttonEndAccount_Click;
            // 
            // endAccountLabel
            // 
            endAccountLabel.AutoSize = true;
            endAccountLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            endAccountLabel.ForeColor = Color.Maroon;
            endAccountLabel.Location = new Point(300, 345);
            endAccountLabel.Name = "endAccountLabel";
            endAccountLabel.Size = new Size(217, 23);
            endAccountLabel.TabIndex = 13;
            endAccountLabel.Text = "סכום כולל לתשלום: 0 ש\"ח";
            // 
            // buttonSeeMyProducts
            // 
            buttonSeeMyProducts.BackColor = SystemColors.ControlDark;
            buttonSeeMyProducts.FlatAppearance.BorderColor = Color.White;
            buttonSeeMyProducts.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSeeMyProducts.ForeColor = Color.Maroon;
            buttonSeeMyProducts.Location = new Point(602, 336);
            buttonSeeMyProducts.Name = "buttonSeeMyProducts";
            buttonSeeMyProducts.Size = new Size(158, 86);
            buttonSeeMyProducts.TabIndex = 14;
            buttonSeeMyProducts.Text = "לראות את המוצרים שנאספו עד עכשיו";
            buttonSeeMyProducts.UseVisualStyleBackColor = false;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            quantityLabel.ForeColor = Color.Maroon;
            quantityLabel.Location = new Point(331, 190);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(160, 23);
            quantityLabel.TabIndex = 16;
            quantityLabel.Text = "הכנס כמות להזמנה";
            // 
            // inputQuantity
            // 
            inputQuantity.Location = new Point(323, 231);
            inputQuantity.Name = "inputQuantity";
            inputQuantity.Size = new Size(168, 30);
            inputQuantity.TabIndex = 18;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(inputQuantity);
            Controls.Add(quantityLabel);
            Controls.Add(buttonSeeMyProducts);
            Controls.Add(endAccountLabel);
            Controls.Add(buttonEndAccount);
            Controls.Add(buttonProductsList);
            Controls.Add(titleLabel);
            Controls.Add(productIdLabel);
            Controls.Add(inputProductId);
            Controls.Add(buttonAddProduct);
            Name = "Account";
            Text = "Account";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonAddProduct;
        private TextBox inputProductId;
        private Label productIdLabel;
        private Label titleLabel;
        private Button buttonProductsList;
        private Button buttonEndAccount;
        private Label endAccountLabel;
        private Button buttonSeeMyProducts;
        private Label quantityLabel;
        private TextBox inputQuantity;
    }
}