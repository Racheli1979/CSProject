namespace UI
{
    partial class ShowSales
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
            listBoxSalesList = new ListBox();
            buttonSalesList = new Button();
            SuspendLayout();
            // 
            // listBoxSalesList
            // 
            listBoxSalesList.FormattingEnabled = true;
            listBoxSalesList.ItemHeight = 23;
            listBoxSalesList.Location = new Point(12, 11);
            listBoxSalesList.Name = "listBoxProductsList";
            listBoxSalesList.Size = new Size(1038, 533);
            listBoxSalesList.TabIndex = 6;
            // 
            // buttonSalesList
            // 
            buttonSalesList.BackColor = SystemColors.ControlDark;
            buttonSalesList.FlatAppearance.BorderColor = Color.White;
            buttonSalesList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSalesList.ForeColor = Color.Maroon;
            buttonSalesList.Location = new Point(459, 215);
            buttonSalesList.Name = "buttonSalesList";
            buttonSalesList.Size = new Size(158, 86);
            buttonSalesList.TabIndex = 5;
            buttonSalesList.Text = "לצפות ברשימת המוצרים";
            buttonSalesList.UseVisualStyleBackColor = false;
            buttonSalesList.Click += buttonSalesList_Click;
            // 
            // ShowSales
            //

            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1070, 561);
            Controls.Add(buttonSalesList);
            Name = "ShowSales";
            Text = "רשימת מבצעים";
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBoxSalesList;
        private Button buttonSalesList;
    }
}