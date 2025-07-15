namespace UI
{
    partial class ShowProducts
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
            buttonProductsList = new Button();
            listBoxProductsList = new ListBox();
            SuspendLayout();
            // 
            // buttonProductsList
            // 
            buttonProductsList.BackColor = SystemColors.ControlDark;
            buttonProductsList.FlatAppearance.BorderColor = Color.White;
            buttonProductsList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProductsList.ForeColor = Color.Maroon;
            buttonProductsList.Location = new Point(459, 215);
            buttonProductsList.Name = "buttonProductsList";
            buttonProductsList.Size = new Size(158, 86);
            buttonProductsList.TabIndex = 5;
            buttonProductsList.Text = "לצפות בקטלוג המוצרים";
            buttonProductsList.UseVisualStyleBackColor = false;
            buttonProductsList.Click += buttonProductsList_Click;
            // 
            // listBoxProductsList
            // 
            listBoxProductsList.FormattingEnabled = true;
            listBoxProductsList.ItemHeight = 23;
            listBoxProductsList.Location = new Point(12, 11);
            listBoxProductsList.Name = "listBoxProductsList";
            listBoxProductsList.Size = new Size(1028, 533);
            listBoxProductsList.TabIndex = 6;
            // 
            // ShowProducts
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(1065, 561);
            Controls.Add(buttonProductsList);
            Name = "ShowProducts";
            Text = "רשימת המוצרים";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonProductsList;
        private ListBox listBoxProductsList;
    }
}