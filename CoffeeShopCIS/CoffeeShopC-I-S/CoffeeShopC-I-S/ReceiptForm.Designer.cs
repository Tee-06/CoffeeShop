
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
            this.exitBtnRf = new System.Windows.Forms.Button();
            this.receiptLB = new System.Windows.Forms.ListBox();
            this.menuLbl = new System.Windows.Forms.Label();
            this.receiptPannel = new System.Windows.Forms.Panel();
            this.printBtn = new System.Windows.Forms.Button();
            this.rCtotalLbl = new System.Windows.Forms.Label();
            this.recieptTotalTB = new System.Windows.Forms.TextBox();
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
            this.exitBtnRf.TabIndex = 8;
            this.exitBtnRf.Text = "Exit";
            this.exitBtnRf.UseVisualStyleBackColor = false;
            // 
            // receiptLB
            // 
            this.receiptLB.FormattingEnabled = true;
            this.receiptLB.Location = new System.Drawing.Point(8, 38);
            this.receiptLB.Name = "receiptLB";
            this.receiptLB.Size = new System.Drawing.Size(167, 199);
            this.receiptLB.TabIndex = 9;
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLbl.Location = new System.Drawing.Point(2, 1);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(152, 34);
            this.menuLbl.TabIndex = 20;
            this.menuLbl.Text = "Menu List";
            // 
            // receiptPannel
            // 
            this.receiptPannel.BackColor = System.Drawing.Color.Gainsboro;
            this.receiptPannel.Controls.Add(this.rCtotalLbl);
            this.receiptPannel.Controls.Add(this.recieptTotalTB);
            this.receiptPannel.Controls.Add(this.receiptLB);
            this.receiptPannel.Controls.Add(this.menuLbl);
            this.receiptPannel.Location = new System.Drawing.Point(15, 10);
            this.receiptPannel.Name = "receiptPannel";
            this.receiptPannel.Size = new System.Drawing.Size(352, 333);
            this.receiptPannel.TabIndex = 21;
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.Chocolate;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Location = new System.Drawing.Point(15, 348);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(121, 43);
            this.printBtn.TabIndex = 22;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = false;
            // 
            // rCtotalLbl
            // 
            this.rCtotalLbl.AutoSize = true;
            this.rCtotalLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rCtotalLbl.Location = new System.Drawing.Point(8, 243);
            this.rCtotalLbl.Name = "rCtotalLbl";
            this.rCtotalLbl.Size = new System.Drawing.Size(93, 34);
            this.rCtotalLbl.TabIndex = 27;
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
            this.recieptTotalTB.Size = new System.Drawing.Size(150, 65);
            this.recieptTotalTB.TabIndex = 26;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.receiptPannel.ResumeLayout(false);
            this.receiptPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtnRf;
        private System.Windows.Forms.ListBox receiptLB;
        private System.Windows.Forms.Label menuLbl;
        private System.Windows.Forms.Panel receiptPannel;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Label rCtotalLbl;
        private System.Windows.Forms.TextBox recieptTotalTB;
    }
}