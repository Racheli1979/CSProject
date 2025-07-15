namespace UI
{
    partial class ManagerMenu
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
            managmentProducts = new Button();
            managmentOrderProducts = new Button();
            managmentSales = new Button();
            SuspendLayout();
            // 
            // managmentProducts
            // 
            managmentProducts.BackColor = SystemColors.ControlDark;
            managmentProducts.FlatAppearance.BorderColor = Color.White;
            managmentProducts.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            managmentProducts.ForeColor = Color.Maroon;
            managmentProducts.Location = new Point(550, 169);
            managmentProducts.Name = "managmentProducts";
            managmentProducts.Size = new Size(158, 86);
            managmentProducts.TabIndex = 4;
            managmentProducts.Text = "לניהול מוצרים";
            managmentProducts.UseVisualStyleBackColor = false;
            managmentProducts.Click += managmentProducts_Click;
            // 
            // managmentOrderProducts
            // 
            managmentOrderProducts.BackColor = SystemColors.ControlDark;
            managmentOrderProducts.FlatAppearance.BorderColor = Color.White;
            managmentOrderProducts.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            managmentOrderProducts.ForeColor = Color.Maroon;
            managmentOrderProducts.Location = new Point(308, 169);
            managmentOrderProducts.Name = "managmentOrderProducts";
            managmentOrderProducts.Size = new Size(158, 86);
            managmentOrderProducts.TabIndex = 5;
            managmentOrderProducts.Text = "לניהול הזמנת מוצרים";
            managmentOrderProducts.UseVisualStyleBackColor = false;
            // 
            // managmentSales
            // 
            managmentSales.BackColor = SystemColors.ControlDark;
            managmentSales.FlatAppearance.BorderColor = Color.White;
            managmentSales.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            managmentSales.ForeColor = Color.Maroon;
            managmentSales.Location = new Point(63, 169);
            managmentSales.Name = "managmentSales";
            managmentSales.Size = new Size(158, 86);
            managmentSales.TabIndex = 6;
            managmentSales.Text = "לניהול מבצעים";
            managmentSales.UseVisualStyleBackColor = false;
            managmentSales.Click += managmentSales_Click;
            // 
            // ManagerMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(managmentSales);
            Controls.Add(managmentOrderProducts);
            Controls.Add(managmentProducts);
            Name = "ManagerMenu";
            Text = "תפריט מנהל";
            ResumeLayout(false);
        }

        #endregion

        private Button managmentProducts;
        private Button managmentOrderProducts;
        private Button managmentSales;
    }
}