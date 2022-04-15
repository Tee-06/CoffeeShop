
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
            this.SuspendLayout();
            // 
            // exitBtnLf
            // 
            this.exitBtnLf.BackColor = System.Drawing.Color.Chocolate;
            this.exitBtnLf.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtnLf.Location = new System.Drawing.Point(667, 395);
            this.exitBtnLf.Name = "exitBtnLf";
            this.exitBtnLf.Size = new System.Drawing.Size(121, 43);
            this.exitBtnLf.TabIndex = 7;
            this.exitBtnLf.Text = "Exit";
            this.exitBtnLf.UseVisualStyleBackColor = false;
            this.exitBtnLf.Click += new System.EventHandler(this.exitBtnLf_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitBtnLf);
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.Load += new System.EventHandler(this.MenuForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button exitBtnLf;
    }
}