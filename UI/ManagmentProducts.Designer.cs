namespace UI
{
    partial class ManagmentProducts
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
            inputCategory = new ComboBox();
            updateProduct = new Button();
            addProduct = new Button();
            deletProductButton = new Button();
            inputQantity = new TextBox();
            inputPrice = new TextBox();
            inputProductName = new TextBox();
            quantityLabel = new Label();
            priceLabel = new Label();
            categoryLabel = new Label();
            productNameLabel = new Label();
            buttonAddProduct = new Button();
            inputProductId = new TextBox();
            productIdLabel = new Label();
            productsList = new Button();
            inputUpdateQantity = new TextBox();
            inputUpdatePrice = new TextBox();
            inputUpdateName = new TextBox();
            updateQantityLabel = new Label();
            updatePriceLabel = new Label();
            updateCategoryLabel = new Label();
            updateNameLabel = new Label();
            buttonUpdateProduct = new Button();
            inputUpdateCategory = new ComboBox();
            SuspendLayout();
            // 
            // inputCategory
            // 
            inputCategory.FormattingEnabled = true;
            inputCategory.Items.AddRange(new object[] { "סיפורי_צדיקים", "ילדים", "נוער", "מבוגרים", "הסטוריה" });
            inputCategory.Location = new Point(253, 212);
            inputCategory.Name = "inputCategory";
            inputCategory.Size = new Size(163, 31);
            inputCategory.TabIndex = 47;
            // 
            // updateProduct
            // 
            updateProduct.BackColor = SystemColors.ControlDark;
            updateProduct.FlatAppearance.BorderColor = Color.White;
            updateProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateProduct.ForeColor = Color.Maroon;
            updateProduct.Location = new Point(59, 51);
            updateProduct.Name = "updateProduct";
            updateProduct.Size = new Size(158, 86);
            updateProduct.TabIndex = 38;
            updateProduct.Text = "לעדכון מוצר קיים";
            updateProduct.UseVisualStyleBackColor = false;
            updateProduct.Click += updateProduct_Click;
            // 
            // addProduct
            // 
            addProduct.BackColor = SystemColors.ControlDark;
            addProduct.FlatAppearance.BorderColor = Color.White;
            addProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addProduct.ForeColor = Color.Maroon;
            addProduct.Location = new Point(317, 51);
            addProduct.Name = "addProduct";
            addProduct.Size = new Size(158, 86);
            addProduct.TabIndex = 37;
            addProduct.Text = "להוספת מוצר חדש";
            addProduct.UseVisualStyleBackColor = false;
            addProduct.Click += addProduct_Click;
            // 
            // deletProductButton
            // 
            deletProductButton.BackColor = SystemColors.ControlDark;
            deletProductButton.FlatAppearance.BorderColor = Color.White;
            deletProductButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deletProductButton.ForeColor = Color.Maroon;
            deletProductButton.Location = new Point(583, 51);
            deletProductButton.Name = "deletProductButton";
            deletProductButton.Size = new Size(158, 86);
            deletProductButton.TabIndex = 36;
            deletProductButton.Text = "למחיקת מוצר קיים";
            deletProductButton.UseVisualStyleBackColor = false;
            deletProductButton.Click += deletProductButton_Click;
            // 
            // inputQantity
            // 
            inputQantity.Location = new Point(253, 312);
            inputQantity.Name = "inputQantity";
            inputQantity.Size = new Size(163, 30);
            inputQantity.TabIndex = 46;
            // 
            // inputPrice
            // 
            inputPrice.Location = new Point(253, 265);
            inputPrice.Name = "inputPrice";
            inputPrice.Size = new Size(163, 30);
            inputPrice.TabIndex = 45;
            // 
            // inputProductName
            // 
            inputProductName.Location = new Point(253, 165);
            inputProductName.Name = "inputProductName";
            inputProductName.Size = new Size(163, 30);
            inputProductName.TabIndex = 44;
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            quantityLabel.ForeColor = Color.Maroon;
            quantityLabel.Location = new Point(442, 312);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(104, 23);
            quantityLabel.TabIndex = 43;
            quantityLabel.Text = "כמות במלאי";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            priceLabel.ForeColor = Color.Maroon;
            priceLabel.Location = new Point(446, 272);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(49, 23);
            priceLabel.TabIndex = 42;
            priceLabel.Text = "מחיר";
            // 
            // categoryLabel
            // 
            categoryLabel.AutoSize = true;
            categoryLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            categoryLabel.ForeColor = Color.Maroon;
            categoryLabel.Location = new Point(442, 220);
            categoryLabel.Name = "categoryLabel";
            categoryLabel.Size = new Size(75, 23);
            categoryLabel.TabIndex = 41;
            categoryLabel.Text = "קטגוריה";
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productNameLabel.ForeColor = Color.Maroon;
            productNameLabel.Location = new Point(438, 168);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(79, 23);
            productNameLabel.TabIndex = 40;
            productNameLabel.Text = "שם מוצר";
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.BackColor = SystemColors.ControlDark;
            buttonAddProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddProduct.ForeColor = Color.Maroon;
            buttonAddProduct.Location = new Point(294, 360);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(94, 40);
            buttonAddProduct.TabIndex = 39;
            buttonAddProduct.Text = "להוספה";
            buttonAddProduct.UseVisualStyleBackColor = false;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // inputProductId
            // 
            inputProductId.Location = new Point(596, 213);
            inputProductId.Name = "inputProductId";
            inputProductId.Size = new Size(125, 30);
            inputProductId.TabIndex = 49;
            inputProductId.KeyPress += inputProductId_KeyPress;
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productIdLabel.ForeColor = Color.Maroon;
            productIdLabel.Location = new Point(596, 165);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(125, 23);
            productIdLabel.TabIndex = 48;
            productIdLabel.Text = "הכנס קוד מוצר";
            // 
            // productsList
            // 
            productsList.BackColor = SystemColors.ControlDark;
            productsList.FlatAppearance.BorderColor = Color.White;
            productsList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productsList.ForeColor = Color.Maroon;
            productsList.Location = new Point(583, 337);
            productsList.Name = "productsList";
            productsList.Size = new Size(158, 86);
            productsList.TabIndex = 50;
            productsList.Text = "לרשימת מוצרים";
            productsList.UseVisualStyleBackColor = false;
            productsList.Click += productsList_Click;
            // 
            // inputUpdateQantity
            // 
            inputUpdateQantity.Location = new Point(29, 312);
            inputUpdateQantity.Name = "inputUpdateQantity";
            inputUpdateQantity.Size = new Size(163, 30);
            inputUpdateQantity.TabIndex = 58;
            // 
            // inputUpdatePrice
            // 
            inputUpdatePrice.Location = new Point(29, 265);
            inputUpdatePrice.Name = "inputUpdatePrice";
            inputUpdatePrice.Size = new Size(163, 30);
            inputUpdatePrice.TabIndex = 57;
            // 
            // inputUpdateName
            // 
            inputUpdateName.Location = new Point(29, 165);
            inputUpdateName.Name = "inputUpdateName";
            inputUpdateName.Size = new Size(163, 30);
            inputUpdateName.TabIndex = 56;
            // 
            // updateQantityLabel
            // 
            updateQantityLabel.AutoSize = true;
            updateQantityLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateQantityLabel.ForeColor = Color.Maroon;
            updateQantityLabel.Location = new Point(218, 312);
            updateQantityLabel.Name = "updateQantityLabel";
            updateQantityLabel.Size = new Size(104, 23);
            updateQantityLabel.TabIndex = 55;
            updateQantityLabel.Text = "כמות במלאי";
            // 
            // updatePriceLabel
            // 
            updatePriceLabel.AutoSize = true;
            updatePriceLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updatePriceLabel.ForeColor = Color.Maroon;
            updatePriceLabel.Location = new Point(222, 268);
            updatePriceLabel.Name = "updatePriceLabel";
            updatePriceLabel.Size = new Size(49, 23);
            updatePriceLabel.TabIndex = 54;
            updatePriceLabel.Text = "מחיר";
            // 
            // updateCategoryLabel
            // 
            updateCategoryLabel.AutoSize = true;
            updateCategoryLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateCategoryLabel.ForeColor = Color.Maroon;
            updateCategoryLabel.Location = new Point(222, 220);
            updateCategoryLabel.Name = "updateCategoryLabel";
            updateCategoryLabel.Size = new Size(75, 23);
            updateCategoryLabel.TabIndex = 53;
            updateCategoryLabel.Text = "קטגוריה";
            // 
            // updateNameLabel
            // 
            updateNameLabel.AutoSize = true;
            updateNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateNameLabel.ForeColor = Color.Maroon;
            updateNameLabel.Location = new Point(218, 168);
            updateNameLabel.Name = "updateNameLabel";
            updateNameLabel.Size = new Size(79, 23);
            updateNameLabel.TabIndex = 52;
            updateNameLabel.Text = "שם מוצר";
            // 
            // buttonUpdateProduct
            // 
            buttonUpdateProduct.BackColor = SystemColors.ControlDark;
            buttonUpdateProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdateProduct.ForeColor = Color.Maroon;
            buttonUpdateProduct.Location = new Point(70, 360);
            buttonUpdateProduct.Name = "buttonUpdateProduct";
            buttonUpdateProduct.Size = new Size(94, 40);
            buttonUpdateProduct.TabIndex = 51;
            buttonUpdateProduct.Text = "לעדכון";
            buttonUpdateProduct.UseVisualStyleBackColor = false;
            buttonUpdateProduct.Click += buttonUpdateProduct_Click;
            // 
            // inputUpdateCategory
            // 
            inputUpdateCategory.FormattingEnabled = true;
            inputUpdateCategory.Items.AddRange(new object[] { "סיפורי_צדיקים", "ילדים", "נוער", "מבוגרים", "הסטוריה" });
            inputUpdateCategory.Location = new Point(29, 212);
            inputUpdateCategory.Name = "inputUpdateCategory";
            inputUpdateCategory.Size = new Size(163, 31);
            inputUpdateCategory.TabIndex = 59;
            // 
            // ManagmentProducts
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(productsList);
            Controls.Add(updateProduct);
            Controls.Add(addProduct);
            Controls.Add(deletProductButton);
            Name = "ManagmentProducts";
            Text = "לניהול מוצרים";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox inputCategory;
        private Button updateProduct;
        private Button addProduct;
        private Button deletProductButton;
        private TextBox inputQantity;
        private TextBox inputPrice;
        private TextBox inputProductName;
        private Label quantityLabel;
        private Label priceLabel;
        private Label categoryLabel;
        private Label productNameLabel;
        private Button buttonAddProduct;
        private TextBox inputProductId;
        private Label productIdLabel;
        private Button productsList;
        private TextBox inputUpdateQantity;
        private TextBox inputUpdatePrice;
        private TextBox inputUpdateName;
        private Label updateQantityLabel;
        private Label updatePriceLabel;
        private Label updateCategoryLabel;
        private Label updateNameLabel;
        private Button buttonUpdateProduct;
        private ComboBox inputUpdateCategory;
    }
}