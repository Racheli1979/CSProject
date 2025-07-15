using System.Windows.Forms;

namespace UI
{
    partial class CashierMenu
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            updateExsistCustomer = new Button();
            addCustomerToClub = new Button();
            deleteCustomerInClub = new Button();
            buttonProductsList = new Button();
            buttonDoAccount = new Button();
            buttonCustomersList = new Button();
            inputPhone = new TextBox();
            inputAddress = new TextBox();
            inputId = new TextBox();
            phoneLabel = new Label();
            addressLabel = new Label();
            nameLabel = new Label();
            idLabel = new Label();
            buttonCencel = new Button();
            buttonAdd = new Button();
            inputName = new TextBox();
            buttonUpdate = new Button();
            inputUpdatePhone = new TextBox();
            inputUpdateAddress = new TextBox();
            inputUpdateId = new TextBox();
            inputUpdateName = new TextBox();
            updatePhoneLabel = new Label();
            updateAddressLabel = new Label();
            updateNameLabel = new Label();
            updateIdLabel = new Label();
            buttonUpdateCencel = new Button();
            inputDeleteId = new TextBox();
            deleteIdLabel = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // updateExsistCustomer
            // 
            updateExsistCustomer.BackColor = SystemColors.ControlDark;
            updateExsistCustomer.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateExsistCustomer.ForeColor = Color.Maroon;
            updateExsistCustomer.Location = new Point(432, 50);
            updateExsistCustomer.Name = "updateExsistCustomer";
            updateExsistCustomer.Size = new Size(158, 86);
            updateExsistCustomer.TabIndex = 3;
            updateExsistCustomer.Text = "לעדכן פרטי לקוח קיים";
            updateExsistCustomer.UseVisualStyleBackColor = false;
            updateExsistCustomer.Click += updateExsistCustomer_Click;
            // 
            // addCustomerToClub
            // 
            addCustomerToClub.BackColor = SystemColors.ControlDark;
            addCustomerToClub.FlatAppearance.BorderColor = Color.White;
            addCustomerToClub.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addCustomerToClub.ForeColor = Color.Maroon;
            addCustomerToClub.Location = new Point(609, 50);
            addCustomerToClub.Name = "addCustomerToClub";
            addCustomerToClub.Size = new Size(158, 86);
            addCustomerToClub.TabIndex = 2;
            addCustomerToClub.Text = "לצרף לקוח למועדון";
            addCustomerToClub.UseVisualStyleBackColor = false;
            addCustomerToClub.Click += addCustomerToClub_Click;
            // 
            // deleteCustomerInClub
            // 
            deleteCustomerInClub.BackColor = SystemColors.ControlDark;
            deleteCustomerInClub.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteCustomerInClub.ForeColor = Color.Maroon;
            deleteCustomerInClub.Location = new Point(254, 50);
            deleteCustomerInClub.Name = "deleteCustomerInClub";
            deleteCustomerInClub.Size = new Size(158, 86);
            deleteCustomerInClub.TabIndex = 5;
            deleteCustomerInClub.Text = "להסיר לקוח מהמועדון";
            deleteCustomerInClub.UseVisualStyleBackColor = false;
            deleteCustomerInClub.Click += deleteCustomerInClub_Click;
            // 
            // buttonProductsList
            // 
            buttonProductsList.BackColor = SystemColors.ControlDark;
            buttonProductsList.FlatAppearance.BorderColor = Color.White;
            buttonProductsList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonProductsList.ForeColor = Color.Maroon;
            buttonProductsList.Location = new Point(73, 50);
            buttonProductsList.Name = "buttonProductsList";
            buttonProductsList.Size = new Size(158, 86);
            buttonProductsList.TabIndex = 4;
            buttonProductsList.Text = "לראות את קטלוג המוצרים";
            buttonProductsList.UseVisualStyleBackColor = false;
            buttonProductsList.Click += buttonProductsList_Click;
            // 
            // buttonDoAccount
            // 
            buttonDoAccount.BackColor = SystemColors.ControlDark;
            buttonDoAccount.FlatAppearance.BorderColor = Color.White;
            buttonDoAccount.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonDoAccount.ForeColor = Color.Maroon;
            buttonDoAccount.Location = new Point(73, 327);
            buttonDoAccount.Name = "buttonDoAccount";
            buttonDoAccount.Size = new Size(158, 84);
            buttonDoAccount.TabIndex = 6;
            buttonDoAccount.Text = "לביצוע הזמנה";
            buttonDoAccount.UseVisualStyleBackColor = false;
            buttonDoAccount.Click += buttonDoAccount_Click;
            // 
            // buttonCustomersList
            // 
            buttonCustomersList.BackColor = SystemColors.ControlDark;
            buttonCustomersList.FlatAppearance.BorderColor = Color.White;
            buttonCustomersList.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCustomersList.ForeColor = Color.Maroon;
            buttonCustomersList.Location = new Point(73, 191);
            buttonCustomersList.Name = "buttonCustomersList";
            buttonCustomersList.Size = new Size(158, 86);
            buttonCustomersList.TabIndex = 9;
            buttonCustomersList.Text = "לראות את כל הלקוחות";
            buttonCustomersList.UseVisualStyleBackColor = false;
            buttonCustomersList.Click += buttonCustomersList_Click;
            // 
            // inputPhone
            // 
            inputPhone.Location = new Point(493, 308);
            inputPhone.Name = "inputPhone";
            inputPhone.Size = new Size(163, 30);
            inputPhone.TabIndex = 55;
            // 
            // inputAddress
            // 
            inputAddress.Location = new Point(493, 261);
            inputAddress.Name = "inputAddress";
            inputAddress.Size = new Size(163, 30);
            inputAddress.TabIndex = 54;
            // 
            // inputId
            // 
            inputId.Location = new Point(493, 161);
            inputId.Name = "inputId";
            inputId.Size = new Size(163, 30);
            inputId.TabIndex = 53;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            phoneLabel.ForeColor = Color.Maroon;
            phoneLabel.Location = new Point(682, 308);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(105, 23);
            phoneLabel.TabIndex = 52;
            phoneLabel.Text = "מספר טלפון";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            addressLabel.ForeColor = Color.Maroon;
            addressLabel.Location = new Point(682, 264);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(61, 23);
            addressLabel.TabIndex = 51;
            addressLabel.Text = "כתובת";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.ForeColor = Color.Maroon;
            nameLabel.Location = new Point(682, 216);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(36, 23);
            nameLabel.TabIndex = 50;
            nameLabel.Text = "שם";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            idLabel.ForeColor = Color.Maroon;
            idLabel.Location = new Point(678, 164);
            idLabel.Name = "idLabel";
            idLabel.Size = new Size(103, 23);
            idLabel.TabIndex = 49;
            idLabel.Text = "מספר מזהה";
            // 
            // buttonCencel
            // 
            buttonCencel.BackColor = SystemColors.ControlDark;
            buttonCencel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCencel.ForeColor = Color.Maroon;
            buttonCencel.Location = new Point(536, 349);
            buttonCencel.Name = "buttonCencel";
            buttonCencel.Size = new Size(94, 40);
            buttonCencel.TabIndex = 48;
            buttonCencel.Text = "ביטול";
            buttonCencel.UseVisualStyleBackColor = false;
            buttonCencel.Click += buttonCencel_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = SystemColors.ControlDark;
            buttonAdd.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonAdd.ForeColor = Color.Maroon;
            buttonAdd.Location = new Point(536, 398);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 40);
            buttonAdd.TabIndex = 57;
            buttonAdd.Text = "הוספה";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // inputName
            // 
            inputName.Location = new Point(493, 209);
            inputName.Name = "inputName";
            inputName.Size = new Size(163, 30);
            inputName.TabIndex = 58;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = SystemColors.ControlDark;
            buttonUpdate.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdate.ForeColor = Color.Maroon;
            buttonUpdate.Location = new Point(441, 398);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(94, 40);
            buttonUpdate.TabIndex = 67;
            buttonUpdate.Text = "עדכון";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdateAdd_Click;
            // 
            // inputUpdatePhone
            // 
            inputUpdatePhone.Location = new Point(398, 308);
            inputUpdatePhone.Name = "inputUpdatePhone";
            inputUpdatePhone.Size = new Size(163, 30);
            inputUpdatePhone.TabIndex = 66;
            // 
            // inputUpdateAddress
            // 
            inputUpdateAddress.Location = new Point(398, 261);
            inputUpdateAddress.Name = "inputUpdateAddress";
            inputUpdateAddress.Size = new Size(163, 30);
            inputUpdateAddress.TabIndex = 65;
            // 
            // inputUpdateId
            // 
            inputUpdateId.Location = new Point(398, 161);
            inputUpdateId.Name = "inputUpdateId";
            inputUpdateId.Size = new Size(163, 30);
            inputUpdateId.TabIndex = 64;
            // 
            // inputUpdateName
            // 
            inputUpdateName.Location = new Point(398, 209);
            inputUpdateName.Name = "inputUpdateName";
            inputUpdateName.Size = new Size(163, 30);
            inputUpdateName.TabIndex = 68;
            // 
            // updatePhoneLabel
            // 
            updatePhoneLabel.AutoSize = true;
            updatePhoneLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updatePhoneLabel.ForeColor = Color.Maroon;
            updatePhoneLabel.Location = new Point(587, 308);
            updatePhoneLabel.Name = "updatePhoneLabel";
            updatePhoneLabel.Size = new Size(105, 23);
            updatePhoneLabel.TabIndex = 63;
            updatePhoneLabel.Text = "מספר טלפון";
            // 
            // updateAddressLabel
            // 
            updateAddressLabel.AutoSize = true;
            updateAddressLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateAddressLabel.ForeColor = Color.Maroon;
            updateAddressLabel.Location = new Point(587, 264);
            updateAddressLabel.Name = "updateAddressLabel";
            updateAddressLabel.Size = new Size(61, 23);
            updateAddressLabel.TabIndex = 62;
            updateAddressLabel.Text = "כתובת";
            // 
            // updateNameLabel
            // 
            updateNameLabel.AutoSize = true;
            updateNameLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateNameLabel.ForeColor = Color.Maroon;
            updateNameLabel.Location = new Point(587, 216);
            updateNameLabel.Name = "updateNameLabel";
            updateNameLabel.Size = new Size(36, 23);
            updateNameLabel.TabIndex = 61;
            updateNameLabel.Text = "שם";
            // 
            // updateIdLabel
            // 
            updateIdLabel.AutoSize = true;
            updateIdLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            updateIdLabel.ForeColor = Color.Maroon;
            updateIdLabel.Location = new Point(583, 164);
            updateIdLabel.Name = "updateIdLabel";
            updateIdLabel.Size = new Size(103, 23);
            updateIdLabel.TabIndex = 60;
            updateIdLabel.Text = "מספר מזהה";
            // 
            // buttonUpdateCencel
            // 
            buttonUpdateCencel.BackColor = SystemColors.ControlDark;
            buttonUpdateCencel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            buttonUpdateCencel.ForeColor = Color.Maroon;
            buttonUpdateCencel.Location = new Point(441, 349);
            buttonUpdateCencel.Name = "buttonUpdateCencel";
            buttonUpdateCencel.Size = new Size(94, 40);
            buttonUpdateCencel.TabIndex = 59;
            buttonUpdateCencel.Text = "ביטול";
            buttonUpdateCencel.UseVisualStyleBackColor = false;
            buttonUpdateCencel.Click += buttonUpdateCencel_Click;
            // 
            // inputDeleteId
            // 
            inputDeleteId.Location = new Point(254, 209);
            inputDeleteId.Name = "inputDeleteId";
            inputDeleteId.Size = new Size(158, 30);
            inputDeleteId.TabIndex = 69;
            inputDeleteId.KeyPress += inputDeleteId_KeyPress;
            // 
            // deleteIdLabel
            // 
            deleteIdLabel.AutoSize = true;
            deleteIdLabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteIdLabel.ForeColor = Color.Maroon;
            deleteIdLabel.Location = new Point(287, 161);
            deleteIdLabel.Name = "deleteIdLabel";
            deleteIdLabel.Size = new Size(103, 23);
            deleteIdLabel.TabIndex = 70;
            deleteIdLabel.Text = "מספר מזהה";
            // 
            // CashierMenu
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonCustomersList);
            Controls.Add(buttonDoAccount);
            Controls.Add(deleteCustomerInClub);
            Controls.Add(buttonProductsList);
            Controls.Add(updateExsistCustomer);
            Controls.Add(addCustomerToClub);
            Name = "CashierMenu";
            Text = "תפריט קופאי";
            ResumeLayout(false);
        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Button updateExsistCustomer;
        private Button addCustomerToClub;
        private Button deleteCustomerInClub;
        private Button buttonProductsList;
        private Button buttonDoAccount;
        private Button buttonCustomersList;
        private TextBox inputPhone;
        private TextBox inputAddress;
        private TextBox inputId;
        private Label phoneLabel;
        private Label addressLabel;
        private Label nameLabel;
        private Label idLabel;
        private Button buttonCencel;
        private Button buttonAdd;
        private TextBox inputName;
        private Button buttonUpdate;
        private TextBox inputUpdatePhone;
        private TextBox inputUpdateAddress;
        private TextBox inputUpdateId;
        private TextBox inputUpdateName;
        private Label updatePhoneLabel;
        private Label updateAddressLabel;
        private Label updateNameLabel;
        private Label updateIdLabel;
        private Button buttonUpdateCencel;
        private TextBox inputDeleteId;
        private Label deleteIdLabel;
    }
}