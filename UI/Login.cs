using System.Windows.Forms;

namespace UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginManager_Click(object sender, EventArgs e)
        {
            Controls.Add(passwordTitle);
            Controls.Add(password);
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) // בדוק אם המקש שנלחץ הוא Enter
            {
                string password = this.password.Text;
                if (password == "2025")
                {
                    password = "";
                    ManagerMenu form = new ManagerMenu();
                    form.ShowDialog();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("סיסמה שגויה!");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void oginCashier_Click(object sender, EventArgs e)
        {

        }

        private void oginCashier_Click_1(object sender, EventArgs e)
        {
            CashierMenu c = new CashierMenu();
            c.ShowDialog();
        }
    }
}