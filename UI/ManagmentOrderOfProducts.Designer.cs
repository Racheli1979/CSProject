namespace UI
{
    partial class ManagmentOrderOfProducts
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
            addQuntityProduct = new Button();
            outInStockProduct = new Button();
            SuspendLayout();
            // 
            // addQuntityProduct
            // 
            addQuntityProduct.BackColor = SystemColors.ControlDark;
            addQuntityProduct.FlatAppearance.BorderColor = Color.White;
            addQuntityProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addQuntityProduct.ForeColor = Color.Maroon;
            addQuntityProduct.Location = new Point(191, 57);
            addQuntityProduct.Name = "addQuntityProduct";
            addQuntityProduct.Size = new Size(158, 86);
            addQuntityProduct.TabIndex = 8;
            addQuntityProduct.Text = "להוספת כמות למוצר";
            addQuntityProduct.UseVisualStyleBackColor = false;
            // 
            // outInStockProduct
            // 
            outInStockProduct.BackColor = SystemColors.ControlDark;
            outInStockProduct.FlatAppearance.BorderColor = Color.White;
            outInStockProduct.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            outInStockProduct.ForeColor = Color.Maroon;
            outInStockProduct.Location = new Point(430, 57);
            outInStockProduct.Name = "outInStockProduct";
            outInStockProduct.Size = new Size(158, 86);
            outInStockProduct.TabIndex = 7;
            outInStockProduct.Text = "לראות מוצרים חסרים";
            outInStockProduct.UseVisualStyleBackColor = false;
            // 
            // ManagmentOrderOfProducts
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(addQuntityProduct);
            Controls.Add(outInStockProduct);
            Name = "ManagmentOrderOfProducts";
            Text = "ManagmentOrderOfProducts";
            ResumeLayout(false);
        }

        #endregion

        private Button addQuntityProduct;
        private Button outInStockProduct;
    }
}