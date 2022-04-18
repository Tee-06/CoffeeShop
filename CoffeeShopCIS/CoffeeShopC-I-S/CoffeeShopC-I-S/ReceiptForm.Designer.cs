
namespace CoffeeShopC_I_S
{
    partial class ReceiptForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.exitBtnRf = new System.Windows.Forms.Button();
            this.receiptLB = new System.Windows.Forms.ListBox();
            this.receiptlbl = new System.Windows.Forms.Label();
            this.receiptPannel = new System.Windows.Forms.Panel();
            this.rCtotalLbl = new System.Windows.Forms.Label();
            this.recieptTotalTB = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            this.printReceiptDocument = new System.Drawing.Printing.PrintDocument();
            this.receiptPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtnRf
            // 
            this.exitBtnRf.BackColor = System.Drawing.Color.Chocolate;
            this.exitBtnRf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtnRf.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtnRf.Location = new System.Drawing.Point(246, 349);
            this.exitBtnRf.Name = "exitBtnRf";
            this.exitBtnRf.Size = new System.Drawing.Size(121, 43);
            this.exitBtnRf.TabIndex = 2;
            this.exitBtnRf.Text = "Exit";
            this.exitBtnRf.UseVisualStyleBackColor = false;
            this.exitBtnRf.Click += new System.EventHandler(this.exitBtnRf_Click);
            // 
            // receiptLB
            // 
            this.receiptLB.FormattingEnabled = true;
            this.receiptLB.Location = new System.Drawing.Point(8, 38);
            this.receiptLB.Name = "receiptLB";
            this.receiptLB.Size = new System.Drawing.Size(167, 199);
            this.receiptLB.TabIndex = 1;
            // 
            // receiptlbl
            // 
            this.receiptlbl.AutoSize = true;
            this.receiptlbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptlbl.Location = new System.Drawing.Point(2, 1);
            this.receiptlbl.Name = "receiptlbl";
            this.receiptlbl.Size = new System.Drawing.Size(120, 34);
            this.receiptlbl.TabIndex = 0;
            this.receiptlbl.Text = "Receipt";
            // 
            // receiptPannel
            // 
            this.receiptPannel.BackColor = System.Drawing.Color.Gainsboro;
            this.receiptPannel.Controls.Add(this.rCtotalLbl);
            this.receiptPannel.Controls.Add(this.recieptTotalTB);
            this.receiptPannel.Controls.Add(this.receiptLB);
            this.receiptPannel.Controls.Add(this.receiptlbl);
            this.receiptPannel.Location = new System.Drawing.Point(15, 10);
            this.receiptPannel.Name = "receiptPannel";
            this.receiptPannel.Size = new System.Drawing.Size(352, 333);
            this.receiptPannel.TabIndex = 21;
            // 
            // rCtotalLbl
            // 
            this.rCtotalLbl.AutoSize = true;
            this.rCtotalLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rCtotalLbl.Location = new System.Drawing.Point(8, 243);
            this.rCtotalLbl.Name = "rCtotalLbl";
            this.rCtotalLbl.Size = new System.Drawing.Size(93, 34);
            this.rCtotalLbl.TabIndex = 3;
            this.rCtotalLbl.Text = "Total:";
            // 
            // recieptTotalTB
            // 
            this.recieptTotalTB.BackColor = System.Drawing.Color.Black;
            this.recieptTotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieptTotalTB.ForeColor = System.Drawing.Color.Chocolate;
            this.recieptTotalTB.Location = new System.Drawing.Point(103, 243);
            this.recieptTotalTB.Multiline = true;
            this.recieptTotalTB.Name = "recieptTotalTB";
            this.recieptTotalTB.ReadOnly = true;
            this.recieptTotalTB.Size = new System.Drawing.Size(150, 65);
            this.recieptTotalTB.TabIndex = 1;
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.Chocolate;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Location = new System.Drawing.Point(15, 348);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(121, 43);
            this.printBtn.TabIndex = 1;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(382, 403);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.receiptPannel);
            this.Controls.Add(this.exitBtnRf);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.receiptPannel.ResumeLayout(false);
            this.receiptPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtnRf;
        private System.Windows.Forms.ListBox receiptLB;
        private System.Windows.Forms.Label receiptlbl;
        private System.Windows.Forms.Panel receiptPannel;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Label rCtotalLbl;
        public System.Windows.Forms.TextBox recieptTotalTB;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
        private System.Drawing.Printing.PrintDocument printReceiptDocument;
    }
}