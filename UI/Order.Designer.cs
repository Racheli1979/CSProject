namespace UI
{
    partial class Order
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
            label1 = new Label();
            customerIdLabel = new Label();
            password = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 95);
            label1.Name = "label1";
            label1.Size = new Size(0, 23);
            label1.TabIndex = 0;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customerIdLabel.ForeColor = Color.Maroon;
            customerIdLabel.Location = new Point(313, 52);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(168, 28);
            customerIdLabel.TabIndex = 6;
            customerIdLabel.Text = "הכנס מזהה לקוח";
            // 
            // password
            // 
            password.Location = new Point(334, 110);
            password.Name = "password";
            password.Size = new Size(125, 30);
            password.TabIndex = 5;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(customerIdLabel);
            Controls.Add(password);
            Controls.Add(label1);
            Name = "Order";
            Text = "הזמנה";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label customerIdLabel;
        private TextBox password;
    }
}