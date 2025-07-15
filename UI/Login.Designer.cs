namespace UI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loginManager = new Button();
            oginCashier = new Button();
            LoginTitle = new Label();
            password = new TextBox();
            passwordTitle = new Label();
            SuspendLayout();
            // 
            // loginManager
            // 
            loginManager.BackColor = SystemColors.ControlDark;
            loginManager.FlatAppearance.BorderColor = Color.White;
            loginManager.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            loginManager.ForeColor = Color.Maroon;
            loginManager.Location = new Point(486, 157);
            loginManager.Name = "loginManager";
            loginManager.Size = new Size(158, 86);
            loginManager.TabIndex = 0;
            loginManager.Text = "מנהל";
            loginManager.UseVisualStyleBackColor = false;
            loginManager.Click += loginManager_Click;
            // 
            // oginCashier
            // 
            oginCashier.BackColor = SystemColors.ControlDark;
            oginCashier.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            oginCashier.ForeColor = Color.Maroon;
            oginCashier.Location = new Point(151, 157);
            oginCashier.Name = "oginCashier";
            oginCashier.Size = new Size(158, 86);
            oginCashier.TabIndex = 1;
            oginCashier.Text = "קופאי";
            oginCashier.UseVisualStyleBackColor = false;
            oginCashier.Click += oginCashier_Click_1;
            // 
            // LoginTitle
            // 
            LoginTitle.AutoSize = true;
            LoginTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            LoginTitle.ForeColor = Color.Maroon;
            LoginTitle.Location = new Point(270, 52);
            LoginTitle.Name = "LoginTitle";
            LoginTitle.Size = new Size(249, 46);
            LoginTitle.TabIndex = 2;
            LoginTitle.Text = "כניסה למערכת";
            LoginTitle.UseWaitCursor = true;
            // 
            // password
            // 
            password.Location = new Point(507, 322);
            password.Name = "password";
            password.Size = new Size(125, 30);
            password.TabIndex = 3;
            password.TextChanged += textBox1_TextChanged;
            password.KeyPress += textBoxPass_KeyPress;
            // 
            // passwordTitle
            // 
            passwordTitle.AutoSize = true;
            passwordTitle.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            passwordTitle.ForeColor = Color.Maroon;
            passwordTitle.Location = new Point(520, 275);
            passwordTitle.Name = "passwordTitle";
            passwordTitle.Size = new Size(109, 23);
            passwordTitle.TabIndex = 4;
            passwordTitle.Text = "הכנס סיסמא";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSalmon;
            ClientSize = new Size(800, 450);
            Controls.Add(LoginTitle);
            Controls.Add(oginCashier);
            Controls.Add(loginManager);
            Name = "Login";
            Text = "כניסה";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginManager;
        private Button oginCashier;
        private Label LoginTitle;
        private TextBox password;
        private Label passwordTitle;
    }
}