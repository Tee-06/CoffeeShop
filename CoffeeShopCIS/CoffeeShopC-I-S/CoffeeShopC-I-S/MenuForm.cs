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
        UsersDataContext productBD = new UsersDataContext();
        OpenFileDialog open = new OpenFileDialog();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            foreach (Product product in productBD.Products)
            {
                orderLB.Items.Add(product.ProductName);
            }
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

        private void mochaBtn_Click(object sender, EventArgs e)
        {
            foreach (Product product in productBD.Products);
            {
                
                //orderLB.Items.Add();
                
            }
        }
    }
}
