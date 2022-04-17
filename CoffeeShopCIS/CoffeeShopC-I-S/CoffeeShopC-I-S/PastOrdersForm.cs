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
    public partial class PastOrdersForm : Form
    {
        public PastOrdersForm()
        {
            InitializeComponent();
        }

        private void PastOrdersForm_Load(object sender, EventArgs e)
        {
            //todo: Logan create Past Orders Form.
        }

        private void exitBtnRf_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            //Todo: logan create on show click, it should re route to reciept and populate the receipt list box with what ever selected items you selected.
            //todo: so in turn that should populate the listbox with the items that were previously ordered, and should populate the receiptTotalTB with the total that it was
            //todo: and then it would allow them to print their receipt if they changed their mind or something -Tyler.
        }
    }
}
