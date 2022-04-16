using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Auth: Logan Wright
//Desc: Coffee Shop App's Admin Page that allows the managers to edit the database
// adminForm and save function made by Logan Wright
//Date:4/15/22

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
        {   //fills the tables with there information on load
            this.usersTableTableAdapter.Fill(this.coffeeShopdbDataSet1.UsersTable);
            this.productsTableAdapter.Fill(this.coffeeShopdbDataSet1.Products);

        }
        //! For Logan To Do:
        //todo: Add remove on click event for database.
        //xtodo: delete add button and just use save button for adding to database
        //todo: Also delete top navigation bar for a more cleaner look.
       //todo: Check Receipt Form.cs *Code*

        private void saveButton_Click(object sender, EventArgs e)
        {
            //todo: Add or make function for saving to the database, and not the instance so on re load of program it is saved to database.
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeShopdbDataSet1);
        }

        private void exitBtnLf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
