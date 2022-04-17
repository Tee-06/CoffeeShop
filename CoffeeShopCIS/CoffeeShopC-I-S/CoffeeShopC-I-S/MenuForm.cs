using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Auth: Tyler Petersen
//Edit: Logan Wright
//Desc: Coffee Shop App
// UsersTable, and Products Database made by Tyler Petersen
//Date:4/15/22
namespace CoffeeShopC_I_S
{
    public partial class MenuForm : Form
    {
        UsersDataContext productdb = new UsersDataContext();
        public MenuForm()
        {
            InitializeComponent();
        }

        //! -Tyler\/\/\/ 
        //! on load all items in products db get added to the menu list box 
        // ! also on load the currency gets formatted in the price list box to be only 2 decimals and have the $ in front.
        private void MenuForm_Load(object sender, EventArgs e)
        {
            foreach (Product product in productdb.Products)
            {
                menuLB.Items.Add(product.ProductName);
                priceLB.Items.Add("$" + Math.Round(product.ProductPrice, 2).ToString());
            }

        }

        // Closes -Tyler
        private void exitBtnLf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ! on the add order button click, the selected item in the menu list box gets added to the order listbox
        // todo: Add in the Qty picker and the price into a seperate textbox, or label for the overall price of the order.
        //! Add to orderLB, adds the menu selected item to the order LB - Tyler
        private void addToOrderBtn_Click(object sender, EventArgs e)
        {
            
            foreach (Product product in productdb.Products)
            {
                if (menuLB.SelectedItem.ToString() == product.ProductName)
                {
                    orderLB.Items.Add(menuLB.SelectedItem.ToString());
                }

            }
            //-Tyler \/\/\/
            //! This loops through the orderlb and then looks through database to find the price, once price is found it adds it to the total.
            //! does that until there are no more items left to loop through.
            decimal totalPrice = 0;
            foreach (string str in orderLB.Items)
            {
                foreach (Product product in productdb.Products)
                {
                    if (product.ProductName == str)
                    {
                        totalPrice += product.ProductPrice;
                    }
                }
                //totalTB.Text = Math.Round(totalPrice, 2).ToString();
                totalTB.Text = Math.Round(totalPrice, 2).ToString(); totalPrice.ToString();
            }

        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            //! Remove button, works if something is selected, but if nothing is selected it will throw an error, in the .exe that might be different idk yet tho -
            foreach (Product product in productdb.Products)
            {
                if (menuLB.SelectedItem.ToString() == product.ProductName)
                {
                    orderLB.Items.Remove(orderLB.SelectedItem.ToString());
                }
                // !Dont think this actually works. So something needs to be selected
                else if(menuLB.SelectedItem.ToString() == null)
                {
                    MessageBox.Show("Please Select An Item To Remove.");
                }
            }
            //\/\/\/
            //! This loops through the orderlb and then looks through database to find the price, once price is found it removes it to the total.
            //! does that until there are no more items left to loop through.
            decimal totalPrice = 0;
            foreach (string str in orderLB.Items)
            {
                foreach (Product product in productdb.Products)
                {
                    if (product.ProductName == str)
                    {
                        totalPrice += product.ProductPrice;
                    }
                }
                //totalTB.Text = Math.Round(totalPrice, 2).ToString();
                totalTB.Text = Math.Round(totalPrice, 2).ToString(); totalPrice.ToString();
            }
        }

        private void ownerMenuBtn_Click(object sender, EventArgs e)
        {
            //button leading to the admin page -Logan
            adminForm admin = new adminForm();
            this.Hide();
            admin.ShowDialog();
            this.Show();

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            //refreshes the listboxes with that information in the database -Logan
            menuLB.Items.Clear();
            priceLB.Items.Clear();
            //! for each product in product in database, on refresh it will fetch the products again and add them to correspoding LB's, will also round the price to nearest 2 decimal places -Tyler 
            foreach (Product product in productdb.Products)
            {
                menuLB.Items.Add(product.ProductName);
                priceLB.Items.Add("$" + Math.Round(product.ProductPrice, 2).ToString());
            }
        }

        private void completeOrderBtn_Click(object sender, EventArgs e)
        {
            
            //todo: Make launch to receipt form and then they can either print *TextFile* or Exit their order
            ReceiptForm reciept = new ReceiptForm();
            this.Hide();
            reciept.ShowDialog();
            this.Show();
        }
    }
}
