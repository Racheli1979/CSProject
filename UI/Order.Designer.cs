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
            orderButton = new Button();
            sendButton = new Button();
            ifPreferredCheckBox = new CheckBox();
            customerIdLabel = new Label();
            customerIdTextBox = new TextBox();
            textHelloLabel = new Label();
            SuspendLayout();
            // 
            // orderButton
            // 
            orderButton.Enabled = false;
            orderButton.BackColor = SystemColors.ControlDark;
            orderButton.FlatAppearance.BorderColor = Color.White;
            orderButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            orderButton.ForeColor = Color.Maroon;
            orderButton.Location = new Point(307, 367);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(187, 44);
            orderButton.TabIndex = 43;
            orderButton.Text = "התחל הזמנה חדשה";
            orderButton.UseVisualStyleBackColor = false;
            orderButton.Click += orderButton_Click;
            // 
            // sendButton
            // 
            sendButton.BackColor = SystemColors.ControlDark;
            sendButton.FlatAppearance.BorderColor = Color.White;
            sendButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            sendButton.ForeColor = Color.Maroon;
            sendButton.Location = new Point(352, 232);
            sendButton.Name = "sendButton";
            sendButton.Size = new Size(107, 44);
            sendButton.TabIndex = 42;
            sendButton.Text = "לשליחה";
            sendButton.UseVisualStyleBackColor = false;
            sendButton.Click += sendButton_Click;
            // 
            // ifPreferredCheckBox
            // 
            ifPreferredCheckBox.AutoSize = true;
            ifPreferredCheckBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            ifPreferredCheckBox.ForeColor = Color.Maroon;
            ifPreferredCheckBox.Location = new Point(352, 170);
            ifPreferredCheckBox.Name = "ifPreferredCheckBox";
            ifPreferredCheckBox.Size = new Size(116, 27);
            ifPreferredCheckBox.TabIndex = 41;
            ifPreferredCheckBox.Text = "חבר מועדון";
            ifPreferredCheckBox.UseVisualStyleBackColor = true;
            // 
            // customerIdLabel
            // 
            customerIdLabel.AutoSize = true;
            customerIdLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            customerIdLabel.ForeColor = Color.Maroon;
            customerIdLabel.Location = new Point(326, 39);
            customerIdLabel.Name = "customerIdLabel";
            customerIdLabel.Size = new Size(168, 28);
            customerIdLabel.TabIndex = 40;
            customerIdLabel.Text = "הכנס מזהה לקוח";
            // 
            // customerIdTextBox
            // 
            customerIdTextBox.Location = new Point(347, 97);
            customerIdTextBox.Name = "customerIdTextBox";
            customerIdTextBox.Size = new Size(125, 30);
            customerIdTextBox.TabIndex = 39;
            // 
            // textHelloLabel
            // 
            textHelloLabel.AutoSize = true;
            textHelloLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            textHelloLabel.ForeColor = Color.Maroon;
            textHelloLabel.Location = new Point(317, 308);
            textHelloLabel.Name = "textHelloLabel";
            textHelloLabel.Size = new Size(0, 28);
            textHelloLabel.TabIndex = 44;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(textHelloLabel);
            Controls.Add(orderButton);
            Controls.Add(sendButton);
            Controls.Add(ifPreferredCheckBox);
            Controls.Add(customerIdLabel);
            Controls.Add(customerIdTextBox);
            Name = "Order";
            Text = "Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button orderButton;
        private Button sendButton;
        private CheckBox ifPreferredCheckBox;
        private Label customerIdLabel;
        private TextBox customerIdTextBox;
        private Label textHelloLabel;
    }
}