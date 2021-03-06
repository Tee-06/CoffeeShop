
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
            this.clearButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.totalTB = new System.Windows.Forms.TextBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.addToOrderBtn = new System.Windows.Forms.Button();
            this.priceLB = new System.Windows.Forms.ListBox();
            this.menuLbl = new System.Windows.Forms.Label();
            this.menuLB = new System.Windows.Forms.ListBox();
            this.completeOrderBtn = new System.Windows.Forms.Button();
            this.orderListLbl = new System.Windows.Forms.Label();
            this.orderLB = new System.Windows.Forms.ListBox();
            this.pastOrdersBtn = new System.Windows.Forms.Button();
            this.ownerMenuBtn = new System.Windows.Forms.Button();
            this.menuHoldingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // exitBtnLf
            // 
            this.exitBtnLf.BackColor = System.Drawing.Color.Chocolate;
            this.exitBtnLf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtnLf.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtnLf.Location = new System.Drawing.Point(387, 396);
            this.exitBtnLf.Name = "exitBtnLf";
            this.exitBtnLf.Size = new System.Drawing.Size(121, 43);
            this.exitBtnLf.TabIndex = 5;
            this.exitBtnLf.Text = "Exit";
            this.exitBtnLf.UseVisualStyleBackColor = false;
            this.exitBtnLf.Click += new System.EventHandler(this.exitBtnLf_Click);
            // 
            // menuHoldingPanel
            // 
            this.menuHoldingPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.menuHoldingPanel.Controls.Add(this.clearButton);
            this.menuHoldingPanel.Controls.Add(this.refreshButton);
            this.menuHoldingPanel.Controls.Add(this.totalLbl);
            this.menuHoldingPanel.Controls.Add(this.totalTB);
            this.menuHoldingPanel.Controls.Add(this.exitBtnLf);
            this.menuHoldingPanel.Controls.Add(this.removeBtn);
            this.menuHoldingPanel.Controls.Add(this.addToOrderBtn);
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
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Chocolate;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(14, 396);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(108, 43);
            this.clearButton.TabIndex = 26;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.BackColor = System.Drawing.Color.Chocolate;
            this.refreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refreshButton.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refreshButton.Location = new System.Drawing.Point(128, 396);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(139, 43);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = false;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLbl.Location = new System.Drawing.Point(277, 268);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(93, 34);
            this.totalLbl.TabIndex = 25;
            this.totalLbl.Text = "Total:";
            // 
            // totalTB
            // 
            this.totalTB.BackColor = System.Drawing.Color.Black;
            this.totalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalTB.ForeColor = System.Drawing.Color.Chocolate;
            this.totalTB.Location = new System.Drawing.Point(376, 268);
            this.totalTB.Multiline = true;
            this.totalTB.Name = "totalTB";
            this.totalTB.ReadOnly = true;
            this.totalTB.Size = new System.Drawing.Size(122, 65);
            this.totalTB.TabIndex = 23;
            // 
            // removeBtn
            // 
            this.removeBtn.BackColor = System.Drawing.Color.Chocolate;
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeBtn.Location = new System.Drawing.Point(128, 277);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(139, 43);
            this.removeBtn.TabIndex = 2;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = false;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // addToOrderBtn
            // 
            this.addToOrderBtn.BackColor = System.Drawing.Color.Chocolate;
            this.addToOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addToOrderBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addToOrderBtn.Location = new System.Drawing.Point(14, 277);
            this.addToOrderBtn.Name = "addToOrderBtn";
            this.addToOrderBtn.Size = new System.Drawing.Size(108, 43);
            this.addToOrderBtn.TabIndex = 1;
            this.addToOrderBtn.Text = "Add";
            this.addToOrderBtn.UseVisualStyleBackColor = false;
            this.addToOrderBtn.Click += new System.EventHandler(this.addToOrderBtn_Click);
            // 
            // priceLB
            // 
            this.priceLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLB.FormattingEnabled = true;
            this.priceLB.ItemHeight = 16;
            this.priceLB.Location = new System.Drawing.Point(170, 41);
            this.priceLB.Name = "priceLB";
            this.priceLB.Size = new System.Drawing.Size(58, 212);
            this.priceLB.TabIndex = 23;
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
            this.menuLB.TabIndex = 23;
            // 
            // completeOrderBtn
            // 
            this.completeOrderBtn.BackColor = System.Drawing.Color.Chocolate;
            this.completeOrderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.completeOrderBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeOrderBtn.Location = new System.Drawing.Point(14, 338);
            this.completeOrderBtn.Name = "completeOrderBtn";
            this.completeOrderBtn.Size = new System.Drawing.Size(253, 43);
            this.completeOrderBtn.TabIndex = 3;
            this.completeOrderBtn.Text = "Complete Order";
            this.completeOrderBtn.UseVisualStyleBackColor = false;
            this.completeOrderBtn.Click += new System.EventHandler(this.completeOrderBtn_Click);
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
            this.orderLB.TabIndex = 23;
            // 
            // pastOrdersBtn
            // 
            this.pastOrdersBtn.BackColor = System.Drawing.Color.Chocolate;
            this.pastOrdersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pastOrdersBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pastOrdersBtn.Location = new System.Drawing.Point(12, 20);
            this.pastOrdersBtn.Name = "pastOrdersBtn";
            this.pastOrdersBtn.Size = new System.Drawing.Size(268, 43);
            this.pastOrdersBtn.TabIndex = 6;
            this.pastOrdersBtn.Text = "Past Orders";
            this.pastOrdersBtn.UseVisualStyleBackColor = false;
            this.pastOrdersBtn.Click += new System.EventHandler(this.pastOrdersBtn_Click);
            // 
            // ownerMenuBtn
            // 
            this.ownerMenuBtn.BackColor = System.Drawing.Color.Chocolate;
            this.ownerMenuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ownerMenuBtn.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownerMenuBtn.Location = new System.Drawing.Point(12, 83);
            this.ownerMenuBtn.Name = "ownerMenuBtn";
            this.ownerMenuBtn.Size = new System.Drawing.Size(268, 43);
            this.ownerMenuBtn.TabIndex = 7;
            this.ownerMenuBtn.Text = "Owner\'s Menu";
            this.ownerMenuBtn.UseVisualStyleBackColor = false;
            this.ownerMenuBtn.Click += new System.EventHandler(this.ownerMenuBtn_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(896, 470);
            this.Controls.Add(this.ownerMenuBtn);
            this.Controls.Add(this.pastOrdersBtn);
            this.Controls.Add(this.menuHoldingPanel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.menuHoldingPanel.ResumeLayout(false);
            this.menuHoldingPanel.PerformLayout();
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
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.TextBox totalTB;
        private System.Windows.Forms.Button clearButton;
    }
}