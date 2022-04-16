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
    public partial class adminForm : Form
    {
        public adminForm()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeShopdbDataSet1);

        }

        private void adminForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'coffeeShopdbDataSet1.UsersTable' table. You can move, or remove it, as needed.
            this.usersTableTableAdapter.Fill(this.coffeeShopdbDataSet1.UsersTable);
            // TODO: This line of code loads data into the 'coffeeShopdbDataSet1.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.coffeeShopdbDataSet1.Products);

        }

        private void saveButton_Click(object sender, EventArgs e)
        {

        }

        private void exitBtnLf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
