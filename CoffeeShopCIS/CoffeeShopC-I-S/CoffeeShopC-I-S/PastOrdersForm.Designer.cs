
namespace CoffeeShopC_I_S
{
    partial class PastOrdersForm
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
            this.printBtn = new System.Windows.Forms.Button();
            this.receiptPannel = new System.Windows.Forms.Panel();
            this.receiptLB = new System.Windows.Forms.ListBox();
            this.pastLbl = new System.Windows.Forms.Label();
            this.exitBtnRf = new System.Windows.Forms.Button();
            this.receiptPannel.SuspendLayout();
            this.SuspendLayout();
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.Chocolate;
            this.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.Location = new System.Drawing.Point(12, 352);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(121, 43);
            this.printBtn.TabIndex = 25;
            this.printBtn.Text = "Show";
            this.printBtn.UseVisualStyleBackColor = false;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // receiptPannel
            // 
            this.receiptPannel.BackColor = System.Drawing.Color.Gainsboro;
            this.receiptPannel.Controls.Add(this.receiptLB);
            this.receiptPannel.Controls.Add(this.pastLbl);
            this.receiptPannel.Location = new System.Drawing.Point(12, 14);
            this.receiptPannel.Name = "receiptPannel";
            this.receiptPannel.Size = new System.Drawing.Size(352, 333);
            this.receiptPannel.TabIndex = 24;
            // 
            // receiptLB
            // 
            this.receiptLB.FormattingEnabled = true;
            this.receiptLB.Location = new System.Drawing.Point(8, 38);
            this.receiptLB.Name = "receiptLB";
            this.receiptLB.Size = new System.Drawing.Size(216, 238);
            this.receiptLB.TabIndex = 9;
            // 
            // pastLbl
            // 
            this.pastLbl.AutoSize = true;
            this.pastLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastLbl.Location = new System.Drawing.Point(2, 1);
            this.pastLbl.Name = "pastLbl";
            this.pastLbl.Size = new System.Drawing.Size(222, 34);
            this.pastLbl.TabIndex = 20;
            this.pastLbl.Text = "Past Order List";
            // 
            // exitBtnRf
            // 
            this.exitBtnRf.BackColor = System.Drawing.Color.Chocolate;
            this.exitBtnRf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtnRf.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtnRf.Location = new System.Drawing.Point(243, 353);
            this.exitBtnRf.Name = "exitBtnRf";
            this.exitBtnRf.Size = new System.Drawing.Size(121, 43);
            this.exitBtnRf.TabIndex = 23;
            this.exitBtnRf.Text = "Exit";
            this.exitBtnRf.UseVisualStyleBackColor = false;
            this.exitBtnRf.Click += new System.EventHandler(this.exitBtnRf_Click);
            // 
            // PastOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(383, 413);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.receiptPannel);
            this.Controls.Add(this.exitBtnRf);
            this.Name = "PastOrdersForm";
            this.Text = "PastOrdersForm";
            this.Load += new System.EventHandler(this.PastOrdersForm_Load);
            this.receiptPannel.ResumeLayout(false);
            this.receiptPannel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Panel receiptPannel;
        private System.Windows.Forms.ListBox receiptLB;
        private System.Windows.Forms.Label pastLbl;
        private System.Windows.Forms.Button exitBtnRf;
    }
}