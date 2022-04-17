
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
            this.SuspendLayout();
            // 
            // exitBtnRf
            // 
            this.exitBtnRf.BackColor = System.Drawing.Color.Chocolate;
            this.exitBtnRf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtnRf.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtnRf.Location = new System.Drawing.Point(426, 471);
            this.exitBtnRf.Name = "exitBtnRf";
            this.exitBtnRf.Size = new System.Drawing.Size(121, 43);
            this.exitBtnRf.TabIndex = 8;
            this.exitBtnRf.Text = "Exit";
            this.exitBtnRf.UseVisualStyleBackColor = false;
            // 
            // ReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(559, 526);
            this.Controls.Add(this.exitBtnRf);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ReceiptForm";
            this.Text = "ReceiptForm";
            this.Load += new System.EventHandler(this.ReceiptForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtnRf;
    }
}