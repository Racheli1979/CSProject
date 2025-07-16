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
            quantityLabel = new Label();
            endAccountLabel = new Label();
            buttonEndAccount = new Button();
            buttonProductsList = new Button();
            titleLabel = new Label();
            productIdLabel = new Label();
            inputProductId = new TextBox();
            buttonAddProduct = new Button();
            buttonRemoveProduct = new Button();
            removeProductIdLabel = new Label();
            inputRemoveProductId = new TextBox();
            listBox1 = new ListBox();
            myProductsLabel = new Label();
            inputQuantity = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)inputQuantity).BeginInit();
            SuspendLayout();
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            quantityLabel.ForeColor = Color.Maroon;
            quantityLabel.Location = new Point(483, 295);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(160, 23);
            quantityLabel.TabIndex = 27;
            quantityLabel.Text = "הכנס כמות להזמנה";
            // 
            // endAccountLabel
            // 
            endAccountLabel.AutoSize = true;
            endAccountLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            endAccountLabel.ForeColor = Color.Maroon;
            endAccountLabel.Location = new Point(362, 570);
            endAccountLabel.Name = "endAccountLabel";
            endAccountLabel.Size = new Size(217, 23);
            endAccountLabel.TabIndex = 25;
            endAccountLabel.Text = "סכום כולל לתשלום: 0 ש\"ח";
            // 
            // buttonEndAccount
            // 
            buttonEndAccount.BackColor = SystemColors.ControlDark;
            buttonEndAccount.FlatAppearance.BorderColor = Color.White;
            buttonEndAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonEndAccount.ForeColor = Color.Maroon;
            buttonEndAccount.Location = new Point(408, 619);
            buttonEndAccount.Name = "buttonEndAccount";
            buttonEndAccount.Size = new Size(126, 44);
            buttonEndAccount.TabIndex = 24;
            buttonEndAccount.Text = "סיום ותשלום";
            buttonEndAccount.UseVisualStyleBackColor = false;
            buttonEndAccount.Click += buttonEndAccount_Click;
            // 
            // buttonProductsList
            // 
            buttonProductsList.BackColor = SystemColors.ControlDark;
            buttonProductsList.FlatAppearance.BorderColor = Color.White;
            buttonProductsList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProductsList.ForeColor = Color.Maroon;
            buttonProductsList.Location = new Point(53, 570);
            buttonProductsList.Name = "buttonProductsList";
            buttonProductsList.Size = new Size(158, 86);
            buttonProductsList.TabIndex = 23;
            buttonProductsList.Text = "לראות את קטלוג המוצרים";
            buttonProductsList.UseVisualStyleBackColor = false;
            buttonProductsList.Click += buttonProductsList_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            titleLabel.ForeColor = Color.Maroon;
            titleLabel.Location = new Point(369, 67);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(210, 46);
            titleLabel.TabIndex = 22;
            titleLabel.Text = "ביצוע הזמנה";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productIdLabel.ForeColor = Color.Maroon;
            productIdLabel.Location = new Point(492, 208);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(141, 23);
            productIdLabel.TabIndex = 21;
            productIdLabel.Text = "הכנס מזהה מוצר";
            // 
            // inputProductId
            // 
            inputProductId.Location = new Point(475, 249);
            inputProductId.Name = "inputProductId";
            inputProductId.Size = new Size(168, 30);
            inputProductId.TabIndex = 20;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.BackColor = SystemColors.ControlDark;
            buttonAddProduct.FlatAppearance.BorderColor = Color.White;
            buttonAddProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddProduct.ForeColor = Color.Maroon;
            buttonAddProduct.Location = new Point(498, 389);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(126, 44);
            buttonAddProduct.TabIndex = 19;
            buttonAddProduct.Text = "הוספת מוצר";
            buttonAddProduct.UseVisualStyleBackColor = false;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // buttonRemoveProduct
            // 
            buttonRemoveProduct.BackColor = SystemColors.ControlDark;
            buttonRemoveProduct.FlatAppearance.BorderColor = Color.White;
            buttonRemoveProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRemoveProduct.ForeColor = Color.Maroon;
            buttonRemoveProduct.Location = new Point(218, 304);
            buttonRemoveProduct.Name = "buttonRemoveProduct";
            buttonRemoveProduct.Size = new Size(126, 44);
            buttonRemoveProduct.TabIndex = 29;
            buttonRemoveProduct.Text = "מחיקת מוצר";
            buttonRemoveProduct.UseVisualStyleBackColor = false;
            buttonRemoveProduct.Click += buttonRemoveProduct_Click;
            // 
            // removeProductIdLabel
            // 
            removeProductIdLabel.AutoSize = true;
            removeProductIdLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            removeProductIdLabel.ForeColor = Color.Maroon;
            removeProductIdLabel.Location = new Point(218, 207);
            removeProductIdLabel.Name = "removeProductIdLabel";
            removeProductIdLabel.Size = new Size(141, 23);
            removeProductIdLabel.TabIndex = 31;
            removeProductIdLabel.Text = "הכנס מזהה מוצר";
            // 
            // inputRemoveProductId
            // 
            inputRemoveProductId.Location = new Point(201, 248);
            inputRemoveProductId.Name = "inputRemoveProductId";
            inputRemoveProductId.Size = new Size(168, 30);
            inputRemoveProductId.TabIndex = 30;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 23;
            listBox1.Location = new Point(696, 100);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(314, 556);
            listBox1.TabIndex = 32;
            // 
            // myProductsLabel
            // 
            myProductsLabel.AutoSize = true;
            myProductsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            myProductsLabel.ForeColor = Color.Maroon;
            myProductsLabel.Location = new Point(765, 52);
            myProductsLabel.Name = "myProductsLabel";
            myProductsLabel.Size = new Size(138, 23);
            myProductsLabel.TabIndex = 33;
            myProductsLabel.Text = "סל המוצרים שלי";
            // 
            // inputQuantity
            // 
            inputQuantity.Location = new Point(483, 339);
            inputQuantity.Name = "inputQuantity";
            inputQuantity.Size = new Size(150, 30);
            inputQuantity.TabIndex = 34;
            // 
            // Account
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1038, 689);
            Controls.Add(inputQuantity);
            Controls.Add(myProductsLabel);
            Controls.Add(listBox1);
            Controls.Add(removeProductIdLabel);
            Controls.Add(inputRemoveProductId);
            Controls.Add(buttonRemoveProduct);
            Controls.Add(quantityLabel);
            Controls.Add(endAccountLabel);
            Controls.Add(buttonEndAccount);
            Controls.Add(buttonProductsList);
            Controls.Add(titleLabel);
            Controls.Add(productIdLabel);
            Controls.Add(inputProductId);
            Controls.Add(buttonAddProduct);
            Name = "Account";
            Text = "Account";
            ((System.ComponentModel.ISupportInitialize)inputQuantity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label quantityLabel;
        private Label endAccountLabel;
        private Button buttonEndAccount;
        private Button buttonProductsList;
        private Label titleLabel;
        private Label productIdLabel;
        private TextBox inputProductId;
        private Button buttonAddProduct;
        private Button buttonRemoveProduct;
        private Label removeProductIdLabel;
        private TextBox inputRemoveProductId;
        private ListBox listBox1;
        private Label myProductsLabel;
        private NumericUpDown inputQuantity;
    }
}