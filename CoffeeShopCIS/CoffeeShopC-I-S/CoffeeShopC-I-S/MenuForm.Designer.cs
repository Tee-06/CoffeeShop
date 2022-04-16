
namespace CoffeeShopC_I_S
{
    partial class MenuForm
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
            this.exitBtnLf = new System.Windows.Forms.Button();
            this.menuHoldingPanel = new System.Windows.Forms.Panel();
            this.priceLB = new System.Windows.Forms.ListBox();
            this.menuLbl = new System.Windows.Forms.Label();
            this.menuLB = new System.Windows.Forms.ListBox();
            this.completeOrderBtn = new System.Windows.Forms.Button();
            this.orderListLbl = new System.Windows.Forms.Label();
            this.orderLB = new System.Windows.Forms.ListBox();
            this.pastOrdersBtn = new System.Windows.Forms.Button();
            this.ownerMenuBtn = new System.Windows.Forms.Button();
            this.qtyControl = new System.Windows.Forms.NumericUpDown();
            this.addToOrderBtn = new System.Windows.Forms.Button();
            this.menuHoldingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyControl)).BeginInit();
            this.SuspendLayout();
            // 
            // exitBtnLf
            // 
            this.exitBtnLf.BackColor = System.Drawing.Color.Chocolate;
            this.exitBtnLf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtnLf.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtnLf.Location = new System.Drawing.Point(763, 473);
            this.exitBtnLf.Name = "exitBtnLf";
            this.exitBtnLf.Size = new System.Drawing.Size(121, 43);
            this.exitBtnLf.TabIndex = 7;
            this.exitBtnLf.Text = "Exit";
            this.exitBtnLf.UseVisualStyleBackColor = false;
            this.exitBtnLf.Click += new System.EventHandler(this.exitBtnLf_Click);
            // 
            // menuHoldingPanel
            // 
            this.menuHoldingPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.menuHoldingPanel.Controls.Add(this.addToOrderBtn);
            this.menuHoldingPanel.Controls.Add(this.qtyControl);
            this.menuHoldingPanel.Controls.Add(this.priceLB);
            this.menuHoldingPanel.Controls.Add(this.menuLbl);
            this.menuHoldingPanel.Controls.Add(this.menuLB);
            this.menuHoldingPanel.Controls.Add(this.completeOrderBtn);
            this.menuHoldingPanel.Controls.Add(this.orderListLbl);
            this.menuHoldingPanel.Controls.Add(this.orderLB);
            this.menuHoldingPanel.Location = new System.Drawing.Point(373, 16);
            this.menuHoldingPanel.Name = "menuHoldingPanel";
            this.menuHoldingPanel.Size = new System.Drawing.Size(511, 442);
            this.menuHoldingPanel.TabIndex = 8;
            // 
            // priceLB
            // 
            this.priceLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLB.FormattingEnabled = true;
            this.priceLB.ItemHeight = 16;
            this.priceLB.Location = new System.Drawing.Point(170, 41);
            this.priceLB.Name = "priceLB";
            this.priceLB.Size = new System.Drawing.Size(58, 212);
            this.priceLB.TabIndex = 20;
            // 
            // menuLbl
            // 
            this.menuLbl.AutoSize = true;
            this.menuLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLbl.Location = new System.Drawing.Point(8, 4);
            this.menuLbl.Name = "menuLbl";
            this.menuLbl.Size = new System.Drawing.Size(152, 34);
            this.menuLbl.TabIndex = 19;
            this.menuLbl.Text = "Menu List";
            // 
            // menuLB
            // 
            this.menuLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLB.FormattingEnabled = true;
            this.menuLB.ItemHeight = 16;
            this.menuLB.Location = new System.Drawing.Point(14, 41);
            this.menuLB.Name = "menuLB";
            this.menuLB.Size = new System.Drawing.Size(150, 212);
            this.menuLB.TabIndex = 18;
            this.menuLB.SelectedIndexChanged += new System.EventHandler(this.menuLB_SelectedIndexChanged);
            // 
            // completeOrderBtn
            // 
            this.completeOrderBtn.BackColor = System.Drawing.Color.Chocolate;
            this.completeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeOrderBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeOrderBtn.Location = new System.Drawing.Point(14, 382);
            this.completeOrderBtn.Name = "completeOrderBtn";
            this.completeOrderBtn.Size = new System.Drawing.Size(268, 43);
            this.completeOrderBtn.TabIndex = 17;
            this.completeOrderBtn.Text = "Complete Order";
            this.completeOrderBtn.UseVisualStyleBackColor = false;
            // 
            // orderListLbl
            // 
            this.orderListLbl.AutoSize = true;
            this.orderListLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderListLbl.Location = new System.Drawing.Point(342, 4);
            this.orderListLbl.Name = "orderListLbl";
            this.orderListLbl.Size = new System.Drawing.Size(153, 34);
            this.orderListLbl.TabIndex = 10;
            this.orderListLbl.Text = "Order List";
            // 
            // orderLB
            // 
            this.orderLB.FormattingEnabled = true;
            this.orderLB.Location = new System.Drawing.Point(348, 41);
            this.orderLB.Name = "orderLB";
            this.orderLB.Size = new System.Drawing.Size(150, 212);
            this.orderLB.TabIndex = 9;
            // 
            // pastOrdersBtn
            // 
            this.pastOrdersBtn.BackColor = System.Drawing.Color.Chocolate;
            this.pastOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pastOrdersBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastOrdersBtn.Location = new System.Drawing.Point(12, 116);
            this.pastOrdersBtn.Name = "pastOrdersBtn";
            this.pastOrdersBtn.Size = new System.Drawing.Size(268, 43);
            this.pastOrdersBtn.TabIndex = 18;
            this.pastOrdersBtn.Text = "Past Orders";
            this.pastOrdersBtn.UseVisualStyleBackColor = false;
            // 
            // ownerMenuBtn
            // 
            this.ownerMenuBtn.BackColor = System.Drawing.Color.Chocolate;
            this.ownerMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ownerMenuBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerMenuBtn.Location = new System.Drawing.Point(12, 20);
            this.ownerMenuBtn.Name = "ownerMenuBtn";
            this.ownerMenuBtn.Size = new System.Drawing.Size(268, 43);
            this.ownerMenuBtn.TabIndex = 19;
            this.ownerMenuBtn.Text = "Owner\'s Menu";
            this.ownerMenuBtn.UseVisualStyleBackColor = false;
            // 
            // qtyControl
            // 
            this.qtyControl.Location = new System.Drawing.Point(14, 260);
            this.qtyControl.Name = "qtyControl";
            this.qtyControl.Size = new System.Drawing.Size(120, 20);
            this.qtyControl.TabIndex = 21;
            // 
            // addToOrderBtn
            // 
            this.addToOrderBtn.BackColor = System.Drawing.Color.Chocolate;
            this.addToOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToOrderBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToOrderBtn.Location = new System.Drawing.Point(14, 305);
            this.addToOrderBtn.Name = "addToOrderBtn";
            this.addToOrderBtn.Size = new System.Drawing.Size(108, 43);
            this.addToOrderBtn.TabIndex = 22;
            this.addToOrderBtn.Text = "Add";
            this.addToOrderBtn.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(896, 528);
            this.Controls.Add(this.ownerMenuBtn);
            this.Controls.Add(this.pastOrdersBtn);
            this.Controls.Add(this.menuHoldingPanel);
            this.Controls.Add(this.exitBtnLf);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuHoldingPanel.ResumeLayout(false);
            this.menuHoldingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qtyControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtnLf;
        private System.Windows.Forms.Panel menuHoldingPanel;
        private System.Windows.Forms.ListBox orderLB;
        private System.Windows.Forms.Label orderListLbl;
        private System.Windows.Forms.Button completeOrderBtn;
        private System.Windows.Forms.Button pastOrdersBtn;
        private System.Windows.Forms.Button ownerMenuBtn;
        private System.Windows.Forms.Label menuLbl;
        private System.Windows.Forms.ListBox menuLB;
        private System.Windows.Forms.ListBox priceLB;
        private System.Windows.Forms.Button addToOrderBtn;
        private System.Windows.Forms.NumericUpDown qtyControl;
    }
}