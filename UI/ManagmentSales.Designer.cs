namespace UI
{
    partial class ManagmentSales
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
            salesList = new Button();
            updateSale = new Button();
            addSale = new Button();
            deletSaleButton = new Button();
            inputSaleId = new TextBox();
            saleIdLabel = new Label();
            buttonUpdateSale = new Button();
            inputSalePrice = new TextBox();
            inputProductId = new TextBox();
            salePriceLabel = new Label();
            qantityLabel = new Label();
            productIdLabel = new Label();
            buttonAddSale = new Button();
            inputQuntity = new TextBox();
            startDateLabel = new Label();
            endDateLabel = new Label();
            updateEndSaleLabel = new Label();
            updateStartDateLabel = new Label();
            inputUpdateQuntity = new TextBox();
            inputUpdateSalePrice = new TextBox();
            inputUpdateProductId = new TextBox();
            updateSalePriceLabel = new Label();
            updateQuntityLabel = new Label();
            updateProductIdLabel = new Label();
            forAllClub = new CheckBox();
            inputStartDate = new DateTimePicker();
            inputEndDate = new DateTimePicker();
            inputUpdateStartDate = new DateTimePicker();
            inputUpdateEndDate = new DateTimePicker();
            updateForAllClub = new CheckBox();
            SuspendLayout();
            // 
            // salesList
            // 
            salesList.BackColor = SystemColors.ControlDark;
            salesList.FlatAppearance.BorderColor = Color.White;
            salesList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            salesList.ForeColor = Color.Maroon;
            salesList.Location = new Point(598, 325);
            salesList.Name = "salesList";
            salesList.Size = new Size(158, 86);
            salesList.TabIndex = 74;
            salesList.Text = "לרשימת מבצעים";
            salesList.UseVisualStyleBackColor = false;
            salesList.Click += salesList_Click;
            // 
            // updateSale
            // 
            updateSale.BackColor = SystemColors.ControlDark;
            updateSale.FlatAppearance.BorderColor = Color.White;
            updateSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateSale.ForeColor = Color.Maroon;
            updateSale.Location = new Point(74, 39);
            updateSale.Name = "updateSale";
            updateSale.Size = new Size(158, 86);
            updateSale.TabIndex = 62;
            updateSale.Text = "לעדכון מבצע קיים";
            updateSale.UseVisualStyleBackColor = false;
            updateSale.Click += updateSale_Click;
            // 
            // addSale
            // 
            addSale.BackColor = SystemColors.ControlDark;
            addSale.FlatAppearance.BorderColor = Color.White;
            addSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addSale.ForeColor = Color.Maroon;
            addSale.Location = new Point(332, 39);
            addSale.Name = "addSale";
            addSale.Size = new Size(158, 86);
            addSale.TabIndex = 61;
            addSale.Text = "להוספת מבצע חדש";
            addSale.UseVisualStyleBackColor = false;
            addSale.Click += addSale_Click;
            // 
            // deletSaleButton
            // 
            deletSaleButton.BackColor = SystemColors.ControlDark;
            deletSaleButton.FlatAppearance.BorderColor = Color.White;
            deletSaleButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deletSaleButton.ForeColor = Color.Maroon;
            deletSaleButton.Location = new Point(598, 39);
            deletSaleButton.Name = "deletSaleButton";
            deletSaleButton.Size = new Size(158, 86);
            deletSaleButton.TabIndex = 60;
            deletSaleButton.Text = "למחיקת מבצע קיים";
            deletSaleButton.UseVisualStyleBackColor = false;
            deletSaleButton.Click += deletSaleButton_Click;
            // 
            // inputSaleId
            // 
            inputSaleId.Location = new Point(611, 201);
            inputSaleId.Name = "inputSaleId";
            inputSaleId.Size = new Size(125, 30);
            inputSaleId.TabIndex = 73;
            inputSaleId.KeyPress += inputSaleId_KeyPress;
            // 
            // saleIdLabel
            // 
            saleIdLabel.AutoSize = true;
            saleIdLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            saleIdLabel.ForeColor = Color.Maroon;
            saleIdLabel.Location = new Point(611, 153);
            saleIdLabel.Name = "saleIdLabel";
            saleIdLabel.Size = new Size(131, 23);
            saleIdLabel.TabIndex = 72;
            saleIdLabel.Text = "הכנס קוד מבצע";
            // 
            // buttonUpdateSale
            // 
            buttonUpdateSale.BackColor = SystemColors.ControlDark;
            buttonUpdateSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdateSale.ForeColor = Color.Maroon;
            buttonUpdateSale.Location = new Point(201, 410);
            buttonUpdateSale.Name = "buttonUpdateSale";
            buttonUpdateSale.Size = new Size(94, 40);
            buttonUpdateSale.TabIndex = 75;
            buttonUpdateSale.Text = "לעדכון";
            buttonUpdateSale.UseVisualStyleBackColor = false;
            buttonUpdateSale.Click += buttonUpdateSale_Click;
            // 
            // inputSalePrice
            // 
            inputSalePrice.Location = new Point(268, 253);
            inputSalePrice.Name = "inputSalePrice";
            inputSalePrice.Size = new Size(163, 30);
            inputSalePrice.TabIndex = 69;
            // 
            // inputProductId
            // 
            inputProductId.Location = new Point(268, 153);
            inputProductId.Name = "inputProductId";
            inputProductId.Size = new Size(163, 30);
            inputProductId.TabIndex = 68;
            // 
            // salePriceLabel
            // 
            salePriceLabel.AutoSize = true;
            salePriceLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            salePriceLabel.ForeColor = Color.Maroon;
            salePriceLabel.Location = new Point(438, 253);
            salePriceLabel.Name = "salePriceLabel";
            salePriceLabel.Size = new Size(138, 23);
            salePriceLabel.TabIndex = 66;
            salePriceLabel.Text = "מחיר כולל מבצע";
            // 
            // qantityLabel
            // 
            qantityLabel.AutoSize = true;
            qantityLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            qantityLabel.ForeColor = Color.Maroon;
            qantityLabel.Location = new Point(438, 201);
            qantityLabel.Name = "qantityLabel";
            qantityLabel.Size = new Size(167, 23);
            qantityLabel.TabIndex = 65;
            qantityLabel.Text = "כמות נדרשת למבצע";
            // 
            // productIdLabel
            // 
            productIdLabel.AutoSize = true;
            productIdLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            productIdLabel.ForeColor = Color.Maroon;
            productIdLabel.Location = new Point(442, 156);
            productIdLabel.Name = "productIdLabel";
            productIdLabel.Size = new Size(95, 23);
            productIdLabel.TabIndex = 64;
            productIdLabel.Text = "מזהה מוצר";
            // 
            // buttonAddSale
            // 
            buttonAddSale.BackColor = SystemColors.ControlDark;
            buttonAddSale.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAddSale.ForeColor = Color.Maroon;
            buttonAddSale.Location = new Point(154, 398);
            buttonAddSale.Name = "buttonAddSale";
            buttonAddSale.Size = new Size(94, 40);
            buttonAddSale.TabIndex = 63;
            buttonAddSale.Text = "להוספה";
            buttonAddSale.UseVisualStyleBackColor = false;
            buttonAddSale.Click += buttonAddSale_Click;
            // 
            // inputQuntity
            // 
            inputQuntity.Location = new Point(268, 201);
            inputQuntity.Name = "inputQuntity";
            inputQuntity.Size = new Size(163, 30);
            inputQuntity.TabIndex = 76;
            // 
            // startDateLabel
            // 
            startDateLabel.AutoSize = true;
            startDateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            startDateLabel.ForeColor = Color.Maroon;
            startDateLabel.Location = new Point(438, 349);
            startDateLabel.Name = "startDateLabel";
            startDateLabel.Size = new Size(124, 23);
            startDateLabel.TabIndex = 77;
            startDateLabel.Text = "תאריך התחלה";
            // 
            // endDateLabel
            // 
            endDateLabel.AutoSize = true;
            endDateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            endDateLabel.ForeColor = Color.Maroon;
            endDateLabel.Location = new Point(438, 391);
            endDateLabel.Name = "endDateLabel";
            endDateLabel.Size = new Size(99, 23);
            endDateLabel.TabIndex = 79;
            endDateLabel.Text = "תאריך סיום";
            // 
            // updateEndSaleLabel
            // 
            updateEndSaleLabel.AutoSize = true;
            updateEndSaleLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateEndSaleLabel.ForeColor = Color.Maroon;
            updateEndSaleLabel.Location = new Point(196, 384);
            updateEndSaleLabel.Name = "updateEndSaleLabel";
            updateEndSaleLabel.Size = new Size(99, 23);
            updateEndSaleLabel.TabIndex = 91;
            updateEndSaleLabel.Text = "תאריך סיום";
            // 
            // updateStartDateLabel
            // 
            updateStartDateLabel.AutoSize = true;
            updateStartDateLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateStartDateLabel.ForeColor = Color.Maroon;
            updateStartDateLabel.Location = new Point(196, 342);
            updateStartDateLabel.Name = "updateStartDateLabel";
            updateStartDateLabel.Size = new Size(124, 23);
            updateStartDateLabel.TabIndex = 89;
            updateStartDateLabel.Text = "תאריך התחלה";
            // 
            // inputUpdateQuntity
            // 
            inputUpdateQuntity.Location = new Point(26, 194);
            inputUpdateQuntity.Name = "inputUpdateQuntity";
            inputUpdateQuntity.Size = new Size(163, 30);
            inputUpdateQuntity.TabIndex = 88;
            // 
            // inputUpdateSalePrice
            // 
            inputUpdateSalePrice.Location = new Point(26, 246);
            inputUpdateSalePrice.Name = "inputUpdateSalePrice";
            inputUpdateSalePrice.Size = new Size(163, 30);
            inputUpdateSalePrice.TabIndex = 86;
            // 
            // inputUpdateProductId
            // 
            inputUpdateProductId.Location = new Point(26, 146);
            inputUpdateProductId.Name = "inputUpdateProductId";
            inputUpdateProductId.Size = new Size(163, 30);
            inputUpdateProductId.TabIndex = 85;
            // 
            // updateSalePriceLabel
            // 
            updateSalePriceLabel.AutoSize = true;
            updateSalePriceLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateSalePriceLabel.ForeColor = Color.Maroon;
            updateSalePriceLabel.Location = new Point(196, 246);
            updateSalePriceLabel.Name = "updateSalePriceLabel";
            updateSalePriceLabel.Size = new Size(138, 23);
            updateSalePriceLabel.TabIndex = 83;
            updateSalePriceLabel.Text = "מחיר כולל מבצע";
            // 
            // updateQuntityLabel
            // 
            updateQuntityLabel.AutoSize = true;
            updateQuntityLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateQuntityLabel.ForeColor = Color.Maroon;
            updateQuntityLabel.Location = new Point(196, 194);
            updateQuntityLabel.Name = "updateQuntityLabel";
            updateQuntityLabel.Size = new Size(167, 23);
            updateQuntityLabel.TabIndex = 82;
            updateQuntityLabel.Text = "כמות נדרשת למבצע";
            // 
            // updateProductIdLabel
            // 
            updateProductIdLabel.AutoSize = true;
            updateProductIdLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateProductIdLabel.ForeColor = Color.Maroon;
            updateProductIdLabel.Location = new Point(200, 149);
            updateProductIdLabel.Name = "updateProductIdLabel";
            updateProductIdLabel.Size = new Size(95, 23);
            updateProductIdLabel.TabIndex = 81;
            updateProductIdLabel.Text = "מזהה מוצר";
            // 
            // forAllClub
            // 
            forAllClub.AutoSize = true;
            forAllClub.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            forAllClub.ForeColor = Color.Maroon;
            forAllClub.Location = new Point(415, 302);
            forAllClub.Name = "forAllClub";
            forAllClub.Size = new Size(177, 27);
            forAllClub.TabIndex = 81;
            forAllClub.Text = "האם לכל הלקוחות";
            forAllClub.UseVisualStyleBackColor = true;
            // 
            // inputStartDate
            // 
            inputStartDate.Location = new Point(268, 343);
            inputStartDate.Name = "inputStartDate";
            inputStartDate.Size = new Size(163, 30);
            inputStartDate.TabIndex = 82;
            // 
            // inputEndDate
            // 
            inputEndDate.Location = new Point(268, 391);
            inputEndDate.Name = "inputEndDate";
            inputEndDate.Size = new Size(164, 30);
            inputEndDate.TabIndex = 83;
            // 
            // inputUpdateStartDate
            // 
            inputUpdateStartDate.Location = new Point(26, 335);
            inputUpdateStartDate.Name = "inputUpdateStartDate";
            inputUpdateStartDate.Size = new Size(164, 30);
            inputUpdateStartDate.TabIndex = 93;
            // 
            // inputUpdateEndDate
            // 
            inputUpdateEndDate.Location = new Point(27, 377);
            inputUpdateEndDate.Name = "inputUpdateEndDate";
            inputUpdateEndDate.Size = new Size(163, 30);
            inputUpdateEndDate.TabIndex = 94;
            // 
            // updateForAllClub
            // 
            updateForAllClub.AutoSize = true;
            updateForAllClub.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateForAllClub.ForeColor = Color.Maroon;
            updateForAllClub.Location = new Point(173, 292);
            updateForAllClub.Name = "updateForAllClub";
            updateForAllClub.Size = new Size(177, 27);
            updateForAllClub.TabIndex = 95;
            updateForAllClub.Text = "האם לכל הלקוחות";
            updateForAllClub.UseVisualStyleBackColor = true;
            // 
            // ManagmentSales
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(salesList);
            Controls.Add(addSale);
            Controls.Add(deletSaleButton);
            Controls.Add(updateSale);
            Name = "ManagmentSales";
            Text = "ניהול מבצעים";
            ResumeLayout(false);
        }

        #endregion

        private Button salesList;
        private Button updateSale;
        private Button addSale;
        private Button deletSaleButton;
        private TextBox inputSaleId;
        private Label saleIdLabel;
        private Button buttonUpdateSale;
        private TextBox inputForClub;
        private TextBox inputSalePrice;
        private TextBox inputProductId;
        private Label forClubLabel;
        private Label salePriceLabel;
        private Label qantityLabel;
        private Label productIdLabel;
        private Button buttonAddSale;
        private TextBox inputQuntity;
        private Label startDateLabel;
        private Label endDateLabel;
        private Label updateEndSaleLabel;
        private Label updateStartDateLabel;
        private TextBox inputUpdateQuntity;
        private TextBox inputUpdateSalePrice;
        private TextBox inputUpdateProductId;
        private Label updateSalePriceLabel;
        private Label updateQuntityLabel;
        private Label updateProductIdLabel;
        private CheckBox forAllClub;
        private DateTimePicker inputStartDate;
        private DateTimePicker inputEndDate;
        private DateTimePicker inputUpdateStartDate;
        private DateTimePicker inputUpdateEndDate;
        private CheckBox updateForAllClub;
    }
}