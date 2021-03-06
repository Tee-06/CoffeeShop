using System;
using System.IO;
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
        public MenuForm(String role)
        {
            InitializeComponent();
            //this if statement checks the role and moves buttons to invisabol if necisary - Logan
            if (role == "Manager"|| role == "manager")
            {
                ownerMenuBtn.Hide();
            }
            else if (role == "Owner")
            {
                return;
            }
            else if (role == "Employee")
            {
                ownerMenuBtn.Hide();
                pastOrdersBtn.Hide();
            }
            else if (role == "")
            {
                MessageBox.Show("How did you get here... You should of had a Role...");
            }
            else
            {
                MessageBox.Show("How did you get here... You should not be here please leave...");
            }
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
        //! Add to orderLB, adds the menu selected item to the order LB - Tyler
        private void addToOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (menuLB.SelectedItem == null)
                {
                    MessageBox.Show("Please Select an Item in the ListBox Thank you.");
                }
                else
                {
                    foreach (Product product in productdb.Products)
                    {
                        if (menuLB.SelectedItem.ToString() == product.ProductName)
                        {
                            orderLB.Items.Add(menuLB.SelectedItem.ToString());
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        //! on remove click, runs a try catch, first it tries if there is no selected item then it prompts user to select an item to remove. - Tyler
        private void removeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (orderLB.SelectedItem == null)
                {
                    MessageBox.Show("Please Select an Item in the ListBox Thank you.");
                }
                else
                {   
                    //xFixed this
                    //x! Remove button, works if something is selected, but if nothing is selected it will throw an error, in the .exe that might be different idk yet tho -
                    foreach (Product product in productdb.Products)
                    {
                        if (menuLB.SelectedItem.ToString() == product.ProductName)
                        {
                            orderLB.Items.Remove(orderLB.SelectedItem.ToString());
                        }
                        else if (menuLB.SelectedItem.ToString() == null)
                        {
                            MessageBox.Show("Please Select An Item To Remove.");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            //refreshes the listboxes with that information in the database as well as clears the old order info -Logan
            menuLB.Items.Clear();
            priceLB.Items.Clear();
            //! for each product in product in database, on refresh it will fetch the products again and add them to correspoding LB's, will also round the price to nearest 2 decimal places -Tyler 
            foreach (Product product in productdb.Products)
            {
                menuLB.Items.Add(product.ProductName);
                priceLB.Items.Add("$" + Math.Round(product.ProductPrice, 2).ToString());
            }
        }

        //Left chunk to ask if i was pasiing it into an array correctly @Westen

        //! Was going to add the listbox items into an array and pass them over but the list was easier and seemed more efficient. - Tyler
        /* public string[] get()
        {
            string[] arr = new string[orderLB.Items.Count];
            for (int i = 0; i < orderLB.Items.Count; i++)
            {
                arr[i] = orderLB.Items[i].ToString();
            }
            return arr;
        }
        */


        // on Complete order button, list of strings and makes them equal to whats in the order listbox if they are type string, then adds to list -Tyler
        private void completeOrderBtn_Click(object sender, EventArgs e)
        {
            //array to pust the completed order into a text file - Logan lines 202-218
            try
            {
                using (TextWriter tw = File.AppendText("../OldOrders.txt"))
                {
                    tw.WriteLine("Order:");
                    foreach (String s in orderLB.Items)
                    {
                        tw.WriteLine(s);
                    }
                    tw.WriteLine("Total: $" + totalTB.Text);
                    tw.WriteLine("");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //xtodo: Make launch to receipt form and then they can either print *TextFile* or Exit their order
            //button leading to the recipt form -Tyler
            List<string> lst = orderLB.Items.OfType<String>().ToList();
            ReceiptForm rf = new ReceiptForm(lst);
            rf.recieptTotalTB.Text = totalTB.Text;
            this.Hide();
            rf.ShowDialog();
            this.Show();

        }

        private void pastOrdersBtn_Click(object sender, EventArgs e)
        {
            //takes you to the past orders to view them - Logan
            PastOrdersForm pof = new PastOrdersForm();
            this.Hide();
            pof.ShowDialog();
            this.Show();
        }
        //clears the past order information - Logan
        private void clearButton_Click(object sender, EventArgs e)
        {
            orderLB.Items.Clear();
        }
    }
}
