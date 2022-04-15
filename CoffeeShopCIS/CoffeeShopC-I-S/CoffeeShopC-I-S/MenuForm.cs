using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopC_I_S
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            
        }

        private void exitBtnLf_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        private void latteBtn_Click(object sender, EventArgs e)
        {
            UsersDataContext usersdb = new UsersDataContext();
            foreach (Product product in usersdb.Products)
            {
                {
                    orderLB.Items.Add(product.ProductName);
                }
            }
        }
    }
}
