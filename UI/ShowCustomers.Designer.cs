namespace UI
{
    partial class ShowCustomers
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
            buttonCustomersList = new Button();
            listBoxCustomersList = new ListBox();
            SuspendLayout();
            // 
            // buttonCustomersList
            // 
            buttonCustomersList.BackColor = SystemColors.ControlDark;
            buttonCustomersList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustomersList.ForeColor = Color.Maroon;
            buttonCustomersList.Location = new Point(361, 161);
            buttonCustomersList.Name = "buttonCustomersList";
            buttonCustomersList.Size = new Size(158, 86);
            buttonCustomersList.TabIndex = 6;
            buttonCustomersList.Text = "לרשימת הלקוחות";
            buttonCustomersList.UseVisualStyleBackColor = false;
            buttonCustomersList.Click += buttonCustomersList_Click;
            // 
            // listBoxCustomersList
            // 
            listBoxCustomersList.FormattingEnabled = true;
            listBoxCustomersList.ItemHeight = 23;
            listBoxCustomersList.Location = new Point(12, 17);
            listBoxCustomersList.Name = "listBoxCustomersList";
            listBoxCustomersList.Size = new Size(841, 418);
            listBoxCustomersList.TabIndex = 7;
            // 
            // ShowCustomers
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(865, 450);
            Controls.Add(buttonCustomersList);
            Name = "ShowCustomers";
            Text = "רשימת הלקוחות";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonCustomersList;
        private ListBox listBoxCustomersList;
    }
}