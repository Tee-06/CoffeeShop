﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Auth: Tyler Petersen
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

        private void exitBtnLf_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
            this.Close();
        }

        // ! on the add order button click, the selected item in the menu list box gets added to the order listbox
        // todo: Add in the Qty picker and the price into a seperate textbox, or label for the overall price of the order.
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

        private void removeBtn_Click(object sender, EventArgs e)
        {
            foreach (Product product in productdb.Products)
            {
                if (menuLB.SelectedItem.ToString() == product.ProductName)
                {
                    orderLB.Items.Remove(orderLB.SelectedItem.ToString());
                }
                else if(menuLB.SelectedItem.ToString() == null)
                {
                    MessageBox.Show("Please Select An Item To Remove.");
                }
            }
        }
    }
}
