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
        //! For Logan To Do: -Tyler
        //todo: Add remove on click event for database. - Logan: could nor find how to remove it using a button
        //xtodo: delete add button and just use save button for adding to database
        //todo: Still gotta get rid of that nav bar if you aren't using it. - Logan: Necicary to delete stuff so can not do so
        //todo: Also delete top navigation bar for a more cleaner look. - Logan: decised to use nav bar

        private void saveButton_Click(object sender, EventArgs e)
        {
            //todo: Add or make function for saving to the database, and not the instance so on re load of program it is saved to database. - Logan: Could not remember how to do so and could not find it in slides and book
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.coffeeShopdbDataSet1);
        }

        private void exitBtnLf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /* Could not get it to work correctly see above
         * private void removeButton_Click(object sender, EventArgs e)
        {
            //todo: Logan makes remove button onclick event that removes employee or manager or admin from database. -tyler
        }
        */

        
    }
}
