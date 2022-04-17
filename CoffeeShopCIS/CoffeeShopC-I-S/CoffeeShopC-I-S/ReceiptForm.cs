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
    public partial class ReceiptForm : Form
    {
        public ReceiptForm()
        {
            InitializeComponent();
            

        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            //todo: Receipt Form doesn't have to have full functionality i can help if you dont get it all the way finished.
            ReceiptForm NewForm = new ReceiptForm();
            NewForm.ShowDialog();
            receiptLB.Items.Clear();
            receiptLB.Items.AddRange(NewForm.receiptLB.Items);
        }
    }
}
