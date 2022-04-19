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

//Auth: Tyler Petersen
//Edit: Logan Wright
//Desc: Coffee Shop App's Receipt Page that allows the user to print and view the completed orders information
//Date:4/18/22

namespace CoffeeShopC_I_S
{
    public partial class ReceiptForm : Form
    {
        // For each str in orderlb *Menu Form*  add it to the receipt listbox - Tyler
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
        
        // Closes the Receipt form - Tyler
        private void exitBtnRf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        // On print button click, it prints the whole form, couldn't figure out the way to just print the listbox and textbox values/Text -Tyler
        private void printBtn_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(PrintImage);
            pd.Print();
        }
        // method for getting the area of what to print - Tyler
        void PrintImage(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int width = this.Width;
            int height = this.Height;

            Rectangle bounds = new Rectangle(x, y, width, height);

            // new bitmap named img equal to a new bitmap, width height
            Bitmap img = new Bitmap(width, height);

            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }

        private void receiptPannel_Paint(object sender, PaintEventArgs e)
        {
            //
        }
    }
}
