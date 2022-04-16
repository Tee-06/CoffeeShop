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
        UsersDataContext productdb = new UsersDataContext();
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_Load(object sender, EventArgs e)
        {
            foreach (Product product in productdb.Products)
            {
                menuLB.Items.Add(product.ProductName);
                priceLB.Items.Add("$" + Math.Round(product.ProductPrice, 2).ToString());
            }

        }

        private void exitBtnLf_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void addToOrderBtn_Click(object sender, EventArgs e)
        {
            foreach (Product product in productdb.Products)
            {
                if (menuLB.SelectedItem.ToString() == product.ProductName)
                {
                    orderLB.Items.Add(menuLB.SelectedItem.ToString());
                }
            }
        }

        private void ownerMenuBtn_Click(object sender, EventArgs e)
        {
            adminForm admin = new adminForm();
            this.Hide();
            admin.ShowDialog();
            this.Show();
        }
    }
}
