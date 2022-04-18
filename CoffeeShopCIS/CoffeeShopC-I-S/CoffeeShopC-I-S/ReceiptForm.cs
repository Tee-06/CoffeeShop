using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace CoffeeShopC_I_S
{
    public partial class ReceiptForm : Form
    {
        
        public ReceiptForm(List<string>lst)
        {
            InitializeComponent();
            foreach (string str in lst)
            {
                receiptLB.Items.Add(str);
            }
        }

        private void ReceiptForm_Load(object sender, EventArgs e)
        {
           //
        }

        private void exitBtnRf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      

        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            pd.Print();
        }
        void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
    }
}
