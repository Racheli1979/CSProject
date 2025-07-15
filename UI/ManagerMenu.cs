using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class ManagerMenu : Form
    {
        //private Form form;
        public ManagerMenu()  //(Form l)
        {
            InitializeComponent();
            /*this.FormClosed += new FormClosedEventHandler(CloseManagerMenu);
            this.form = l;*/
        }

        /*private void CloseManagerMenu(object sender, EventArgs e)
        {
            form.Close();
        }
*/
        private void managmentProducts_Click(object sender, EventArgs e)
        {
            ManagmentProducts mp = new ManagmentProducts();
            mp.ShowDialog();
        }

        private void managmentSales_Click(object sender, EventArgs e)
        {
            ManagmentSales ms = new ManagmentSales();   
            ms.ShowDialog();
        }
    }
}