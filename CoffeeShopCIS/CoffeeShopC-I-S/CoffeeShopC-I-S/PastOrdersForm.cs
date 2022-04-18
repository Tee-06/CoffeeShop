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

//Auth: Logan Wright
//Desc: Coffee Shop App past order form where users can se the discription of past orders
// PastOrderForm, and products made by Logan Wright
//Date:4/14/22

namespace CoffeeShopC_I_S
{
    public partial class PastOrdersForm : Form
    {
        public PastOrdersForm()
        {
            InitializeComponent();
            //this takes in the old orders that are saved and spits them into a list box for veiwing by the worker
            try
            {
                //i'm doing using (StreamReader file = new StreamReader("../OldOrders.txt")) so it resolves and
                //closes after it is done being used so i dont run into it trying to open more than once
                using (StreamReader file = new StreamReader("../OldOrders.txt"))
                    {
                        int counter = 0;
                        string line;
                            while ((line = file.ReadLine()) != null)
                            {
                                receiptLB.Items.Add(line);
                                counter++;
                            }
                    }
            }
            //catch just in case it trys to open a nonexestent file
            catch (Exception ex)
            {
                MessageBox.Show("There are no past orders to show.\n\n Error: " + ex.Message);
            }
        }

        private void PastOrdersForm_Load(object sender, EventArgs e)
        {

        }

        private void exitBtnRf_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }
    }
}
